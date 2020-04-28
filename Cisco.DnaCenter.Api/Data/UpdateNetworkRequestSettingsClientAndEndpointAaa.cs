using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequestSettingsClientAndEndpointAaa
	/// </summary>
	[DataContract]
	public class UpdateNetworkRequestSettingsClientAndEndpointAaa
	{
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum IpAddressEnum
		{

			/// <summary>
			/// Enum MandatoryforISEservers for "Mandatory for ISE servers."
			/// </summary>
			[EnumMember(Value = "Mandatory for ISE servers.")]
			MandatoryforISEservers
		}

		/// <summary>
		/// Gets or Sets SharedSecret
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SharedSecretEnum
		{

			/// <summary>
			/// Enum Servers for "Supported only by ISE servers"
			/// </summary>
			[EnumMember(Value = "Supported only by ISE servers")]
			Servers
		}

		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public IpAddressEnum? IpAddress { get; set; }

		/// <summary>
		/// Gets or Sets SharedSecret
		/// </summary>
		[DataMember(Name = "sharedSecret", EmitDefaultValue = false)]
		public SharedSecretEnum? SharedSecret { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettingsClientAndEndpointAaa" /> class.
		/// </summary>
		/// <param name="Servers">Servers.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="Network">Network.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="SharedSecret">SharedSecret.</param>
		public UpdateNetworkRequestSettingsClientAndEndpointAaa(string? Servers = default, IpAddressEnum? IpAddress = default, string? Network = default, string? Protocol = default, SharedSecretEnum? SharedSecret = default)
		{
			this.Servers = Servers;
			this.IpAddress = IpAddress;
			this.Network = Network;
			this.Protocol = Protocol;
			this.SharedSecret = SharedSecret;
		}

		/// <summary>
		/// Gets or Sets Servers
		/// </summary>
		[DataMember(Name = "servers", EmitDefaultValue = false)]
		public string? Servers { get; set; }

		/// <summary>
		/// Gets or Sets Network
		/// </summary>
		[DataMember(Name = "network", EmitDefaultValue = false)]
		public string? Network { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequestSettingsClientAndEndpointAaa {\n");
			sb.Append("  Servers: ").Append(Servers).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  Network: ").Append(Network).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
