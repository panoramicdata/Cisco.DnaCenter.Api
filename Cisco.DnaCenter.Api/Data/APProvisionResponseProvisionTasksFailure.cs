using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionResponseProvisionTasksFailure
	/// </summary>
	[DataContract]
	public class ApProvisionResponseProvisionTasksFailure
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApProvisionResponseProvisionTasksFailure" /> class.
		/// </summary>
		/// <param name="TaskId">TaskId.</param>
		/// <param name="TaskUrl">TaskUrl.</param>
		/// <param name="FailureReason">FailureReason.</param>
		public ApProvisionResponseProvisionTasksFailure(string? TaskId = default, string? TaskUrl = default, string? FailureReason = default)
		{
			this.TaskId = TaskId;
			this.TaskUrl = TaskUrl;
			this.FailureReason = FailureReason;
		}

		/// <summary>
		/// Gets or Sets TaskId
		/// </summary>
		[DataMember(Name = "taskId", EmitDefaultValue = false)]
		public string? TaskId { get; set; }
		/// <summary>
		/// Gets or Sets TaskUrl
		/// </summary>
		[DataMember(Name = "taskUrl", EmitDefaultValue = false)]
		public string? TaskUrl { get; set; }
		/// <summary>
		/// Gets or Sets FailureReason
		/// </summary>
		[DataMember(Name = "failureReason", EmitDefaultValue = false)]
		public string? FailureReason { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionResponseProvisionTasksFailure {\n");
			sb.Append("  TaskId: ").Append(TaskId).Append("\n");
			sb.Append("  TaskUrl: ").Append(TaskUrl).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
