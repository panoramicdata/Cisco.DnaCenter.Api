using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAuthentication
	{
		#region Asynchronous Operations

		/// <summary>
		/// Authentication API
		/// </summary>
		/// <remarks>
		/// API to obtain an access token. The token obtained using this API is required to be set as value to the X-Auth-Token HTTP Header for all API calls to Cisco DNA Center.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="Content_Type">Request body content type</param>
		/// <param name="Authorization">Basic Auth Base64 encoding of &lt;username&gt;:&lt;password&gt;</param>
		/// <returns>Task of AuthenticationAPIResponse</returns>
		[Post("/dna/system/api/v1/auth/token")]
		System.Threading.Tasks.Task<AuthenticationAPIResponse> AuthenticationAPI([Header("UserAgent")] string userAgent, string Content_Type, string Authorization);
		#endregion Asynchronous Operations
	}
}
