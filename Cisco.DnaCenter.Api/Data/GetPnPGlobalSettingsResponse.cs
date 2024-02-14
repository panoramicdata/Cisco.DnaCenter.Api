using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetPnpGlobalSettingsResponse
/// </summary>
[DataContract]
public class GetPnpGlobalSettingsResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetPnpGlobalSettingsResponse" /> class.
	/// </summary>
	/// <param name="SavaMappingList">SavaMappingList.</param>
	/// <param name="TaskTimeOuts">TaskTimeOuts.</param>
	/// <param name="TenantId">TenantId.</param>
	/// <param name="AaaCredentials">AaaCredentials.</param>
	/// <param name="DefaultProfile">DefaultProfile.</param>
	/// <param name="AcceptEula">AcceptEula.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Id">Id.</param>
	/// <param name="_Version">_Version.</param>
	public GetPnpGlobalSettingsResponse(List<GetPnpGlobalSettingsResponseSavaMappingList> SavaMappingList = default, GetPnpGlobalSettingsResponseTaskTimeOuts TaskTimeOuts = default, string? TenantId = default, DeviceDeviceInfoAaaCredentials AaaCredentials = default, GetPnpGlobalSettingsResponseDefaultProfile DefaultProfile = default, bool? AcceptEula = default, string? Id = default, string? _Id = default, decimal? _Version = default)
	{
		this.SavaMappingList = SavaMappingList;
		this.TaskTimeOuts = TaskTimeOuts;
		this.TenantId = TenantId;
		this.AaaCredentials = AaaCredentials;
		this.DefaultProfile = DefaultProfile;
		this.AcceptEula = AcceptEula;
		this.Id = Id;
		this.Id2 = _Id;
		this.Version = _Version;
	}

	/// <summary>
	/// Gets or Sets SavaMappingList
	/// </summary>
	[DataMember(Name = "savaMappingList", EmitDefaultValue = false)]
	public List<GetPnpGlobalSettingsResponseSavaMappingList> SavaMappingList { get; set; }

	/// <summary>
	/// Gets or Sets TaskTimeOuts
	/// </summary>
	[DataMember(Name = "taskTimeOuts", EmitDefaultValue = false)]
	public GetPnpGlobalSettingsResponseTaskTimeOuts TaskTimeOuts { get; set; }

	/// <summary>
	/// Gets or Sets TenantId
	/// </summary>
	[DataMember(Name = "tenantId", EmitDefaultValue = false)]
	public string? TenantId { get; set; }

	/// <summary>
	/// Gets or Sets AaaCredentials
	/// </summary>
	[DataMember(Name = "aaaCredentials", EmitDefaultValue = false)]
	public DeviceDeviceInfoAaaCredentials AaaCredentials { get; set; }

	/// <summary>
	/// Gets or Sets DefaultProfile
	/// </summary>
	[DataMember(Name = "defaultProfile", EmitDefaultValue = false)]
	public GetPnpGlobalSettingsResponseDefaultProfile DefaultProfile { get; set; }

	/// <summary>
	/// Gets or Sets AcceptEula
	/// </summary>
	[DataMember(Name = "acceptEula", EmitDefaultValue = false)]
	public bool? AcceptEula { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "_id", EmitDefaultValue = false)]
	public string? Id2 { get; set; }

	/// <summary>
	/// Gets or Sets _Version
	/// </summary>
	[DataMember(Name = "version", EmitDefaultValue = false)]
	public decimal? Version { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetPnpGlobalSettingsResponse {\n");
		sb.Append("  SavaMappingList: ").Append(SavaMappingList).Append("\n");
		sb.Append("  TaskTimeOuts: ").Append(TaskTimeOuts).Append("\n");
		sb.Append("  TenantId: ").Append(TenantId).Append("\n");
		sb.Append("  AaaCredentials: ").Append(AaaCredentials).Append("\n");
		sb.Append("  DefaultProfile: ").Append(DefaultProfile).Append("\n");
		sb.Append("  AcceptEula: ").Append(AcceptEula).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  _Id: ").Append(Id2).Append("\n");
		sb.Append("  _Version: ").Append(Version).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
