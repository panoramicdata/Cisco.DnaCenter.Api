using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TemplateDeploymentStatusDto
/// </summary>
[DataContract]
public class TemplateDeploymentStatusDto
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TemplateDeploymentStatusDto" /> class.
	/// </summary>
	/// <param name="DeploymentId">DeploymentId.</param>
	/// <param name="DeploymentName">DeploymentName.</param>
	/// <param name="Devices">Devices.</param>
	/// <param name="Duration">Duration.</param>
	/// <param name="EndTime">EndTime.</param>
	/// <param name="ProjectName">ProjectName.</param>
	/// <param name="StartTime">StartTime.</param>
	/// <param name="Status">Status.</param>
	/// <param name="TemplateName">TemplateName.</param>
	/// <param name="TemplateVersion">TemplateVersion.</param>
	public TemplateDeploymentStatusDto(
		string? DeploymentId = default,
		string? DeploymentName = default,
		List<TemplateDeploymentStatusDtoDevices> Devices = default,
		string? Duration = default,
		string? EndTime = default,
		string? ProjectName = default,
		string? StartTime = default,
		string? Status = default,
		string? TemplateName = default,
		string? TemplateVersion = default)
	{
		this.DeploymentId = DeploymentId;
		this.DeploymentName = DeploymentName;
		this.Devices = Devices;
		this.Duration = Duration;
		this.EndTime = EndTime;
		this.ProjectName = ProjectName;
		this.StartTime = StartTime;
		this.Status = Status;
		this.TemplateName = TemplateName;
		this.TemplateVersion = TemplateVersion;
	}

	/// <summary>
	/// Gets or Sets DeploymentId
	/// </summary>
	[DataMember(Name = "deploymentId", EmitDefaultValue = false)]
	public string? DeploymentId { get; set; }

	/// <summary>
	/// Gets or Sets DeploymentName
	/// </summary>
	[DataMember(Name = "deploymentName", EmitDefaultValue = false)]
	public string? DeploymentName { get; set; }

	/// <summary>
	/// Gets or Sets Devices
	/// </summary>
	[DataMember(Name = "devices", EmitDefaultValue = false)]
	public List<TemplateDeploymentStatusDtoDevices> Devices { get; set; }

	/// <summary>
	/// Gets or Sets Duration
	/// </summary>
	[DataMember(Name = "duration", EmitDefaultValue = false)]
	public string? Duration { get; set; }

	/// <summary>
	/// Gets or Sets EndTime
	/// </summary>
	[DataMember(Name = "endTime", EmitDefaultValue = false)]
	public string? EndTime { get; set; }

	/// <summary>
	/// Gets or Sets ProjectName
	/// </summary>
	[DataMember(Name = "projectName", EmitDefaultValue = false)]
	public string? ProjectName { get; set; }

	/// <summary>
	/// Gets or Sets StartTime
	/// </summary>
	[DataMember(Name = "startTime", EmitDefaultValue = false)]
	public string? StartTime { get; set; }

	/// <summary>
	/// Gets or Sets Status
	/// </summary>
	[DataMember(Name = "status", EmitDefaultValue = false)]
	public string? Status { get; set; }

	/// <summary>
	/// Gets or Sets TemplateName
	/// </summary>
	[DataMember(Name = "templateName", EmitDefaultValue = false)]
	public string? TemplateName { get; set; }

	/// <summary>
	/// Gets or Sets TemplateVersion
	/// </summary>
	[DataMember(Name = "templateVersion", EmitDefaultValue = false)]
	public string? TemplateVersion { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TemplateDeploymentStatusDto {\n");
		sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
		sb.Append("  DeploymentName: ").Append(DeploymentName).Append("\n");
		sb.Append("  Devices: ").Append(Devices).Append("\n");
		sb.Append("  Duration: ").Append(Duration).Append("\n");
		sb.Append("  EndTime: ").Append(EndTime).Append("\n");
		sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
		sb.Append("  StartTime: ").Append(StartTime).Append("\n");
		sb.Append("  Status: ").Append(Status).Append("\n");
		sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
		sb.Append("  TemplateVersion: ").Append(TemplateVersion).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
