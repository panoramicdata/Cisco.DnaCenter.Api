using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ResetRequestConfigList
/// </summary>
[DataContract]
public class ResetRequestConfigList
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ResetRequestConfigList" /> class.
	/// </summary>
	/// <param name="ConfigId">ConfigId.</param>
	/// <param name="ConfigParameters">ConfigParameters.</param>
	public ResetRequestConfigList(string? ConfigId = default, List<DeviceDeviceInfoHttpHeaders> ConfigParameters = default)
	{
		this.ConfigId = ConfigId;
		this.ConfigParameters = ConfigParameters;
	}

	/// <summary>
	/// Gets or Sets ConfigId
	/// </summary>
	[DataMember(Name = "configId", EmitDefaultValue = false)]
	public string? ConfigId { get; set; }

	/// <summary>
	/// Gets or Sets ConfigParameters
	/// </summary>
	[DataMember(Name = "configParameters", EmitDefaultValue = false)]
	public List<DeviceDeviceInfoHttpHeaders> ConfigParameters { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ResetRequestConfigList {\n");
		sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
		sb.Append("  ConfigParameters: ").Append(ConfigParameters).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
