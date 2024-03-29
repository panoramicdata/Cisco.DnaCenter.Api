using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAuthentication
{
	/// <summary>
	/// Authentication API
	/// </summary>
	/// <remarks>
	/// API to obtain an access token. The token obtained using this API is required to be set as value to the X-Auth-Token HTTP Header for all API calls to Cisco DNA Center.
	/// </remarks>
	/// <param name="authorization">Basic Auth Base64 encoding of &lt;username&gt;:&lt;password&gt;</param>
	/// <returns>Task of AuthenticationAPIResponse</returns>
	[Post("/dna/system/api/v1/auth/token")]
	Task<AuthenticationResponse> Authenticate(
		[Header("Authorization")]string authorization,
		CancellationToken cancellationToken = default);
}
