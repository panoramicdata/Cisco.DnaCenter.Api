using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;
using System;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Credential-free tests: a refused write throws before any request is sent.
/// </summary>
public class ReadOnlyOptionTests
{
	private static DnaCenterClientOptions Options(Uri uri, bool isReadOnly) => new()
	{
		Uri = uri,
		Token = "fake-token-for-tests",
		IsReadOnly = isReadOnly
	};

	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> new DnaCenterClientOptions().IsReadOnly.Should().BeFalse();

	[Fact]
	public void IsReadOnly_WithSuppliedHttpClient_FailsValidation()
	{
		var options = new DnaCenterClientOptions { HttpClient = new HttpClient(), IsReadOnly = true };

		var act = options.Validate;

		act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public async Task WriteIsRefused_WhenIsReadOnly_AndNothingIsSent()
	{
		using var server = new CountingServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: true));

		var act = () => client.ApplicationPolicies.DeleteApplicationAsync("1", TestContext.Current.CancellationToken);

		(await act.Should().ThrowAsync<Refit.ApiRequestException>()).Which.InnerException.Should().BeOfType<InvalidOperationException>();
		server.RequestCount.Should().Be(0);
	}

	[Fact]
	public async Task WriteIsSent_WhenNotReadOnly()
	{
		using var server = new CountingServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: false));

		try
		{
			await client.ApplicationPolicies.DeleteApplicationAsync("1", TestContext.Current.CancellationToken);
		}
		catch (Exception e) when (e is not InvalidOperationException)
		{
			// The stub returns no usable body; only the fact that the request arrived matters.
		}

		server.RequestCount.Should().Be(1);
	}

	[Fact]
	public async Task ReadStillGoesThrough_WhenIsReadOnly()
	{
		using var server = new CountingServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: true));

		var status = await client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		status.Should().NotBeNull();
		server.RequestCount.Should().Be(1);
	}

	private sealed class CountingServer : IDisposable
	{
		private readonly HttpListener _listener = new();
		private int _requestCount;

		public Uri BaseUri { get; }

		public int RequestCount => Volatile.Read(ref _requestCount);

		public CountingServer()
		{
			var probe = new TcpListener(IPAddress.Loopback, 0);
			probe.Start();
			var port = ((IPEndPoint)probe.LocalEndpoint).Port;
			probe.Stop();

			BaseUri = new Uri($"http://127.0.0.1:{port}/");
			_listener.Prefixes.Add(BaseUri.AbsoluteUri);
			_listener.Start();
			_ = Task.Run(ServeAsync);
		}

		private async Task ServeAsync()
		{
			while (_listener.IsListening)
			{
				HttpListenerContext context;
				try
				{
					context = await _listener.GetContextAsync().ConfigureAwait(false);
				}
				catch (Exception e) when (e is HttpListenerException or ObjectDisposedException or InvalidOperationException)
				{
					return;
				}

				Interlocked.Increment(ref _requestCount);
				var body = System.Text.Encoding.UTF8.GetBytes("{\"status\":\"SUCCESS\"}");
				context.Response.ContentType = "application/json";
				await context.Response.OutputStream.WriteAsync(body).ConfigureAwait(false);
				context.Response.Close();
			}
		}

		public void Dispose() => _listener.Close();
	}
}
