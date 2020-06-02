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
	public interface IDeviceOnboardingPnp
	{
		/// <summary>
		/// Add a Workflow
		/// </summary>
		/// <remarks>
		/// Adds a Pnp Workflow along with the relevant tasks in the workflow into the Pnp database
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddAWorkflowResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-workflow")]
		Task<AddWorkflowResponse> AddWorkflowAsync(
			[Body] Workflow request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Add Device
		/// </summary>
		/// <remarks>
		/// Adds a device to the Pnp database.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of Device</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device")]
		Task<Device> AddDeviceToPnpDatabaseAsync(
			[Body] List<DeviceDeviceInfo> request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Add Virtual Account
		/// </summary>
		/// <remarks>
		/// Registers a Smart Account, Virtual Account and the relevant server profile info with the Pnp System &amp; database. The devices present in the registered virtual account are synced with the Pnp database as well. The response payload returns the new profile
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddVirtualAccountResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-settings/savacct")]
		Task<AddVirtualAccountResponse> AddVirtualAccountAsync(
			[Body] SavaMapping request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Claim a Device to a Site
		/// </summary>
		/// <remarks>
		/// Claim a device based on DNA-C Site based design process. Different parameters are required for different device platforms.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of SiteClaimResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/site-claim")]
		Task<SiteClaimResponse> ClaimDeviceToSiteAsync(
			[Body] SiteProvisionRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Claim Device
		/// </summary>
		/// <remarks>
		/// Claims one of more devices with specified workflow
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of ClaimDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/claim")]
		Task<ClaimDeviceResponse> ClaimDeviceAsync(
			[Body] ClaimDeviceRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Device by Id from Pnp
		/// </summary>
		/// <remarks>
		/// Deletes specified device from Pnp database
		/// </remarks>
		/// <param name="id">id</param>
		/// <returns>Task of DeleteDeviceByIdFromPnpResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		Task<DeleteDeviceByIdFromPnpResponse> DeleteDeviceByIdFromPnpAysnc(
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Workflow By Id
		/// </summary>
		/// <remarks>
		/// Deletes a workflow specified by id
		/// </remarks>
		/// <param name="id">id</param>
		/// <returns>Task of DeleteWorkflowByIdResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		Task<DeleteWorkflowByIdResponse> DeleteWorkflowByIdAsync(
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Deregister Virtual Account
		/// </summary>
		/// <remarks>
		/// Deregisters the specified smart account &amp; virtual account info and the associated device information from the Pnp System &amp; database. The devices associated with the deregistered virtual account are removed from the Pnp database as well. The response payload contains the deregistered smart &amp; virtual account information
		/// </remarks>
		/// <param name="domain">Smart Account Domain</param>
		/// <param name="name">Virtual Account Name</param>
		/// <returns>Task of DeregisterVirtualAccountResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-settings/vacct")]
		Task<DeregisterVirtualAccountResponse> DeregisterVirtualAccountAsync(
			[AliasAs("domain")] string domain,
			[AliasAs("name")] string name,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Device by Id
		/// </summary>
		/// <remarks>
		/// Returns device details specified by device id
		/// </remarks>
		/// <param name="id">id</param>
		/// <returns>Task of GetDeviceByIdResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		Task<GetDeviceByIdResponse> GetDeviceAsync(
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Device History
		/// </summary>
		/// <remarks>
		/// Returns history for a specific device. Serial number is a required parameter
		/// </remarks>
		/// <param name="serialNumber">Device Serial Number</param>
		/// <param name="sort">Comma seperated list of fields to sort on (optional)</param>
		/// <param name="sortOrder">Sort Order Ascending (asc) or Descending (des) (optional)</param>
		/// <returns>Task of GetDeviceHistoryResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/history")]
		Task<GetDeviceHistoryResponse> GetDeviceHistoryAsync(
			[AliasAs("serialNumber")] string serialNumber,
			[AliasAs("sort")] List<string> sort = null,
			[AliasAs("sortOrder")] string sortOrder = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Pnp global settings
		/// </summary>
		/// <remarks>
		/// Returns global Pnp settings of the user
		/// </remarks>
		/// <returns>Task of GetPnpGlobalSettingsResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings")]
		Task<GetPnpGlobalSettingsResponse> GetPnpGlobalSettingsAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Device Count
		/// </summary>
		/// <remarks>
		/// Returns the device count based on filter criteria. This is useful for pagination
		/// </remarks>
		/// <param name="serialNumber">Device Serial Number (optional)</param>
		/// <param name="state">Device State (optional)</param>
		/// <param name="onbState">Device Onboarding State (optional)</param>
		/// <param name="cmState">Device Connection Manager State (optional)</param>
		/// <param name="name">Device Name (optional)</param>
		/// <param name="pid">Device ProductId (optional)</param>
		/// <param name="source">Device Source (optional)</param>
		/// <param name="projectId">Device Project Id (optional)</param>
		/// <param name="workflowId">Device Workflow Id (optional)</param>
		/// <param name="projectName">Device Project Name (optional)</param>
		/// <param name="workflowName">Device Workflow Name (optional)</param>
		/// <param name="smartAccountId">Device Smart Account (optional)</param>
		/// <param name="virtualAccountId">Device Virtual Account (optional)</param>
		/// <param name="lastContact">Device Has Contacted lastContact &gt; 0 (optional)</param>
		/// <returns>Task of GetDeviceCountResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/count")]
		Task<GetDeviceCountResponse> GetPnpDeviceCountAsync(
			[AliasAs("serialNumber")] List<string> serialNumber = null,
			[AliasAs("state")] List<string> state = null,
			[AliasAs("onbState")] List<string> onbState = null,
			[AliasAs("cmState")] List<string> cmState = null,
			[AliasAs("name")] List<string> name = null,
			[AliasAs("pid")] List<string> pid = null,
			[AliasAs("source")] List<string> source = null,
			[AliasAs("projectId")] List<string> projectId = null,
			[AliasAs("workflowId")] List<string> workflowId = null,
			[AliasAs("projectName")] List<string> projectName = null,
			[AliasAs("workflowName")] List<string> workflowName = null,
			[AliasAs("smartAccountId")] List<string> smartAccountId = null,
			[AliasAs("virtualAccountId")] List<string> virtualAccountId = null,
			[AliasAs("lastContact")] bool? lastContact = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Device list
		/// </summary>
		/// <remarks>
		/// Returns list of devices based on filter crieteria. If a limit is not specified, it will default to return 50 devices. Pagination and sorting are also supported by this endpoint
		/// </remarks>
		/// <param name="limit">Limits number of results (optional)</param>
		/// <param name="offset">Index of first result (optional)</param>
		/// <param name="sort">Comma seperated list of fields to sort on (optional)</param>
		/// <param name="sortOrder">Sort Order Ascending (asc) or Descending (des) (optional)</param>
		/// <param name="serialNumber">Device Serial Number (optional)</param>
		/// <param name="state">Device State (optional)</param>
		/// <param name="onbState">Device Onboarding State (optional)</param>
		/// <param name="cmState">Device Connection Manager State (optional)</param>
		/// <param name="name">Device Name (optional)</param>
		/// <param name="pid">Device ProductId (optional)</param>
		/// <param name="source">Device Source (optional)</param>
		/// <param name="projectId">Device Project Id (optional)</param>
		/// <param name="workflowId">Device Workflow Id (optional)</param>
		/// <param name="projectName">Device Project Name (optional)</param>
		/// <param name="siteName">Device Site Name (optional)</param>
		/// <param name="workflowName">Device Workflow Name (optional)</param>
		/// <param name="smartAccountId">Device Smart Account (optional)</param>
		/// <param name="virtualAccountId">Device Virtual Account (optional)</param>
		/// <param name="lastContact">Device Has Contacted lastContact &gt; 0 (optional)</param>
		/// <returns>Task of Device</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device")]
		Task<Device> GetPnpDeviceListAsync(
			[AliasAs("limit")] int? limit = null,
			[AliasAs("offset")] int? offset = null,
			[AliasAs("sort")] List<string> sort = null,
			[AliasAs("sortOrder")] string sortOrder = null,
			[AliasAs("serialNumber")] List<string> serialNumber = null,
			[AliasAs("state")] List<string> state = null,
			[AliasAs("onbState")] List<string> onbState = null,
			[AliasAs("cmState")] List<string> cmState = null,
			[AliasAs("name")] List<string> name = null,
			[AliasAs("pid")] List<string> pid = null,
			[AliasAs("source")] List<string> source = null,
			[AliasAs("projectId")] List<string> projectId = null,
			[AliasAs("workflowId")] List<string> workflowId = null,
			[AliasAs("projectName")] List<string> projectName = null,
			[AliasAs("siteName")] List<string> SiteName = null,
			[AliasAs("workflowName")] List<string> workflowName = null,
			[AliasAs("smartAccountId")] List<string> smartAccountId = null,
			[AliasAs("virtualAccountId")] List<string> virtualAccountId = null,
			[AliasAs("lastContact")] bool? lastContact = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Smart Account List
		/// </summary>
		/// <remarks>
		/// Returns the list of Smart Account domains
		/// </remarks>
		/// <returns>Task of GetSmartAccountListResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings/sacct")]
		Task<GetSmartAccountListResponse> GetSmartAccountListAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Sync Result for Virtual Account
		/// </summary>
		/// <remarks>
		/// Returns the summary of devices synced from the given smart account &amp; virtual account with Pnp
		/// </remarks>
		/// <param name="domain">Smart Account Domain</param>
		/// <param name="name">Virtual Account Name</param>
		/// <returns>Task of GetSyncResultForVirtualAccountResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/sacct/{domain}/vacct/{name}/sync-result")]
		Task<GetSyncResultForVirtualAccountResponse> GetSyncResultForVirtualAccountAsync(
			[AliasAs("domain")] string domain,
			[AliasAs("name")] string name,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Virtual Account List
		/// </summary>
		/// <remarks>
		/// Returns list of virtual accounts associated with the specified smart account
		/// </remarks>
		/// <param name="domain">Smart Account Domain</param>
		/// <returns>Task of GetVirtualAccountListResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings/sacct/{domain}/vacct")]
		Task<GetVirtualAccountListResponse> GetVirtualAccountListAsync(
			[AliasAs("domain")] string domain,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Workflow by Id
		/// </summary>
		/// <remarks>
		/// Returns a workflow specified by id
		/// </remarks>
		/// <param name="id">id</param>
		/// <returns>Task of GetWorkflowByIdResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		Task<GetWorkflowByIdResponse> GetWorkflowByIdAsync(
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Workflow Count
		/// </summary>
		/// <remarks>
		/// Returns the workflow count
		/// </remarks>
		/// <param name="name">Workflow Name (optional)</param>
		/// <returns>Task of GetWorkflowCountResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow/count")]
		Task<GetWorkflowCountResponse> GetWorkflowCountAsync(
			[AliasAs("name")] List<string> name = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Workflows
		/// </summary>
		/// <remarks>
		/// Returns the list of workflows based on filter criteria. If a limit is not specified, it will default to return 50 workflows. Pagination and sorting are also supported by this endpoint
		/// </remarks>
		/// <param name="limit">Limits number of results (optional)</param>
		/// <param name="offset">Index of first result (optional)</param>
		/// <param name="sort">Comma seperated lost of fields to sort on (optional)</param>
		/// <param name="sortOrder">Sort Order Ascending (asc) or Descending (des) (optional)</param>
		/// <param name="type">Workflow Type (optional)</param>
		/// <param name="name">Workflow Name (optional)</param>
		/// <returns>Task of GetWorkflowsResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow")]
		Task<GetWorkflowsResponse> GetWorkflowsAsync(
			[AliasAs("limit")] int? limit = null,
			[AliasAs("offset")] int? offset = null,
			[AliasAs("sort")] List<string> sort = null,
			[AliasAs("sortOrder")] string sortOrder = null,
			[AliasAs("type")] List<string> type = null,
			[AliasAs("name")] List<string> name = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Import Devices in bulk
		/// </summary>
		/// <remarks>
		/// Add devices to Pnp in bulk
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of ImportDevicesInBulkResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/import")]
		Task<ImportDevicesInBulkResponse> ImportDevicesInBulkAsync(
			[Body] ClaimDeviceRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Preview Config
		/// </summary>
		/// <remarks>
		/// Triggers a preview for site-based Day 0 Configuration
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of DayZeroConfigPreviewResult</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/site-config-preview")]
		Task<DayZeroConfigPreviewResult> PreviewConfigAsync(
			[Body] SiteProvisionRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Reset Device
		/// </summary>
		/// <remarks>
		/// Recovers a device from a Workflow Execution Error state
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of ResetDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/reset")]
		Task<ResetDeviceResponse> ResetDeviceAsync(
			[Body] ResetRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Sync Virtual Account Devices
		/// </summary>
		/// <remarks>
		/// Synchronizes the device info from the given smart account &amp; virtual account with the Pnp database. The response payload returns a list of synced devices
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of SyncVirtualAccountDevicesResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/vacct-sync")]
		Task<SyncVirtualAccountDevicesResponse> SyncVirtualAccountDevicesAsync(
			[Body] SavaMapping request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Un-Claim Device
		/// </summary>
		/// <remarks>
		/// Un-Claims one of more devices with specified workflow
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UnClaimDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/unclaim")]
		Task<UnClaimDeviceResponse> UnClaimDeviceAsync(
			[Body] UnclaimRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Device
		/// </summary>
		/// <remarks>
		/// Updates device details specified by device id in Pnp database
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="id">id</param>
		/// <returns>Task of UpdateDeviceResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		Task<UpdateDeviceResponse> UpdateDeviceAsync(
			[Body] Device request,
			string Content_Type,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Pnp global settings
		/// </summary>
		/// <remarks>
		/// Updates the user&#39;s list of global Pnp settings
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdatePnpGlobalSettingsResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-settings")]
		Task<UpdatePnpGlobalSettingsResponse> UpdatePnpGlobalSettingsAsync(
			[Body] Settings request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Pnp Server Profile
		/// </summary>
		/// <remarks>
		/// Updates the Pnp Server profile in a registered Virtual Account in the Pnp database. The response payload returns the updated smart &amp; virtual account info
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdatePnpServerProfileResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-settings/savacct")]
		Task<UpdatePnpServerProfileResponse> UpdatePnpServerProfileAsync(
			[Body] SavaMapping request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Workflow
		/// </summary>
		/// <remarks>
		/// Updates an existing workflow
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="id">id</param>
		/// <returns>Task of UpdateWorkflowResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		Task<UpdateWorkflowResponse> UpdateWorkflowAsync(
			[Body] Workflow request,
			string Content_Type,
			[AliasAs("id")] string id,
			CancellationToken cancellationToken = default);
	}
}
