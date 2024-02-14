using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeviceWorkflowParameters
/// </summary>
[DataContract]
public class DeviceWorkflowParameters
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeviceWorkflowParameters" /> class.
	/// </summary>
	/// <param name="TopOfStackSerialNumber">TopOfStackSerialNumber.</param>
	/// <param name="LicenseLevel">LicenseLevel.</param>
	/// <param name="LicenseType">LicenseType.</param>
	/// <param name="ConfigList">ConfigList.</param>
	public DeviceWorkflowParameters(string? TopOfStackSerialNumber = default, string? LicenseLevel = default, string? LicenseType = default, List<DeviceWorkflowParametersConfigList> ConfigList = default)
	{
		this.TopOfStackSerialNumber = TopOfStackSerialNumber;
		this.LicenseLevel = LicenseLevel;
		this.LicenseType = LicenseType;
		this.ConfigList = ConfigList;
	}

	/// <summary>
	/// Gets or Sets TopOfStackSerialNumber
	/// </summary>
	[DataMember(Name = "topOfStackSerialNumber", EmitDefaultValue = false)]
	public string? TopOfStackSerialNumber { get; set; }

	/// <summary>
	/// Gets or Sets LicenseLevel
	/// </summary>
	[DataMember(Name = "licenseLevel", EmitDefaultValue = false)]
	public string? LicenseLevel { get; set; }

	/// <summary>
	/// Gets or Sets LicenseType
	/// </summary>
	[DataMember(Name = "licenseType", EmitDefaultValue = false)]
	public string? LicenseType { get; set; }

	/// <summary>
	/// Gets or Sets ConfigList
	/// </summary>
	[DataMember(Name = "configList", EmitDefaultValue = false)]
	public List<DeviceWorkflowParametersConfigList> ConfigList { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceWorkflowParameters {\n");
		sb.Append("  TopOfStackSerialNumber: ").Append(TopOfStackSerialNumber).Append("\n");
		sb.Append("  LicenseLevel: ").Append(LicenseLevel).Append("\n");
		sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
		sb.Append("  ConfigList: ").Append(ConfigList).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
