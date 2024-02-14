using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// WirelessInfoResultResponse
/// </summary>
[DataContract]
public class WirelessInfoResultResponse
{
	/// <summary>
	/// Gets or Sets WirelessLicenseInfo
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WirelessLicenseInfoEnum
	{

		/// <summary>
		/// Enum ADVANTAGE for "ADVANTAGE"
		/// </summary>
		[EnumMember(Value = "ADVANTAGE")]
		ADVANTAGE,

		/// <summary>
		/// Enum ESSENTIALS for "ESSENTIALS"
		/// </summary>
		[EnumMember(Value = "ESSENTIALS")]
		ESSENTIALS
	}

	/// <summary>
	/// Gets or Sets WirelessLicenseInfo
	/// </summary>
	[DataMember(Name = "wirelessLicenseInfo", EmitDefaultValue = false)]
	public WirelessLicenseInfoEnum? WirelessLicenseInfo { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="WirelessInfoResultResponse" /> class.
	/// </summary>
	/// <param name="AdminEnabledPorts">AdminEnabledPorts.</param>
	/// <param name="ApGroupName">ApGroupName.</param>
	/// <param name="DeviceId">DeviceId.</param>
	/// <param name="EthMacAddress">EthMacAddress.</param>
	/// <param name="FlexGroupName">FlexGroupName.</param>
	/// <param name="Id">Id.</param>
	/// <param name="InstanceTenantId">InstanceTenantId.</param>
	/// <param name="InstanceUuid">InstanceUuid.</param>
	/// <param name="LagModeEnabled">LagModeEnabled.</param>
	/// <param name="NetconfEnabled">NetconfEnabled.</param>
	/// <param name="WirelessLicenseInfo">WirelessLicenseInfo.</param>
	/// <param name="WirelessPackageInstalled">WirelessPackageInstalled.</param>
	public WirelessInfoResultResponse(List<int?> AdminEnabledPorts = default, string? ApGroupName = default, string? DeviceId = default, string? EthMacAddress = default, string? FlexGroupName = default, string? Id = default, string? InstanceTenantId = default, string? InstanceUuid = default, bool? LagModeEnabled = default, bool? NetconfEnabled = default, WirelessLicenseInfoEnum? WirelessLicenseInfo = default, bool? WirelessPackageInstalled = default)
	{
		this.AdminEnabledPorts = AdminEnabledPorts;
		this.ApGroupName = ApGroupName;
		this.DeviceId = DeviceId;
		this.EthMacAddress = EthMacAddress;
		this.FlexGroupName = FlexGroupName;
		this.Id = Id;
		this.InstanceTenantId = InstanceTenantId;
		this.InstanceUuid = InstanceUuid;
		this.LagModeEnabled = LagModeEnabled;
		this.NetconfEnabled = NetconfEnabled;
		this.WirelessLicenseInfo = WirelessLicenseInfo;
		this.WirelessPackageInstalled = WirelessPackageInstalled;
	}

	/// <summary>
	/// Gets or Sets AdminEnabledPorts
	/// </summary>
	[DataMember(Name = "adminEnabledPorts", EmitDefaultValue = false)]
	public List<int?> AdminEnabledPorts { get; set; }

	/// <summary>
	/// Gets or Sets ApGroupName
	/// </summary>
	[DataMember(Name = "apGroupName", EmitDefaultValue = false)]
	public string? ApGroupName { get; set; }

	/// <summary>
	/// Gets or Sets DeviceId
	/// </summary>
	[DataMember(Name = "deviceId", EmitDefaultValue = false)]
	public string? DeviceId { get; set; }

	/// <summary>
	/// Gets or Sets EthMacAddress
	/// </summary>
	[DataMember(Name = "ethMacAddress", EmitDefaultValue = false)]
	public string? EthMacAddress { get; set; }

	/// <summary>
	/// Gets or Sets FlexGroupName
	/// </summary>
	[DataMember(Name = "flexGroupName", EmitDefaultValue = false)]
	public string? FlexGroupName { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets InstanceTenantId
	/// </summary>
	[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
	public string? InstanceTenantId { get; set; }

	/// <summary>
	/// Gets or Sets InstanceUuid
	/// </summary>
	[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
	public string? InstanceUuid { get; set; }

	/// <summary>
	/// Gets or Sets LagModeEnabled
	/// </summary>
	[DataMember(Name = "lagModeEnabled", EmitDefaultValue = false)]
	public bool? LagModeEnabled { get; set; }

	/// <summary>
	/// Gets or Sets NetconfEnabled
	/// </summary>
	[DataMember(Name = "netconfEnabled", EmitDefaultValue = false)]
	public bool? NetconfEnabled { get; set; }

	/// <summary>
	/// Gets or Sets WirelessPackageInstalled
	/// </summary>
	[DataMember(Name = "wirelessPackageInstalled", EmitDefaultValue = false)]
	public bool? WirelessPackageInstalled { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class WirelessInfoResultResponse {\n");
		sb.Append("  AdminEnabledPorts: ").Append(AdminEnabledPorts).Append("\n");
		sb.Append("  ApGroupName: ").Append(ApGroupName).Append("\n");
		sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
		sb.Append("  EthMacAddress: ").Append(EthMacAddress).Append("\n");
		sb.Append("  FlexGroupName: ").Append(FlexGroupName).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
		sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
		sb.Append("  LagModeEnabled: ").Append(LagModeEnabled).Append("\n");
		sb.Append("  NetconfEnabled: ").Append(NetconfEnabled).Append("\n");
		sb.Append("  WirelessLicenseInfo: ").Append(WirelessLicenseInfo).Append("\n");
		sb.Append("  WirelessPackageInstalled: ").Append(WirelessPackageInstalled).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
