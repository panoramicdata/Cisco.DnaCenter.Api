using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceSystemResetWorkflow
	/// </summary>
	[DataContract]
	public class DeviceSystemResetWorkflow
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceSystemResetWorkflow" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="State">State.</param>
		/// <param name="Type">Type.</param>
		/// <param name="Description">Description.</param>
		/// <param name="LastupdateOn">LastupdateOn.</param>
		/// <param name="ImageId">ImageId.</param>
		/// <param name="CurrTaskIdx">CurrTaskIdx.</param>
		/// <param name="AddedOn">AddedOn.</param>
		/// <param name="Tasks">Tasks.</param>
		/// <param name="AddToInventory">AddToInventory.</param>
		/// <param name="InstanceType">InstanceType.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="ExecTime">ExecTime.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="UseState">UseState.</param>
		/// <param name="ConfigId">ConfigId.</param>
		/// <param name="Name">Name.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="TenantId">TenantId.</param>
		public DeviceSystemResetWorkflow(
			string? Id = default,
			string? State = default,
			string? Type = default,
			string? Description = default,
			long? LastupdateOn = default,
			string? ImageId = default,
			decimal? CurrTaskIdx = default,
			long? AddedOn = default,
			List<DeviceSystemResetWorkflowTasks> Tasks = default,
			bool? AddToInventory = default,
			string? InstanceType = default,
			long? EndTime = default,
			long? ExecTime = default,
			long? StartTime = default,
			string? UseState = default,
			string? ConfigId = default,
			string? Name = default,
			decimal? _Version = default,
			string? TenantId = default)
		{
			this.Id = Id;
			this.State = State;
			this.Type = Type;
			this.Description = Description;
			this.LastupdateOn = LastupdateOn;
			this.ImageId = ImageId;
			this.CurrTaskIdx = CurrTaskIdx;
			this.AddedOn = AddedOn;
			this.Tasks = Tasks;
			this.AddToInventory = AddToInventory;
			this.InstanceType = InstanceType;
			this.EndTime = EndTime;
			this.ExecTime = ExecTime;
			this.StartTime = StartTime;
			this.UseState = UseState;
			this.ConfigId = ConfigId;
			this.Name = Name;
			this._Version = _Version;
			this.TenantId = TenantId;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "_id", EmitDefaultValue = false)]
		public string? Id { get; set; }

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
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or Sets LastupdateOn
		/// </summary>
		[DataMember(Name = "lastupdateOn", EmitDefaultValue = false)]
		public long? LastupdateOn { get; set; }

		/// <summary>
		/// Gets or Sets ImageId
		/// </summary>
		[DataMember(Name = "imageId", EmitDefaultValue = false)]
		public string? ImageId { get; set; }

		/// <summary>
		/// Gets or Sets CurrTaskIdx
		/// </summary>
		[DataMember(Name = "currTaskIdx", EmitDefaultValue = false)]
		public decimal? CurrTaskIdx { get; set; }

		/// <summary>
		/// Gets or Sets AddedOn
		/// </summary>
		[DataMember(Name = "addedOn", EmitDefaultValue = false)]
		public long? AddedOn { get; set; }

		/// <summary>
		/// Gets or Sets Tasks
		/// </summary>
		[DataMember(Name = "tasks", EmitDefaultValue = false)]
		public List<DeviceSystemResetWorkflowTasks> Tasks { get; set; }

		/// <summary>
		/// Gets or Sets AddToInventory
		/// </summary>
		[DataMember(Name = "addToInventory", EmitDefaultValue = false)]
		public bool? AddToInventory { get; set; }

		/// <summary>
		/// Gets or Sets InstanceType
		/// </summary>
		[DataMember(Name = "instanceType", EmitDefaultValue = false)]
		public string? InstanceType { get; set; }

		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public long? EndTime { get; set; }

		/// <summary>
		/// Gets or Sets ExecTime
		/// </summary>
		[DataMember(Name = "execTime", EmitDefaultValue = false)]
		public long? ExecTime { get; set; }

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public long? StartTime { get; set; }

		/// <summary>
		/// Gets or Sets UseState
		/// </summary>
		[DataMember(Name = "useState", EmitDefaultValue = false)]
		public string? UseState { get; set; }

		/// <summary>
		/// Gets or Sets ConfigId
		/// </summary>
		[DataMember(Name = "configId", EmitDefaultValue = false)]
		public string? ConfigId { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public decimal? _Version { get; set; }

		/// <summary>
		/// Gets or Sets TenantId
		/// </summary>
		[DataMember(Name = "tenantId", EmitDefaultValue = false)]
		public string? TenantId { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceSystemResetWorkflow {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  LastupdateOn: ").Append(LastupdateOn).Append("\n");
			sb.Append("  ImageId: ").Append(ImageId).Append("\n");
			sb.Append("  CurrTaskIdx: ").Append(CurrTaskIdx).Append("\n");
			sb.Append("  AddedOn: ").Append(AddedOn).Append("\n");
			sb.Append("  Tasks: ").Append(Tasks).Append("\n");
			sb.Append("  AddToInventory: ").Append(AddToInventory).Append("\n");
			sb.Append("  InstanceType: ").Append(InstanceType).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  ExecTime: ").Append(ExecTime).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  UseState: ").Append(UseState).Append("\n");
			sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
