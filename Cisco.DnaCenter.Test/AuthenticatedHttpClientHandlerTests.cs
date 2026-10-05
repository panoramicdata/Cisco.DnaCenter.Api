using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Exceptions;
using Refit;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Tests for the token, refresh and retry behaviour of <see cref="AuthenticatedHttpClientHandler" />.
///
/// <para>
/// The handler derives from <c>HttpClientHandler</c>, so its network send cannot be replaced with a
/// mocked message handler. Instead each test drives the real client against a scripted HTTP server
/// bound to the loopback interface. No credentials and no DNA Center are needed.
/// </para>
/// </summary>
public class AuthenticatedHttpClientHandlerTests
{
	private const string AuthPath = "/dna/system/api/v1/auth/token";
	private const string StatusPath = "/dna/platform/management/business-api/v1/execution-status/abc";
	private const string SuccessBody = "{\"status\":\"SUCCESS\"}";

	private sealed record Received(string Path, string? AuthToken);

	private sealed class ScriptedServer : IDisposable
	{
		private readonly HttpListener _listener = new();
		private readonly Dictionary<string, Queue<(int Status, string Body)>> _script = new();
		private readonly ConcurrentQueue<Received> _received = new();

		public Uri BaseUri { get; }

		public IReadOnlyList<Received> Received => _received.ToList();

		public ScriptedServer()
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

		// The last scripted response for a path repeats once the queue is down to one entry.
		public ScriptedServer On(string path, params (int Status, string Body)[] responses)
		{
			_script[path] = new Queue<(int, string)>(responses);
			return this;
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

				var path = context.Request.Url!.AbsolutePath;
				_received.Enqueue(new Received(path, context.Request.Headers["X-Auth-Token"]));

				var (status, body) = (404, string.Empty);
				if (_script.TryGetValue(path, out var queue))
				{
					lock (queue)
					{
						(status, body) = queue.Count > 1 ? queue.Dequeue() : queue.Peek();
					}
				}

				var bytes = Encoding.UTF8.GetBytes(body);
				context.Response.StatusCode = status;
				context.Response.ContentType = "application/json";
				context.Response.ContentLength64 = bytes.Length;
				await context.Response.OutputStream.WriteAsync(bytes).ConfigureAwait(false);
				context.Response.Close();
			}
		}

		public void Dispose() => _listener.Close();
	}

	private static DnaCenterClient CreateClient(ScriptedServer server, int maxAttemptCount = 5)
		=> new(new DnaCenterClientOptions
		{
			Uri = server.BaseUri,
			Username = "user",
			Password = "pass",
			MaxAttemptCount = maxAttemptCount
		});

	private static (int, string) Token(string token) => (200, $"{{\"Token\":\"{token}\"}}");

	[Fact]
	public async Task FirstRequest_AcquiresTokenAndSendsItOnTheRequest()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token-1"))
			.On(StatusPath, (200, SuccessBody));
		using var client = CreateClient(server);

		var status = await client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		status.Status.Should().Be(ExecutionStatusStatus.Success);
		server.Received.Select(r => r.Path).Should().Equal(AuthPath, StatusPath);
		server.Received[1].AuthToken.Should().Be("token-1");
	}

	[Fact]
	public async Task Unauthorized_RefreshesTokenAndRetriesRequest()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token-1"), Token("token-2"))
			.On(StatusPath, (401, string.Empty), (200, SuccessBody));
		using var client = CreateClient(server);

		var status = await client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		status.Status.Should().Be(ExecutionStatusStatus.Success);
		server.Received.Select(r => r.Path).Should().Equal(AuthPath, StatusPath, AuthPath, StatusPath);
		server.Received[1].AuthToken.Should().Be("token-1");
		server.Received[3].AuthToken.Should().Be("token-2");
	}

	[Fact]
	public async Task PersistentUnauthorized_GivesUpAfterTwoRefreshes()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token"))
			.On(StatusPath, (401, string.Empty));
		using var client = CreateClient(server);

		var act = () => client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		(await act.Should().ThrowAsync<ApiException>()).Which.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
		// One initial token, two refreshes; three attempts at the endpoint.
		server.Received.Count(r => r.Path == AuthPath).Should().Be(3);
		server.Received.Count(r => r.Path == StatusPath).Should().Be(3);
	}

	[Theory]
	[InlineData(429)]
	[InlineData(503)]
	public async Task ThrottledOrUnavailable_GivesUpAtMaxAttemptCountWithExplanation(int statusCode)
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token"))
			.On(StatusPath, (statusCode, string.Empty));
		using var client = CreateClient(server, maxAttemptCount: 1);

		var act = () => client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		var exception = (await act.Should().ThrowAsync<ApiException>()).Which;
		exception.StatusCode.Should().Be((HttpStatusCode)statusCode);
		exception.ReasonPhrase.Should().Contain("Giving up retrying").And.Contain(statusCode.ToString());
		server.Received.Count(r => r.Path == StatusPath).Should().Be(1);
	}

	[Fact]
	public async Task ServiceUnavailable_IsRetriedAfterDelayUntilSuccess()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token"))
			.On(StatusPath, (503, string.Empty), (200, SuccessBody));
		using var client = CreateClient(server);

		var status = await client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		status.Status.Should().Be(ExecutionStatusStatus.Success);
		server.Received.Count(r => r.Path == StatusPath).Should().Be(2);
	}

	[Fact]
	public async Task OtherErrors_AreReturnedToTheCallerWithoutRetry()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token"))
			.On(StatusPath, (500, string.Empty));
		using var client = CreateClient(server);

		var act = () => client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		(await act.Should().ThrowAsync<ApiException>()).Which.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		server.Received.Count(r => r.Path == StatusPath).Should().Be(1);
	}

	[Fact]
	public async Task CancelledToken_ThrowsBeforeSending()
	{
		using var server = new ScriptedServer()
			.On(AuthPath, Token("token"))
			.On(StatusPath, (200, SuccessBody));
		using var client = CreateClient(server);
		using var cts = new System.Threading.CancellationTokenSource();
		await cts.CancelAsync();

		var act = () => client.Business.GetExecutionStatusAsync("abc", cts.Token);

		await act.Should().ThrowAsync<OperationCanceledException>();
		server.Received.Should().BeEmpty();
	}

	[Theory]
	[InlineData(1, 10, 2.0, 32, 10)]
	[InlineData(5, 1, 2.0, 32, 16)]
	[InlineData(10, 1, 2.0, 32, 32)]
	[InlineData(3, 10, 2.0, 32, 10)]
	public void CalculateBackoffDelay_WaitsAtLeastRetryAfterButNoMoreThanMaximum(
		int attemptCount,
		int retryAfterSeconds,
		double factor,
		int maxSeconds,
		int expectedSeconds)
		=> AuthenticatedHttpClientHandler
			.CalculateBackoffDelay(attemptCount, retryAfterSeconds, factor, maxSeconds)
			.Should().Be(TimeSpan.FromSeconds(expectedSeconds));
}

