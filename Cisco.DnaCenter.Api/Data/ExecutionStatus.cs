using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	[DataContract]
	public class ExecutionStatus
	{
		[DataMember(Name = "bapiKey")]
		public string BapiKey { get; set; } = string.Empty;

		[DataMember(Name = "bapiName")]
		public string BapiName { get; set; } = string.Empty;

		[DataMember(Name = "bapiExecutionId")]
		public string BapiExecutionId { get; set; } = string.Empty;

		[DataMember(Name = "startTime")]
		public string StartTime { get; set; } = string.Empty;

		[DataMember(Name = "startTimeEpoch")]
		public long StartTimeEpoch { get; set; }

		[DataMember(Name = "endTime")]
		public string EndTime { get; set; } = string.Empty;

		[DataMember(Name = "endTimeEpoch")]
		public long EndTimeEpoch { get; set; }

		[DataMember(Name = "timeDuration")]
		public int TimeDuration { get; set; }

		[DataMember(Name = "status")]
		public ExecutionStatusStatus Status { get; set; }

		[DataMember(Name = "bapiError")]
		public string BapiError { get; set; } = string.Empty;

		[DataMember(Name = "runtimeInstanceId")]
		public string RuntimeInstanceId { get; set; } = string.Empty;
	}
}
