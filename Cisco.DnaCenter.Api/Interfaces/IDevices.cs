using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDevices
	{
		/// <summary>
		/// Add Device
		/// </summary>
		/// <remarks>
		/// Adds the device with given credential
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/network-device")]
		Task<TaskIdResult> AddDevice([Body]InventoryDeviceInfo request);

		/// <summary>
		/// Delete Device by Id
		/// </summary>
		/// <remarks>
		/// Deletes the network device for the given Id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Device ID</param>
		/// <param name="isForceDelete">isForceDelete (optional)</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/network-device/{id}")]
		Task<TaskIdResult> DeleteDeviceById([AliasAs("id")]string id, [AliasAs("isForceDelete")]bool? isForceDelete = null);

		/// <summary>
		/// Export Device list
		/// </summary>
		/// <remarks>
		/// Exports the selected network device to a file
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/network-device/file")]
		Task<TaskIdResult> ExportDeviceList([Body]ExportDeviceDto request);

		/// <summary>
		/// Get all interfaces
		/// </summary>
		/// <remarks>
		/// Returns all available interfaces. This endpoint can return a maximum of 500 interfaces
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface")]
		Task<DeviceIfListResult> GetAllInterfaces([AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null);

		/// <summary>
		/// Get Device by ID
		/// </summary>
		/// <remarks>
		/// Returns the network device details for the given device ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Device ID</param>
		/// <returns>Task of NetworkDeviceResult</returns>
		[Get("/dna/intent/api/v1/network-device/{id}")]
		Task<NetworkDeviceResult> GetDeviceByID([AliasAs("id")]string id);

		/// <summary>
		/// Get Device by Serial number
		/// </summary>
		/// <remarks>
		/// Returns the network device with given serial number
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serialNumber">Device serial number</param>
		/// <returns>Task of NetworkDeviceResult</returns>
		[Get("/dna/intent/api/v1/network-device/serial-number/{serialNumber}")]
		Task<NetworkDeviceResult> GetDeviceBySerialNumber([AliasAs("serialNumber")]string serialNumber);

		/// <summary>
		/// Get Device Config by Id
		/// </summary>
		/// <remarks>
		/// Returns the device config by specified device ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkDeviceId">networkDeviceId</param>
		/// <returns>Task of SuccessResult</returns>
		[Get("/dna/intent/api/v1/network-device/{networkDeviceId}/config")]
		Task<SuccessResult> GetDeviceConfigById([AliasAs("networkDeviceId")]string networkDeviceId);

		/// <summary>
		/// Get Device Config Count
		/// </summary>
		/// <remarks>
		/// Returns the count of device configs
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/network-device/config/count")]
		Task<CountResult> GetDeviceConfigCount();

		/// <summary>
		/// Get Device Config for all devices
		/// </summary>
		/// <remarks>
		/// Returns the config for all devices
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of RawCliInfoNIOListResult</returns>
		[Get("/dna/intent/api/v1/network-device/config")]
		Task<RawCliInfoNIOListResult> GetDeviceConfigForAllDevices();

		/// <summary>
		/// Get Device Count
		/// </summary>
		/// <remarks>
		/// Returns the count of network devices based on the filter criteria by management IP address, mac address, hostname and location name
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/network-device/count")]
		Task<CountResult> GetDeviceCount();

		/// <summary>
		/// Get Device Detail
		/// </summary>
		/// <remarks>
		/// Returns detailed Network Device information retrieved by Mac Address, Device Name or UUID for any given point of time.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchBy">MAC Address or Device Name value or UUID of the network device</param>
		/// <param name="identifier">One of keywords : macAddress or uuid or nwDeviceName</param>
		/// <param name="timestamp">Epoch time(in milliseconds) when the device data is required (optional, default to )</param>
		/// <returns>Task of GetDeviceDetailResponse</returns>
		[Get("/dna/intent/api/v1/device-detail")]
		Task<GetDeviceDetailResponse> GetDeviceDetail([AliasAs("searchBy")]string searchBy, [AliasAs("identifier")]string identifier, [AliasAs("timestamp")]string timestamp = null);

		/// <summary>
		/// Get Device Enrichment Details
		/// </summary>
		/// <remarks>
		/// Enriches a given network device context (device id or device Mac Address or device management IP address) with details about the device and neighbor topology
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="entity_type">Device enrichment details can be fetched based on either Device ID or Device MAC address or Device IP Address. This parameter value must either be device_id/mac_address/ip_address</param>
		/// <param name="entity_value">Contains the actual value for the entity type that has been defined</param>
		/// <returns>Task of GetDeviceEnrichmentDetailsResponse</returns>
		[Get("/dna/intent/api/v1/device-enrichment-details")]
		Task<GetDeviceEnrichmentDetailsResponse> GetDeviceEnrichmentDetails(string entity_type, string entity_value);

		/// <summary>
		/// Get Device Interface Count
		/// </summary>
		/// <remarks>
		/// Returns the count of interfaces for all devices
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/interface/count")]
		Task<CountResult> GetDeviceInterfaceCount();

		/// <summary>
		/// Get Device Interface count
		/// </summary>
		/// <remarks>
		/// Returns the interface count for the given device
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">Device ID</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/interface/network-device/{deviceId}/count")]
		Task<CountResult> GetDeviceInterfaceCountByDeviceId([AliasAs("deviceId")]string deviceId);

		/// <summary>
		/// Get Device Interface VLANs
		/// </summary>
		/// <remarks>
		/// Returns Device Interface VLANs
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">deviceUUID</param>
		/// <param name="interfaceType">Vlan assocaited with sub-interface (optional)</param>
		/// <returns>Task of VlanListResult</returns>
		[Get("/dna/intent/api/v1/network-device/{id}/vlan")]
		Task<VlanListResult> GetDeviceInterfaceVLANs([AliasAs("id")]string id, [AliasAs("interfaceType")]string interfaceType = null);

		/// <summary>
		/// Get Device Interfaces by specified range
		/// </summary>
		/// <remarks>
		/// Returns the list of interfaces for the device for the specified range
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">Device ID</param>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface/network-device/{deviceId}/{startIndex}/{recordsToReturn}")]
		Task<DeviceIfListResult> GetDeviceInterfacesBySpecifiedRange([AliasAs("deviceId")]string deviceId, [AliasAs("startIndex")]int? startIndex, [AliasAs("recordsToReturn")]int? recordsToReturn);

		/// <summary>
		/// Get Device list
		/// </summary>
		/// <remarks>
		/// Returns list of network devices based on filter criteria such as management IP address, mac address, hostname, location name and a wide variety of additional criteria. You can also use the asterisk in any value to conduct a wildcard search. For example, to find all hostnames beginning with myhost in the IP address range 192.25.18.n, issue the following request: GET  fqdnoripofdnacenterplatform/dna/intent/api/v1/network-device? hostname&#x3D;myhost* &amp; managementIpAddress&#x3D;192.25.18.* For a complete list of parameter names that you can use for filtering this request, see the DNA Center API Reference documentation.  Note: If id parameter is provided, it will return the list of network-devices for the given ids and ignores the other request parameters.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="hostname">hostname (optional)</param>
		/// <param name="managementIpAddress">managementIpAddress (optional)</param>
		/// <param name="macAddress">macAddress (optional)</param>
		/// <param name="locationName">locationName (optional)</param>
		/// <param name="serialNumber">serialNumber (optional)</param>
		/// <param name="location">location (optional)</param>
		/// <param name="family">family (optional)</param>
		/// <param name="type">type (optional)</param>
		/// <param name="series">series (optional)</param>
		/// <param name="collectionStatus">collectionStatus (optional)</param>
		/// <param name="collectionInterval">collectionInterval (optional)</param>
		/// <param name="notSyncedForMinutes">notSyncedForMinutes (optional)</param>
		/// <param name="errorCode">errorCode (optional)</param>
		/// <param name="errorDescription">errorDescription (optional)</param>
		/// <param name="softwareVersion">softwareVersion (optional)</param>
		/// <param name="softwareType">softwareType (optional)</param>
		/// <param name="platformId">platformId (optional)</param>
		/// <param name="role">role (optional)</param>
		/// <param name="reachabilityStatus">reachabilityStatus (optional)</param>
		/// <param name="upTime">upTime (optional)</param>
		/// <param name="associatedWlcIp">associatedWlcIp (optional)</param>
		/// <param name="license_name">licenseName (optional)</param>
		/// <param name="license_type">licenseType (optional)</param>
		/// <param name="license_status">licenseStatus (optional)</param>
		/// <param name="modulename">moduleName (optional)</param>
		/// <param name="moduleequpimenttype">moduleEqupimentType (optional)</param>
		/// <param name="moduleservicestate">moduleServiceState (optional)</param>
		/// <param name="modulevendorequipmenttype">moduleVendorEquipmentType (optional)</param>
		/// <param name="modulepartnumber">modulePartNumber (optional)</param>
		/// <param name="moduleoperationstatecode">moduleOperationStateCode (optional)</param>
		/// <param name="id">Accepts comma separated id&#39;s and return list of network-devices for the given id&#39;s. If invalid or not-found id&#39;s are provided, null entry will be returned in the list. (optional)</param>
		/// <returns>Task of NetworkDeviceListResult</returns>
		[Get("/dna/intent/api/v1/network-device")]
		Task<NetworkDeviceListResult> GetDeviceList([AliasAs("hostname")]List<string> hostname = null, [AliasAs("managementIpAddress")]List<string> managementIpAddress = null, [AliasAs("macAddress")]List<string> macAddress = null, [AliasAs("locationName")]List<string> locationName = null, [AliasAs("serialNumber")]List<string> serialNumber = null, [AliasAs("location")]List<string> location = null, [AliasAs("family")]List<string> family = null, [AliasAs("type")]List<string> type = null, [AliasAs("series")]List<string> series = null, [AliasAs("collectionStatus")]List<string> collectionStatus = null, [AliasAs("collectionInterval")]List<string> collectionInterval = null, [AliasAs("notSyncedForMinutes")]List<string> notSyncedForMinutes = null, [AliasAs("errorCode")]List<string> errorCode = null, [AliasAs("errorDescription")]List<string> errorDescription = null, [AliasAs("softwareVersion")]List<string> softwareVersion = null, [AliasAs("softwareType")]List<string> softwareType = null, [AliasAs("platformId")]List<string> platformId = null, [AliasAs("role")]List<string> role = null, [AliasAs("reachabilityStatus")]List<string> reachabilityStatus = null, [AliasAs("upTime")]List<string> upTime = null, [AliasAs("associatedWlcIp")]List<string> associatedWlcIp = null, [AliasAs("license_name")]List<string> license_name = null, [AliasAs("license_type")]List<string> license_type = null, [AliasAs("license_status")]List<string> license_status = null, [AliasAs("modulename")]List<string> modulename = null, [AliasAs("moduleequpimenttype")]List<string> moduleequpimenttype = null, [AliasAs("moduleservicestate")]List<string> moduleservicestate = null, [AliasAs("modulevendorequipmenttype")]List<string> modulevendorequipmenttype = null, [AliasAs("modulepartnumber")]List<string> modulepartnumber = null, [AliasAs("moduleoperationstatecode")]List<string> moduleoperationstatecode = null, [AliasAs("id")]string id = null);

		/// <summary>
		/// Get Device Summary
		/// </summary>
		/// <remarks>
		/// Returns brief summary of device info such as hostname, management IP address for the given device Id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Device ID</param>
		/// <returns>Task of NetworkDeviceBriefNIOResult</returns>
		[Get("/dna/intent/api/v1/network-device/{id}/brief")]
		Task<NetworkDeviceBriefNIOResult> GetDeviceSummary([AliasAs("id")]string id);

		/// <summary>
		/// Get Functional Capability by Id
		/// </summary>
		/// <remarks>
		/// Returns functional capability with given Id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Functional Capability UUID</param>
		/// <returns>Task of FunctionalCapabilityResult</returns>
		[Get("/dna/intent/api/v1/network-device/functional-capability/{id}")]
		Task<FunctionalCapabilityResult> GetFunctionalCapabilityById([AliasAs("id")]string id);

		/// <summary>
		/// Get Functional Capability for devices
		/// </summary>
		/// <remarks>
		/// Returns the functional-capability for given devices
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">Accepts comma separated deviceid&#39;s and return list of functional-capabilities for the given id&#39;s. If invalid or not-found id&#39;s are provided, null entry will be returned in the list.</param>
		/// <param name="functionName">functionName (optional)</param>
		/// <returns>Task of FunctionalCapabilityListResult</returns>
		[Get("/dna/intent/api/v1/network-device/functional-capability")]
		Task<FunctionalCapabilityListResult> GetFunctionalCapabilityForDevices([AliasAs("deviceId")]string deviceId, [AliasAs("functionName")]List<string> functionName = null);

		/// <summary>
		/// Get ISIS interfaces
		/// </summary>
		/// <remarks>
		/// Returns the interfaces that has ISIS enabled
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface/isis")]
		Task<DeviceIfListResult> GetISISInterfaces();

		/// <summary>
		/// Get Interface by IP
		/// </summary>
		/// <remarks>
		/// Returns list of interfaces by specified IP address
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ipAddress">IP address of the interface</param>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface/ip-address/{ipAddress}")]
		Task<DeviceIfListResult> GetInterfaceByIP([AliasAs("ipAddress")]string ipAddress);

		/// <summary>
		/// Get Interface by Id
		/// </summary>
		/// <remarks>
		/// Returns the interface for the given interface ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Interface ID</param>
		/// <returns>Task of DeviceIfResult</returns>
		[Get("/dna/intent/api/v1/interface/{id}")]
		Task<DeviceIfResult> GetInterfaceById([AliasAs("id")]string id);

		/// <summary>
		/// Get Interface details by device Id and interface name
		/// </summary>
		/// <remarks>
		/// Returns interface by specified device Id and interface name
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">Device ID</param>
		/// <param name="name">Interface name</param>
		/// <returns>Task of DeviceIfResult</returns>
		[Get("/dna/intent/api/v1/interface/network-device/{deviceId}/interface-name")]
		Task<DeviceIfResult> GetInterfaceDetailsByDeviceIdAndInterfaceName([AliasAs("deviceId")]string deviceId, [AliasAs("name")]string name);

		/// <summary>
		/// Get Interface info by Id
		/// </summary>
		/// <remarks>
		/// Returns list of interfaces by specified device
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">Device ID</param>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface/network-device/{deviceId}")]
		Task<DeviceIfListResult> GetInterfaceInfoById([AliasAs("deviceId")]string deviceId);

		/// <summary>
		/// Get Module count
		/// </summary>
		/// <remarks>
		/// Returns Module Count
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">deviceId</param>
		/// <param name="nameList">nameList (optional)</param>
		/// <param name="vendorEquipmentTypeList">vendorEquipmentTypeList (optional)</param>
		/// <param name="partNumberList">partNumberList (optional)</param>
		/// <param name="operationalStateCodeList">operationalStateCodeList (optional)</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/network-device/module/count")]
		Task<CountResult> GetModuleCount([AliasAs("deviceId")]string deviceId, [AliasAs("nameList")]List<string> nameList = null, [AliasAs("vendorEquipmentTypeList")]List<string> vendorEquipmentTypeList = null, [AliasAs("partNumberList")]List<string> partNumberList = null, [AliasAs("operationalStateCodeList")]List<string> operationalStateCodeList = null);

		/// <summary>
		/// Get Module Info by Id
		/// </summary>
		/// <remarks>
		/// Returns Module info by id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of ModuleResult</returns>
		[Get("/dna/intent/api/v1/network-device/module/{id}")]
		Task<ModuleResult> GetModuleInfoById([AliasAs("id")]string id);

		/// <summary>
		/// Get Modules
		/// </summary>
		/// <remarks>
		/// Returns modules by specified device id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceId">deviceId</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="nameList">nameList (optional)</param>
		/// <param name="vendorEquipmentTypeList">vendorEquipmentTypeList (optional)</param>
		/// <param name="partNumberList">partNumberList (optional)</param>
		/// <param name="operationalStateCodeList">operationalStateCodeList (optional)</param>
		/// <returns>Task of ModuleListResult</returns>
		[Get("/dna/intent/api/v1/network-device/module")]
		Task<ModuleListResult> GetModules([AliasAs("deviceId")]string deviceId, [AliasAs("limit")]string limit = null, [AliasAs("offset")]string offset = null, [AliasAs("nameList")]List<string> nameList = null, [AliasAs("vendorEquipmentTypeList")]List<string> vendorEquipmentTypeList = null, [AliasAs("partNumberList")]List<string> partNumberList = null, [AliasAs("operationalStateCodeList")]List<string> operationalStateCodeList = null);

		/// <summary>
		/// Get Network Device by IP
		/// </summary>
		/// <remarks>
		/// Returns the network device by specified IP address
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ipAddress">Device IP address</param>
		/// <returns>Task of NetworkDeviceResult</returns>
		[Get("/dna/intent/api/v1/network-device/ip-address/{ipAddress}")]
		Task<NetworkDeviceResult> GetNetworkDeviceByIP([AliasAs("ipAddress")]string ipAddress);

		/// <summary>
		/// Get Network Device by pagination range
		/// </summary>
		/// <remarks>
		/// Returns the list of network devices for the given pagination range
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startIndex">Start index</param>
		/// <param name="recordsToReturn">Number of records to return</param>
		/// <returns>Task of NetworkDeviceListResult</returns>
		[Get("/dna/intent/api/v1/network-device/{startIndex}/{recordsToReturn}")]
		Task<NetworkDeviceListResult> GetNetworkDeviceByPaginationRange([AliasAs("startIndex")]int? startIndex, [AliasAs("recordsToReturn")]int? recordsToReturn);

		/// <summary>
		/// Get OSPF interfaces
		/// </summary>
		/// <remarks>
		/// Returns the interfaces that has OSPF enabled
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of DeviceIfListResult</returns>
		[Get("/dna/intent/api/v1/interface/ospf")]
		Task<DeviceIfListResult> GetOSPFInterfaces();

		/// <summary>
		/// Get Organization list for Meraki
		/// </summary>
		/// <remarks>
		/// Returns list of organizations for meraki dashboard
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id</param>
		/// <returns>Task of SuccessResultList</returns>
		[Get("/dna/intent/api/v1/network-device/{id}/meraki-organization")]
		Task<SuccessResultList> GetOrganizationListForMeraki([AliasAs("id")]string id);

		/// <summary>
		/// Get Polling Interval by Id
		/// </summary>
		/// <remarks>
		/// Returns polling interval by device id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Device ID</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/network-device/{id}/collection-schedule")]
		Task<CountResult> GetPollingIntervalById([AliasAs("id")]string id);

		/// <summary>
		/// Get Polling Interval for all devices
		/// </summary>
		/// <remarks>
		/// Returns polling interval of all devices
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/network-device/collection-schedule/global")]
		Task<CountResult> GetPollingIntervalForAllDevices();

		/// <summary>
		/// Get wireless lan controller details by Id
		/// </summary>
		/// <remarks>
		/// Returns the wireless lan controller info with given device ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Device ID</param>
		/// <returns>Task of WirelessInfoResult</returns>
		[Get("/dna/intent/api/v1/network-device/{id}/wireless-info")]
		Task<WirelessInfoResult> GetWirelessLanControllerDetailsById([AliasAs("id")]string id);

		/// <summary>
		/// Register device for WSA
		/// </summary>
		/// <remarks>
		/// Registers a device for WSA notification
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serialNumber">Serial number of the device (optional)</param>
		/// <param name="macaddress">Mac addres of the device (optional)</param>
		/// <returns>Task of RegisterNetworkDeviceResult</returns>
		[Get("/dna/intent/api/v1/network-device/tenantinfo/macaddress")]
		Task<RegisterNetworkDeviceResult> RegisterDeviceForWSA([AliasAs("serialNumber")]string serialNumber = null, [AliasAs("macaddress")]string macaddress = null);

		/// <summary>
		/// Retrieves all network devices
		/// </summary>
		/// <remarks>
		/// Gets the list of first 500 network devices sorted lexicographically based on host name. It can be filtered using management IP address, mac address, hostname and location name. If id param is provided, it will be returning the list of network-devices for the given id&#39;s and other request params will be ignored. In case of autocomplete request, returns the list of specified attributes.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="vrfName">vrfName (optional)</param>
		/// <param name="managementIpAddress">managementIpAddress (optional)</param>
		/// <param name="hostname">hostname (optional)</param>
		/// <param name="macAddress">macAddress (optional)</param>
		/// <param name="family">family (optional)</param>
		/// <param name="collectionStatus">collectionStatus (optional)</param>
		/// <param name="collectionInterval">collectionInterval (optional)</param>
		/// <param name="softwareVersion">softwareVersion (optional)</param>
		/// <param name="softwareType">softwareType (optional)</param>
		/// <param name="reachabilityStatus">reachabilityStatus (optional)</param>
		/// <param name="reachabilityFailureReason">reachabilityFailureReason (optional)</param>
		/// <param name="errorCode">errorCode (optional)</param>
		/// <param name="platformId">platformId (optional)</param>
		/// <param name="series">series (optional)</param>
		/// <param name="type">type (optional)</param>
		/// <param name="serialNumber">serialNumber (optional)</param>
		/// <param name="upTime">upTime (optional)</param>
		/// <param name="role">role (optional)</param>
		/// <param name="roleSource">roleSource (optional)</param>
		/// <param name="associatedWlcIp">associatedWlcIp (optional)</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <returns>Task of RetrievesAllNetworkDevicesResponse</returns>
		[Get("/dna/intent/api/v1/network-device/autocomplete")]
		Task<RetrievesAllNetworkDevicesResponse> RetrievesAllNetworkDevices([AliasAs("vrfName")]string vrfName = null, [AliasAs("managementIpAddress")]string managementIpAddress = null, [AliasAs("hostname")]string hostname = null, [AliasAs("macAddress")]string macAddress = null, [AliasAs("family")]string family = null, [AliasAs("collectionStatus")]string collectionStatus = null, [AliasAs("collectionInterval")]string collectionInterval = null, [AliasAs("softwareVersion")]string softwareVersion = null, [AliasAs("softwareType")]string softwareType = null, [AliasAs("reachabilityStatus")]string reachabilityStatus = null, [AliasAs("reachabilityFailureReason")]string reachabilityFailureReason = null, [AliasAs("errorCode")]string errorCode = null, [AliasAs("platformId")]string platformId = null, [AliasAs("series")]string series = null, [AliasAs("type")]string type = null, [AliasAs("serialNumber")]string serialNumber = null, [AliasAs("upTime")]string upTime = null, [AliasAs("role")]string role = null, [AliasAs("roleSource")]string roleSource = null, [AliasAs("associatedWlcIp")]string associatedWlcIp = null, [AliasAs("offset")]string offset = null, [AliasAs("limit")]string limit = null);

		/// <summary>
		/// Sync Devices
		/// </summary>
		/// <remarks>
		/// Sync the devices provided as input
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/network-device")]
		Task<TaskIdResult> SyncDevices([Body]InventoryDeviceInfo request);

		/// <summary>
		/// Sync Devices
		/// </summary>
		/// <remarks>
		/// Synchronizes the devices. If forceSync param is false (default) then the sync would run in normal priority thread. If forceSync param is true then the sync would run in high priority thread if available, else the sync will fail. Result can be seen in the child task of each device
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="forceSync">forceSync (optional)</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/network-device/sync")]
		Task<TaskIdResult> SyncNetworkDevices([Body]SyncDevicesRequest request, string Content_Type, [AliasAs("forceSync")]bool? forceSync = null);

		/// <summary>
		/// Update Device role
		/// </summary>
		/// <remarks>
		/// Updates the role of the device as access, core, distribution, border router
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/network-device/brief")]
		Task<TaskIdResult> UpdateDeviceRole([Body]NetworkDeviceBriefNIO request);
	}
}
