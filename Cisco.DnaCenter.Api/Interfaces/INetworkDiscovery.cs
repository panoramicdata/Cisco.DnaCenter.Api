using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Collections.Generic;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkDiscovery
	{
		#region Asynchronous Operations

		/// <summary>
		/// Create CLI credentials
		/// </summary>
		/// <remarks>
		/// Adds global CLI credential
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/cli")]
		System.Threading.Tasks.Task<TaskIdResult> CreateCLICredentials([Header("UserAgent")] string userAgent, [Body]CLICredentialDto request, string Content_Type);

		/// <summary>
		/// Create HTTP read credentials
		/// </summary>
		/// <remarks>
		/// Adds HTTP read credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/http-read")]
		System.Threading.Tasks.Task<TaskIdResult> CreateHTTPReadCredentials([Header("UserAgent")] string userAgent, [Body]HTTPReadCredentialDto request, string Content_Type);

		/// <summary>
		/// Create HTTP write credentials
		/// </summary>
		/// <remarks>
		/// Adds global HTTP write credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/http-write")]
		System.Threading.Tasks.Task<TaskIdResult> CreateHTTPWriteCredentials([Header("UserAgent")] string userAgent, [Body]HTTPWriteCredentialDto request, string Content_Type);

		/// <summary>
		/// Create Netconf credentials
		/// </summary>
		/// <remarks>
		/// Adds global netconf credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/netconf")]
		System.Threading.Tasks.Task<TaskIdResult> CreateNetconfCredentials([Header("UserAgent")] string userAgent, [Body]NetconfCredentialDto request, string Content_Type);

		/// <summary>
		/// Create SNMP read community
		/// </summary>
		/// <remarks>
		/// Adds global SNMP read community
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv2-read-community")]
		System.Threading.Tasks.Task<TaskIdResult> CreateSNMPReadCommunity([Header("UserAgent")] string userAgent, [Body]SNMPvReadCommunityDto request, string Content_Type);

		/// <summary>
		/// Create SNMP write community
		/// </summary>
		/// <remarks>
		/// Adds global SNMP write community
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv2-write-community")]
		System.Threading.Tasks.Task<TaskIdResult> CreateSNMPWriteCommunity([Header("UserAgent")] string userAgent, [Body]SNMPvWriteCommunityDto request, string Content_Type);

		/// <summary>
		/// Create SNMPv3 credentials
		/// </summary>
		/// <remarks>
		/// Adds global SNMPv3 credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv3")]
		System.Threading.Tasks.Task<TaskIdResult> CreateSNMPv3Credentials([Header("UserAgent")] string userAgent, [Body]SNMPvCredentialDto request, string Content_Type);

		/// <summary>
		/// Create/Update SNMP properties
		/// </summary>
		/// <remarks>
		/// Adds SNMP properties
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/snmp-property")]
		System.Threading.Tasks.Task<TaskIdResult> CreateUpdateSNMPProperties([Header("UserAgent")] string userAgent, [Body]SystemPropertyNameAndIntValueDto request, string Content_Type);

		/// <summary>
		/// Delete all discovery
		/// </summary>
		/// <remarks>
		/// Stops all the discoveries and removes them
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery")]
		System.Threading.Tasks.Task<TaskIdResult> DeleteAllDiscovery([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Delete discovery by Id
		/// </summary>
		/// <remarks>
		/// Stops the discovery for the given Discovery ID and removes it. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery/{id}")]
		System.Threading.Tasks.Task<TaskIdResult> DeleteDiscoveryById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Delete discovery by specified range
		/// </summary>
		/// <remarks>
		/// Stops discovery for the given range and removes them
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToDelete">Number of records to delete</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery/{startIndex}/{recordsToDelete}")]
		System.Threading.Tasks.Task<TaskIdResult> DeleteDiscoveryBySpecifiedRange([Header("UserAgent")] string userAgent, [AliasAs("startIndex")]int? startIndex, [AliasAs("recordsToDelete")]int? recordsToDelete);

		/// <summary>
		/// Delete global credentials by Id
		/// </summary>
		/// <remarks>
		/// Deletes global credential for the given ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="globalCredentialId">ID of global-credential</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/global-credential/{globalCredentialId}")]
		System.Threading.Tasks.Task<TaskIdResult> DeleteGlobalCredentialsById([Header("UserAgent")] string userAgent, [AliasAs("globalCredentialId")]string globalCredentialId);

		/// <summary>
		/// Get count of all discovery jobs
		/// </summary>
		/// <remarks>
		/// Returns the count of all available discovery jobs
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/discovery/count")]
		System.Threading.Tasks.Task<CountResult> GetCountOfAllDiscoveryJobs([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Get Credential sub type by credential Id
		/// </summary>
		/// <remarks>
		/// Returns the credential sub type for the given Id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Global Credential ID</param>
		/// <returns>Task of GlobalCredentialSubTypeResult</returns>
		[Get("/dna/intent/api/v1/global-credential/{id}")]
		System.Threading.Tasks.Task<GlobalCredentialSubTypeResult> GetCredentialSubTypeByCredentialId([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Get Devices discovered by Id
		/// </summary>
		/// <remarks>
		/// Returns the count of network devices discovered in the given discovery. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device/count")]
		System.Threading.Tasks.Task<CountResult> GetDevicesDiscoveredById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id, [AliasAs("taskId")]string taskId = null);

		/// <summary>
		/// Get Discovered devices by range
		/// </summary>
		/// <remarks>
		/// Returns the network devices discovered for the given discovery and for the given range. The maximum number of records that can be retrieved is 500. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of NetworkDeviceNIOListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device/{startIndex}/{recordsToReturn}")]
		System.Threading.Tasks.Task<NetworkDeviceNIOListResult> GetDiscoveredDevicesByRange([Header("UserAgent")] string userAgent, [AliasAs("id")]string id, [AliasAs("startIndex")]int? startIndex, [AliasAs("recordsToReturn")]int? recordsToReturn, [AliasAs("taskId")]string taskId = null);

		/// <summary>
		/// Get Discovered network devices by discovery Id
		/// </summary>
		/// <remarks>
		/// Returns the network devices discovered for the given Discovery ID. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of NetworkDeviceNIOListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device")]
		System.Threading.Tasks.Task<NetworkDeviceNIOListResult> GetDiscoveredNetworkDevicesByDiscoveryId([Header("UserAgent")] string userAgent, [AliasAs("id")]string id, [AliasAs("taskId")]string taskId = null);

		/// <summary>
		/// Get Discoveries by range
		/// </summary>
		/// <remarks>
		/// Returns the discovery by specified range
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <returns>Task of DiscoveryNIOListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{startIndex}/{recordsToReturn}")]
		System.Threading.Tasks.Task<DiscoveryNIOListResult> GetDiscoveriesByRange([Header("UserAgent")] string userAgent, [AliasAs("startIndex")]int? startIndex, [AliasAs("recordsToReturn")]int? recordsToReturn);

		/// <summary>
		/// Get Discovery by Id
		/// </summary>
		/// <remarks>
		/// Returns discovery by Discovery ID. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <returns>Task of DiscoveryNIOResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}")]
		System.Threading.Tasks.Task<DiscoveryNIOResult> GetDiscoveryById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Get Discovery jobs by IP
		/// </summary>
		/// <remarks>
		/// Returns the list of discovery jobs for the given IP
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ipAddress">ipAddress</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="name">name (optional)</param>
		/// <returns>Task of DiscoveryJobNIOListResult</returns>
		[Get("/dna/intent/api/v1/discovery/job")]
		System.Threading.Tasks.Task<DiscoveryJobNIOListResult> GetDiscoveryJobsByIP([Header("UserAgent")] string userAgent, [AliasAs("ipAddress")]string ipAddress, [AliasAs("offset")]int? offset = null, [AliasAs("limit")]int? limit = null, [AliasAs("name")]string name = null);

		/// <summary>
		/// Get Global credentials
		/// </summary>
		/// <remarks>
		/// Returns global credential for the given credential sub type
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="credentialSubType">Credential type as CLI / SNMPV2_READ_COMMUNITY / SNMPV2_WRITE_COMMUNITY / SNMPV3 / HTTP_WRITE / HTTP_READ / NETCONF</param>
		/// <param name="sortBy">sortBy (optional)</param>
		/// <param name="order">order (optional)</param>
		/// <returns>Task of GlobalCredentialListResult</returns>
		[Get("/dna/intent/api/v1/global-credential")]
		System.Threading.Tasks.Task<GlobalCredentialListResult> GetGlobalCredentials([Header("UserAgent")] string userAgent, [AliasAs("credentialSubType")]string credentialSubType, [AliasAs("sortBy")]string sortBy = null, [AliasAs("order")]string order = null);

		/// <summary>
		/// Get list of discoveries by discovery Id
		/// </summary>
		/// <remarks>
		/// Returns the list of discovery jobs for the given Discovery ID. The results can be optionally filtered based on IP. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="ipAddress">ipAddress (optional)</param>
		/// <returns>Task of DiscoveryJobNIOListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/job")]
		System.Threading.Tasks.Task<DiscoveryJobNIOListResult> GetListOfDiscoveriesByDiscoveryId([Header("UserAgent")] string userAgent, [AliasAs("id")]string id, [AliasAs("offset")]int? offset = null, [AliasAs("limit")]int? limit = null, [AliasAs("ipAddress")]string ipAddress = null);

		/// <summary>
		/// Get network devices from Discovery
		/// </summary>
		/// <remarks>
		/// Returns the network devices from a discovery job based on given filters. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Discovery ID</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <param name="sortBy">sortBy (optional)</param>
		/// <param name="sortOrder">sortOrder (optional)</param>
		/// <param name="ipAddress">ipAddress (optional)</param>
		/// <param name="pingStatus">pingStatus (optional)</param>
		/// <param name="snmpStatus">snmpStatus (optional)</param>
		/// <param name="cliStatus">cliStatus (optional)</param>
		/// <param name="netconfStatus">netconfStatus (optional)</param>
		/// <param name="httpStatus">httpStatus (optional)</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/summary")]
		System.Threading.Tasks.Task<CountResult> GetNetworkDevicesFromDiscovery([Header("UserAgent")] string userAgent, [AliasAs("id")]string id, [AliasAs("taskId")]string taskId = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("sortOrder")]string sortOrder = null, [AliasAs("ipAddress")]List<string> ipAddress = null, [AliasAs("pingStatus")]List<string> pingStatus = null, [AliasAs("snmpStatus")]List<string> snmpStatus = null, [AliasAs("cliStatus")]List<string> cliStatus = null, [AliasAs("netconfStatus")]List<string> netconfStatus = null, [AliasAs("httpStatus")]List<string> httpStatus = null);

		/// <summary>
		/// Get SNMP properties
		/// </summary>
		/// <remarks>
		/// Returns SNMP properties
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of SystemPropertyListResult</returns>
		[Get("/dna/intent/api/v1/snmp-property")]
		System.Threading.Tasks.Task<SystemPropertyListResult> GetSNMPProperties([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Start discovery
		/// </summary>
		/// <remarks>
		/// Initiates discovery with the given parameters
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/discovery")]
		System.Threading.Tasks.Task<TaskIdResult> StartDiscovery([Header("UserAgent")] string userAgent, [Body]InventoryRequest request, string Content_Type);

		/// <summary>
		/// Update CLI credentials
		/// </summary>
		/// <remarks>
		/// Updates global CLI credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/cli")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateCLICredentials([Header("UserAgent")] string userAgent, [Body]CLICredentialDto request, string Content_Type);

		/// <summary>
		/// Update global credentials
		/// </summary>
		/// <remarks>
		/// Update global credential for network devices in site(s)
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <param name="globalCredentialId">Global credential Uuid</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/{globalCredentialId}")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateGlobalCredentials([Header("UserAgent")] string userAgent, [Body]SitesInfoDto request, string Content_Type, [AliasAs("globalCredentialId")]string globalCredentialId);

		/// <summary>
		/// Update HTTP read credential
		/// </summary>
		/// <remarks>
		/// Updates global HTTP Read credential
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/http-read")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateHTTPReadCredential([Header("UserAgent")] string userAgent, [Body]HTTPReadCredentialDto request, string Content_Type);

		/// <summary>
		/// Update HTTP write credentials
		/// </summary>
		/// <remarks>
		/// Updates global HTTP write credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/http-write")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateHTTPWriteCredentials([Header("UserAgent")] string userAgent, [Body]HTTPWriteCredentialDto request, string Content_Type);

		/// <summary>
		/// Update Netconf credentials
		/// </summary>
		/// <remarks>
		/// Updates global netconf credentials
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/netconf")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateNetconfCredentials([Header("UserAgent")] string userAgent, [Body]NetconfCredentialDto request, string Content_Type);

		/// <summary>
		/// Update SNMP read community
		/// </summary>
		/// <remarks>
		/// Updates global SNMP read community
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv2-read-community")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateSNMPReadCommunity([Header("UserAgent")] string userAgent, [Body]SNMPvReadCommunityDto request, string Content_Type);

		/// <summary>
		/// Update SNMP write community
		/// </summary>
		/// <remarks>
		/// Updates global SNMP write community
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv2-write-community")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateSNMPWriteCommunity([Header("UserAgent")] string userAgent, [Body]SNMPvWriteCommunityDto request, string Content_Type);

		/// <summary>
		/// Update SNMPv3 credentials
		/// </summary>
		/// <remarks>
		/// Updates global SNMPv3 credential
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv3")]
		System.Threading.Tasks.Task<TaskIdResult> UpdateSNMPv3Credentials([Header("UserAgent")] string userAgent, [Body]SNMPvCredentialDto request, string Content_Type);

		/// <summary>
		/// Updates an existing discovery by specified Id
		/// </summary>
		/// <remarks>
		/// Stops or starts an existing discovery
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/discovery")]
		System.Threading.Tasks.Task<TaskIdResult> UpdatesAnExistingDiscoveryBySpecifiedId([Header("UserAgent")] string userAgent, [Body]DiscoveryNIO request, string Content_Type);
		#endregion Asynchronous Operations
	}
}
