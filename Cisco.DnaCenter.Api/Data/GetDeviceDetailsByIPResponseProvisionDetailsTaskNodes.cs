using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceDetailsByIPResponseProvisionDetailsTaskNodes
	/// </summary>
	[DataContract]
	public class GetDeviceDetailsByIpResponseProvisionDetailsTaskNodes
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailsByIpResponseProvisionDetailsTaskNodes" /> class.
		/// </summary>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="Duration">Duration.</param>
		/// <param name="Status">Status.</param>
		/// <param name="NextTask">NextTask.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Target">Target.</param>
		/// <param name="StatusMessage">StatusMessage.</param>
		/// <param name="Payload">Payload.</param>
		/// <param name="ProvisionedNames">ProvisionedNames.</param>
		/// <param name="ErrorPayload">ErrorPayload.</param>
		/// <param name="ParentTask">ParentTask.</param>
		/// <param name="CliTemplateUserMessageDto">CliTemplateUserMessageDto.</param>
		/// <param name="StepRan">StepRan.</param>
		public GetDeviceDetailsByIpResponseProvisionDetailsTaskNodes(string? StartTime = default, string? EndTime = default, string? Duration = default, string? Status = default, string? NextTask = default, string? Name = default, string? Target = default, string? StatusMessage = default, string? Payload = default, Object ProvisionedNames = default, Object ErrorPayload = default, Object ParentTask = default, Object CliTemplateUserMessageDto = default, string? StepRan = default)
		{
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.Duration = Duration;
			this.Status = Status;
			this.NextTask = NextTask;
			this.Name = Name;
			this.Target = Target;
			this.StatusMessage = StatusMessage;
			this.Payload = Payload;
			this.ProvisionedNames = ProvisionedNames;
			this.ErrorPayload = ErrorPayload;
			this.ParentTask = ParentTask;
			this.CliTemplateUserMessageDto = CliTemplateUserMessageDto;
			this.StepRan = StepRan;
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
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }

		/// <summary>
		/// Gets or Sets NextTask
		/// </summary>
		[DataMember(Name = "nextTask", EmitDefaultValue = false)]
		public string? NextTask { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets Target
		/// </summary>
		[DataMember(Name = "target", EmitDefaultValue = false)]
		public string? Target { get; set; }

		/// <summary>
		/// Gets or Sets StatusMessage
		/// </summary>
		[DataMember(Name = "statusMessage", EmitDefaultValue = false)]
		public string? StatusMessage { get; set; }

		/// <summary>
		/// Gets or Sets Payload
		/// </summary>
		[DataMember(Name = "payload", EmitDefaultValue = false)]
		public string? Payload { get; set; }

		/// <summary>
		/// Gets or Sets ProvisionedNames
		/// </summary>
		[DataMember(Name = "provisionedNames", EmitDefaultValue = false)]
		public Object ProvisionedNames { get; set; }

		/// <summary>
		/// Gets or Sets ErrorPayload
		/// </summary>
		[DataMember(Name = "errorPayload", EmitDefaultValue = false)]
		public Object ErrorPayload { get; set; }

		/// <summary>
		/// Gets or Sets ParentTask
		/// </summary>
		[DataMember(Name = "parentTask", EmitDefaultValue = false)]
		public Object ParentTask { get; set; }

		/// <summary>
		/// Gets or Sets CliTemplateUserMessageDto
		/// </summary>
		[DataMember(Name = "cliTemplateUserMessageDto", EmitDefaultValue = false)]
		public Object CliTemplateUserMessageDto { get; set; }

		/// <summary>
		/// Gets or Sets StepRan
		/// </summary>
		[DataMember(Name = "stepRan", EmitDefaultValue = false)]
		public string? StepRan { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceDetailsByIPResponseProvisionDetailsTaskNodes {\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  NextTask: ").Append(NextTask).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Target: ").Append(Target).Append("\n");
			sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
			sb.Append("  Payload: ").Append(Payload).Append("\n");
			sb.Append("  ProvisionedNames: ").Append(ProvisionedNames).Append("\n");
			sb.Append("  ErrorPayload: ").Append(ErrorPayload).Append("\n");
			sb.Append("  ParentTask: ").Append(ParentTask).Append("\n");
			sb.Append("  CliTemplateUserMessageDto: ").Append(CliTemplateUserMessageDto).Append("\n");
			sb.Append("  StepRan: ").Append(StepRan).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
