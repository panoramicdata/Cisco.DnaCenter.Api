using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequestSettings
	/// </summary>
	[DataContract]
	public class UpdateNetworkRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettings" /> class.
		/// </summary>
		/// <param name="DhcpServer">DhcpServer.</param>
		/// <param name="DnsServer">DnsServer.</param>
		/// <param name="SyslogServer">SyslogServer.</param>
		/// <param name="SnmpServer">SnmpServer.</param>
		/// <param name="Netflowcollector">Netflowcollector.</param>
		/// <param name="NtpServer">NtpServer.</param>
		/// <param name="Timezone">Timezone.</param>
		/// <param name="MessageOfTheday">MessageOfTheday.</param>
		/// <param name="NetworkAaa">NetworkAaa.</param>
		/// <param name="ClientAndEndpointAaa">ClientAndEndpointAaa.</param>
		public UpdateNetworkRequestSettings(List<string> DhcpServer = default, UpdateNetworkRequestSettingsDnsServer DnsServer = default, UpdateNetworkRequestSettingsSyslogServer SyslogServer = default, UpdateNetworkRequestSettingsSyslogServer SnmpServer = default, UpdateNetworkRequestSettingsNetflowcollector Netflowcollector = default, List<string> NtpServer = default, string? Timezone = default, UpdateNetworkRequestSettingsMessageOfTheday MessageOfTheday = default, UpdateNetworkRequestSettingsNetworkAaa NetworkAaa = default, UpdateNetworkRequestSettingsClientAndEndpointAaa ClientAndEndpointAaa = default)
		{
			this.DhcpServer = DhcpServer;
			this.DnsServer = DnsServer;
			this.SyslogServer = SyslogServer;
			this.SnmpServer = SnmpServer;
			this.Netflowcollector = Netflowcollector;
			this.NtpServer = NtpServer;
			this.Timezone = Timezone;
			this.MessageOfTheday = MessageOfTheday;
			this.NetworkAaa = NetworkAaa;
			this.ClientAndEndpointAaa = ClientAndEndpointAaa;
		}

		/// <summary>
		/// Gets or Sets DhcpServer
		/// </summary>
		[DataMember(Name = "dhcpServer", EmitDefaultValue = false)]
		public List<string> DhcpServer { get; set; }
		/// <summary>
		/// Gets or Sets DnsServer
		/// </summary>
		[DataMember(Name = "dnsServer", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsDnsServer DnsServer { get; set; }
		/// <summary>
		/// Gets or Sets SyslogServer
		/// </summary>
		[DataMember(Name = "syslogServer", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsSyslogServer SyslogServer { get; set; }
		/// <summary>
		/// Gets or Sets SnmpServer
		/// </summary>
		[DataMember(Name = "snmpServer", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsSyslogServer SnmpServer { get; set; }
		/// <summary>
		/// Gets or Sets Netflowcollector
		/// </summary>
		[DataMember(Name = "netflowcollector", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsNetflowcollector Netflowcollector { get; set; }
		/// <summary>
		/// Gets or Sets NtpServer
		/// </summary>
		[DataMember(Name = "ntpServer", EmitDefaultValue = false)]
		public List<string> NtpServer { get; set; }
		/// <summary>
		/// Gets or Sets Timezone
		/// </summary>
		[DataMember(Name = "timezone", EmitDefaultValue = false)]
		public string? Timezone { get; set; }
		/// <summary>
		/// Gets or Sets MessageOfTheday
		/// </summary>
		[DataMember(Name = "messageOfTheday", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsMessageOfTheday MessageOfTheday { get; set; }
		/// <summary>
		/// Gets or Sets NetworkAaa
		/// </summary>
		[DataMember(Name = "network_aaa", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsNetworkAaa NetworkAaa { get; set; }
		/// <summary>
		/// Gets or Sets ClientAndEndpointAaa
		/// </summary>
		[DataMember(Name = "clientAndEndpoint_aaa", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettingsClientAndEndpointAaa ClientAndEndpointAaa { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequestSettings {\n");
			sb.Append("  DhcpServer: ").Append(DhcpServer).Append("\n");
			sb.Append("  DnsServer: ").Append(DnsServer).Append("\n");
			sb.Append("  SyslogServer: ").Append(SyslogServer).Append("\n");
			sb.Append("  SnmpServer: ").Append(SnmpServer).Append("\n");
			sb.Append("  Netflowcollector: ").Append(Netflowcollector).Append("\n");
			sb.Append("  NtpServer: ").Append(NtpServer).Append("\n");
			sb.Append("  Timezone: ").Append(Timezone).Append("\n");
			sb.Append("  MessageOfTheday: ").Append(MessageOfTheday).Append("\n");
			sb.Append("  NetworkAaa: ").Append(NetworkAaa).Append("\n");
			sb.Append("  ClientAndEndpointAaa: ").Append(ClientAndEndpointAaa).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
