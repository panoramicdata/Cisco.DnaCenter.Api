using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetControlPlaneDeviceFromSDAFabricResponse
	/// </summary>
	[DataContract]
	public partial class GetControlPlaneDeviceFromSDAFabricResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetControlPlaneDeviceFromSDAFabricResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Roles">Roles.</param>
		/// <param name="DeviceManagementIpAddress">DeviceManagementIpAddress.</param>
		/// <param name="SiteHierarchy">SiteHierarchy.</param>
		public GetControlPlaneDeviceFromSDAFabricResponse(string? Status = default, string? Description = default, string? Name = default, List<string> Roles = default, string? DeviceManagementIpAddress = default, string? SiteHierarchy = default)
		{
			this.Status = Status;
			this.Description = Description;
			this.Name = Name;
			this.Roles = Roles;
			this.DeviceManagementIpAddress = DeviceManagementIpAddress;
			this.SiteHierarchy = SiteHierarchy;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Roles
		/// </summary>
		[DataMember(Name = "roles", EmitDefaultValue = false)]
		public List<string> Roles { get; set; }
		/// <summary>
		/// Gets or Sets DeviceManagementIpAddress
		/// </summary>
		[DataMember(Name = "deviceManagementIpAddress", EmitDefaultValue = false)]
		public string? DeviceManagementIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets SiteHierarchy
		/// </summary>
		[DataMember(Name = "siteHierarchy", EmitDefaultValue = false)]
		public string? SiteHierarchy { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetControlPlaneDeviceFromSDAFabricResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Roles: ").Append(Roles).Append("\n");
			sb.Append("  DeviceManagementIpAddress: ").Append(DeviceManagementIpAddress).Append("\n");
			sb.Append("  SiteHierarchy: ").Append(SiteHierarchy).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
