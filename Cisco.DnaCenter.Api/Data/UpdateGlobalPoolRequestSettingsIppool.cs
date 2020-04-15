using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateGlobalPoolRequestSettingsIppool
	/// </summary>
	[DataContract]
	public partial class UpdateGlobalPoolRequestSettingsIppool
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateGlobalPoolRequestSettingsIppool" /> class.
		/// </summary>
		/// <param name="IpPoolName">IpPoolName.</param>
		/// <param name="Gateway">Gateway.</param>
		/// <param name="DhcpServerIps">DhcpServerIps.</param>
		/// <param name="DnsServerIps">DnsServerIps.</param>
		/// <param name="Id">Id.</param>
		public UpdateGlobalPoolRequestSettingsIppool(string? IpPoolName = default, string? Gateway = default, List<string> DhcpServerIps = default, List<string> DnsServerIps = default, string? Id = default)
		{
			this.IpPoolName = IpPoolName;
			this.Gateway = Gateway;
			this.DhcpServerIps = DhcpServerIps;
			this.DnsServerIps = DnsServerIps;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets IpPoolName
		/// </summary>
		[DataMember(Name = "ipPoolName", EmitDefaultValue = false)]
		public string? IpPoolName { get; set; }
		/// <summary>
		/// Gets or Sets Gateway
		/// </summary>
		[DataMember(Name = "gateway", EmitDefaultValue = false)]
		public string? Gateway { get; set; }
		/// <summary>
		/// Gets or Sets DhcpServerIps
		/// </summary>
		[DataMember(Name = "dhcpServerIps", EmitDefaultValue = false)]
		public List<string> DhcpServerIps { get; set; }
		/// <summary>
		/// Gets or Sets DnsServerIps
		/// </summary>
		[DataMember(Name = "dnsServerIps", EmitDefaultValue = false)]
		public List<string> DnsServerIps { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateGlobalPoolRequestSettingsIppool {\n");
			sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
			sb.Append("  Gateway: ").Append(Gateway).Append("\n");
			sb.Append("  DhcpServerIps: ").Append(DhcpServerIps).Append("\n");
			sb.Append("  DnsServerIps: ").Append(DnsServerIps).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
