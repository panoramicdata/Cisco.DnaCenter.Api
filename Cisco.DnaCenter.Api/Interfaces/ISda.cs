using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISda
	{
		/// <summary>
		/// **BETA** - Add control plane device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add control plane device in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddControlPlaneDeviceInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/control-plane-device")]
		Task<AddControlPlaneDeviceInSdaFabricResponse> AddControlPlaneDeviceInSdaFabricAsync(
			[Body]AddControlPlaneDeviceInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add default authentication profile in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add default authentication profile in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddDefaultAuthenticationProfileInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/authentication-profile")]
		Task<AddDefaultAuthenticationProfileInSdaFabricResponse> AddDefaultAuthenticationProfileInSdaFabricAsync(
			[Body]AddDefaultAuthenticationProfileInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add edge device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add edge device in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddEdgeDeviceInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/edge-device")]
		Task<AddEdgeDeviceInSdaFabricResponse> AddEdgeDeviceInSdaFabricAsync(
			[Body]AddEdgeDeviceInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/fabric")]
		Task<AddFabricResponse> AddFabricAsync(
			[Body]AddFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add IP Pool in SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Add IP Pool in SDA Virtual Network
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddIPPoolInSDAVirtualNetworkResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		Task<AddIpPoolInSdaVirtualNetworkResponse> AddIpPoolInSdaVirtualNetwork(
			[Body]AddIpPoolInSDAVirtualNetworkRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddPortAssignmentForAccessPointInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		Task<AddPortAssignmentForAccessPointInSdaFabricResponse> AddPortAssignmentForAccessPointInSdaFabricAsync(
			[Body]AddPortAssignmentForAccessPointInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddPortAssignmentForUserDeviceInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		Task<AddPortAssignmentForUserDeviceInSdaFabricResponse> AddPortAssignmentForUserDeviceInSdaFabric(
			[Body]AddPortAssignmentForUserDeviceInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add Site in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add Site in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddSiteInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/fabric-site")]
		Task<AddSiteInSdaFabricResponse> AddSiteInSdaFabricAsync(
			[Body]AddSiteInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Add VN in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Add virtual network (VN) in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddVNInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/virtual-network")]
		Task<AddVnInSdaFabricResponse> AddVnInSdaFabricAsync(
			[Body]AddVnInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Adds border device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Adds border device in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of AddsBorderDeviceInSdaFabricResponse</returns>
		[Post("/dna/intent/api/v1/business/sda/border-device")]
		Task<AddsBorderDeviceInSdaFabricResponse> AddsBorderDeviceInSdaFabricAsync(
			[Body]AddsBorderDeviceInSdaFabricRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete control plane device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete control plane device in SDA Fabric
		/// </remarks>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of DeleteControlPlaneDeviceInSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/control-plane-device")]
		Task<DeleteControlPlaneDeviceInSdaFabricResponse> DeleteControlPlaneDeviceInSdaFabricAsync(
			[AliasAs("deviceIPAddress")]string deviceIPAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete default authentication profile from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete default authentication profile from SDA Fabric
		/// </remarks>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of DeleteDefaultAuthenticationProfileFromSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/authentication-profile")]
		Task<DeleteDefaultAuthenticationProfileFromSdaFabricResponse> DeleteDefaultAuthenticationProfileFromSdaFabricAsync(
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete edge device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete edge device from SDA Fabric.
		/// </remarks>
		/// <param name="deviceIpAddress">Device IP Address</param>
		/// <returns>Task of DeleteEdgeDeviceFromSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/edge-device")]
		Task<DeleteEdgeDeviceFromSdaFabricResponse> DeleteEdgeDeviceFromSdaFabricAsync(
			[AliasAs("deviceIPAddress")]string deviceIpAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete IP Pool from SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete IP Pool from SDA Virtual Network
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="ipPoolName">ipPoolName</param>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <returns>Task of DeleteIPPoolFromSDAVirtualNetworkResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		Task<DeleteIpPoolFromSdaVirtualNetworkResponse> DeleteIpPoolFromSdaVirtualNetwork(
			[Body]DeleteIpPoolFromSdaVirtualNetworkRequest request,
			[AliasAs("ipPoolName")]string ipPoolName,
			[AliasAs("virtualNetworkName")]string virtualNetworkName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of DeletePortAssignmentForAccessPointInSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		Task<DeletePortAssignmentForAccessPointInSdaFabricResponse> DeletePortAssignmentForAccessPointInSdaFabricAsync(
			[Body]DeletePortAssignmentForAccessPointInSdaFabricRequest request,
			[AliasAs("device_ip")]string deviceIp,
			[AliasAs("interfaceName")]string interfaceName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of DeletePortAssignmentForUserDeviceInSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		Task<DeletePortAssignmentForUserDeviceInSdaFabricResponse> DeletePortAssignmentForUserDeviceInSdaFabricAsync(
			[Body]DeletePortAssignmentForUserDeviceInSdaFabricRequest request,
			[AliasAs("device_ip")]string deviceIp,
			[AliasAs("interfaceName")]string interfaceName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="fabricName">Fabric Name</param>
		/// <returns>Task of DeleteSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/fabric")]
		Task<DeleteSdaFabricResponse> DeleteSdaFabricAsync(
			[Body]DeleteSdaFabricRequest request,
			[AliasAs("fabricName")]string fabricName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete Site from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete Site from SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">Site Name Hierarchy</param>
		/// <returns>Task of DeleteSiteFromSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/fabric-site")]
		Task<DeleteSiteFromSdaFabricResponse> DeleteSiteFromSdaFabric(
			[Body]DeleteSiteFromSdaFabricRequest request,
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Delete VN from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Delete virtual network (VN) from SDA Fabric
		/// </remarks>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of DeleteVNFromSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/virtual-network")]
		Task<DeleteVnFromSdaFabricResponse> DeleteVnFromSdaFabric(
			[AliasAs("virtualNetworkName")]string virtualNetworkName,
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Deletes border device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Deletes border device from SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of DeletesBorderDeviceFromSdaFabricResponse</returns>
		[Delete("/dna/intent/api/v1/business/sda/border-device")]
		Task<DeleteBorderDeviceFromSdaFabricResponse> DeleteBorderDeviceFromSdaFabricAsync(
			[Body]DeleteBorderDeviceFromSdaFabricRequest request,
			[AliasAs("deviceIPAddress")]string deviceIPAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get control plane device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get control plane device from SDA Fabric
		/// </remarks>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetControlPlaneDeviceFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/control-plane-device")]
		Task<GetControlPlaneDeviceFromSdaFabricResponse> GetControlPlaneDeviceFromSdaFabricAysnc(
			[AliasAs("deviceIPAddress")]string deviceIpAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get default authentication profile from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get default authentication profile from SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of GetDefaultAuthenticationProfileFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/authentication-profile")]
		Task<GetDefaultAuthenticationProfileFromSdaFabricResponse> GetDefaultAuthenticationProfileFromSdaFabricAsync(
			[Body]GetDefaultAuthenticationProfileFromSdaFabricRequest request,
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get device info from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get device info from SDA Fabric
		/// </remarks>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetDeviceInfoFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/device")]
		Task<GetDeviceInfoFromSdaFabricResponse> GetDeviceInfoFromSdaFabricAsync(
			[AliasAs("deviceIPAddress")]string deviceIpAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get edge device from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get edge device from SDA Fabric
		/// </remarks>
		/// <param name="deviceIpAddress">Device IP Address</param>
		/// <returns>Task of GetEdgeDeviceFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/edge-device")]
		Task<GetEdgeDeviceFromSdaFabricResponse> GetEdgeDeviceFromSdaFabricAsync(
			[AliasAs("deviceIPAddress")]string deviceIpAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get IP Pool from SDA Virtual Network
		/// </summary>
		/// <remarks>
		/// **BETA** - Get IP Pool from SDA Virtual Network
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="ipPoolName">ipPoolName</param>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <returns>Task of GetIPPoolFromSDAVirtualNetworkResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/virtualnetwork/ippool")]
		Task<GetIpPoolFromSdaVirtualNetworkResponse> GetIpPoolFromSdaVirtualNetworkAsync(
			[Body]GetIpPoolFromSdaVirtualNetworkRequest request,
			[AliasAs("ipPoolName")]string ipPoolName,
			[AliasAs("virtualNetworkName")]string virtualNetworkName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get Port assignment for access point in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Port assignment for access point in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of GetPortAssignmentForAccessPointInSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/hostonboarding/access-point")]
		Task<GetPortAssignmentForAccessPointInSdaFabricResponse> GetPortAssignmentForAccessPointInSdaFabricAsync(
			[Body]GetPortAssignmentForAccessPointInSdaFabricRequest request,
			[AliasAs("device_ip")]string deviceIp,
			[AliasAs("interfaceName")]string interfaceName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get Port assignment for user device in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Port assignment for user device in SDA Fabric.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="device_ip">device-ip</param>
		/// <param name="interfaceName">interfaceName</param>
		/// <returns>Task of GetPortAssignmentForUserDeviceInSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/hostonboarding/user-device")]
		Task<GetPortAssignmentForUserDeviceInSdaFabricResponse> GetPortAssignmentForUserDeviceInSdaFabricAsync(
			[Body]GetPortAssignmentForUserDeviceInSdaFabricRequest request,
			[AliasAs("device_ip")]string device_ip,
			[AliasAs("interfaceName")]string interfaceName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get SDA Fabric Info
		/// </summary>
		/// <remarks>
		/// **BETA** - Get SDA Fabric Info
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="fabricName">Fabric Name</param>
		/// <returns>Task of GetSdaFabricInfoResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/fabric")]
		Task<GetSdaFabricInfoResponse> GetSdaFabricInfoAsync(
			[Body]GetSdaFabricInfoRequest request,
			[AliasAs("fabricName")]string fabricName,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get Site from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get Site info from SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="siteNameHierarchy">Site Name Hierarchy</param>
		/// <returns>Task of GetSiteFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/fabric-site")]
		Task<GetSiteFromSdaFabricResponse> GetSiteFromSdaFabricAsync(
			[Body]GetSiteFromSdaFabricRequest request,
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Get VN from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Get virtual network (VN) from SDA Fabric
		/// </remarks>
		/// <param name="virtualNetworkName">virtualNetworkName</param>
		/// <param name="siteNameHierarchy">siteNameHierarchy</param>
		/// <returns>Task of GetVNFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/virtual-network")]
		Task<GetVnFromSdaFabricResponse> GetVnFromSdaFabricAsync(
			[AliasAs("virtualNetworkName")]string virtualNetworkName,
			[AliasAs("siteNameHierarchy")]string siteNameHierarchy,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Gets border device detail from SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Gets border device detail from SDA Fabric
		/// </remarks>
		/// <param name="deviceIPAddress">Device IP Address</param>
		/// <returns>Task of GetsBorderDeviceDetailFromSdaFabricResponse</returns>
		[Get("/dna/intent/api/v1/business/sda/border-device")]
		Task<GetsBorderDeviceDetailFromSdaFabricResponse> GetsBorderDeviceDetailFromSdaFabricAsync(
			[AliasAs("deviceIPAddress")]string deviceIPAddress,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// **BETA** - Update default authentication profile template in SDA Fabric
		/// </summary>
		/// <remarks>
		/// **BETA** - Update default authentication profile template in SDA Fabric
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse</returns>
		[Put("/dna/intent/api/v1/business/sda/authentication-profile")]
		Task<UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse> UpdateDefaultAuthenticationProfileTemplateInSdaFabricAsync(
			[Body]UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest request,
			CancellationToken cancellationToken = default);
	}
}
