using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TaskIdResultResponse
	/// </summary>
	[DataContract]
	public class TaskIdResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TaskIdResultResponse" /> class.
		/// </summary>
		/// <param name="TaskId">TaskId.</param>
		/// <param name="Url">Url.</param>
		public TaskIdResultResponse(Object TaskId = default, string? Url = default)
		{
			this.TaskId = TaskId;
			this.Url = Url;
		}

		/// <summary>
		/// Gets or Sets TaskId
		/// </summary>
		[DataMember(Name = "taskId", EmitDefaultValue = false)]
		public Object TaskId { get; set; }

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
			sb.Append("class TaskIdResultResponse {\n");
			sb.Append("  TaskId: ").Append(TaskId).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
