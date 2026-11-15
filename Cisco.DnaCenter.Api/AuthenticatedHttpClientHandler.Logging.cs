using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api;

public partial class AuthenticatedHttpClientHandler
{
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
}
