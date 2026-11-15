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
public partial class AuthenticatedHttpClientHandler : HttpClientHandler
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
	/// Gets or sets the session token currently set on this handler.
	/// </summary>
	public string? Token
	{
		get => _token;
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
		ThrowIfWriteRefused(request);

		var state = new SendState($"Request {Guid.NewGuid()}: ");
		HttpResponseMessage? httpResponseMessage = null;

		while (true)
		{
			state.AttemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			await AttachHeadersAsync(request, cancellationToken).ConfigureAwait(false);
			await LogRequestAsync(request, state.LogPrefix).ConfigureAwait(false);

			LastRequestUri = GetRequestUri(request);

			httpResponseMessage = await base
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

			var giveUp = await HandleWaitOutcomeAsync(httpResponseMessage, request, statusCodeInt, state, decision, cancellationToken).ConfigureAwait(false);
			if (giveUp)
			{
				return httpResponseMessage;
			}
		}
	}

	private void ThrowIfWriteRefused(HttpRequestMessage request)
	{
		if (_options.IsReadOnly && !IsReadMethod(request.Method))
		{
			throw new InvalidOperationException($"The client is read-only: refusing {request.Method} {request.RequestUri}.");
		}
	}

	private static string GetRequestUri(HttpRequestMessage request)
		=> request.RequestUri?.ToString() ?? string.Empty;

	private static bool IsReadMethod(HttpMethod method)
		=> method == HttpMethod.Get || method == HttpMethod.Head || method == HttpMethod.Options;

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
}
