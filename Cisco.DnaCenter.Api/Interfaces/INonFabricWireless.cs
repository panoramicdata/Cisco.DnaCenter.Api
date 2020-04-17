using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INonFabricWireless
	{
		/// <summary>
		/// AP Provision
		/// </summary>
		/// <remarks>
		/// Provision wireless Access points
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput"> (optional, default to true)</param>
		/// <returns>Task of APProvisionResponse</returns>
		[Post("/dna/intent/api/v1/wireless/ap-provision")]
		Task<APProvisionResponse> APProvision([Body]APProvisionRequest request, string __persistbapioutput = null);

		/// <summary>
		/// Create and Provision SSID
		/// </summary>
		/// <remarks>
		/// Creates SSID, updates the SSID to the corresponding site profiles and provision it to the devices matching the given sites
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Enable this parameter to execute the API and return a response asynchronously.</param>
		/// <returns>Task of CreateAndProvisionSSIDResponse</returns>
		[Post("/dna/intent/api/v1/business/ssid")]
		Task<CreateAndProvisionSSIDResponse> CreateAndProvisionSSID([Body]CreateAndProvisionSSIDRequest request, string __persistbapioutput);

		/// <summary>
		/// Create Enterprise SSID
		/// </summary>
		/// <remarks>
		/// Creates enterprise SSID
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateEnterpriseSSIDResponse</returns>
		[Post("/dna/intent/api/v1/enterprise-ssid")]
		Task<CreateEnterpriseSSIDResponse> CreateEnterpriseSSID([Body]CreateEnterpriseSSIDRequest request);

		/// <summary>
		/// Create or Update RF profile
		/// </summary>
		/// <remarks>
		/// Create or Update RF profile
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateOrUpdateRFProfileResponse</returns>
		[Post("/dna/intent/api/v1/wireless/rf-profile")]
		Task<CreateOrUpdateRFProfileResponse> CreateOrUpdateRFProfile([Body]CreateOrUpdateRFProfileRequest request);

		/// <summary>
		/// Create Wireless Profile
		/// </summary>
		/// <remarks>
		/// Creates Wireless Network Profile on DNAC and associates sites and SSIDs to it.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateWirelessProfileResponse</returns>
		[Post("/dna/intent/api/v1/wireless/profile")]
		Task<CreateWirelessProfileResponse> CreateWirelessProfile([Body]CreateWirelessProfileRequest request);

		/// <summary>
		/// Delete Enterprise SSID
		/// </summary>
		/// <remarks>
		/// Deletes given enterprise SSID
		/// </remarks>
		/// <param name="ssidName">Enter the SSID name to be deleted</param>
		/// <returns>Task of DeleteEnterpriseSSIDResponse</returns>
		[Delete("/dna/intent/api/v1/enterprise-ssid/{ssidName}")]
		Task<DeleteEnterpriseSSIDResponse> DeleteEnterpriseSSID([AliasAs("ssidName")]string ssidName);

		/// <summary>
		/// Delete RF profiles
		/// </summary>
		/// <remarks>
		/// Delete RF profile(s)
		/// </remarks>
		/// <param name="rf_profile_name"></param>
		/// <returns>Task of DeleteRFProfilesResponse</returns>
		[Delete("/dna/intent/api/v1/wireless/rf-profile/{rfProfileName}")]
		Task<DeleteRFProfilesResponse> DeleteRFProfiles([AliasAs("rfProfileName")]string rfProfileName);

		/// <summary>
		/// Delete SSID and provision it to devices
		/// </summary>
		/// <remarks>
		/// Removes SSID or WLAN from the network profile, reprovision the device(s) and deletes the SSID or WLAN from DNA Center
		/// </remarks>
		/// <param name="__persistbapioutput">Enable this parameter to execute the API and return a response asynchronously.</param>
		/// <param name="ssidName"></param>
		/// <param name="managedAPLocations"></param>
		/// <returns>Task of DeleteSSIDAndProvisionItToDevicesResponse</returns>
		[Delete("/dna/intent/api/v1/business/ssid/{ssidName}/{managedAPLocations}")]
		Task<DeleteSSIDAndProvisionItToDevicesResponse> DeleteSSIDAndProvisionItToDevices(string __persistbapioutput, [AliasAs("ssidName")]string ssidName, [AliasAs("managedAPLocations")]string managedAPLocations);

		/// <summary>
		/// Delete Wireless Profile
		/// </summary>
		/// <remarks>
		/// Delete the Wireless Profile from DNAC whose name is provided.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="wirelessProfileName"></param>
		/// <returns>Task of DeleteWirelessProfileResponse</returns>
		[Delete("/dna/intent/api/v1/wireless-profile/{wirelessProfileName}")]
		Task<DeleteWirelessProfileResponse> DeleteWirelessProfile([Body]DeleteWirelessProfileRequest request, [AliasAs("wirelessProfileName")]string wirelessProfileName);

		/// <summary>
		/// Get Enterprise SSID
		/// </summary>
		/// <remarks>
		/// Gets either one or all the enterprise SSID
		/// </remarks>
		/// <param name="ssidName">Enter the enterprise SSID name that needs to be retrieved. If not entered, all the enterprise SSIDs will be retrieved. (optional, default to )</param>
		/// <returns>Task of GetEnterpriseSSIDResponse</returns>
		[Get("/dna/intent/api/v1/enterprise-ssid")]
		Task<GetEnterpriseSSIDResponse> GetEnterpriseSSID([AliasAs("ssidName")]string ssidName = null);

		/// <summary>
		/// Get Wireless Profile
		/// </summary>
		/// <remarks>
		/// Gets either one or all the wireless network profiles if no name is provided for network-profile.
		/// </remarks>
		/// <param name="profileName"> (optional, default to )</param>
		/// <returns>Task of GetWirelessProfileResponse</returns>
		[Get("/dna/intent/api/v1/wireless/profile")]
		Task<GetWirelessProfileResponse> GetWirelessProfile([AliasAs("profileName")]string profileName = null);

		/// <summary>
		/// Provision
		/// </summary>
		/// <remarks>
		/// Provision wireless devices
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Enable this parameter to execute the API and return a response asynchronously.</param>
		/// <returns>Task of ProvisionResponse</returns>
		[Post("/dna/intent/api/v1/wireless/provision")]
		Task<ProvisionResponse> Provision([Body]ProvisionRequest request, string __persistbapioutput);

		/// <summary>
		/// Provision update
		/// </summary>
		/// <remarks>
		/// Updates wireless provisioning
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Enable this parameter to execute the API and return a response asynchronously.</param>
		/// <returns>Task of ProvisionUpdateResponse</returns>
		[Put("/dna/intent/api/v1/wireless/provision")]
		Task<ProvisionUpdateResponse> ProvisionUpdate([Body]ProvisionUpdateRequest request, string __persistbapioutput);

		/// <summary>
		/// Retrieve RF profiles
		/// </summary>
		/// <remarks>
		/// Retrieve all RF profiles
		/// </remarks>
		/// <param name="rf_profile_name"> (optional, default to )</param>
		/// <returns>Task of RetrieveRFProfilesResponse</returns>
		[Get("/dna/intent/api/v1/wireless/rf-profile")]
		Task<RetrieveRFProfilesResponse> RetrieveRFProfiles([AliasAs("rf_profile_name")]string rf_profile_name = null);

		/// <summary>
		/// Update Wireless Profile
		/// </summary>
		/// <remarks>
		/// Updates the wireless Network Profile with updated details provided. All sites to be present in the network profile should be provided.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateWirelessProfileResponse</returns>
		[Put("/dna/intent/api/v1/wireless/profile")]
		Task<UpdateWirelessProfileResponse> UpdateWirelessProfile([Body]UpdateWirelessProfileRequest request);
	}
}
