using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSdaFabricInfoRequestInner
	/// </summary>
	[DataContract]
	public class GetSdaFabricInfoRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSdaFabricInfoRequestInner" /> class.
		/// </summary>
		/// <param name="DeviceManagementIpAddress">DeviceManagementIpAddress.</param>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		public GetSdaFabricInfoRequestInner(string? DeviceManagementIpAddress = default, string? SiteNameHierarchy = default)
		{
			this.DeviceManagementIpAddress = DeviceManagementIpAddress;
			this.SiteNameHierarchy = SiteNameHierarchy;
		}

		/// <summary>
		/// Gets or Sets DeviceManagementIpAddress
		/// </summary>
		[DataMember(Name = "deviceManagementIpAddress", EmitDefaultValue = false)]
		public string? DeviceManagementIpAddress { get; set; }

		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSdaFabricInfoRequestInner {\n");
			sb.Append("  DeviceManagementIpAddress: ").Append(DeviceManagementIpAddress).Append("\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
