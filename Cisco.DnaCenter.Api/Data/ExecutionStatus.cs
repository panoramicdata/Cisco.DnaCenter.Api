using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// The status of a Business API (BAPI) execution.
/// </summary>
[DataContract]
public class ExecutionStatus
{
	/// <summary>
	/// The key identifying the Business API that was executed.
	/// </summary>
	[DataMember(Name = "bapiKey")]
	public string BapiKey { get; set; } = string.Empty;

	/// <summary>
	/// The name of the Business API that was executed.
	/// </summary>
	[DataMember(Name = "bapiName")]
	public string BapiName { get; set; } = string.Empty;

	/// <summary>
	/// The identifier of this execution.
	/// </summary>
	[DataMember(Name = "bapiExecutionId")]
	public string BapiExecutionId { get; set; } = string.Empty;

	/// <summary>
	/// The time at which the execution started.
	/// </summary>
	[DataMember(Name = "startTime")]
	public string StartTime { get; set; } = string.Empty;

	/// <summary>
	/// The time at which the execution started, in milliseconds since the Unix epoch.
	/// </summary>
	[DataMember(Name = "startTimeEpoch")]
	public long StartTimeEpoch { get; set; }

	/// <summary>
	/// The time at which the execution finished.
	/// </summary>
	[DataMember(Name = "endTime")]
	public string EndTime { get; set; } = string.Empty;

	/// <summary>
	/// The time at which the execution finished, in milliseconds since the Unix epoch.
	/// </summary>
	[DataMember(Name = "endTimeEpoch")]
	public long EndTimeEpoch { get; set; }

	/// <summary>
	/// How long the execution took, in milliseconds.
	/// </summary>
	[DataMember(Name = "timeDuration")]
	public int TimeDuration { get; set; }

	/// <summary>
	/// Whether the execution is still running, and if not, whether it succeeded.
	/// </summary>
	[DataMember(Name = "status")]
	public ExecutionStatusStatus Status { get; set; }

	/// <summary>
	/// The error reported by the Business API, if the execution failed.
	/// </summary>
	[DataMember(Name = "bapiError")]
	public string BapiError { get; set; } = string.Empty;

	/// <summary>
	/// The identifier of the runtime instance that performed the execution.
	/// </summary>
	[DataMember(Name = "runtimeInstanceId")]
	public string RuntimeInstanceId { get; set; } = string.Empty;
}
