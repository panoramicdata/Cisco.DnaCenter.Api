using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings
	/// </summary>
	[DataContract]
	public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceId">InstanceId.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="DeployPending">DeployPending.</param>
		/// <param name="InstanceVersion">InstanceVersion.</param>
		/// <param name="ConnectedTo">ConnectedTo.</param>
		/// <param name="Cpu">Cpu.</param>
		/// <param name="DhcpEnabled">DhcpEnabled.</param>
		/// <param name="ExternalConnectivityIpPool">ExternalConnectivityIpPool.</param>
		/// <param name="ExternalDomainRoutingProtocol">ExternalDomainRoutingProtocol.</param>
		/// <param name="InternalDomainProtocolNumber">InternalDomainProtocolNumber.</param>
		/// <param name="Memory">Memory.</param>
		/// <param name="NodeType">NodeType.</param>
		/// <param name="Storage">Storage.</param>
		/// <param name="ExtConnectivitySettings">ExtConnectivitySettings.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings(string? Id = default, int? InstanceId = default, string? DisplayName = default, string? InstanceTenantId = default, string? DeployPending = default, int? InstanceVersion = default, List<Object> ConnectedTo = default, decimal? Cpu = default, bool? DhcpEnabled = default, string? ExternalConnectivityIpPool = default, string? ExternalDomainRoutingProtocol = default, string? InternalDomainProtocolNumber = default, decimal? Memory = default, List<string> NodeType = default, decimal? Storage = default, List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings> ExtConnectivitySettings = default)
		{
			this.Id = Id;
			this.InstanceId = InstanceId;
			this.DisplayName = DisplayName;
			this.InstanceTenantId = InstanceTenantId;
			this.DeployPending = DeployPending;
			this.InstanceVersion = InstanceVersion;
			this.ConnectedTo = ConnectedTo;
			this.Cpu = Cpu;
			this.DhcpEnabled = DhcpEnabled;
			this.ExternalConnectivityIpPool = ExternalConnectivityIpPool;
			this.ExternalDomainRoutingProtocol = ExternalDomainRoutingProtocol;
			this.InternalDomainProtocolNumber = InternalDomainProtocolNumber;
			this.Memory = Memory;
			this.NodeType = NodeType;
			this.Storage = Storage;
			this.ExtConnectivitySettings = ExtConnectivitySettings;
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
		/// Gets or Sets ConnectedTo
		/// </summary>
		[DataMember(Name = "connectedTo", EmitDefaultValue = false)]
		public List<Object> ConnectedTo { get; set; }
		/// <summary>
		/// Gets or Sets Cpu
		/// </summary>
		[DataMember(Name = "cpu", EmitDefaultValue = false)]
		public decimal? Cpu { get; set; }
		/// <summary>
		/// Gets or Sets DhcpEnabled
		/// </summary>
		[DataMember(Name = "dhcpEnabled", EmitDefaultValue = false)]
		public bool? DhcpEnabled { get; set; }
		/// <summary>
		/// Gets or Sets ExternalConnectivityIpPool
		/// </summary>
		[DataMember(Name = "externalConnectivityIpPool", EmitDefaultValue = false)]
		public string? ExternalConnectivityIpPool { get; set; }
		/// <summary>
		/// Gets or Sets ExternalDomainRoutingProtocol
		/// </summary>
		[DataMember(Name = "externalDomainRoutingProtocol", EmitDefaultValue = false)]
		public string? ExternalDomainRoutingProtocol { get; set; }
		/// <summary>
		/// Gets or Sets InternalDomainProtocolNumber
		/// </summary>
		[DataMember(Name = "internalDomainProtocolNumber", EmitDefaultValue = false)]
		public string? InternalDomainProtocolNumber { get; set; }
		/// <summary>
		/// Gets or Sets Memory
		/// </summary>
		[DataMember(Name = "memory", EmitDefaultValue = false)]
		public decimal? Memory { get; set; }
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "nodeType", EmitDefaultValue = false)]
		public List<string> NodeType { get; set; }
		/// <summary>
		/// Gets or Sets Storage
		/// </summary>
		[DataMember(Name = "storage", EmitDefaultValue = false)]
		public decimal? Storage { get; set; }
		/// <summary>
		/// Gets or Sets ExtConnectivitySettings
		/// </summary>
		[DataMember(Name = "extConnectivitySettings", EmitDefaultValue = false)]
		public List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings> ExtConnectivitySettings { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  DeployPending: ").Append(DeployPending).Append("\n");
			sb.Append("  InstanceVersion: ").Append(InstanceVersion).Append("\n");
			sb.Append("  ConnectedTo: ").Append(ConnectedTo).Append("\n");
			sb.Append("  Cpu: ").Append(Cpu).Append("\n");
			sb.Append("  DhcpEnabled: ").Append(DhcpEnabled).Append("\n");
			sb.Append("  ExternalConnectivityIpPool: ").Append(ExternalConnectivityIpPool).Append("\n");
			sb.Append("  ExternalDomainRoutingProtocol: ").Append(ExternalDomainRoutingProtocol).Append("\n");
			sb.Append("  InternalDomainProtocolNumber: ").Append(InternalDomainProtocolNumber).Append("\n");
			sb.Append("  Memory: ").Append(Memory).Append("\n");
			sb.Append("  NodeType: ").Append(NodeType).Append("\n");
			sb.Append("  Storage: ").Append(Storage).Append("\n");
			sb.Append("  ExtConnectivitySettings: ").Append(ExtConnectivitySettings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
