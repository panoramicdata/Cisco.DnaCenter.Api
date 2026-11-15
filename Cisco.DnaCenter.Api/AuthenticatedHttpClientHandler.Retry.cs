using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api;

public partial class AuthenticatedHttpClientHandler
{
	private async Task<bool> HandleWaitOutcomeAsync(
		HttpResponseMessage httpResponseMessage,
		HttpRequestMessage request,
		int statusCodeInt,
		SendState state,
		SendDecision decision,
		CancellationToken cancellationToken)
	{
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

			return true;
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

		return false;
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

		state.BeginTokenRefresh();

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

	private const int MaxTokenRefreshCount = 2;

	private sealed class SendState(string logPrefix)
	{
		public string LogPrefix { get; } = logPrefix;

		public int AttemptCount { get; private set; }

		public int TokenRefreshCount { get; private set; }

		public void BeginAttempt() => AttemptCount++;

		public void BeginTokenRefresh() => TokenRefreshCount++;
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
