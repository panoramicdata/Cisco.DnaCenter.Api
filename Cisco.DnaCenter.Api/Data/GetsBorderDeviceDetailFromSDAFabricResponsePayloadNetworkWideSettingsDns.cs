using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns
	/// </summary>
	[DataContract]
	public partial class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DomainName">DomainName.</param>
		/// <param name="Ip">Ip.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns(string? Id = default, string? DomainName = default, GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress Ip = default)
		{
			this.Id = Id;
			this.DomainName = DomainName;
			this.Ip = Ip;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets DomainName
		/// </summary>
		[DataMember(Name = "domainName", EmitDefaultValue = false)]
		public string? DomainName { get; set; }
		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress Ip { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DomainName: ").Append(DomainName).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
