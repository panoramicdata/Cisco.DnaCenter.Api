using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceHistoryResponseHistoryTaskInfoWorkItemList
	/// </summary>
	[DataContract]
	public partial class GetDeviceHistoryResponseHistoryTaskInfoWorkItemList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceHistoryResponseHistoryTaskInfoWorkItemList" /> class.
		/// </summary>
		/// <param name="State">State.</param>
		/// <param name="Command">Command.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		/// <param name="OutputStr">OutputStr.</param>
		public GetDeviceHistoryResponseHistoryTaskInfoWorkItemList(string? State = default, string? Command = default, decimal? StartTime = default, decimal? EndTime = default, decimal? TimeTaken = default, string? OutputStr = default)
		{
			this.State = State;
			this.Command = Command;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.TimeTaken = TimeTaken;
			this.OutputStr = OutputStr;
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
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public decimal? StartTime { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public decimal? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public decimal? TimeTaken { get; set; }
		/// <summary>
		/// Gets or Sets OutputStr
		/// </summary>
		[DataMember(Name = "outputStr", EmitDefaultValue = false)]
		public string? OutputStr { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceHistoryResponseHistoryTaskInfoWorkItemList {\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Command: ").Append(Command).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("  OutputStr: ").Append(OutputStr).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
