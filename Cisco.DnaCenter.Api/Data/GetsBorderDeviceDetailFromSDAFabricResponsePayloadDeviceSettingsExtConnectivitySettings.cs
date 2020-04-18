using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings
	/// </summary>
	[DataContract]
	public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceId">InstanceId.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="DeployPending">DeployPending.</param>
		/// <param name="InstanceVersion">InstanceVersion.</param>
		/// <param name="ExternalDomainProtocolNumber">ExternalDomainProtocolNumber.</param>
		/// <param name="InterfaceUuid">InterfaceUuid.</param>
		/// <param name="PolicyPropagationEnabled">PolicyPropagationEnabled.</param>
		/// <param name="PolicySgtTag">PolicySgtTag.</param>
		/// <param name="L2Handoff">L2Handoff.</param>
		/// <param name="L3Handoff">L3Handoff.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings(string? Id = default, int? InstanceId = default, string? DisplayName = default, string? InstanceTenantId = default, string? DeployPending = default, int? InstanceVersion = default, string? ExternalDomainProtocolNumber = default, string? InterfaceUuid = default, bool? PolicyPropagationEnabled = default, decimal? PolicySgtTag = default, List<Object> L2Handoff = default, List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff> L3Handoff = default)
		{
			this.Id = Id;
			this.InstanceId = InstanceId;
			this.DisplayName = DisplayName;
			this.InstanceTenantId = InstanceTenantId;
			this.DeployPending = DeployPending;
			this.InstanceVersion = InstanceVersion;
			this.ExternalDomainProtocolNumber = ExternalDomainProtocolNumber;
			this.InterfaceUuid = InterfaceUuid;
			this.PolicyPropagationEnabled = PolicyPropagationEnabled;
			this.PolicySgtTag = PolicySgtTag;
			this.L2Handoff = L2Handoff;
			this.L3Handoff = L3Handoff;
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
		/// Gets or Sets ExternalDomainProtocolNumber
		/// </summary>
		[DataMember(Name = "externalDomainProtocolNumber", EmitDefaultValue = false)]
		public string? ExternalDomainProtocolNumber { get; set; }
		/// <summary>
		/// Gets or Sets InterfaceUuid
		/// </summary>
		[DataMember(Name = "interfaceUuid", EmitDefaultValue = false)]
		public string? InterfaceUuid { get; set; }
		/// <summary>
		/// Gets or Sets PolicyPropagationEnabled
		/// </summary>
		[DataMember(Name = "policyPropagationEnabled", EmitDefaultValue = false)]
		public bool? PolicyPropagationEnabled { get; set; }
		/// <summary>
		/// Gets or Sets PolicySgtTag
		/// </summary>
		[DataMember(Name = "policySgtTag", EmitDefaultValue = false)]
		public decimal? PolicySgtTag { get; set; }
		/// <summary>
		/// Gets or Sets L2Handoff
		/// </summary>
		[DataMember(Name = "l2Handoff", EmitDefaultValue = false)]
		public List<Object> L2Handoff { get; set; }
		/// <summary>
		/// Gets or Sets L3Handoff
		/// </summary>
		[DataMember(Name = "l3Handoff", EmitDefaultValue = false)]
		public List<GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff> L3Handoff { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsExtConnectivitySettings {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  DeployPending: ").Append(DeployPending).Append("\n");
			sb.Append("  InstanceVersion: ").Append(InstanceVersion).Append("\n");
			sb.Append("  ExternalDomainProtocolNumber: ").Append(ExternalDomainProtocolNumber).Append("\n");
			sb.Append("  InterfaceUuid: ").Append(InterfaceUuid).Append("\n");
			sb.Append("  PolicyPropagationEnabled: ").Append(PolicyPropagationEnabled).Append("\n");
			sb.Append("  PolicySgtTag: ").Append(PolicySgtTag).Append("\n");
			sb.Append("  L2Handoff: ").Append(L2Handoff).Append("\n");
			sb.Append("  L3Handoff: ").Append(L3Handoff).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
