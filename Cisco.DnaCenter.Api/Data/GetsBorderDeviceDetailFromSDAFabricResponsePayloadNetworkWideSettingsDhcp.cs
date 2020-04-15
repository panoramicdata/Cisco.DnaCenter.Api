using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDhcp
	/// </summary>
	[DataContract]
	public partial class GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDhcp
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDhcp" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IpAddress">IpAddress.</param>
		public GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDhcp(string? Id = default, GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsIpAddress IpAddress = default)
		{
			this.Id = Id;
			this.IpAddress = IpAddress;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsIpAddress IpAddress { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDhcp {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
