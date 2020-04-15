using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoPrimaryEndpoint
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoPrimaryEndpoint
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoPrimaryEndpoint" /> class.
		/// </summary>
		/// <param name="Port">Port.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="Ipv4Address">Ipv4Address.</param>
		/// <param name="Ipv6Address">Ipv6Address.</param>
		/// <param name="Fqdn">Fqdn.</param>
		/// <param name="Certificate">Certificate.</param>
		public DeviceDeviceInfoPrimaryEndpoint(decimal? Port = default, string? Protocol = default, Object Ipv4Address = default, Object Ipv6Address = default, string? Fqdn = default, string? Certificate = default)
		{
			this.Port = Port;
			this.Protocol = Protocol;
			this.Ipv4Address = Ipv4Address;
			this.Ipv6Address = Ipv6Address;
			this.Fqdn = Fqdn;
			this.Certificate = Certificate;
		}

		/// <summary>
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public decimal? Port { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4Address
		/// </summary>
		[DataMember(Name = "ipv4Address", EmitDefaultValue = false)]
		public Object Ipv4Address { get; set; }
		/// <summary>
		/// Gets or Sets Ipv6Address
		/// </summary>
		[DataMember(Name = "ipv6Address", EmitDefaultValue = false)]
		public Object Ipv6Address { get; set; }
		/// <summary>
		/// Gets or Sets Fqdn
		/// </summary>
		[DataMember(Name = "fqdn", EmitDefaultValue = false)]
		public string? Fqdn { get; set; }
		/// <summary>
		/// Gets or Sets Certificate
		/// </summary>
		[DataMember(Name = "certificate", EmitDefaultValue = false)]
		public string? Certificate { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoPrimaryEndpoint {\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
			sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
			sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
			sb.Append("  Certificate: ").Append(Certificate).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
