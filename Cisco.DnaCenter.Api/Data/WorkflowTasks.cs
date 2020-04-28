using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// WorkflowTasks
	/// </summary>
	[DataContract]
	public class WorkflowTasks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkflowTasks" /> class.
		/// </summary>
		/// <param name="CurrWorkItemIdx">CurrWorkItemIdx.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="Name">Name.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="State">State.</param>
		/// <param name="TaskSeqNo">TaskSeqNo.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		/// <param name="Type">Type.</param>
		/// <param name="WorkItemList">WorkItemList.</param>
		public WorkflowTasks(int? CurrWorkItemIdx = default, int? EndTime = default, string? Name = default, int? StartTime = default, string? State = default, int? TaskSeqNo = default, int? TimeTaken = default, string? Type = default, List<WorkflowWorkItemList> WorkItemList = default)
		{
			this.CurrWorkItemIdx = CurrWorkItemIdx;
			this.EndTime = EndTime;
			this.Name = Name;
			this.StartTime = StartTime;
			this.State = State;
			this.TaskSeqNo = TaskSeqNo;
			this.TimeTaken = TimeTaken;
			this.Type = Type;
			this.WorkItemList = WorkItemList;
		}

		/// <summary>
		/// Gets or Sets CurrWorkItemIdx
		/// </summary>
		[DataMember(Name = "currWorkItemIdx", EmitDefaultValue = false)]
		public int? CurrWorkItemIdx { get; set; }

		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public int? EndTime { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public int? StartTime { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }

		/// <summary>
		/// Gets or Sets TaskSeqNo
		/// </summary>
		[DataMember(Name = "taskSeqNo", EmitDefaultValue = false)]
		public int? TaskSeqNo { get; set; }

		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public int? TimeTaken { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets WorkItemList
		/// </summary>
		[DataMember(Name = "workItemList", EmitDefaultValue = false)]
		public List<WorkflowWorkItemList> WorkItemList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkflowTasks {\n");
			sb.Append("  CurrWorkItemIdx: ").Append(CurrWorkItemIdx).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  TaskSeqNo: ").Append(TaskSeqNo).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  WorkItemList: ").Append(WorkItemList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
