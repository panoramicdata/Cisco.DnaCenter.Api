using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// The state of a Business API (BAPI) execution.
/// </summary>
[DataContract]
public enum ExecutionStatusStatus
{
	/// <summary>
	/// The execution has not yet finished.
	/// </summary>
	[EnumMember(Value = "IN_PROGRESS")]
	InProgress,

	/// <summary>
	/// The execution finished successfully.
	/// </summary>
	[EnumMember(Value = "SUCCESS")]
	Success,

	/// <summary>
	/// The execution finished unsuccessfully.
	/// </summary>
	[EnumMember(Value = "FAILURE")]
	Failure,

}
