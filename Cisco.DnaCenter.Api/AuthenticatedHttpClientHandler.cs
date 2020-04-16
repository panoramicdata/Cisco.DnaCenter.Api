using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api
{
	public class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private string? _token;

		public string Token
		{
			set
			{
				_token = value ?? throw new ArgumentNullException(nameof(value));
			}
		}

		public AuthenticatedHttpClientHandler(string? token)
		{
			_token = token;
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			if (_token is null)
			{
				// Token will be null when first connecting - this is fine.
				// However, if the user is attempting a secure call, throw an exception
				if (!request.RequestUri.AbsoluteUri.EndsWith("/dna/system/api/v1/auth/token"))
				{
					throw new InvalidOperationException("Call ConnectAsync() to obtain an authentication token before making other calls.");
				}
			}
			else
			{
				request.Headers.Add("X-Auth-Token", _token);
			}
			return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
		}
	}
}
