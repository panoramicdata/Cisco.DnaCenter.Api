using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// FlowAnalysisRequestResultOutputResponse
/// </summary>
[DataContract]
public class FlowAnalysisRequestResultOutputResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FlowAnalysisRequestResultOutputResponse" /> class.
	/// </summary>
	/// <param name="FlowAnalysisId">FlowAnalysisId.</param>
	/// <param name="TaskId">TaskId.</param>
	/// <param name="Url">Url.</param>
	public FlowAnalysisRequestResultOutputResponse(string? FlowAnalysisId = default, string? TaskId = default, string? Url = default)
	{
		this.FlowAnalysisId = FlowAnalysisId;
		this.TaskId = TaskId;
		this.Url = Url;
	}

	/// <summary>
	/// Gets or Sets FlowAnalysisId
	/// </summary>
	[DataMember(Name = "flowAnalysisId", EmitDefaultValue = false)]
	public string? FlowAnalysisId { get; set; }

	/// <summary>
	/// Gets or Sets TaskId
	/// </summary>
	[DataMember(Name = "taskId", EmitDefaultValue = false)]
	public string? TaskId { get; set; }

	/// <summary>
	/// Gets or Sets Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string? Url { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class FlowAnalysisRequestResultOutputResponse {\n");
		sb.Append("  FlowAnalysisId: ").Append(FlowAnalysisId).Append("\n");
		sb.Append("  TaskId: ").Append(TaskId).Append("\n");
		sb.Append("  Url: ").Append(Url).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
