using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeviceDeviceInfoStackInfo
/// </summary>
[DataContract]
public class DeviceDeviceInfoStackInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeviceDeviceInfoStackInfo" /> class.
	/// </summary>
	/// <param name="SupportsStackWorkflows">SupportsStackWorkflows.</param>
	/// <param name="IsFullRing">IsFullRing.</param>
	/// <param name="StackMemberList">StackMemberList.</param>
	/// <param name="StackRingProtocol">StackRingProtocol.</param>
	/// <param name="ValidLicenseLevels">ValidLicenseLevels.</param>
	/// <param name="TotalMemberCount">TotalMemberCount.</param>
	public DeviceDeviceInfoStackInfo(bool? SupportsStackWorkflows = default, bool? IsFullRing = default, List<DeviceDeviceInfoStackInfoStackMemberList> StackMemberList = default, string? StackRingProtocol = default, List<string> ValidLicenseLevels = default, decimal? TotalMemberCount = default)
	{
		this.SupportsStackWorkflows = SupportsStackWorkflows;
		this.IsFullRing = IsFullRing;
		this.StackMemberList = StackMemberList;
		this.StackRingProtocol = StackRingProtocol;
		this.ValidLicenseLevels = ValidLicenseLevels;
		this.TotalMemberCount = TotalMemberCount;
	}

	/// <summary>
	/// Gets or Sets SupportsStackWorkflows
	/// </summary>
	[DataMember(Name = "supportsStackWorkflows", EmitDefaultValue = false)]
	public bool? SupportsStackWorkflows { get; set; }

	/// <summary>
	/// Gets or Sets IsFullRing
	/// </summary>
	[DataMember(Name = "isFullRing", EmitDefaultValue = false)]
	public bool? IsFullRing { get; set; }

	/// <summary>
	/// Gets or Sets StackMemberList
	/// </summary>
	[DataMember(Name = "stackMemberList", EmitDefaultValue = false)]
	public List<DeviceDeviceInfoStackInfoStackMemberList> StackMemberList { get; set; }

	/// <summary>
	/// Gets or Sets StackRingProtocol
	/// </summary>
	[DataMember(Name = "stackRingProtocol", EmitDefaultValue = false)]
	public string? StackRingProtocol { get; set; }

	/// <summary>
	/// Gets or Sets ValidLicenseLevels
	/// </summary>
	[DataMember(Name = "validLicenseLevels", EmitDefaultValue = false)]
	public List<string> ValidLicenseLevels { get; set; }

	/// <summary>
	/// Gets or Sets TotalMemberCount
	/// </summary>
	[DataMember(Name = "totalMemberCount", EmitDefaultValue = false)]
	public decimal? TotalMemberCount { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceDeviceInfoStackInfo {\n");
		sb.Append("  SupportsStackWorkflows: ").Append(SupportsStackWorkflows).Append("\n");
		sb.Append("  IsFullRing: ").Append(IsFullRing).Append("\n");
		sb.Append("  StackMemberList: ").Append(StackMemberList).Append("\n");
		sb.Append("  StackRingProtocol: ").Append(StackRingProtocol).Append("\n");
		sb.Append("  ValidLicenseLevels: ").Append(ValidLicenseLevels).Append("\n");
		sb.Append("  TotalMemberCount: ").Append(TotalMemberCount).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
