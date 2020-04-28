using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionResponseProvisionTasksSuccess
	/// </summary>
	[DataContract]
	public class ApProvisionResponseProvisionTasksSuccess
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApProvisionResponseProvisionTasksSuccess" /> class.
		/// </summary>
		/// <param name="TaskId">TaskId.</param>
		/// <param name="TaskUrl">TaskUrl.</param>
		public ApProvisionResponseProvisionTasksSuccess(string? TaskId = default, string? TaskUrl = default)
		{
			this.TaskId = TaskId;
			this.TaskUrl = TaskUrl;
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
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionResponseProvisionTasksSuccess {\n");
			sb.Append("  TaskId: ").Append(TaskId).Append("\n");
			sb.Append("  TaskUrl: ").Append(TaskUrl).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
