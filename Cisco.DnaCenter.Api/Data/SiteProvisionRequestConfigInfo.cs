using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SiteProvisionRequestConfigInfo
/// </summary>
[DataContract]
public class SiteProvisionRequestConfigInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SiteProvisionRequestConfigInfo" /> class.
	/// </summary>
	/// <param name="ConfigId ">ConfigId.</param>
	/// <param name="ConfigParameters">ConfigParameters.</param>
	public SiteProvisionRequestConfigInfo(
		string? ConfigId = default,
		object? ConfigParameters = default
		)
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
	public object? ConfigParameters { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SiteProvisionRequestConfigInfo {\n");
		sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
		sb.Append("  ConfigParameters: ").Append(ConfigParameters?.ToString()).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}