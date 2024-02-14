using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp
/// </summary>
[DataContract]
public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="IpAddress">IpAddress.</param>
	public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp(string? Id = default, GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress IpAddress = default)
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
	public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress IpAddress { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
