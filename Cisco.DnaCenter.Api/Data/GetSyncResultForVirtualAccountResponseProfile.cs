using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSyncResultForVirtualAccountResponseProfile
	/// </summary>
	[DataContract]
	public class GetSyncResultForVirtualAccountResponseProfile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSyncResultForVirtualAccountResponseProfile" /> class.
		/// </summary>
		/// <param name="Proxy">Proxy.</param>
		/// <param name="MakeDefault">MakeDefault.</param>
		/// <param name="Port">Port.</param>
		/// <param name="ProfileId">ProfileId.</param>
		/// <param name="Name">Name.</param>
		/// <param name="AddressIpV4">AddressIpV4.</param>
		/// <param name="Cert">Cert.</param>
		/// <param name="AddressFqdn">AddressFqdn.</param>
		public GetSyncResultForVirtualAccountResponseProfile(bool? Proxy = default, bool? MakeDefault = default, decimal? Port = default, string? ProfileId = default, string? Name = default, string? AddressIpV4 = default, string? Cert = default, string? AddressFqdn = default)
		{
			this.Proxy = Proxy;
			this.MakeDefault = MakeDefault;
			this.Port = Port;
			this.ProfileId = ProfileId;
			this.Name = Name;
			this.AddressIpV4 = AddressIpV4;
			this.Cert = Cert;
			this.AddressFqdn = AddressFqdn;
		}

		/// <summary>
		/// Gets or Sets Proxy
		/// </summary>
		[DataMember(Name = "proxy", EmitDefaultValue = false)]
		public bool? Proxy { get; set; }
		/// <summary>
		/// Gets or Sets MakeDefault
		/// </summary>
		[DataMember(Name = "makeDefault", EmitDefaultValue = false)]
		public bool? MakeDefault { get; set; }
		/// <summary>
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public decimal? Port { get; set; }
		/// <summary>
		/// Gets or Sets ProfileId
		/// </summary>
		[DataMember(Name = "profileId", EmitDefaultValue = false)]
		public string? ProfileId { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets AddressIpV4
		/// </summary>
		[DataMember(Name = "addressIpV4", EmitDefaultValue = false)]
		public string? AddressIpV4 { get; set; }
		/// <summary>
		/// Gets or Sets Cert
		/// </summary>
		[DataMember(Name = "cert", EmitDefaultValue = false)]
		public string? Cert { get; set; }
		/// <summary>
		/// Gets or Sets AddressFqdn
		/// </summary>
		[DataMember(Name = "addressFqdn", EmitDefaultValue = false)]
		public string? AddressFqdn { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSyncResultForVirtualAccountResponseProfile {\n");
			sb.Append("  Proxy: ").Append(Proxy).Append("\n");
			sb.Append("  MakeDefault: ").Append(MakeDefault).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  AddressIpV4: ").Append(AddressIpV4).Append("\n");
			sb.Append("  Cert: ").Append(Cert).Append("\n");
			sb.Append("  AddressFqdn: ").Append(AddressFqdn).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
