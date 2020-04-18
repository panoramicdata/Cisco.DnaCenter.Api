using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings
	/// </summary>
	[DataContract]
	public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceId">InstanceId.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="DeployPending">DeployPending.</param>
		/// <param name="InstanceVersion">InstanceVersion.</param>
		/// <param name="Aaa">Aaa.</param>
		/// <param name="Cmx">Cmx.</param>
		/// <param name="Dhcp">Dhcp.</param>
		/// <param name="Dns">Dns.</param>
		/// <param name="Ldap">Ldap.</param>
		/// <param name="NativeVlan">NativeVlan.</param>
		/// <param name="Netflow">Netflow.</param>
		/// <param name="Ntp">Ntp.</param>
		/// <param name="Snmp">Snmp.</param>
		/// <param name="Syslogs">Syslogs.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings(string? Id = default, int? InstanceId = default, string? DisplayName = default, string? InstanceTenantId = default, string? DeployPending = default, int? InstanceVersion = default, List<Object> Aaa = default, List<Object> Cmx = default, List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp> Dhcp = default, List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns> Dns = default, List<Object> Ldap = default, List<Object> NativeVlan = default, List<Object> Netflow = default, List<Object> Ntp = default, List<Object> Snmp = default, List<Object> Syslogs = default)
		{
			this.Id = Id;
			this.InstanceId = InstanceId;
			this.DisplayName = DisplayName;
			this.InstanceTenantId = InstanceTenantId;
			this.DeployPending = DeployPending;
			this.InstanceVersion = InstanceVersion;
			this.Aaa = Aaa;
			this.Cmx = Cmx;
			this.Dhcp = Dhcp;
			this.Dns = Dns;
			this.Ldap = Ldap;
			this.NativeVlan = NativeVlan;
			this.Netflow = Netflow;
			this.Ntp = Ntp;
			this.Snmp = Snmp;
			this.Syslogs = Syslogs;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets InstanceId
		/// </summary>
		[DataMember(Name = "instanceId", EmitDefaultValue = false)]
		public int? InstanceId { get; set; }
		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string? DisplayName { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Gets or Sets DeployPending
		/// </summary>
		[DataMember(Name = "deployPending", EmitDefaultValue = false)]
		public string? DeployPending { get; set; }
		/// <summary>
		/// Gets or Sets InstanceVersion
		/// </summary>
		[DataMember(Name = "instanceVersion", EmitDefaultValue = false)]
		public int? InstanceVersion { get; set; }
		/// <summary>
		/// Gets or Sets Aaa
		/// </summary>
		[DataMember(Name = "aaa", EmitDefaultValue = false)]
		public List<Object> Aaa { get; set; }
		/// <summary>
		/// Gets or Sets Cmx
		/// </summary>
		[DataMember(Name = "cmx", EmitDefaultValue = false)]
		public List<Object> Cmx { get; set; }
		/// <summary>
		/// Gets or Sets Dhcp
		/// </summary>
		[DataMember(Name = "dhcp", EmitDefaultValue = false)]
		public List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDhcp> Dhcp { get; set; }
		/// <summary>
		/// Gets or Sets Dns
		/// </summary>
		[DataMember(Name = "dns", EmitDefaultValue = false)]
		public List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettingsDns> Dns { get; set; }
		/// <summary>
		/// Gets or Sets Ldap
		/// </summary>
		[DataMember(Name = "ldap", EmitDefaultValue = false)]
		public List<Object> Ldap { get; set; }
		/// <summary>
		/// Gets or Sets NativeVlan
		/// </summary>
		[DataMember(Name = "nativeVlan", EmitDefaultValue = false)]
		public List<Object> NativeVlan { get; set; }
		/// <summary>
		/// Gets or Sets Netflow
		/// </summary>
		[DataMember(Name = "netflow", EmitDefaultValue = false)]
		public List<Object> Netflow { get; set; }
		/// <summary>
		/// Gets or Sets Ntp
		/// </summary>
		[DataMember(Name = "ntp", EmitDefaultValue = false)]
		public List<Object> Ntp { get; set; }
		/// <summary>
		/// Gets or Sets Snmp
		/// </summary>
		[DataMember(Name = "snmp", EmitDefaultValue = false)]
		public List<Object> Snmp { get; set; }
		/// <summary>
		/// Gets or Sets Syslogs
		/// </summary>
		[DataMember(Name = "syslogs", EmitDefaultValue = false)]
		public List<Object> Syslogs { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  DeployPending: ").Append(DeployPending).Append("\n");
			sb.Append("  InstanceVersion: ").Append(InstanceVersion).Append("\n");
			sb.Append("  Aaa: ").Append(Aaa).Append("\n");
			sb.Append("  Cmx: ").Append(Cmx).Append("\n");
			sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
			sb.Append("  Dns: ").Append(Dns).Append("\n");
			sb.Append("  Ldap: ").Append(Ldap).Append("\n");
			sb.Append("  NativeVlan: ").Append(NativeVlan).Append("\n");
			sb.Append("  Netflow: ").Append(Netflow).Append("\n");
			sb.Append("  Ntp: ").Append(Ntp).Append("\n");
			sb.Append("  Snmp: ").Append(Snmp).Append("\n");
			sb.Append("  Syslogs: ").Append(Syslogs).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
