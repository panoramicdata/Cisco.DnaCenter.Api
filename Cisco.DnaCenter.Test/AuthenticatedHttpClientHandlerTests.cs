using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Data;
using Refit;
using System;
using System.Linq;
using System.Net;
using System.Threading;
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

	private static DnaCenterClient CreateClient(ScriptedServer server, int maxAttemptCount = 5)
		=> new(new DnaCenterClientOptions
		{
			Uri = server.BaseUri,
			Username = "user",
			Password = "pass",
			MaxAttemptCount = maxAttemptCount
		});

	private static (int, string) TokenResponse(string value) => (200, $"{{\"Token\":\"{value}\"}}");

	private static ScriptedServer ServeStatus(params (int Status, string Body)[] statusResponses)
		=> ServeStatusWithTokens(["token"], statusResponses);

	private static ScriptedServer ServeStatusWithTokens(string[] tokens, params (int Status, string Body)[] statusResponses)
		=> new ScriptedServer()
			.On(AuthPath, [.. tokens.Select(TokenResponse)])
			.On(StatusPath, statusResponses);

	private static async Task<ExecutionStatus> GetSuccessfulStatusAsync(ScriptedServer server)
	{
		using var client = CreateClient(server);
		var status = await GetStatusAsync(client);
		status.Status.Should().Be(ExecutionStatusStatus.Success);
		return status;
	}

	private static Task<ExecutionStatus> GetStatusAsync(DnaCenterClient client)
		=> client.Business.GetExecutionStatusAsync("abc", TestContext.Current.CancellationToken);

	private static async Task<ApiException> GetStatusExpectingFailureAsync(DnaCenterClient client)
		=> (await FluentActions.Awaiting(() => GetStatusAsync(client)).Should().ThrowAsync<ApiException>()).Which;

	private static int StatusRequestCount(ScriptedServer server)
		=> server.Received.Count(r => r.Path == StatusPath);

	[Fact]
	public async Task FirstRequest_AcquiresTokenAndSendsItOnTheRequest()
	{
		using var server = ServeStatusWithTokens(["token-1"], (200, SuccessBody));

		await GetSuccessfulStatusAsync(server);

		server.Received.Select(r => r.Path).Should().Equal(AuthPath, StatusPath);
		server.Received[1].AuthToken.Should().Be("token-1");
	}

	[Fact]
	public async Task Unauthorized_RefreshesTokenAndRetriesRequest()
	{
		using var server = ServeStatusWithTokens(["token-1", "token-2"], (401, string.Empty), (200, SuccessBody));

		await GetSuccessfulStatusAsync(server);

		server.Received.Select(r => r.Path).Should().Equal(AuthPath, StatusPath, AuthPath, StatusPath);
		server.Received[1].AuthToken.Should().Be("token-1");
		server.Received[3].AuthToken.Should().Be("token-2");
	}

	[Fact]
	public async Task PersistentUnauthorized_GivesUpAfterTwoRefreshes()
	{
		using var server = ServeStatus((401, string.Empty));
		using var client = CreateClient(server);

		var exception = await GetStatusExpectingFailureAsync(client);

		exception.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
		// One initial token, two refreshes; three attempts at the endpoint.
		server.Received.Count(r => r.Path == AuthPath).Should().Be(3);
		StatusRequestCount(server).Should().Be(3);
	}

	[Theory]
	[InlineData(429)]
	[InlineData(503)]
	public async Task ThrottledOrUnavailable_GivesUpAtMaxAttemptCountWithExplanation(int statusCode)
	{
		using var server = ServeStatus((statusCode, string.Empty));
		using var client = CreateClient(server, maxAttemptCount: 1);

		var exception = await GetStatusExpectingFailureAsync(client);

		exception.StatusCode.Should().Be((HttpStatusCode)statusCode);
		exception.ReasonPhrase.Should().Contain("Giving up retrying").And.Contain(statusCode.ToString());
		StatusRequestCount(server).Should().Be(1);
	}

	[Fact]
	public async Task ServiceUnavailable_IsRetriedAfterDelayUntilSuccess()
	{
		using var server = ServeStatus((503, string.Empty), (200, SuccessBody));

		await GetSuccessfulStatusAsync(server);

		StatusRequestCount(server).Should().Be(2);
	}

	[Fact]
	public async Task OtherErrors_AreReturnedToTheCallerWithoutRetry()
	{
		using var server = ServeStatus((500, string.Empty));
		using var client = CreateClient(server);

		var exception = await GetStatusExpectingFailureAsync(client);

		exception.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		StatusRequestCount(server).Should().Be(1);
	}

	[Fact]
	public async Task CancelledToken_ThrowsBeforeSending()
	{
		using var server = ServeStatus((200, SuccessBody));
		using var client = CreateClient(server);
		using var cts = new CancellationTokenSource();
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