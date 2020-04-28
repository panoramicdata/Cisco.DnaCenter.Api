using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ImportDevicesInBulkResponseSuccessList
	/// </summary>
	[DataContract]
	public class ImportDevicesInBulkResponseSuccessList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportDevicesInBulkResponseSuccessList" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DeviceInfo">DeviceInfo.</param>
		/// <param name="SystemResetWorkflow">SystemResetWorkflow.</param>
		/// <param name="SystemWorkflow">SystemWorkflow.</param>
		/// <param name="Workflow">Workflow.</param>
		/// <param name="RunSummaryList">RunSummaryList.</param>
		/// <param name="WorkflowParameters">WorkflowParameters.</param>
		/// <param name="DayZeroConfig">DayZeroConfig.</param>
		/// <param name="DayZeroConfigPreview">DayZeroConfigPreview.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="TenantId">TenantId.</param>
		public ImportDevicesInBulkResponseSuccessList(string? Id = default, DeviceDeviceInfo DeviceInfo = default, DeviceSystemResetWorkflow SystemResetWorkflow = default, DeviceSystemResetWorkflow SystemWorkflow = default, DeviceSystemResetWorkflow Workflow = default, List<DeviceRunSummaryList> RunSummaryList = default, DeviceWorkflowParameters WorkflowParameters = default, DeviceDayZeroConfig DayZeroConfig = default, Object DayZeroConfigPreview = default, decimal? _Version = default, string? TenantId = default)
		{
			this.Id = Id;
			this.DeviceInfo = DeviceInfo;
			this.SystemResetWorkflow = SystemResetWorkflow;
			this.SystemWorkflow = SystemWorkflow;
			this.Workflow = Workflow;
			this.RunSummaryList = RunSummaryList;
			this.WorkflowParameters = WorkflowParameters;
			this.DayZeroConfig = DayZeroConfig;
			this.DayZeroConfigPreview = DayZeroConfigPreview;
			this._Version = _Version;
			this.TenantId = TenantId;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "_id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets DeviceInfo
		/// </summary>
		[DataMember(Name = "deviceInfo", EmitDefaultValue = false)]
		public DeviceDeviceInfo DeviceInfo { get; set; }

		/// <summary>
		/// Gets or Sets SystemResetWorkflow
		/// </summary>
		[DataMember(Name = "systemResetWorkflow", EmitDefaultValue = false)]
		public DeviceSystemResetWorkflow SystemResetWorkflow { get; set; }

		/// <summary>
		/// Gets or Sets SystemWorkflow
		/// </summary>
		[DataMember(Name = "systemWorkflow", EmitDefaultValue = false)]
		public DeviceSystemResetWorkflow SystemWorkflow { get; set; }

		/// <summary>
		/// Gets or Sets Workflow
		/// </summary>
		[DataMember(Name = "workflow", EmitDefaultValue = false)]
		public DeviceSystemResetWorkflow Workflow { get; set; }

		/// <summary>
		/// Gets or Sets RunSummaryList
		/// </summary>
		[DataMember(Name = "runSummaryList", EmitDefaultValue = false)]
		public List<DeviceRunSummaryList> RunSummaryList { get; set; }

		/// <summary>
		/// Gets or Sets WorkflowParameters
		/// </summary>
		[DataMember(Name = "workflowParameters", EmitDefaultValue = false)]
		public DeviceWorkflowParameters WorkflowParameters { get; set; }

		/// <summary>
		/// Gets or Sets DayZeroConfig
		/// </summary>
		[DataMember(Name = "dayZeroConfig", EmitDefaultValue = false)]
		public DeviceDayZeroConfig DayZeroConfig { get; set; }

		/// <summary>
		/// Gets or Sets DayZeroConfigPreview
		/// </summary>
		[DataMember(Name = "dayZeroConfigPreview", EmitDefaultValue = false)]
		public Object DayZeroConfigPreview { get; set; }

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
			sb.Append("class ImportDevicesInBulkResponseSuccessList {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DeviceInfo: ").Append(DeviceInfo).Append("\n");
			sb.Append("  SystemResetWorkflow: ").Append(SystemResetWorkflow).Append("\n");
			sb.Append("  SystemWorkflow: ").Append(SystemWorkflow).Append("\n");
			sb.Append("  Workflow: ").Append(Workflow).Append("\n");
			sb.Append("  RunSummaryList: ").Append(RunSummaryList).Append("\n");
			sb.Append("  WorkflowParameters: ").Append(WorkflowParameters).Append("\n");
			sb.Append("  DayZeroConfig: ").Append(DayZeroConfig).Append("\n");
			sb.Append("  DayZeroConfigPreview: ").Append(DayZeroConfigPreview).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
