using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISda
	{
		#region Asynchronous Operations

		/// <summary>
		/// **BETA** - Add control plane device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add control plane device in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddControlPlaneDeviceInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/control-plane-device")]
		System.Threading.Tasks.Task<AddControlPlaneDeviceInSdaFabricResponse> AddControlPlaneDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddControlPlaneDeviceInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add default authentication profile in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add default authentication profile in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddDefaultAuthenticationProfileInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/authentication-profile")]
		System.Threading.Tasks.Task<AddDefaultAuthenticationProfileInSDAFabricResponse> AddDefaultAuthenticationProfileInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddDefaultAuthenticationProfileInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add edge device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add edge device in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddEdgeDeviceInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/edge-device")]
		System.Threading.Tasks.Task<AddEdgeDeviceInSdaFabricResponse> AddEdgeDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddEdgeDeviceInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/fabric")]
		System.Threading.Tasks.Task<AddFabricResponse> AddFabric([Header("UserAgent")] string userAgent, [Body]AddFabricRequest request);

		/// <summary>
		/// **BETA** - Add IP Pool in SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Add IP Pool in SDA Virtual Network
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddIPPoolInSDAVirtualNetworkResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		System.Threading.Tasks.Task<AddIpPoolInSdaVirtualNetworkResponse> AddIPPoolInSDAVirtualNetwork([Header("UserAgent")] string userAgent, [Body]AddIpPoolInSDAVirtualNetworkRequest request);

		/// <summary>
		/// **BETA** - Add Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddPortAssignmentForAccessPointInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		System.Threading.Tasks.Task<AddPortAssignmentForAccessPointInSdaFabricResponse> AddPortAssignmentForAccessPointInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddPortAssignmentForAccessPointInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddPortAssignmentForUserDeviceInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		System.Threading.Tasks.Task<AddPortAssignmentForUserDeviceInSdaFabricResponse> AddPortAssignmentForUserDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddPortAssignmentForUserDeviceInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add Site in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Site in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddSiteInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/fabric-site")]
		System.Threading.Tasks.Task<AddSiteInSDAFabricResponse> AddSiteInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddSiteInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Add VN in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add virtual network (VN) in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddVNInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/virtual-network")]
		System.Threading.Tasks.Task<AddVNInSDAFabricResponse> AddVNInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddVNInSDAFabricRequest request);

		/// <summary>
		/// **BETA** - Adds border device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Adds border device in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of AddsBorderDeviceInSDAFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/border-device")]
		System.Threading.Tasks.Task<AddsBorderDeviceInSdaFabricResponse> AddsBorderDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]AddsBorderDeviceInSdaFabricRequest request);

		/// <summary>
		/// **BETA** - Delete control plane device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete control plane device in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of DeleteControlPlaneDeviceInSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/control-plane-device")]
		System.Threading.Tasks.Task<DeleteControlPlaneDeviceInSDAFabricResponse> DeleteControlPlaneDeviceInSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Delete default authentication profile from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete default authentication profile from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of DeleteDefaultAuthenticationProfileFromSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/authentication-profile")]
		System.Threading.Tasks.Task<DeleteDefaultAuthenticationProfileFromSDAFabricResponse> DeleteDefaultAuthenticationProfileFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Delete edge device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete edge device from SDA Fabric.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of DeleteEdgeDeviceFromSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/edge-device")]
		System.Threading.Tasks.Task<DeleteEdgeDeviceFromSDAFabricResponse> DeleteEdgeDeviceFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Delete IP Pool from SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete IP Pool from SDA Virtual Network
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="ipPoolName">ipPoolName</param>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <returns>Task of DeleteIPPoolFromSDAVirtualNetworkResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		System.Threading.Tasks.Task<DeleteIPPoolFromSDAVirtualNetworkResponse> DeleteIPPoolFromSDAVirtualNetwork([Header("UserAgent")] string userAgent, [Body]DeleteIPPoolFromSDAVirtualNetworkRequest request, [AliasAs("ipPoolName")]string ipPoolName, [AliasAs("virtualNetworkName")]string virtualNetworkName);

		/// <summary>
		/// **BETA** - Delete Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of DeletePortAssignmentForAccessPointInSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		System.Threading.Tasks.Task<DeletePortAssignmentForAccessPointInSDAFabricResponse> DeletePortAssignmentForAccessPointInSDAFabric([Header("UserAgent")] string userAgent, [Body]DeletePortAssignmentForAccessPointInSDAFabricRequest request, [AliasAs("device_ip")]string device_ip, [AliasAs("interfaceName")]string interfaceName);

		/// <summary>
		/// **BETA** - Delete Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of DeletePortAssignmentForUserDeviceInSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		System.Threading.Tasks.Task<DeletePortAssignmentForUserDeviceInSDAFabricResponse> DeletePortAssignmentForUserDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]DeletePortAssignmentForUserDeviceInSDAFabricRequest request, [AliasAs("device_ip")]string device_ip, [AliasAs("interfaceName")]string interfaceName);

		/// <summary>
		/// **BETA** - Delete SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="fabricName">Fabric Name</param>
		/// <returns>Task of DeleteSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/fabric")]
		System.Threading.Tasks.Task<DeleteSDAFabricResponse> DeleteSDAFabric([Header("UserAgent")] string userAgent, [Body]DeleteSDAFabricRequest request, [AliasAs("fabricName")]string fabricName);

		/// <summary>
		/// **BETA** - Delete Site from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Site from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">Site Name Hierarchy</param>
		/// <returns>Task of DeleteSiteFromSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/fabric-site")]
		System.Threading.Tasks.Task<DeleteSiteFromSDAFabricResponse> DeleteSiteFromSDAFabric([Header("UserAgent")] string userAgent, [Body]DeleteSiteFromSDAFabricRequest request, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Delete VN from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete virtual network (VN) from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of DeleteVNFromSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/virtual-network")]
		System.Threading.Tasks.Task<DeleteVNFromSDAFabricResponse> DeleteVNFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("virtualNetworkName")]string virtualNetworkName, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Deletes border device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Deletes border device from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of DeletesBorderDeviceFromSDAFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/border-device")]
		System.Threading.Tasks.Task<DeletesBorderDeviceFromSDAFabricResponse> DeletesBorderDeviceFromSDAFabric([Header("UserAgent")] string userAgent, [Body]DeletesBorderDeviceFromSDAFabricRequest request, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Get control plane device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get control plane device from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetControlPlaneDeviceFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/control-plane-device")]
		System.Threading.Tasks.Task<GetControlPlaneDeviceFromSDAFabricResponse> GetControlPlaneDeviceFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Get default authentication profile from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get default authentication profile from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of GetDefaultAuthenticationProfileFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/authentication-profile")]
		System.Threading.Tasks.Task<GetDefaultAuthenticationProfileFromSDAFabricResponse> GetDefaultAuthenticationProfileFromSDAFabric([Header("UserAgent")] string userAgent, [Body]GetDefaultAuthenticationProfileFromSDAFabricRequest request, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Get device info from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get device info from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetDeviceInfoFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/device")]
		System.Threading.Tasks.Task<GetDeviceInfoFromSDAFabricResponse> GetDeviceInfoFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Get edge device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get edge device from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetEdgeDeviceFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/edge-device")]
		System.Threading.Tasks.Task<GetEdgeDeviceFromSDAFabricResponse> GetEdgeDeviceFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Get IP Pool from SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Get IP Pool from SDA Virtual Network
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="ipPoolName">ipPoolName</param>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <returns>Task of GetIPPoolFromSDAVirtualNetworkResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		System.Threading.Tasks.Task<GetIPPoolFromSDAVirtualNetworkResponse> GetIPPoolFromSDAVirtualNetwork([Header("UserAgent")] string userAgent, [Body]GetIPPoolFromSDAVirtualNetworkRequest request, [AliasAs("ipPoolName")]string ipPoolName, [AliasAs("virtualNetworkName")]string virtualNetworkName);

		/// <summary>
		/// **BETA** - Get Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of GetPortAssignmentForAccessPointInSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		System.Threading.Tasks.Task<GetPortAssignmentForAccessPointInSDAFabricResponse> GetPortAssignmentForAccessPointInSDAFabric([Header("UserAgent")] string userAgent, [Body]GetPortAssignmentForAccessPointInSDAFabricRequest request, [AliasAs("device_ip")]string device_ip, [AliasAs("interfaceName")]string interfaceName);

		/// <summary>
		/// **BETA** - Get Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of GetPortAssignmentForUserDeviceInSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		System.Threading.Tasks.Task<GetPortAssignmentForUserDeviceInSDAFabricResponse> GetPortAssignmentForUserDeviceInSDAFabric([Header("UserAgent")] string userAgent, [Body]GetPortAssignmentForUserDeviceInSDAFabricRequest request, [AliasAs("device_ip")]string device_ip, [AliasAs("interfaceName")]string interfaceName);

		/// <summary>
		/// **BETA** - Get SDA Fabric Info
		/// </summary>
		/// <remarks>
		/// **BETA** - Get SDA Fabric Info
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="fabricName">Fabric Name</param>
		/// <returns>Task of GetSDAFabricInfoResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/fabric")]
		System.Threading.Tasks.Task<GetSDAFabricInfoResponse> GetSDAFabricInfo([Header("UserAgent")] string userAgent, [Body]GetSDAFabricInfoRequest request, [AliasAs("fabricName")]string fabricName);

		/// <summary>
		/// **BETA** - Get Site from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Site info from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">Site Name Hierarchy</param>
		/// <returns>Task of GetSiteFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/fabric-site")]
		System.Threading.Tasks.Task<GetSiteFromSDAFabricResponse> GetSiteFromSDAFabric([Header("UserAgent")] string userAgent, [Body]GetSiteFromSDAFabricRequest request, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Get VN from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get virtual network (VN) from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of GetVNFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/virtual-network")]
		System.Threading.Tasks.Task<GetVNFromSDAFabricResponse> GetVNFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("virtualNetworkName")]string virtualNetworkName, [AliasAs("siteNameHierarchy")]string siteNameHierarchy);

		/// <summary>
		/// **BETA** - Gets border device detail from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Gets border device detail from SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetsBorderDeviceDetailFromSDAFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/border-device")]
		System.Threading.Tasks.Task<GetsBorderDeviceDetailFromSDAFabricResponse> GetsBorderDeviceDetailFromSDAFabric([Header("UserAgent")] string userAgent, [AliasAs("deviceIPAddress")]string deviceIPAddress);

		/// <summary>
		/// **BETA** - Update default authentication profile template in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Update default authentication profile template in SDA Fabric
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateDefaultAuthenticationProfileTemplateInSDAFabricResponse</returns>
		[Put("/dna/intent/api/v1/business/sda/authentication-profile")]
		System.Threading.Tasks.Task<UpdateDefaultAuthenticationProfileTemplateInSDAFabricResponse> UpdateDefaultAuthenticationProfileTemplateInSDAFabric([Header("UserAgent")] string userAgent, [Body]UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest request);
		#endregion Asynchronous Operations
	}
}
