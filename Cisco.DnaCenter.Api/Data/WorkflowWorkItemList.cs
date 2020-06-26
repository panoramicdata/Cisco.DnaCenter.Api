using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// WorkflowWorkItemList
	/// </summary>
	[DataContract]
	public class WorkflowWorkItemList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkflowWorkItemList" /> class.
		/// </summary>
		/// <param name="Command">Command.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="OutputStr">OutputStr.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="State">State.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		public WorkflowWorkItemList(
			string? Command = default,
			long? EndTime = default,
			string? OutputStr = default,
			long? StartTime = default,
			string? State = default,
			int? TimeTaken = default)
		{
			this.Command = Command;
			this.EndTime = EndTime;
			this.OutputStr = OutputStr;
			this.StartTime = StartTime;
			this.State = State;
			this.TimeTaken = TimeTaken;
		}

		/// <summary>
		/// Gets or Sets Command
		/// </summary>
		[DataMember(Name = "command", EmitDefaultValue = false)]
		public string? Command { get; set; }

		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public long? EndTime { get; set; }

		/// <summary>
		/// Gets or Sets OutputStr
		/// </summary>
		[DataMember(Name = "outputStr", EmitDefaultValue = false)]
		public string? OutputStr { get; set; }

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public long? StartTime { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }

		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public int? TimeTaken { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkflowWorkItemList {\n");
			sb.Append("  Command: ").Append(Command).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  OutputStr: ").Append(OutputStr).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
