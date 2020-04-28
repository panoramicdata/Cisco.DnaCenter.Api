using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress
	/// </summary>
	[DataContract]
	public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="PaddedAddress">PaddedAddress.</param>
		/// <param name="AddressType">AddressType.</param>
		/// <param name="Address">Address.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress(string? Id = default, string? PaddedAddress = default, string? AddressType = default, string? Address = default)
		{
			this.Id = Id;
			this.PaddedAddress = PaddedAddress;
			this.AddressType = AddressType;
			this.Address = Address;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets PaddedAddress
		/// </summary>
		[DataMember(Name = "paddedAddress", EmitDefaultValue = false)]
		public string? PaddedAddress { get; set; }

		/// <summary>
		/// Gets or Sets AddressType
		/// </summary>
		[DataMember(Name = "addressType", EmitDefaultValue = false)]
		public string? AddressType { get; set; }

		/// <summary>
		/// Gets or Sets Address
		/// </summary>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string? Address { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsIpAddress {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  PaddedAddress: ").Append(PaddedAddress).Append("\n");
			sb.Append("  AddressType: ").Append(AddressType).Append("\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
