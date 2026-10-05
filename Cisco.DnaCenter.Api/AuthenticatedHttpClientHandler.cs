using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api;

/// <summary>
/// An <see cref="HttpClientHandler" /> that attaches the DNA Center session token to each
/// request, refreshes it when it expires, and retries throttled or failed requests.
/// </summary>
public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly DnaCenterClientOptions _options;
	private readonly DnaCenterClient _dnaCenterClient;
	private readonly ILogger _logger;
	private string? _token;
	private readonly string? _userAgent;
	private const LogLevel _levelToLogAt = LogLevel.Trace;

	/// <summary>
	/// The URI of the most recent request sent through this handler.
	/// </summary>
	public string LastRequestUri { get; private set; } = string.Empty;

	/// <summary>
	/// Sets the session token sent with each request. Write-only, so that the token
	/// cannot be read back out of the handler.
	/// </summary>
	public string Token
	{
		set
		{
			_token = value ?? throw new ArgumentNullException(nameof(value));
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AuthenticatedHttpClientHandler" /> class.
	/// </summary>
	/// <param name="dnaCenterClient">The client used to acquire a token when one is needed.</param>
	/// <param name="options">The client options.</param>
	/// <param name="logger">The logger to write diagnostics to.</param>
	/// <exception cref="ArgumentNullException">Any argument is null.</exception>
	public AuthenticatedHttpClientHandler(
		DnaCenterClient? dnaCenterClient,
		DnaCenterClientOptions? options,
		ILogger logger
		)
	{
		_options = options ?? throw new ArgumentNullException(nameof(options));
		_token = _options.Token;
		_userAgent = _options.UserAgent;
		_dnaCenterClient = dnaCenterClient ?? throw new ArgumentNullException(nameof(dnaCenterClient));
		_logger = logger ?? throw new ArgumentNullException(nameof(logger));

		if (_options.IgnoreSslCertificateErrors)
		{
			ServerCertificateCustomValidationCallback = DangerousAcceptAnyServerCertificateValidator;
		}
	}

	/// <summary>
	/// Sends a request, adding the session token and retrying as the options allow.
	/// </summary>
	/// <param name="request">The request to send.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>The response.</returns>
	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		var state = new SendState($"Request {Guid.NewGuid()}: ");

		while (true)
		{
			state.AttemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			await AttachHeadersAsync(request, cancellationToken).ConfigureAwait(false);
			await LogRequestAsync(request, state.LogPrefix).ConfigureAwait(false);

			LastRequestUri = request.RequestUri?.ToString() ?? string.Empty;

			var httpResponseMessage = await base
				.SendAsync(request, cancellationToken)
				.ConfigureAwait(false);

			await LogResponseAsync(httpResponseMessage, state.LogPrefix).ConfigureAwait(false);

			// As long as we were not given a back-off request then we'll return the response and any further StatusCode handling is up to the caller
			var statusCodeInt = (int)httpResponseMessage.StatusCode;
			var decision = await DecideAsync(request, statusCodeInt, state, cancellationToken).ConfigureAwait(false);

			if (decision.Outcome == SendOutcome.Return)
			{
				return httpResponseMessage;
			}

			if (decision.Outcome == SendOutcome.Continue)
			{
				continue;
			}

			// Try up to the maximum retry count. Replace the reason phrase with an error message if giving up.
			if (state.AttemptCount >= _options.MaxAttemptCount)
			{
				_logger.LogInformation(
					"{LogPrefix}Giving up retrying. Returning {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
					state.LogPrefix,
					statusCodeInt,
					state.AttemptCount,
					_options.MaxAttemptCount,
					request.Method.ToString(),
					request.RequestUri
				);

				httpResponseMessage.ReasonPhrase = $"Giving up retrying. Returning {statusCodeInt} on attempt {state.AttemptCount}/{_options.MaxAttemptCount}.";

				return httpResponseMessage;
			}

			// Wait and then retry. Replace the reason phrase with a message that we're retrying.
			_logger.LogInformation(
				"{LogPrefix}Received {StatusCode} on attempt {AttemptCount}/{MaxAttemptCount} - Waiting {TotalSeconds:N2}s. ({Method} - {Url})",
				state.LogPrefix,
				statusCodeInt,
				state.AttemptCount,
				_options.MaxAttemptCount,
				decision.Delay.TotalSeconds,
				request.Method.ToString(),
				request.RequestUri
			);

			httpResponseMessage.ReasonPhrase = $"Retrying after receiving {statusCodeInt} on attempt {state.AttemptCount}/{_options.MaxAttemptCount} - Waiting {decision.Delay.TotalSeconds:N2}s.";

			await Task.Delay(decision.Delay, cancellationToken).ConfigureAwait(false);
		}
	}

	private async Task AttachHeadersAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (_token is null)
		{
			if (request.RequestUri?.AbsoluteUri.EndsWith("/dna/system/api/v1/auth/token") != true)
			{
				await _dnaCenterClient
					.ConnectAsync(cancellationToken)
					.ConfigureAwait(false);

				// Token can be forcefully unset before here
				// Check that X-Auth-Token is not present before adding new token to avoid double entry, triggering a 401
				request.Headers.Remove("X-Auth-Token");
				request.Headers.Add("X-Auth-Token", _token);
			}
		}
		else
		{
			// For safety, ensure an old header isn't present.
			request.Headers.Remove("X-Auth-Token");

			request.Headers.Add("X-Auth-Token", _token);
		}

		if (_userAgent is not null)
		{
			request.Headers.Add("User-Agent", _userAgent);
		}
	}

	private async Task LogRequestAsync(HttpRequestMessage request, string logPrefix)
	{
		// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Request\r\n{Request}", logPrefix, request.ToRedactedString());
		if (request.Content != null)
		{
			var requestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}RequestContent\r\n{RequestContent}", logPrefix, requestContent);
		}
	}

	private async Task LogResponseAsync(HttpResponseMessage httpResponseMessage, string logPrefix)
	{
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Response\r\n{HttpResponseMessage}", logPrefix, httpResponseMessage.ToRedactedString());
		if (httpResponseMessage.Content != null)
		{
			var responseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}ResponseContent\r\n{ResponseContent}", logPrefix, responseContent);
		}
	}

	private async Task<SendDecision> DecideAsync(
		HttpRequestMessage request,
		int statusCodeInt,
		SendState state,
		CancellationToken cancellationToken)
	{
		switch (statusCodeInt)
		{
			case 401:
				return await HandleUnauthorizedAsync(request, state, cancellationToken).ConfigureAwait(false);
			case 429:
				// Back off. The limiter varies depending on the endpoint e.g 100/min for Sites and 50/min for Devices.
				// The 429 body names the rate-limit window, but it is unclear whether that is consistent across
				// endpoints, so we use our usual retry method; worst case we wait another 50+ seconds.
				_logger.LogDebug(
					"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
					state.LogPrefix, statusCodeInt, state.AttemptCount, _options.MaxAttemptCount
				);
				return SendDecision.Wait(CalculateBackoffDelay(state.AttemptCount, 10, _options.BackOffDelayFactor, _options.MaxBackOffDelaySeconds));
			case 502:
			case 503:
			case 504:
				_logger.LogInformation(
					"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
					state.LogPrefix, statusCodeInt, state.AttemptCount, _options.MaxAttemptCount
				);
				return SendDecision.Wait(TimeSpan.FromSeconds(5));
			default:
				LogOtherStatus(request, statusCodeInt, state);
				return SendDecision.ReturnResponse;
		}
	}

	private async Task<SendDecision> HandleUnauthorizedAsync(
		HttpRequestMessage request,
		SendState state,
		CancellationToken cancellationToken)
	{
		// Token might be expired or invalid, try to refresh
		if (state.TokenRefreshCount >= MaxTokenRefreshCount)
		{
			_logger.LogError(
				"{LogPrefix}Token refresh failed or unauthorized after {MaxTokenRefreshCount} attempts. ({Method} - {Url})",
				state.LogPrefix,
				MaxTokenRefreshCount,
				request.Method.ToString(),
				request.RequestUri
			);
			return SendDecision.ReturnResponse;
		}

		state.TokenRefreshCount++;

		_logger.LogWarning(
			"{LogPrefix}Received 401 Unauthorized. Attempting token refresh #{TokenRefreshCount}. ({Method} - {Url})",
			state.LogPrefix,
			state.TokenRefreshCount,
			request.Method.ToString(),
			request.RequestUri
		);

		// Unset old token and remove from header
		_token = null;
		_dnaCenterClient.IsConnected = false;

		// Get a new token
		await _dnaCenterClient.ConnectAsync(cancellationToken).ConfigureAwait(false);

		request.Headers.Remove("X-Auth-Token");
		request.Headers.Add("X-Auth-Token", _token);

		return SendDecision.ContinueLoop;
	}

	private void LogOtherStatus(HttpRequestMessage request, int statusCodeInt, SendState state)
	{
		if (state.AttemptCount > 1)
		{
			_logger.LogDebug(
				"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
				state.LogPrefix, statusCodeInt, state.AttemptCount, _options.MaxAttemptCount
			);
		}

		if (statusCodeInt == 500)
		{
			_logger.LogError(
				"{LogPrefix}Received remote error code 500 on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
				state.LogPrefix,
				state.AttemptCount,
				_options.MaxAttemptCount,
				request.Method.ToString(),
				request.RequestUri
			);
		}
	}

	private const int MaxTokenRefreshCount = 2;

	private sealed class SendState(string logPrefix)
	{
		public string LogPrefix { get; } = logPrefix;

		public int AttemptCount { get; set; }

		public int TokenRefreshCount { get; set; }
	}

	private enum SendOutcome
	{
		Return,
		Continue,
		Wait
	}

	private readonly record struct SendDecision(SendOutcome Outcome, TimeSpan Delay)
	{
		public static SendDecision ReturnResponse { get; } = new(SendOutcome.Return, TimeSpan.Zero);

		public static SendDecision ContinueLoop { get; } = new(SendOutcome.Continue, TimeSpan.Zero);

		public static SendDecision Wait(TimeSpan delay) => new(SendOutcome.Wait, delay);
	}

	/// <summary>
	/// Calculate the back-off delay taking into account the attemptcount, back-off factor and the maximum back-off delay.
	/// Wait at least retryAfterSeconds, then back off by the backOffDelayFactor to the power of the attemptCount, but no more than maxBackOffDelay.
	/// </summary>
	internal static TimeSpan CalculateBackoffDelay(
		int attemptCount,
		int retryAfterSeconds,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds)
		=> TimeSpan.FromSeconds(
			Math.Min(
				Math.Max(
					// Wait as long as we can based on the attemptCount
					Math.Pow(backOffDelayFactor, attemptCount - 1),
					retryAfterSeconds
				),
				// But no longer than the maximum
				maxBackOffDelaySeconds)
		);
}