/// <summary>
/// Tests for <see cref="DnaCenterClientOptions.Validate" />.
/// </summary>
public class DnaCenterClientOptionsValidateTests
{
	private static readonly Uri SomeUri = new("https://dna.example.com/");

	[Fact]
	public void UsernameAndPassword_WithUri_IsValid()
		=> new DnaCenterClientOptions { Uri = SomeUri, Username = "u", Password = "p" }
			.Invoking(o => o.Validate()).Should().NotThrow();

	[Fact]
	public void Token_WithUri_IsValid()
		=> new DnaCenterClientOptions { Uri = SomeUri, Token = "t" }
			.Invoking(o => o.Validate()).Should().NotThrow();

	[Fact]
	public void HttpClientAlone_IsValid()
		=> new DnaCenterClientOptions { HttpClient = new System.Net.Http.HttpClient() }
			.Invoking(o => o.Validate()).Should().NotThrow();

	[Fact]
	public void MaxBackOffDelaySecondsBelowOne_Throws()
		=> new DnaCenterClientOptions { Uri = SomeUri, Token = "t", MaxBackOffDelaySeconds = 0 }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*MaxBackOffDelaySeconds*");

	[Fact]
	public void BackOffDelayFactorBelowOne_Throws()
		=> new DnaCenterClientOptions { Uri = SomeUri, Token = "t", BackOffDelayFactor = 0.5 }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*BackOffDelayFactor*");

	[Fact]
	public void MaxAttemptCountBelowOne_Throws()
		=> new DnaCenterClientOptions { Uri = SomeUri, Token = "t", MaxAttemptCount = 0 }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*MaxAttemptCount*");

	[Fact]
	public void MissingUri_Throws()
		=> new DnaCenterClientOptions { Token = "t" }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*Uri*");

	[Fact]
	public void NoTokenAndNoUsername_Throws()
		=> new DnaCenterClientOptions { Uri = SomeUri, Password = "p" }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*Username*");

	[Fact]
	public void NoTokenAndNoPassword_Throws()
		=> new DnaCenterClientOptions { Uri = SomeUri, Username = "u" }
			.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage("*Password*");

	[Theory]
	[InlineData("Username")]
	[InlineData("Password")]
	public void TokenWithCredentials_Throws(string which)
	{
		var options = new DnaCenterClientOptions { Uri = SomeUri, Token = "t" };
		if (which == "Username")
		{
			options.Username = "u";
		}
		else
		{
			options.Password = "p";
		}

		options.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage($"*{which}*");
	}

	[Theory]
	[InlineData("Token")]
	[InlineData("Username")]
	[InlineData("Password")]
	public void HttpClientWithCredentials_Throws(string which)
	{
		var options = new DnaCenterClientOptions { HttpClient = new System.Net.Http.HttpClient() };
		switch (which)
		{
			case "Token":
				options.Token = "t";
				break;
			case "Username":
				options.Username = "u";
				break;
			default:
				options.Password = "p";
				break;
		}

		options.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage($"*{which}*");
	}
}
