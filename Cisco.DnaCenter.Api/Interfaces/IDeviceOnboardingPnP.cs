using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Collections.Generic;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDeviceOnboardingPnP
	{
		#region Asynchronous Operations

		/// <summary>
		/// Add a Workflow
		/// </summary>
		/// <remarks>
		/// Adds a PnP Workflow along with the relevant tasks in the workflow into the PnP database
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of AddAWorkflowResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-workflow")]
		System.Threading.Tasks.Task<AddAWorkflowResponse> AddAWorkflow([Header("UserAgent")] string userAgent, [Body]Workflow request, string Content_Type);

		/// <summary>
		/// Add Device
		/// </summary>
		/// <remarks>
		/// Adds a device to the PnP database.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of Device</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device")]
		System.Threading.Tasks.Task<Device> AddDeviceToPnpDatabase([Header("UserAgent")] string userAgent, [Body]Device request, string Content_Type);

		/// <summary>
		/// Add Virtual Account
		/// </summary>
		/// <remarks>
		/// Registers a Smart Account, Virtual Account and the relevant server profile info with the PnP System &amp; database. The devices present in the registered virtual account are synced with the PnP database as well. The response payload returns the new profile
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of AddVirtualAccountResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-settings/savacct")]
		System.Threading.Tasks.Task<AddVirtualAccountResponse> AddVirtualAccount([Header("UserAgent")] string userAgent, [Body]SAVAMapping request, string Content_Type);

		/// <summary>
		/// Claim a Device to a Site
		/// </summary>
		/// <remarks>
		/// Claim a device based on DNA-C Site based design process. Different parameters are required for different device platforms.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of SiteClaimResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/site-claim")]
		System.Threading.Tasks.Task<SiteClaimResponse> ClaimADeviceToASite([Header("UserAgent")] string userAgent, [Body]SiteProvisionRequest request, string Content_Type);

		/// <summary>
		/// Claim Device
		/// </summary>
		/// <remarks>
		/// Claims one of more devices with specified workflow
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of ClaimDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/claim")]
		System.Threading.Tasks.Task<ClaimDeviceResponse> ClaimDevice([Header("UserAgent")] string userAgent, [Body]ClaimDeviceRequest request, string Content_Type);

		/// <summary>
		/// Delete Device by Id from PnP
		/// </summary>
		/// <remarks>
		/// Deletes specified device from PnP database
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of DeleteDeviceByIdFromPnPResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		System.Threading.Tasks.Task<DeleteDeviceByIdFromPnPResponse> DeleteDeviceByIdFromPnP([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Delete Workflow By Id
		/// </summary>
		/// <remarks>
		/// Deletes a workflow specified by id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of DeleteWorkflowByIdResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		System.Threading.Tasks.Task<DeleteWorkflowByIdResponse> DeleteWorkflowById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Deregister Virtual Account
		/// </summary>
		/// <remarks>
		/// Deregisters the specified smart account &amp; virtual account info and the associated device information from the PnP System &amp; database. The devices associated with the deregistered virtual account are removed from the PnP database as well. The response payload contains the deregistered smart &amp; virtual account information
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="domain">Smart Account Domain</param>
		/// <param name="name">Virtual Account Name</param>
		/// <returns>Task of DeregisterVirtualAccountResponse</returns>
		[Delete("/dna/intent/api/v1/onboarding/pnp-settings/vacct")]
		System.Threading.Tasks.Task<DeregisterVirtualAccountResponse> DeregisterVirtualAccount([Header("UserAgent")] string userAgent, [AliasAs("domain")]string domain, [AliasAs("name")]string name);

		/// <summary>
		/// Get Device by Id
		/// </summary>
		/// <remarks>
		/// Returns device details specified by device id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of GetDeviceByIdResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		System.Threading.Tasks.Task<GetDeviceByIdResponse> GetDeviceById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Get Device History
		/// </summary>
		/// <remarks>
		/// Returns history for a specific device. Serial number is a required parameter
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serialNumber">Device Serial Number</param>
		/// <param name="sort">Comma seperated list of fields to sort on (optional)</param>
		/// <param name="sortOrder">Sort Order Ascending (asc) or Descending (des) (optional)</param>
		/// <returns>Task of GetDeviceHistoryResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/history")]
		System.Threading.Tasks.Task<GetDeviceHistoryResponse> GetDeviceHistory([Header("UserAgent")] string userAgent, [AliasAs("serialNumber")]string serialNumber, [AliasAs("sort")]List<string> sort = null, [AliasAs("sortOrder")]string sortOrder = null);

		/// <summary>
		/// Get PnP global settings
		/// </summary>
		/// <remarks>
		/// Returns global PnP settings of the user
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GetPnPGlobalSettingsResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings")]
		System.Threading.Tasks.Task<GetPnPGlobalSettingsResponse> GetPnPGlobalSettings([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Get Device Count
		/// </summary>
		/// <remarks>
		/// Returns the device count based on filter criteria. This is useful for pagination
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
		System.Threading.Tasks.Task<GetDeviceCountResponse> GetPnpDeviceCount([Header("UserAgent")] string userAgent, [AliasAs("serialNumber")]List<string> serialNumber = null, [AliasAs("state")]List<string> state = null, [AliasAs("onbState")]List<string> onbState = null, [AliasAs("cmState")]List<string> cmState = null, [AliasAs("name")]List<string> name = null, [AliasAs("pid")]List<string> pid = null, [AliasAs("source")]List<string> source = null, [AliasAs("projectId")]List<string> projectId = null, [AliasAs("workflowId")]List<string> workflowId = null, [AliasAs("projectName")]List<string> projectName = null, [AliasAs("workflowName")]List<string> workflowName = null, [AliasAs("smartAccountId")]List<string> smartAccountId = null, [AliasAs("virtualAccountId")]List<string> virtualAccountId = null, [AliasAs("lastContact")]bool? lastContact = null);

		/// <summary>
		/// Get Device list
		/// </summary>
		/// <remarks>
		/// Returns list of devices based on filter crieteria. If a limit is not specified, it will default to return 50 devices. Pagination and sorting are also supported by this endpoint
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
		/// <param name="workflowName">Device Workflow Name (optional)</param>
		/// <param name="smartAccountId">Device Smart Account (optional)</param>
		/// <param name="virtualAccountId">Device Virtual Account (optional)</param>
		/// <param name="lastContact">Device Has Contacted lastContact &gt; 0 (optional)</param>
		/// <returns>Task of Device</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device")]
		System.Threading.Tasks.Task<Device> GetPnpDeviceList([Header("UserAgent")] string userAgent, [AliasAs("limit")]int? limit = null, [AliasAs("offset")]int? offset = null, [AliasAs("sort")]List<string> sort = null, [AliasAs("sortOrder")]string sortOrder = null, [AliasAs("serialNumber")]List<string> serialNumber = null, [AliasAs("state")]List<string> state = null, [AliasAs("onbState")]List<string> onbState = null, [AliasAs("cmState")]List<string> cmState = null, [AliasAs("name")]List<string> name = null, [AliasAs("pid")]List<string> pid = null, [AliasAs("source")]List<string> source = null, [AliasAs("projectId")]List<string> projectId = null, [AliasAs("workflowId")]List<string> workflowId = null, [AliasAs("projectName")]List<string> projectName = null, [AliasAs("workflowName")]List<string> workflowName = null, [AliasAs("smartAccountId")]List<string> smartAccountId = null, [AliasAs("virtualAccountId")]List<string> virtualAccountId = null, [AliasAs("lastContact")]bool? lastContact = null);

		/// <summary>
		/// Get Smart Account List
		/// </summary>
		/// <remarks>
		/// Returns the list of Smart Account domains
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GetSmartAccountListResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings/sacct")]
		System.Threading.Tasks.Task<GetSmartAccountListResponse> GetSmartAccountList([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Get Sync Result for Virtual Account
		/// </summary>
		/// <remarks>
		/// Returns the summary of devices synced from the given smart account &amp; virtual account with PnP
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="domain">Smart Account Domain</param>
		/// <param name="name">Virtual Account Name</param>
		/// <returns>Task of GetSyncResultForVirtualAccountResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-device/sacct/{domain}/vacct/{name}/sync-result")]
		System.Threading.Tasks.Task<GetSyncResultForVirtualAccountResponse> GetSyncResultForVirtualAccount([Header("UserAgent")] string userAgent, [AliasAs("domain")]string domain, [AliasAs("name")]string name);

		/// <summary>
		/// Get Virtual Account List
		/// </summary>
		/// <remarks>
		/// Returns list of virtual accounts associated with the specified smart account
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="domain">Smart Account Domain</param>
		/// <returns>Task of GetVirtualAccountListResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-settings/sacct/{domain}/vacct")]
		System.Threading.Tasks.Task<GetVirtualAccountListResponse> GetVirtualAccountList([Header("UserAgent")] string userAgent, [AliasAs("domain")]string domain);

		/// <summary>
		/// Get Workflow by Id
		/// </summary>
		/// <remarks>
		/// Returns a workflow specified by id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of GetWorkflowByIdResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		System.Threading.Tasks.Task<GetWorkflowByIdResponse> GetWorkflowById([Header("UserAgent")] string userAgent, [AliasAs("id")]string id);

		/// <summary>
		/// Get Workflow Count
		/// </summary>
		/// <remarks>
		/// Returns the workflow count
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">Workflow Name (optional)</param>
		/// <returns>Task of GetWorkflowCountResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow/count")]
		System.Threading.Tasks.Task<GetWorkflowCountResponse> GetWorkflowCount([Header("UserAgent")] string userAgent, [AliasAs("name")]List<string> name = null);

		/// <summary>
		/// Get Workflows
		/// </summary>
		/// <remarks>
		/// Returns the list of workflows based on filter criteria. If a limit is not specified, it will default to return 50 workflows. Pagination and sorting are also supported by this endpoint
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="limit">Limits number of results (optional)</param>
		/// <param name="offset">Index of first result (optional)</param>
		/// <param name="sort">Comma seperated lost of fields to sort on (optional)</param>
		/// <param name="sortOrder">Sort Order Ascending (asc) or Descending (des) (optional)</param>
		/// <param name="type">Workflow Type (optional)</param>
		/// <param name="name">Workflow Name (optional)</param>
		/// <returns>Task of GetWorkflowsResponse</returns>
		[Get("/dna/intent/api/v1/onboarding/pnp-workflow")]
		System.Threading.Tasks.Task<GetWorkflowsResponse> GetWorkflows([Header("UserAgent")] string userAgent, [AliasAs("limit")]int? limit = null, [AliasAs("offset")]int? offset = null, [AliasAs("sort")]List<string> sort = null, [AliasAs("sortOrder")]string sortOrder = null, [AliasAs("type")]List<string> type = null, [AliasAs("name")]List<string> name = null);

		/// <summary>
		/// Import Devices in bulk
		/// </summary>
		/// <remarks>
		/// Add devices to PnP in bulk
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of ImportDevicesInBulkResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/import")]
		System.Threading.Tasks.Task<ImportDevicesInBulkResponse> ImportDevicesInBulk([Header("UserAgent")] string userAgent, [Body]Device request, string Content_Type);

		/// <summary>
		/// Preview Config
		/// </summary>
		/// <remarks>
		/// Triggers a preview for site-based Day 0 Configuration
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of DayZeroConfigPreviewResult</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/site-config-preview")]
		System.Threading.Tasks.Task<DayZeroConfigPreviewResult> PreviewConfig([Header("UserAgent")] string userAgent, [Body]SiteProvisionRequest request, string Content_Type);

		/// <summary>
		/// Reset Device
		/// </summary>
		/// <remarks>
		/// Recovers a device from a Workflow Execution Error state
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of ResetDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/reset")]
		System.Threading.Tasks.Task<ResetDeviceResponse> ResetDevice([Header("UserAgent")] string userAgent, [Body]ResetRequest request, string Content_Type);

		/// <summary>
		/// Sync Virtual Account Devices
		/// </summary>
		/// <remarks>
		/// Synchronizes the device info from the given smart account &amp; virtual account with the PnP database. The response payload returns a list of synced devices
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of SyncVirtualAccountDevicesResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/vacct-sync")]
		System.Threading.Tasks.Task<SyncVirtualAccountDevicesResponse> SyncVirtualAccountDevices([Header("UserAgent")] string userAgent, [Body]SAVAMapping request, string Content_Type);

		/// <summary>
		/// Un-Claim Device
		/// </summary>
		/// <remarks>
		/// Un-Claims one of more devices with specified workflow
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of UnClaimDeviceResponse</returns>
		[Post("/dna/intent/api/v1/onboarding/pnp-device/unclaim")]
		System.Threading.Tasks.Task<UnClaimDeviceResponse> UnClaimDevice([Header("UserAgent")] string userAgent, [Body]UnclaimRequest request, string Content_Type);

		/// <summary>
		/// Update Device
		/// </summary>
		/// <remarks>
		/// Updates device details specified by device id in PnP database
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <param name="id">id</param>
		/// <returns>Task of UpdateDeviceResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-device/{id}")]
		System.Threading.Tasks.Task<UpdateDeviceResponse> UpdateDevice([Header("UserAgent")] string userAgent, [Body]Device request, string Content_Type, [AliasAs("id")]string id);

		/// <summary>
		/// Update PnP global settings
		/// </summary>
		/// <remarks>
		/// Updates the user&#39;s list of global PnP settings
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of UpdatePnPGlobalSettingsResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-settings")]
		System.Threading.Tasks.Task<UpdatePnPGlobalSettingsResponse> UpdatePnPGlobalSettings([Header("UserAgent")] string userAgent, [Body]Settings request, string Content_Type);

		/// <summary>
		/// Update PnP Server Profile
		/// </summary>
		/// <remarks>
		/// Updates the PnP Server profile in a registered Virtual Account in the PnP database. The response payload returns the updated smart &amp; virtual account info
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of UpdatePnPServerProfileResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-settings/savacct")]
		System.Threading.Tasks.Task<UpdatePnPServerProfileResponse> UpdatePnPServerProfile([Header("UserAgent")] string userAgent, [Body]SAVAMapping request, string Content_Type);

		/// <summary>
		/// Update Workflow
		/// </summary>
		/// <remarks>
		/// Updates an existing workflow
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <param name="id">id</param>
		/// <returns>Task of UpdateWorkflowResponse</returns>
		[Put("/dna/intent/api/v1/onboarding/pnp-workflow/{id}")]
		System.Threading.Tasks.Task<UpdateWorkflowResponse> UpdateWorkflow([Header("UserAgent")] string userAgent, [Body]Workflow request, string Content_Type, [AliasAs("id")]string id);
		#endregion Asynchronous Operations
	}
}
