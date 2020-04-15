using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceDetailsByIPResponseProvisionDetails
	/// </summary>
	[DataContract]
	public partial class GetDeviceDetailsByIPResponseProvisionDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailsByIPResponseProvisionDetails" /> class.
		/// </summary>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="Duration">Duration.</param>
		/// <param name="StatusMessage">StatusMessage.</param>
		/// <param name="Status">Status.</param>
		/// <param name="TaskNodes">TaskNodes.</param>
		/// <param name="Topology">Topology.</param>
		/// <param name="BeginStep">BeginStep.</param>
		public GetDeviceDetailsByIPResponseProvisionDetails(string? StartTime = default, string? EndTime = default, string? Duration = default, string? StatusMessage = default, string? Status = default, List<GetDeviceDetailsByIPResponseProvisionDetailsTaskNodes> TaskNodes = default, string? Topology = default, string? BeginStep = default)
		{
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.Duration = Duration;
			this.StatusMessage = StatusMessage;
			this.Status = Status;
			this.TaskNodes = TaskNodes;
			this.Topology = Topology;
			this.BeginStep = BeginStep;
		}

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string? StartTime { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public string? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public string? Duration { get; set; }
		/// <summary>
		/// Gets or Sets StatusMessage
		/// </summary>
		[DataMember(Name = "statusMessage", EmitDefaultValue = false)]
		public string? StatusMessage { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets TaskNodes
		/// </summary>
		[DataMember(Name = "taskNodes", EmitDefaultValue = false)]
		public List<GetDeviceDetailsByIPResponseProvisionDetailsTaskNodes> TaskNodes { get; set; }
		/// <summary>
		/// Gets or Sets Topology
		/// </summary>
		[DataMember(Name = "topology", EmitDefaultValue = false)]
		public string? Topology { get; set; }
		/// <summary>
		/// Gets or Sets BeginStep
		/// </summary>
		[DataMember(Name = "beginStep", EmitDefaultValue = false)]
		public string? BeginStep { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceDetailsByIPResponseProvisionDetails {\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  TaskNodes: ").Append(TaskNodes).Append("\n");
			sb.Append("  Topology: ").Append(Topology).Append("\n");
			sb.Append("  BeginStep: ").Append(BeginStep).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
