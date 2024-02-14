using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionUpdateResponse
/// </summary>
[DataContract]
public class ProvisionUpdateResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionUpdateResponse" /> class.
	/// </summary>
	/// <param name="ExecutionId">ExecutionId.</param>
	/// <param name="ExecutionUrl">ExecutionUrl.</param>
	/// <param name="ProvisioningTasks">ProvisioningTasks.</param>
	public ProvisionUpdateResponse(string? ExecutionId = default, string? ExecutionUrl = default, ProvisionResponseProvisioningTasks ProvisioningTasks = default)
	{
		this.ExecutionId = ExecutionId;
		this.ExecutionUrl = ExecutionUrl;
		this.ProvisioningTasks = ProvisioningTasks;
	}

	/// <summary>
	/// Gets or Sets ExecutionId
	/// </summary>
	[DataMember(Name = "executionId", EmitDefaultValue = false)]
	public string? ExecutionId { get; set; }

	/// <summary>
	/// Gets or Sets ExecutionUrl
	/// </summary>
	[DataMember(Name = "executionUrl", EmitDefaultValue = false)]
	public string? ExecutionUrl { get; set; }

	/// <summary>
	/// Gets or Sets ProvisioningTasks
	/// </summary>
	[DataMember(Name = "provisioningTasks", EmitDefaultValue = false)]
	public ProvisionResponseProvisioningTasks ProvisioningTasks { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionUpdateResponse {\n");
		sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
		sb.Append("  ExecutionUrl: ").Append(ExecutionUrl).Append("\n");
		sb.Append("  ProvisioningTasks: ").Append(ProvisioningTasks).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
