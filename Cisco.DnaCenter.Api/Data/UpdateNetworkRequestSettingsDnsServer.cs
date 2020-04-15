using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequestSettingsDnsServer
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkRequestSettingsDnsServer
	{
		/// <summary>
		/// Gets or Sets DomainName
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DomainNameEnum
		{

			/// <summary>
			/// Enum Hyphen for "can only contain alphanumeric characters or hyphen"
			/// </summary>
			[EnumMember(Value = "can only contain alphanumeric characters or hyphen")]
			Hyphen
		}

		/// <summary>
		/// Gets or Sets PrimaryIpAddress
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum PrimaryIpAddressEnum
		{

			/// <summary>
			/// Enum _255 for "valid range : 1.0.0.0 - 223.255.255.255"
			/// </summary>
			[EnumMember(Value = "valid range : 1.0.0.0 - 223.255.255.255")]
			_255
		}

		/// <summary>
		/// Gets or Sets SecondaryIpAddress
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SecondaryIpAddressEnum
		{

			/// <summary>
			/// Enum _255 for "valid range : 1.0.0.0 - 223.255.255.255"
			/// </summary>
			[EnumMember(Value = "valid range : 1.0.0.0 - 223.255.255.255")]
			_255
		}

		/// <summary>
		/// Gets or Sets DomainName
		/// </summary>
		[DataMember(Name = "domainName", EmitDefaultValue = false)]
		public DomainNameEnum? DomainName { get; set; }
		/// <summary>
		/// Gets or Sets PrimaryIpAddress
		/// </summary>
		[DataMember(Name = "primaryIpAddress", EmitDefaultValue = false)]
		public PrimaryIpAddressEnum? PrimaryIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets SecondaryIpAddress
		/// </summary>
		[DataMember(Name = "secondaryIpAddress", EmitDefaultValue = false)]
		public SecondaryIpAddressEnum? SecondaryIpAddress { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettingsDnsServer" /> class.
		/// </summary>
		/// <param name="DomainName">DomainName.</param>
		/// <param name="PrimaryIpAddress">PrimaryIpAddress.</param>
		/// <param name="SecondaryIpAddress">SecondaryIpAddress.</param>
		public UpdateNetworkRequestSettingsDnsServer(DomainNameEnum? DomainName = default, PrimaryIpAddressEnum? PrimaryIpAddress = default, SecondaryIpAddressEnum? SecondaryIpAddress = default)
		{
			this.DomainName = DomainName;
			this.PrimaryIpAddress = PrimaryIpAddress;
			this.SecondaryIpAddress = SecondaryIpAddress;
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequestSettingsDnsServer {\n");
			sb.Append("  DomainName: ").Append(DomainName).Append("\n");
			sb.Append("  PrimaryIpAddress: ").Append(PrimaryIpAddress).Append("\n");
			sb.Append("  SecondaryIpAddress: ").Append(SecondaryIpAddress).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
