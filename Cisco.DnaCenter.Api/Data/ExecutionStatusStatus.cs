using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	[DataContract]
	public enum ExecutionStatusStatus
	{
		[EnumMember(Value = "IN_PROGRESS")]
		InProgress,

		[EnumMember(Value = "SUCCESS")]
		Success,

		[EnumMember(Value = "FAILURE")]
		Failure,

	}
}
