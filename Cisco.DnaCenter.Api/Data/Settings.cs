using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public class Settings
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Settings" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="AaaCredentials">AaaCredentials.</param>
	/// <param name="AcceptEula">AcceptEula.</param>
	/// <param name="DefaultProfile">DefaultProfile.</param>
	/// <param name="SavaMappingList">SavaMappingList.</param>
	/// <param name="TaskTimeOuts">TaskTimeOuts.</param>
	/// <param name="TenantId">TenantId.</param>
	/// <param name="_Version">_Version.</param>
	public Settings(string? Id = default, DeviceDeviceInfoAaaCredentials AaaCredentials = default, bool? AcceptEula = default, SettingsDefaultProfile DefaultProfile = default, List<SettingsSavaMappingList> SavaMappingList = default, SettingsTaskTimeOuts TaskTimeOuts = default, string? TenantId = default, int? _Version = default)
	{
		this.Id = Id;
		this.AaaCredentials = AaaCredentials;
		this.AcceptEula = AcceptEula;
		this.DefaultProfile = DefaultProfile;
		this.SavaMappingList = SavaMappingList;
		this.TaskTimeOuts = TaskTimeOuts;
		this.TenantId = TenantId;
		this._Version = _Version;
	}

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "_id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets AaaCredentials
	/// </summary>
	[DataMember(Name = "aaaCredentials", EmitDefaultValue = false)]
	public DeviceDeviceInfoAaaCredentials AaaCredentials { get; set; }

	/// <summary>
	/// Gets or Sets AcceptEula
	/// </summary>
	[DataMember(Name = "acceptEula", EmitDefaultValue = false)]
	public bool? AcceptEula { get; set; }

	/// <summary>
	/// Gets or Sets DefaultProfile
	/// </summary>
	[DataMember(Name = "defaultProfile", EmitDefaultValue = false)]
	public SettingsDefaultProfile DefaultProfile { get; set; }

	/// <summary>
	/// Gets or Sets SavaMappingList
	/// </summary>
	[DataMember(Name = "savaMappingList", EmitDefaultValue = false)]
	public List<SettingsSavaMappingList> SavaMappingList { get; set; }

	/// <summary>
	/// Gets or Sets TaskTimeOuts
	/// </summary>
	[DataMember(Name = "taskTimeOuts", EmitDefaultValue = false)]
	public SettingsTaskTimeOuts TaskTimeOuts { get; set; }

	/// <summary>
	/// Gets or Sets TenantId
	/// </summary>
	[DataMember(Name = "tenantId", EmitDefaultValue = false)]
	public string? TenantId { get; set; }

	/// <summary>
	/// Gets or Sets _Version
	/// </summary>
	[DataMember(Name = "version", EmitDefaultValue = false)]
	public int? _Version { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class Settings {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  AaaCredentials: ").Append(AaaCredentials).Append("\n");
		sb.Append("  AcceptEula: ").Append(AcceptEula).Append("\n");
		sb.Append("  DefaultProfile: ").Append(DefaultProfile).Append("\n");
		sb.Append("  SavaMappingList: ").Append(SavaMappingList).Append("\n");
		sb.Append("  TaskTimeOuts: ").Append(TaskTimeOuts).Append("\n");
		sb.Append("  TenantId: ").Append(TenantId).Append("\n");
		sb.Append("  _Version: ").Append(_Version).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
