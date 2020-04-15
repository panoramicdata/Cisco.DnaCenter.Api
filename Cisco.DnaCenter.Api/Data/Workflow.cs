using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// Workflow
	/// </summary>
	[DataContract]
	public partial class Workflow
	{
		/// <summary>
		/// Gets or Sets InstanceType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum InstanceTypeEnum
		{

			/// <summary>
			/// Enum SystemWorkflow for "SystemWorkflow"
			/// </summary>
			[EnumMember(Value = "SystemWorkflow")]
			SystemWorkflow,

			/// <summary>
			/// Enum UserWorkflow for "UserWorkflow"
			/// </summary>
			[EnumMember(Value = "UserWorkflow")]
			UserWorkflow,

			/// <summary>
			/// Enum SystemResetWorkflow for "SystemResetWorkflow"
			/// </summary>
			[EnumMember(Value = "SystemResetWorkflow")]
			SystemResetWorkflow
		}

		/// <summary>
		/// Gets or Sets InstanceType
		/// </summary>
		[DataMember(Name = "instanceType", EmitDefaultValue = false)]
		public InstanceTypeEnum? InstanceType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Workflow" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AddToInventory">AddToInventory.</param>
		/// <param name="AddedOn">AddedOn.</param>
		/// <param name="ConfigId">ConfigId.</param>
		/// <param name="CurrTaskIdx">CurrTaskIdx.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="ExecTime">ExecTime.</param>
		/// <param name="ImageId">ImageId.</param>
		/// <param name="InstanceType">InstanceType.</param>
		/// <param name="LastupdateOn">LastupdateOn.</param>
		/// <param name="Name">Name.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="State">State.</param>
		/// <param name="Tasks">Tasks.</param>
		/// <param name="TenantId">TenantId.</param>
		/// <param name="Type">Type.</param>
		/// <param name="UseState">UseState.</param>
		/// <param name="_Version">_Version.</param>
		public Workflow(string? Id = default, bool? AddToInventory = default, int? AddedOn = default, string? ConfigId = default, int? CurrTaskIdx = default, string? Description = default, int? EndTime = default, int? ExecTime = default, string? ImageId = default, InstanceTypeEnum? InstanceType = default, int? LastupdateOn = default, string? Name = default, int? StartTime = default, string? State = default, List<WorkflowTasks> Tasks = default, string? TenantId = default, string? Type = default, string? UseState = default, int? _Version = default)
		{
			this.Id = Id;
			this.AddToInventory = AddToInventory;
			this.AddedOn = AddedOn;
			this.ConfigId = ConfigId;
			this.CurrTaskIdx = CurrTaskIdx;
			this.Description = Description;
			this.EndTime = EndTime;
			this.ExecTime = ExecTime;
			this.ImageId = ImageId;
			this.InstanceType = InstanceType;
			this.LastupdateOn = LastupdateOn;
			this.Name = Name;
			this.StartTime = StartTime;
			this.State = State;
			this.Tasks = Tasks;
			this.TenantId = TenantId;
			this.Type = Type;
			this.UseState = UseState;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "_id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets AddToInventory
		/// </summary>
		[DataMember(Name = "addToInventory", EmitDefaultValue = false)]
		public bool? AddToInventory { get; set; }
		/// <summary>
		/// Gets or Sets AddedOn
		/// </summary>
		[DataMember(Name = "addedOn", EmitDefaultValue = false)]
		public int? AddedOn { get; set; }
		/// <summary>
		/// Gets or Sets ConfigId
		/// </summary>
		[DataMember(Name = "configId", EmitDefaultValue = false)]
		public string? ConfigId { get; set; }
		/// <summary>
		/// Gets or Sets CurrTaskIdx
		/// </summary>
		[DataMember(Name = "currTaskIdx", EmitDefaultValue = false)]
		public int? CurrTaskIdx { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public int? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets ExecTime
		/// </summary>
		[DataMember(Name = "execTime", EmitDefaultValue = false)]
		public int? ExecTime { get; set; }
		/// <summary>
		/// Gets or Sets ImageId
		/// </summary>
		[DataMember(Name = "imageId", EmitDefaultValue = false)]
		public string? ImageId { get; set; }
		/// <summary>
		/// Gets or Sets LastupdateOn
		/// </summary>
		[DataMember(Name = "lastupdateOn", EmitDefaultValue = false)]
		public int? LastupdateOn { get; set; }
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
		/// Gets or Sets Tasks
		/// </summary>
		[DataMember(Name = "tasks", EmitDefaultValue = false)]
		public List<WorkflowTasks> Tasks { get; set; }
		/// <summary>
		/// Gets or Sets TenantId
		/// </summary>
		[DataMember(Name = "tenantId", EmitDefaultValue = false)]
		public string? TenantId { get; set; }
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets UseState
		/// </summary>
		[DataMember(Name = "useState", EmitDefaultValue = false)]
		public string? UseState { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? _Version { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Workflow {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  AddToInventory: ").Append(AddToInventory).Append("\n");
			sb.Append("  AddedOn: ").Append(AddedOn).Append("\n");
			sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
			sb.Append("  CurrTaskIdx: ").Append(CurrTaskIdx).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  ExecTime: ").Append(ExecTime).Append("\n");
			sb.Append("  ImageId: ").Append(ImageId).Append("\n");
			sb.Append("  InstanceType: ").Append(InstanceType).Append("\n");
			sb.Append("  LastupdateOn: ").Append(LastupdateOn).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Tasks: ").Append(Tasks).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  UseState: ").Append(UseState).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
