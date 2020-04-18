using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestCustomNetworks1
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestCustomNetworks1
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestCustomNetworks1" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Port">Port.</param>
		/// <param name="IpAddressPool">IpAddressPool.</param>
		public ProvisionNfvRequestCustomNetworks1(string? Name = default, string? Port = default, string? IpAddressPool = default)
		{
			this.Name = Name;
			this.Port = Port;
			this.IpAddressPool = IpAddressPool;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public string? Port { get; set; }
		/// <summary>
		/// Gets or Sets IpAddressPool
		/// </summary>
		[DataMember(Name = "ipAddressPool", EmitDefaultValue = false)]
		public string? IpAddressPool { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestCustomNetworks1 {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("  IpAddressPool: ").Append(IpAddressPool).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
