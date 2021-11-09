using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api
{
	public class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private const LogLevel _levelToLogAt = LogLevel.Trace;
		private string? _token;
		private readonly ILogger _logger;
		private readonly DnaCenterClient _dnaCenterClient;

		public string Token
		{
			set
			{
				_token = value ?? throw new ArgumentNullException(nameof(value));
			}
		}

		public AuthenticatedHttpClientHandler(
			DnaCenterClient dnaCenterClient,
			string? token,
			ILogger logger,
			bool ignoreSslCertificateErrors)
		{
			_dnaCenterClient = dnaCenterClient;
			_token = token;
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));

			if (ignoreSslCertificateErrors)
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
			var retryCount = 0;
			while (true)
			{
				if (_token is null)
				{
					// Token will be null when first connecting - this is fine.
					// However, if the user is attempting a secure call, throw an exception
					if (!request.RequestUri.AbsoluteUri.EndsWith("/dna/system/api/v1/auth/token"))
					{
						// We're not connected, so connect now (just in time)
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

				// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
				if (_logger.IsEnabled(_levelToLogAt))
				{
					_logger.Log(_levelToLogAt, $"Request\r\n{request}");
					if (request.Content != null)
					{
						_logger.Log(_levelToLogAt, "RequestContent\r\n" + await request.Content.ReadAsStringAsync().ConfigureAwait(false));
					}
				}

				var httpResponseMessage = await base
					.SendAsync(request, cancellationToken)
					.ConfigureAwait(false);

				if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized
					&& (await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false)).IndexOf("expired", StringComparison.InvariantCultureIgnoreCase) >= 0)
				{
					if (retryCount != 0)
					{
						// We've already tried this, so throw exception.
						throw new InvalidOperationException("Unable to acquire new token.");
					}

					// Invalidate the token so that on the next pass, a new token is requested.
					_token = null;
					retryCount++;
					continue;
				}

				// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
				if (_logger.IsEnabled(_levelToLogAt))
				{
					_logger.Log(_levelToLogAt, $"Response\r\n{httpResponseMessage}");
					if (httpResponseMessage.Content != null)
					{
						_logger.Log(_levelToLogAt, "ResponseContent\r\n" + await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));
					}
				}

				return httpResponseMessage;
			}
		}
	}
}
