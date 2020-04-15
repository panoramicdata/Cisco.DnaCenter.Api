using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkSettings
	{
		#region Asynchronous Operations

		/// <summary>
		/// Assign Credential To Site
		/// </summary>
		/// <remarks>
		/// Assign Device Credential To Site
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="siteId">site id to assign credential.</param>
		/// <returns>Task of AssignCredentialToSiteResponse</returns>
		[Post("/dna/intent/api/v1/credential-to-site/{siteId}")]
		System.Threading.Tasks.Task<AssignCredentialToSiteResponse> AssignCredentialToSite([Header("UserAgent")] string userAgent, [Body]AssignCredentialToSiteRequest request, string __persistbapioutput, [AliasAs("siteId")]string siteId);

		/// <summary>
		/// Create Device Credentials
		/// </summary>
		/// <remarks>
		/// API to create device credentials.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of CreateDeviceCredentialsResponse</returns>
		[Post("/dna/intent/api/v1/device-credential")]
		System.Threading.Tasks.Task<CreateDeviceCredentialsResponse> CreateDeviceCredentials([Header("UserAgent")] string userAgent, [Body]CreateDeviceCredentialsRequest request);

		/// <summary>
		/// Create Global Pool
		/// </summary>
		/// <remarks>
		/// API to create global pool.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput"> Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of CreateGlobalPoolResponse</returns>
		[Post("/dna/intent/api/v1/global-pool")]
		System.Threading.Tasks.Task<CreateGlobalPoolResponse> CreateGlobalPool([Header("UserAgent")] string userAgent, [Body]CreateGlobalPoolRequest request, string __persistbapioutput = null);

		/// <summary>
		/// Create Network
		/// </summary>
		/// <remarks>
		/// API to create a network for DHCP and DNS center server settings.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="siteId">Site id to which site details to associate with the network settings.</param>
		/// <param name="__persistbapioutput">Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of CreateNetworkResponse</returns>
		[Post("/dna/intent/api/v1/network/{siteId}")]
		System.Threading.Tasks.Task<CreateNetworkResponse> CreateNetwork([Header("UserAgent")] string userAgent, [Body]CreateNetworkRequest request, [AliasAs("siteId")]string siteId, bool? __persistbapioutput = null);

		/// <summary>
		/// Create SP Profile
		/// </summary>
		/// <remarks>
		/// API to create service provider profile(QOS).
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of CreateSPProfileResponse</returns>
		[Post("/dna/intent/api/v1/service-provider")]
		System.Threading.Tasks.Task<CreateSPProfileResponse> CreateSPProfile([Header("UserAgent")] string userAgent, [Body]CreateSPProfileRequest request);

		/// <summary>
		/// Delete Device Credential
		/// </summary>
		/// <remarks>
		/// Delete device credential.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">global credential id</param>
		/// <returns>Task of DeleteDeviceCredentialResponse</returns>
		[Delete("/dna/intent/api/v1/device-credential/{id}")]
		System.Threading.Tasks.Task<DeleteDeviceCredentialResponse> DeleteDeviceCredential([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Delete Global IP Pool
		/// </summary>
		/// <remarks>
		/// API to delete global IP pool.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">global pool id</param>
		/// <returns>Task of DeleteGlobalIPPoolResponse</returns>
		[Delete("/dna/intent/api/v1/global-pool/{id}")]
		System.Threading.Tasks.Task<DeleteGlobalIPPoolResponse> DeleteGlobalIPPool([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Delete SP Profile
		/// </summary>
		/// <remarks>
		/// API to delete Service Provider profile (QoS).
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="sp_profile_name">sp profile name</param>
		/// <returns>Task of DeleteSPProfileResponse</returns>
		[Delete("/dna/intent/api/v1/sp-profile/{sp-profile-name}")]
		System.Threading.Tasks.Task<DeleteSPProfileResponse> DeleteSPProfile([Header("UserAgent")] string userAgent, [AliasAs("sp_profile_name")]string sp_profile_name);

		/// <summary>
		/// Get Device Credential Details
		/// </summary>
		/// <remarks>
		/// API to get device credential details.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteId">Site id to retrieve the credential details associated with the site. (optional, default to )</param>
		/// <returns>Task of GetDeviceCredentialDetailsResponse</returns>
		[Get("/dna/intent/api/v1/device-credential")]
		System.Threading.Tasks.Task<GetDeviceCredentialDetailsResponse> GetDeviceCredentialDetails([Header("UserAgent")] string userAgent, [AliasAs("siteId")]string siteId = null);

		/// <summary>
		/// Get Global Pool
		/// </summary>
		/// <remarks>
		/// API to get global pool.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="offset">offset/starting row (optional, default to )</param>
		/// <param name="limit">No of Global Pools to be retrieved (optional, default to )</param>
		/// <returns>Task of GetGlobalPoolResponse</returns>
		[Get("/dna/intent/api/v1/global-pool")]
		System.Threading.Tasks.Task<GetGlobalPoolResponse> GetGlobalPool([Header("UserAgent")] string userAgent, [AliasAs("offset")]string offset = null, [AliasAs("limit")]string limit = null);

		/// <summary>
		/// Get Network
		/// </summary>
		/// <remarks>
		/// API to get  DHCP and DNS center server details.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteId">Site id to get the network settings associated with the site. (optional, default to )</param>
		/// <returns>Task of GetNetworkResponse</returns>
		[Get("/dna/intent/api/v1/network")]
		System.Threading.Tasks.Task<GetNetworkResponse> GetNetwork([Header("UserAgent")] string userAgent, [AliasAs("siteId")]string siteId = null);

		/// <summary>
		/// Get Service provider Details
		/// </summary>
		/// <remarks>
		/// API to get service provider details (QoS).
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GetServiceProviderDetailsResponse</returns>
		[Get("/dna/intent/api/v1/service-provider")]
		System.Threading.Tasks.Task<GetServiceProviderDetailsResponse> GetServiceProviderDetails([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Update Device Credentials
		/// </summary>
		/// <remarks>
		/// API to update device credentials.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateDeviceCredentialsResponse</returns>
		[Put("/dna/intent/api/v1/device-credential")]
		System.Threading.Tasks.Task<UpdateDeviceCredentialsResponse> UpdateDeviceCredentials([Header("UserAgent")] string userAgent, [Body]UpdateDeviceCredentialsRequest request);

		/// <summary>
		/// Update Global Pool
		/// </summary>
		/// <remarks>
		/// API to update global pool
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateGlobalPoolResponse</returns>
		[Put("/dna/intent/api/v1/global-pool")]
		System.Threading.Tasks.Task<UpdateGlobalPoolResponse> UpdateGlobalPool([Header("UserAgent")] string userAgent, [Body]UpdateGlobalPoolRequest request);

		/// <summary>
		/// Update Network
		/// </summary>
		/// <remarks>
		/// API to update network for DHCP and DNS center server settings.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="siteId">Site id to update the network settings which is associated with the site</param>
		/// <param name="__persistbapioutput">Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of UpdateNetworkResponse</returns>
		[Put("/dna/intent/api/v1/network/{siteId}")]
		System.Threading.Tasks.Task<UpdateNetworkResponse> UpdateNetwork([Header("UserAgent")] string userAgent, [Body]UpdateNetworkRequest request, [AliasAs("siteId")]string siteId, bool? __persistbapioutput = null);

		/// <summary>
		/// Update SP Profile
		/// </summary>
		/// <remarks>
		/// API to update SP profile
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateSPProfileResponse</returns>
		[Put("/dna/intent/api/v1/service-provider")]
		System.Threading.Tasks.Task<UpdateSPProfileResponse> UpdateSPProfile([Header("UserAgent")] string userAgent, [Body]UpdateSPProfileRequest request);
		#endregion Asynchronous Operations
	}
}
