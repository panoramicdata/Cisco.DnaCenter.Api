using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkSettings
	{
		/// <summary>
		/// Assign Credential To Site
		/// </summary>
		/// <remarks>
		/// Assign Device Credential To Site
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="siteId">site id to assign credential.</param>
		/// <returns>Task of AssignCredentialToSiteResponse</returns>
		[Post("/dna/intent/api/v1/credential-to-site/{siteId}")]
		Task<ExecutionStatusResponse> AssignCredentialToSiteAsync(
			[Body]AssignCredentialToSiteRequest request,
			string __persistbapioutput,
			[AliasAs("siteId")]string siteId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Device Credentials
		/// </summary>
		/// <remarks>
		/// API to create device credentials.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateDeviceCredentialsResponse</returns>
		[Post("/dna/intent/api/v1/device-credential")]
		Task<ExecutionStatusResponse> CreateDeviceCredentialsAsync(
			[Body]CreateDeviceCredentialsRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Global Pool
		/// </summary>
		/// <remarks>
		/// API to create global pool.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput"> Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of CreateGlobalPoolResponse</returns>
		[Post("/dna/intent/api/v1/global-pool")]
		Task<ExecutionStatusResponse> CreateGlobalPoolAsync(
			[Body]CreateGlobalPoolRequest request,
			string __persistbapioutput = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Network
		/// </summary>
		/// <remarks>
		/// API to create a network for DHCP and DNS center server settings.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="siteId">Site id to which site details to associate with the network settings.</param>
		/// <param name="__persistbapioutput">Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of CreateNetworkResponse</returns>
		[Post("/dna/intent/api/v1/network/{siteId}")]
		Task<ExecutionStatusResponse> CreateNetworkAsync(
			[Body]CreateNetworkRequest request,
			[AliasAs("siteId")]string siteId,
			bool? __persistbapioutput = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create SP Profile
		/// </summary>
		/// <remarks>
		/// API to create service provider profile(QOS).
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateSPProfileResponse</returns>
		[Post("/dna/intent/api/v1/service-provider")]
		Task<ExecutionStatusResponse> CreateSpProfileAsync(
			[Body]CreateSpProfileRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Device Credential
		/// </summary>
		/// <remarks>
		/// Delete device credential.
		/// </remarks>
		/// <param name="id">global credential id</param>
		/// <returns>Task of DeleteDeviceCredentialResponse</returns>
		[Delete("/dna/intent/api/v1/device-credential/{id}")]
		Task<ExecutionResponse> DeleteDeviceCredentialAsync(
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Global IP Pool
		/// </summary>
		/// <remarks>
		/// API to delete global IP pool.
		/// </remarks>
		/// <param name="id">global pool id</param>
		/// <returns>Task of DeleteGlobalIPPoolResponse</returns>
		[Delete("/dna/intent/api/v1/global-pool/{id}")]
		Task<ExecutionStatusResponse> DeleteGlobalIpPoolAsync(
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete SP Profile
		/// </summary>
		/// <remarks>
		/// API to delete Service Provider profile (QoS).
		/// </remarks>
		/// <param name="sp_profile_name">sp profile name</param>
		/// <returns>Task of DeleteSPProfileResponse</returns>
		[Delete("/dna/intent/api/v1/sp-profile/{spProfileName}")]
		Task<ExecutionStatusResponse> DeleteSpProfileAsync(
			[AliasAs("spProfileName")]string spProfileName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Device Credential Details
		/// </summary>
		/// <remarks>
		/// API to get device credential details.
		/// </remarks>
		/// <param name="siteId">Site id to retrieve the credential details associated with the site. (optional, default to )</param>
		/// <returns>Task of GetDeviceCredentialDetailsResponse</returns>
		[Get("/dna/intent/api/v1/device-credential")]
		Task<GetDeviceCredentialDetailsResponse> GetDeviceCredentialDetailsAsync(
			[AliasAs("siteId")]string siteId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Global Pool
		/// </summary>
		/// <remarks>
		/// API to get global pool.
		/// </remarks>
		/// <param name="offset">offset/starting row (optional, default to )</param>
		/// <param name="limit">No of Global Pools to be retrieved (optional, default to )</param>
		/// <returns>Task of GetGlobalPoolResponse</returns>
		[Get("/dna/intent/api/v1/global-pool")]
		Task<GetGlobalPoolResponse> GetGlobalPoolAsync(
			[AliasAs("offset")]string offset = null,
			[AliasAs("limit")]string limit = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Network
		/// </summary>
		/// <remarks>
		/// API to get  DHCP and DNS center server details.
		/// </remarks>
		/// <param name="siteId">Site id to get the network settings associated with the site. (optional, default to )</param>
		/// <returns>Task of GetNetworkResponse</returns>
		[Get("/dna/intent/api/v1/network")]
		Task<GetNetworkResponse> GetNetworkAsync(
			[AliasAs("siteId")]string siteId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Service provider Details
		/// </summary>
		/// <remarks>
		/// API to get service provider details (QoS).
		/// </remarks>
		/// <returns>Task of GetServiceProviderDetailsResponse</returns>
		[Get("/dna/intent/api/v1/service-provider")]
		Task<GetServiceProviderDetailsResponse> GetServiceProviderDetailsAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Device Credentials
		/// </summary>
		/// <remarks>
		/// API to update device credentials.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateDeviceCredentialsResponse</returns>
		[Put("/dna/intent/api/v1/device-credential")]
		Task<ExecutionStatusResponse> UpdateDeviceCredentialsAsync(
			[Body]UpdateDeviceCredentialsRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Global Pool
		/// </summary>
		/// <remarks>
		/// API to update global pool
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateGlobalPoolResponse</returns>
		[Put("/dna/intent/api/v1/global-pool")]
		Task<ExecutionStatusResponse> UpdateGlobalPoolAsync(
			[Body]UpdateGlobalPoolRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Network
		/// </summary>
		/// <remarks>
		/// API to update network for DHCP and DNS center server settings.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="siteId">Site id to update the network settings which is associated with the site</param>
		/// <param name="__persistbapioutput">Persist bapi sync response (optional, default to true)</param>
		/// <returns>Task of UpdateNetworkResponse</returns>
		[Put("/dna/intent/api/v1/network/{siteId}")]
		Task<ExecutionStatusResponse> UpdateNetworkAsync(
			[Body]UpdateNetworkRequest request,
			[AliasAs("siteId")]string siteId,
			bool? __persistbapioutput = null);

		/// <summary>
		/// Update SP Profile
		/// </summary>
		/// <remarks>
		/// API to update SP profile
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateSPProfileResponse</returns>
		[Put("/dna/intent/api/v1/service-provider")]
		Task<ExecutionStatusResponse> UpdateSPProfileAsync(
			[Body]UpdateSpProfileRequest request,
			CancellationToken cancellationToken = default);
	}
}
