using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceSystemResetWorkflowTasks
	/// </summary>
	[DataContract]
	public partial class DeviceSystemResetWorkflowTasks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceSystemResetWorkflowTasks" /> class.
		/// </summary>
		/// <param name="State">State.</param>
		/// <param name="Type">Type.</param>
		/// <param name="CurrWorkItemIdx">CurrWorkItemIdx.</param>
		/// <param name="TaskSeqNo">TaskSeqNo.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="WorkItemList">WorkItemList.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		/// <param name="Name">Name.</param>
		public DeviceSystemResetWorkflowTasks(string? State = default, string? Type = default, decimal? CurrWorkItemIdx = default, decimal? TaskSeqNo = default, decimal? EndTime = default, decimal? StartTime = default, List<DeviceSystemResetWorkflowWorkItemList> WorkItemList = default, decimal? TimeTaken = default, string? Name = default)
		{
			this.State = State;
			this.Type = Type;
			this.CurrWorkItemIdx = CurrWorkItemIdx;
			this.TaskSeqNo = TaskSeqNo;
			this.EndTime = EndTime;
			this.StartTime = StartTime;
			this.WorkItemList = WorkItemList;
			this.TimeTaken = TimeTaken;
			this.Name = Name;
		}

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets CurrWorkItemIdx
		/// </summary>
		[DataMember(Name = "currWorkItemIdx", EmitDefaultValue = false)]
		public decimal? CurrWorkItemIdx { get; set; }
		/// <summary>
		/// Gets or Sets TaskSeqNo
		/// </summary>
		[DataMember(Name = "taskSeqNo", EmitDefaultValue = false)]
		public decimal? TaskSeqNo { get; set; }
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
		/// Gets or Sets WorkItemList
		/// </summary>
		[DataMember(Name = "workItemList", EmitDefaultValue = false)]
		public List<DeviceSystemResetWorkflowWorkItemList> WorkItemList { get; set; }
		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public decimal? TimeTaken { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceSystemResetWorkflowTasks {\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  CurrWorkItemIdx: ").Append(CurrWorkItemIdx).Append("\n");
			sb.Append("  TaskSeqNo: ").Append(TaskSeqNo).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  WorkItemList: ").Append(WorkItemList).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
