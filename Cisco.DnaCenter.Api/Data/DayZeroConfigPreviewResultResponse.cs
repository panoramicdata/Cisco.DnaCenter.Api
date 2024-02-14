using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DayZeroConfigPreviewResultResponse
/// </summary>
[DataContract]
public class DayZeroConfigPreviewResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DayZeroConfigPreviewResultResponse" /> class.
	/// </summary>
	/// <param name="Complete">Complete.</param>
	/// <param name="Config">Config.</param>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="ExpiredTime">ExpiredTime.</param>
	/// <param name="RfProfile">RfProfile.</param>
	/// <param name="SensorProfile">SensorProfile.</param>
	/// <param name="SiteId">SiteId.</param>
	/// <param name="StartTime">StartTime.</param>
	/// <param name="TaskId">TaskId.</param>
	public DayZeroConfigPreviewResultResponse(
		bool? Complete = default,
		string? Config = default,
		bool? Error = default,
		string? ErrorMessage = default,
		long? ExpiredTime = default,
		string? RfProfile = default,
		string? SensorProfile = default,
		string? SiteId = default,
		long? StartTime = default,
		string? TaskId = default)
	{
		this.Complete = Complete;
		this.Config = Config;
		this.Error = Error;
		this.ErrorMessage = ErrorMessage;
		this.ExpiredTime = ExpiredTime;
		this.RfProfile = RfProfile;
		this.SensorProfile = SensorProfile;
		this.SiteId = SiteId;
		this.StartTime = StartTime;
		this.TaskId = TaskId;
	}

	/// <summary>
	/// Gets or Sets Complete
	/// </summary>
	[DataMember(Name = "complete", EmitDefaultValue = false)]
	public bool? Complete { get; set; }

	/// <summary>
	/// Gets or Sets Config
	/// </summary>
	[DataMember(Name = "config", EmitDefaultValue = false)]
	public string? Config { get; set; }

	/// <summary>
	/// Gets or Sets Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public bool? Error { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string? ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets ExpiredTime
	/// </summary>
	[DataMember(Name = "expiredTime", EmitDefaultValue = false)]
	public long? ExpiredTime { get; set; }

	/// <summary>
	/// Gets or Sets RfProfile
	/// </summary>
	[DataMember(Name = "RfProfile", EmitDefaultValue = false)]
	public string? RfProfile { get; set; }

	/// <summary>
	/// Gets or Sets SensorProfile
	/// </summary>
	[DataMember(Name = "sensorProfile", EmitDefaultValue = false)]
	public string? SensorProfile { get; set; }

	/// <summary>
	/// Gets or Sets SiteId
	/// </summary>
	[DataMember(Name = "siteId", EmitDefaultValue = false)]
	public string? SiteId { get; set; }

	/// <summary>
	/// Gets or Sets StartTime
	/// </summary>
	[DataMember(Name = "startTime", EmitDefaultValue = false)]
	public long? StartTime { get; set; }

	/// <summary>
	/// Gets or Sets TaskId
	/// </summary>
	[DataMember(Name = "taskId", EmitDefaultValue = false)]
	public string? TaskId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DayZeroConfigPreviewResultResponse {\n");
		sb.Append("  Complete: ").Append(Complete).Append("\n");
		sb.Append("  Config: ").Append(Config).Append("\n");
		sb.Append("  Error: ").Append(Error).Append("\n");
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
		sb.Append("  ExpiredTime: ").Append(ExpiredTime).Append("\n");
		sb.Append("  RfProfile: ").Append(RfProfile).Append("\n");
		sb.Append("  SensorProfile: ").Append(SensorProfile).Append("\n");
		sb.Append("  SiteId: ").Append(SiteId).Append("\n");
		sb.Append("  StartTime: ").Append(StartTime).Append("\n");
		sb.Append("  TaskId: ").Append(TaskId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
