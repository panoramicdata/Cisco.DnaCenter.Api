using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDns
	/// </summary>
	[DataContract]
	public partial class GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDns
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDns" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DomainName">DomainName.</param>
		/// <param name="Ip">Ip.</param>
		public GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDns(string? Id = default, string? DomainName = default, GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsIpAddress Ip = default)
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
		public GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsIpAddress Ip { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSDAFabricResponsePayloadNetworkWideSettingsDns {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DomainName: ").Append(DomainName).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
