using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff
/// </summary>
[DataContract]
public class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="InstanceId">InstanceId.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="InstanceTenantId">InstanceTenantId.</param>
	/// <param name="DeployPending">DeployPending.</param>
	/// <param name="InstanceVersion">InstanceVersion.</param>
	/// <param name="LocalIpAddress">LocalIpAddress.</param>
	/// <param name="RemoteIpAddress">RemoteIpAddress.</param>
	/// <param name="VlanId">VlanId.</param>
	/// <param name="VirtualNetwork">VirtualNetwork.</param>
	public GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff(string? Id = default, int? InstanceId = default, string? DisplayName = default, string? InstanceTenantId = default, string? DeployPending = default, decimal? InstanceVersion = default, string? LocalIpAddress = default, string? RemoteIpAddress = default, int? VlanId = default, EditApplicationRequestInnerApplicationSet VirtualNetwork = default)
	{
		this.Id = Id;
		this.InstanceId = InstanceId;
		this.DisplayName = DisplayName;
		this.InstanceTenantId = InstanceTenantId;
		this.DeployPending = DeployPending;
		this.InstanceVersion = InstanceVersion;
		this.LocalIpAddress = LocalIpAddress;
		this.RemoteIpAddress = RemoteIpAddress;
		this.VlanId = VlanId;
		this.VirtualNetwork = VirtualNetwork;
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
	public decimal? InstanceVersion { get; set; }

	/// <summary>
	/// Gets or Sets LocalIpAddress
	/// </summary>
	[DataMember(Name = "localIpAddress", EmitDefaultValue = false)]
	public string? LocalIpAddress { get; set; }

	/// <summary>
	/// Gets or Sets RemoteIpAddress
	/// </summary>
	[DataMember(Name = "remoteIpAddress", EmitDefaultValue = false)]
	public string? RemoteIpAddress { get; set; }

	/// <summary>
	/// Gets or Sets VlanId
	/// </summary>
	[DataMember(Name = "vlanId", EmitDefaultValue = false)]
	public int? VlanId { get; set; }

	/// <summary>
	/// Gets or Sets VirtualNetwork
	/// </summary>
	[DataMember(Name = "virtualNetwork", EmitDefaultValue = false)]
	public EditApplicationRequestInnerApplicationSet VirtualNetwork { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettingsL3Handoff {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
		sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
		sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
		sb.Append("  DeployPending: ").Append(DeployPending).Append("\n");
		sb.Append("  InstanceVersion: ").Append(InstanceVersion).Append("\n");
		sb.Append("  LocalIpAddress: ").Append(LocalIpAddress).Append("\n");
		sb.Append("  RemoteIpAddress: ").Append(RemoteIpAddress).Append("\n");
		sb.Append("  VlanId: ").Append(VlanId).Append("\n");
		sb.Append("  VirtualNetwork: ").Append(VirtualNetwork).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
