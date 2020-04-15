using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api
{
	public class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private readonly string _scheme;
		private readonly string _token;

		public AuthenticatedHttpClientHandler(string scheme, string token)
		{
			_scheme = scheme;
			_token = token;
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			request.Headers.Authorization = new AuthenticationHeaderValue(_scheme, _token);
			return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
		}
	}
}
