using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateApplicationSetResponseResponse
	/// </summary>
	[DataContract]
	public class CreateApplicationSetResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateApplicationSetResponseResponse" /> class.
		/// </summary>
		/// <param name="TaskId">TaskId.</param>
		/// <param name="Url">Url.</param>
		public CreateApplicationSetResponseResponse(string? TaskId = default, string? Url = default)
		{
			this.TaskId = TaskId;
			this.Url = Url;
		}

		/// <summary>
		/// Gets or Sets TaskId
		/// </summary>
		[DataMember(Name = "taskId", EmitDefaultValue = false)]
		public string? TaskId { get; set; }
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
			sb.Append("class CreateApplicationSetResponseResponse {\n");
			sb.Append("  TaskId: ").Append(TaskId).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
