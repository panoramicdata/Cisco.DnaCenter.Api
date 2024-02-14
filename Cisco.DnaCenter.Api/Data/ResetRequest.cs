using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ResetRequest
/// </summary>
[DataContract]
public class ResetRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ResetRequest" /> class.
	/// </summary>
	/// <param name="DeviceResetList">DeviceResetList.</param>
	/// <param name="ProjectId">ProjectId.</param>
	/// <param name="WorkflowId">WorkflowId.</param>
	public ResetRequest(List<ResetRequestDeviceResetList> DeviceResetList = default, string? ProjectId = default, string? WorkflowId = default)
	{
		this.DeviceResetList = DeviceResetList;
		this.ProjectId = ProjectId;
		this.WorkflowId = WorkflowId;
	}

	/// <summary>
	/// Gets or Sets DeviceResetList
	/// </summary>
	[DataMember(Name = "deviceResetList", EmitDefaultValue = false)]
	public List<ResetRequestDeviceResetList> DeviceResetList { get; set; }

	/// <summary>
	/// Gets or Sets ProjectId
	/// </summary>
	[DataMember(Name = "projectId", EmitDefaultValue = false)]
	public string? ProjectId { get; set; }

	/// <summary>
	/// Gets or Sets WorkflowId
	/// </summary>
	[DataMember(Name = "workflowId", EmitDefaultValue = false)]
	public string? WorkflowId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ResetRequest {\n");
		sb.Append("  DeviceResetList: ").Append(DeviceResetList).Append("\n");
		sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
		sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
