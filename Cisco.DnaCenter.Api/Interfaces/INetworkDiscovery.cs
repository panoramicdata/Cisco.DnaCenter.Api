using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkDiscovery
	{
		/// <summary>
		/// Create CLI credentials
		/// </summary>
		/// <remarks>
		/// Adds global CLI credential
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/cli")]
		Task<TaskIdResult> CreateCliCredentialsAsync(
			[Body]CliCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create HTTP read credentials
		/// </summary>
		/// <remarks>
		/// Adds HTTP read credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/http-read")]
		Task<TaskIdResult> CreateHttpReadCredentialsAsync(
			[Body]HttpReadCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create HTTP write credentials
		/// </summary>
		/// <remarks>
		/// Adds global HTTP write credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/http-write")]
		Task<TaskIdResult> CreateHttpWriteCredentialsAsync(
			[Body]HttpWriteCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Netconf credentials
		/// </summary>
		/// <remarks>
		/// Adds global netconf credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/netconf")]
		Task<TaskIdResult> CreateNetconfCredentialsAsync(
			[Body]NetconfCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create SNMP read community
		/// </summary>
		/// <remarks>
		/// Adds global SNMP read community
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv2-read-community")]
		Task<TaskIdResult> CreateSnmpV2ReadCommunityAsync(
			[Body]SnmpV2ReadCommunityDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create SNMP write community
		/// </summary>
		/// <remarks>
		/// Adds global SNMP write community
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv2-write-community")]
		Task<TaskIdResult> CreateSnmpV2WriteCommunityAsync([Body]SnmpV2WriteCommunityDto request);

		/// <summary>
		/// Create SNMPv3 credentials
		/// </summary>
		/// <remarks>
		/// Adds global SNMPv3 credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/global-credential/snmpv3")]
		Task<TaskIdResult> CreateSnmpv3CredentialsAsync([Body]Snmpv3CredentialDto request);

		/// <summary>
		/// Create/Update SNMP properties
		/// </summary>
		/// <remarks>
		/// Adds SNMP properties
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/snmp-property")]
		Task<TaskIdResult> CreateUpdateSnmpPropertiesAsync([Body]SystemPropertyNameAndIntValueDto request);

		/// <summary>
		/// Delete all discovery
		/// </summary>
		/// <remarks>
		/// Stops all the discoveries and removes them
		/// </remarks>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery")]
		Task<TaskIdResult> DeleteAllDiscoveryAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete discovery by Id
		/// </summary>
		/// <remarks>
		/// Stops the discovery for the given Discovery ID and removes it. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery/{id}")]
		Task<TaskIdResult> DeleteDiscoveryByIdAsync(
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete discovery by specified range
		/// </summary>
		/// <remarks>
		/// Stops discovery for the given range and removes them
		/// </remarks>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToDelete">Number of records to delete</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/discovery/{startIndex}/{recordsToDelete}")]
		Task<TaskIdResult> DeleteDiscoveryBySpecifiedRangeAsync(
			[AliasAs("startIndex")]int? startIndex,
			[AliasAs("recordsToDelete")]int? recordsToDelete,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete global credentials by Id
		/// </summary>
		/// <remarks>
		/// Deletes global credential for the given ID
		/// </remarks>
		/// <param name="globalCredentialId">ID of global-credential</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/global-credential/{globalCredentialId}")]
		Task<TaskIdResult> DeleteGlobalCredentialsByIdAsync(
			[AliasAs("globalCredentialId")]string globalCredentialId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get count of all discovery jobs
		/// </summary>
		/// <remarks>
		/// Returns the count of all available discovery jobs
		/// </remarks>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/discovery/count")]
		Task<CountResult> GetDiscoveryJobCountAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Credential sub type by credential Id
		/// </summary>
		/// <remarks>
		/// Returns the credential sub type for the given Id
		/// </remarks>
		/// <param name="id">Global Credential ID</param>
		/// <returns>Task of GlobalCredentialSubTypeResult</returns>
		[Get("/dna/intent/api/v1/global-credential/{id}")]
		Task<GlobalCredentialSubTypeResult> GetCredentialSubTypeByCredentialIdAsync(
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Devices discovered by Id
		/// </summary>
		/// <remarks>
		/// Returns the count of network devices discovered in the given discovery. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device/count")]
		Task<CountResult> GetDevicesDiscoveredByIdAsync(
			[AliasAs("id")]string id,
			[AliasAs("taskId")]string taskId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Discovered devices by range
		/// </summary>
		/// <remarks>
		/// Returns the network devices discovered for the given discovery and for the given range. The maximum number of records that can be retrieved is 500. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of NetworkDeviceNioListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device/{startIndex}/{recordsToReturn}")]
		Task<NetworkDeviceNioListResult> GetDiscoveredDevicesByRangeAsync(
			[AliasAs("id")]string id,
			[AliasAs("startIndex")]int? startIndex,
			[AliasAs("recordsToReturn")]int? recordsToReturn,
			[AliasAs("taskId")]string taskId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Discovered network devices by discovery Id
		/// </summary>
		/// <remarks>
		/// Returns the network devices discovered for the given Discovery ID. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <param name="taskId">taskId (optional)</param>
		/// <returns>Task of NetworkDeviceNioListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/network-device")]
		Task<NetworkDeviceNioListResult> GetDiscoveredNetworkDevicesByDiscoveryIdAsync(
			[AliasAs("id")]string id,
			[AliasAs("taskId")]string taskId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Discoveries by range
		/// </summary>
		/// <remarks>
		/// Returns the discovery by specified range
		/// </remarks>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <returns>Task of DiscoveryNioListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{startIndex}/{recordsToReturn}")]
		Task<DiscoveryNioListResult> GetDiscoveriesByRangeAsync(
			[AliasAs("startIndex")]int? startIndex,
			[AliasAs("recordsToReturn")]int? recordsToReturn,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Discovery by Id
		/// </summary>
		/// <remarks>
		/// Returns discovery by Discovery ID. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <returns>Task of DiscoveryNioResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}")]
		Task<DiscoveryNioResult> GetDiscoveryByIdAsync(
			[AliasAs("id")]string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Discovery jobs by IP
		/// </summary>
		/// <remarks>
		/// Returns the list of discovery jobs for the given IP
		/// </remarks>
		/// <param name="ipAddress">ipAddress</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="name">name (optional)</param>
		/// <returns>Task of DiscoveryJobNioListResult</returns>
		[Get("/dna/intent/api/v1/discovery/job")]
		Task<DiscoveryJobNioListResult> GetDiscoveryJobsByIpAsync(
			[AliasAs("ipAddress")]string ipAddress,
			[AliasAs("offset")]int? offset = null,
			[AliasAs("limit")]int? limit = null,
			[AliasAs("name")]string name = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Global credentials
		/// </summary>
		/// <remarks>
		/// Returns global credential for the given credential sub type
		/// </remarks>
		/// <param name="credentialSubType">Credential type as CLI / SNMPV2_READ_COMMUNITY / SNMPV2_WRITE_COMMUNITY / SNMPV3 / HTTP_WRITE / HTTP_READ / NETCONF</param>
		/// <param name="sortBy">sortBy (optional)</param>
		/// <param name="order">order (optional)</param>
		/// <returns>Task of GlobalCredentialListResult</returns>
		[Get("/dna/intent/api/v1/global-credential")]
		Task<GlobalCredentialListResult> GetGlobalCredentialsAsync(
			[AliasAs("credentialSubType")]string credentialSubType,
			[AliasAs("sortBy")]string sortBy = null,
			[AliasAs("order")]string order = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get list of discoveries by discovery Id
		/// </summary>
		/// <remarks>
		/// Returns the list of discovery jobs for the given Discovery ID. The results can be optionally filtered based on IP. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
		/// <param name="id">Discovery ID</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="ipAddress">ipAddress (optional)</param>
		/// <returns>Task of DiscoveryJobNioListResult</returns>
		[Get("/dna/intent/api/v1/discovery/{id}/job")]
		Task<DiscoveryJobNioListResult> GetListOfDiscoveriesByDiscoveryIdAsync(
			[AliasAs("id")]string id,
			[AliasAs("offset")]int? offset = null,
			[AliasAs("limit")]int? limit = null,
			[AliasAs("ipAddress")]string ipAddress = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get network devices from Discovery
		/// </summary>
		/// <remarks>
		/// Returns the network devices from a discovery job based on given filters. Discovery ID can be obtained using the \&quot;Get Discoveries by range\&quot; API.
		/// </remarks>
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
		Task<CountResult> GetNetworkDevicesFromDiscoveryAsync(
			[AliasAs("id")]string id,
			[AliasAs("taskId")]string taskId = null,
			[AliasAs("sortBy")]string sortBy = null,
			[AliasAs("sortOrder")]string sortOrder = null,
			[AliasAs("ipAddress")]List<string> ipAddress = null,
			[AliasAs("pingStatus")]List<string> pingStatus = null,
			[AliasAs("snmpStatus")]List<string> snmpStatus = null,
			[AliasAs("cliStatus")]List<string> cliStatus = null,
			[AliasAs("netconfStatus")]List<string> netconfStatus = null,
			[AliasAs("httpStatus")]List<string> httpStatus = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get SNMP properties
		/// </summary>
		/// <remarks>
		/// Returns SNMP properties
		/// </remarks>
		/// <returns>Task of SystemPropertyListResult</returns>
		[Get("/dna/intent/api/v1/snmp-property")]
		Task<SystemPropertyListResult> GetSnmpPropertiesAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Start discovery
		/// </summary>
		/// <remarks>
		/// Initiates discovery with the given parameters
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/discovery")]
		Task<TaskIdResult> StartDiscoveryAsync(
			[Body]InventoryRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update CLI credentials
		/// </summary>
		/// <remarks>
		/// Updates global CLI credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/cli")]
		Task<TaskIdResult> UpdateCliCredentialsAsync(
			[Body]CliCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update global credentials
		/// </summary>
		/// <remarks>
		/// Update global credential for network devices in site(s)
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="globalCredentialId">Global credential Uuid</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/{globalCredentialId}")]
		Task<TaskIdResult> UpdateGlobalCredentialsAsync(
			[Body]SitesInfoDto request,
			string Content_Type,
			[AliasAs("globalCredentialId")]string globalCredentialId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update HTTP read credential
		/// </summary>
		/// <remarks>
		/// Updates global HTTP Read credential
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/http-read")]
		Task<TaskIdResult> UpdateHttpReadCredentialAsync(
			[Body]HttpReadCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update HTTP write credentials
		/// </summary>
		/// <remarks>
		/// Updates global HTTP write credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/http-write")]
		Task<TaskIdResult> UpdateHttpWriteCredentialsAsync(
			[Body]HttpWriteCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Netconf credentials
		/// </summary>
		/// <remarks>
		/// Updates global netconf credentials
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/netconf")]
		Task<TaskIdResult> UpdateNetconfCredentialsAsync(
			[Body]NetconfCredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update SNMP read community
		/// </summary>
		/// <remarks>
		/// Updates global SNMP read community
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv2-read-community")]
		Task<TaskIdResult> UpdateSnmpReadCommunityAsync(
			[Body]SnmpV2ReadCommunityDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update SNMP write community
		/// </summary>
		/// <remarks>
		/// Updates global SNMP write community
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv2-write-community")]
		Task<TaskIdResult> UpdateSnmpWriteCommunityAsync(
			[Body]SnmpV2WriteCommunityDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update SNMPv3 credentials
		/// </summary>
		/// <remarks>
		/// Updates global SNMPv3 credential
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/global-credential/snmpv3")]
		Task<TaskIdResult> UpdateSnmpv3CredentialsAsync(
			[Body]Snmpv3CredentialDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Updates an existing discovery by specified Id
		/// </summary>
		/// <remarks>
		/// Stops or starts an existing discovery
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/discovery")]
		Task<TaskIdResult> UpdatesAnExistingDiscoveryBySpecifiedIdAsync(
			[Body]DiscoveryNio request,
			CancellationToken cancellationToken = default);
	}
}
