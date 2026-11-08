using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;
using System;
using System.Net.Http;
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
		using var server = CreateServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: true));

		var act = () => client.ApplicationPolicies.DeleteApplicationAsync("1", TestContext.Current.CancellationToken);

		(await act.Should().ThrowAsync<Refit.ApiRequestException>()).Which.InnerException.Should().BeOfType<InvalidOperationException>();
		server.Received.Count.Should().Be(0);
	}

	[Fact]
	public async Task WriteIsSent_WhenNotReadOnly()
	{
		using var server = CreateServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: false));

		try
		{
			await client.ApplicationPolicies.DeleteApplicationAsync("1", TestContext.Current.CancellationToken);
		}
		catch (Exception e) when (e is not InvalidOperationException)
		{
			// The stub returns no usable body; only the fact that the request arrived matters.
		}

		server.Received.Count.Should().Be(1);
	}

	[Fact]
	public async Task ReadStillGoesThrough_WhenIsReadOnly()
	{
		using var server = CreateServer();
		using var client = new DnaCenterClient(Options(server.BaseUri, isReadOnly: true));

		var status = await client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

		status.Should().NotBeNull();
		server.Received.Count.Should().Be(1);
	}

	private static ScriptedServer CreateServer() => new((200, "{\"status\":\"SUCCESS\"}"));
}