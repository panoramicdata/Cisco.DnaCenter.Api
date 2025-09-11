using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api;

public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly DnaCenterClientOptions _options;
	private readonly DnaCenterClient _dnaCenterClient;
	private readonly ILogger _logger;
	private string? _token;
	private string? _userAgent;
	private const LogLevel _levelToLogAt = LogLevel.Trace;

	public string LastRequestUri { get; private set; } = string.Empty;

	private readonly Stopwatch _durationStopWatch = new();

	public string Token
    {
        set
        {
            _token = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public AuthenticatedHttpClientHandler(
		DnaCenterClient dnaCenterClient,
		DnaCenterClientOptions options,
		ILogger logger
        )
    {
		_options = options;
		_token = options.Token;
		_userAgent = options.UserAgent;
		_dnaCenterClient = dnaCenterClient;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        if (_options.IgnoreSslCertificateErrors)
        {
            ServerCertificateCustomValidationCallback = DangerousAcceptAnyServerCertificateValidator;
        }
    }

    private bool DangerousAcceptAnyServerCertificateValidator(
        HttpRequestMessage arg1,
        X509Certificate2 arg2,
        X509Chain arg3,
        SslPolicyErrors arg4)
        => true;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var attemptCount = 0;
        var logPrefix = $"Request {Guid.NewGuid()}: ";
        var durationStopWatch = new Stopwatch();

        while (true)
        {
			_durationStopWatch.Restart();
			attemptCount++;
            cancellationToken.ThrowIfCancellationRequested();

            if (_token is null)
            {
                if (!request.RequestUri.AbsoluteUri.EndsWith("/dna/system/api/v1/auth/token"))
                {
                    await _dnaCenterClient
                        .ConnectAsync(cancellationToken)
                        .ConfigureAwait(false);
                    request.Headers.Add("X-Auth-Token", _token);
                }
            }
            else
            {
                request.Headers.Add("X-Auth-Token", _token);
            }

            if (_userAgent is not null)
            {
                request.Headers.Add("User-Agent", _userAgent);
            }

			// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
			if (_logger.IsEnabled(_levelToLogAt))
            {
                _logger.Log(_levelToLogAt, "{LogPrefix}Request\r\n{Request}", logPrefix, request);
                if (request.Content != null)
                {
                    var requestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                    _logger.Log(_levelToLogAt, "{LogPrefix}RequestContent\r\n{RequestContent}", logPrefix, requestContent);
                }
            }

			LastRequestUri = request.RequestUri?.ToString() ?? string.Empty;

			// Complete the action
			HttpResponseMessage httpResponseMessage;

            try
            {
                httpResponseMessage = await base
                    .SendAsync(request, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (HttpRequestException ex) when (ex.Message.StartsWith("INSERT COMMON ANNOYING ERROR HERE", StringComparison.Ordinal))
            {
				// *Keeping this try/catch template from the Meraki.API for consistancy* when applying to other projects.
				// If there's any specific random error that seems to occur, log it as a warning and retry

				var errorSummary = "SUMMARY";

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
                {
                    _logger.LogError(
						"{LogPrefix}Giving up retrying. Received {ErrorSummary} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix,
						errorSummary,
						attemptCount,
						_options.MaxAttemptCount,
						request.Method.ToString(),
                        request.RequestUri
                    );
                    throw;
                }

                _logger.LogWarning(
					"{LogPrefix}Received {ErrorSummary} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
                    logPrefix,
					errorSummary,
					attemptCount,
					_options.MaxAttemptCount,
					request.Method.ToString(),
                    request.RequestUri
                );

				// Wait 1 seconds and then retry
				await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken).ConfigureAwait(false);
                continue;
            }

			// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
			if (_logger.IsEnabled(_levelToLogAt))
            {
                _logger.Log(_levelToLogAt, "{LogPrefix}Response\r\n{HttpResponseMessage}", logPrefix, httpResponseMessage);
                if (httpResponseMessage.Content != null)
                {
                    var responseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                    _logger.Log(_levelToLogAt, "{LogPrefix}ResponseContent\r\n{ResponseContent}", logPrefix, responseContent);
                }
            }

            durationStopWatch.Stop();

			TimeSpan delay;
			// As long as we were not given a back-off request then we'll return the response and any further StatusCode handling is up to the caller
			var statusCodeInt = (int)httpResponseMessage.StatusCode;

            try
            {
                switch (statusCodeInt)
                {
                    case 429:
						// Back off by the requested amount.
						var headers = httpResponseMessage.Headers;
                        var foundHeader = headers.TryGetValues("Retry-After", out var retryAfterHeaders);
                        var retryAfterSecondsString = foundHeader
                            ? retryAfterHeaders.FirstOrDefault() ?? "1"
                            : "1";
                        if (!int.TryParse(retryAfterSecondsString, out var retryAfterSeconds))
                        {
                            retryAfterSeconds = 1;
                        }

                        delay = CalculateBackoffDelay(attemptCount, retryAfterSeconds, _options.BackOffDelayFactor, _options.MaxBackOffDelaySeconds);

                        _logger.LogDebug(
                            "{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
                            logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
                        );
                        break;
                    case 502:
                    case 503:
                    case 504:
                        _logger.LogInformation(
                            "{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
                            logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
                        );
                        delay = TimeSpan.FromSeconds(5);
                        break;
                    default:
                        if (attemptCount > 1)
                        {
                            _logger.LogDebug(
                                "{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
                                logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
                            );
                        }

                        if (statusCodeInt == 500)
                        {
                            _logger.LogError(
                                "{LogPrefix}Received remote error code 500 on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
                                logPrefix,
                                attemptCount,
                                _options.MaxAttemptCount,
                                request.Method.ToString(),
                                request.RequestUri
                            );
                        }

                        // Handle token expiration (existing logic)
                        if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized
                            && (await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false)).IndexOf("expired", StringComparison.InvariantCultureIgnoreCase) >= 0)
                        {
                            if (attemptCount != 1)
                            {
                                throw new InvalidOperationException("Unable to acquire new token.");
                            }
                            _token = null;
                            continue;
                        }

                        return httpResponseMessage;
                }

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
                {
                    _logger.LogInformation(
                        "{LogPrefix}Giving up retrying. Returning {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
                        logPrefix,
                        statusCodeInt,
                        attemptCount,
                        _options.MaxAttemptCount,
                        request.Method.ToString(),
                        request.RequestUri
                    );
                    return httpResponseMessage;
                }

                _logger.LogInformation(
                    "{LogPrefix}Received {StatusCode} on attempt {AttemptCount}/{MaxAttemptCount} - Waiting {TotalSeconds:N2}s. ({Method} - {Url})",
                    logPrefix,
                    statusCodeInt,
                    attemptCount,
                    _options.MaxAttemptCount,
                    delay.TotalSeconds,
                    request.Method.ToString(),
                    request.RequestUri
                );

                await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                // If you have statistics, record here as in Meraki.Api
                // Statistics.RecordStatusCode(statusCodeInt, (long)durationStopWatch.Elapsed.TotalMilliseconds, (long)delay.TotalMilliseconds);
            }
        }
    }

	/// <summary>
	/// Calculate the back-off delay taking into account the retry-after header, the attemptcount and back-off factor and the maximum back-off delay.
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
