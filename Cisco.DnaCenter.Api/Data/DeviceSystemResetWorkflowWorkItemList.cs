using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceSystemResetWorkflowWorkItemList
	/// </summary>
	[DataContract]
	public class DeviceSystemResetWorkflowWorkItemList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceSystemResetWorkflowWorkItemList" /> class.
		/// </summary>
		/// <param name="State">State.</param>
		/// <param name="Command">Command.</param>
		/// <param name="OutputStr">OutputStr.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		public DeviceSystemResetWorkflowWorkItemList(string? State = default, string? Command = default, string? OutputStr = default, decimal? EndTime = default, decimal? StartTime = default, decimal? TimeTaken = default)
		{
			this.State = State;
			this.Command = Command;
			this.OutputStr = OutputStr;
			this.EndTime = EndTime;
			this.StartTime = StartTime;
			this.TimeTaken = TimeTaken;
		}

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }

		/// <summary>
		/// Gets or Sets Command
		/// </summary>
		[DataMember(Name = "command", EmitDefaultValue = false)]
		public string? Command { get; set; }

		/// <summary>
		/// Gets or Sets OutputStr
		/// </summary>
		[DataMember(Name = "outputStr", EmitDefaultValue = false)]
		public string? OutputStr { get; set; }

		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public decimal? EndTime { get; set; }

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public decimal? StartTime { get; set; }

		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public decimal? TimeTaken { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceSystemResetWorkflowWorkItemList {\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Command: ").Append(Command).Append("\n");
			sb.Append("  OutputStr: ").Append(OutputStr).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
