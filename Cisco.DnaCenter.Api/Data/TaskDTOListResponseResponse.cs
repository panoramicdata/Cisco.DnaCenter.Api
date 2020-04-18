using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TaskDtoListResponseResponse
	/// </summary>
	[DataContract]
	public class TaskDtoListResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TaskDtoListResponseResponse" /> class.
		/// </summary>
		/// <param name="AdditionalStatusURL">AdditionalStatusURL.</param>
		/// <param name="Data">Data.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="ErrorCode">ErrorCode.</param>
		/// <param name="ErrorKey">ErrorKey.</param>
		/// <param name="FailureReason">FailureReason.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="IsError">IsError.</param>
		/// <param name="LastUpdate">LastUpdate.</param>
		/// <param name="OperationIdList">OperationIdList.</param>
		/// <param name="ParentId">ParentId.</param>
		/// <param name="Progress">Progress.</param>
		/// <param name="RootId">RootId.</param>
		/// <param name="ServiceType">ServiceType.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="Username">Username.</param>
		/// <param name="_Version">_Version.</param>
		public TaskDtoListResponseResponse(string? AdditionalStatusURL = default, string? Data = default, string? EndTime = default, string? ErrorCode = default, string? ErrorKey = default, string? FailureReason = default, string? Id = default, string? InstanceTenantId = default, bool? IsError = default, string? LastUpdate = default, Object OperationIdList = default, string? ParentId = default, string? Progress = default, string? RootId = default, string? ServiceType = default, string? StartTime = default, string? Username = default, int? _Version = default)
		{
			this.AdditionalStatusURL = AdditionalStatusURL;
			this.Data = Data;
			this.EndTime = EndTime;
			this.ErrorCode = ErrorCode;
			this.ErrorKey = ErrorKey;
			this.FailureReason = FailureReason;
			this.Id = Id;
			this.InstanceTenantId = InstanceTenantId;
			this.IsError = IsError;
			this.LastUpdate = LastUpdate;
			this.OperationIdList = OperationIdList;
			this.ParentId = ParentId;
			this.Progress = Progress;
			this.RootId = RootId;
			this.ServiceType = ServiceType;
			this.StartTime = StartTime;
			this.Username = Username;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets AdditionalStatusURL
		/// </summary>
		[DataMember(Name = "additionalStatusURL", EmitDefaultValue = false)]
		public string? AdditionalStatusURL { get; set; }
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public string? Data { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public string? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets ErrorCode
		/// </summary>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public string? ErrorCode { get; set; }
		/// <summary>
		/// Gets or Sets ErrorKey
		/// </summary>
		[DataMember(Name = "errorKey", EmitDefaultValue = false)]
		public string? ErrorKey { get; set; }
		/// <summary>
		/// Gets or Sets FailureReason
		/// </summary>
		[DataMember(Name = "failureReason", EmitDefaultValue = false)]
		public string? FailureReason { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Gets or Sets IsError
		/// </summary>
		[DataMember(Name = "isError", EmitDefaultValue = false)]
		public bool? IsError { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdate
		/// </summary>
		[DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
		public string? LastUpdate { get; set; }
		/// <summary>
		/// Gets or Sets OperationIdList
		/// </summary>
		[DataMember(Name = "operationIdList", EmitDefaultValue = false)]
		public Object OperationIdList { get; set; }
		/// <summary>
		/// Gets or Sets ParentId
		/// </summary>
		[DataMember(Name = "parentId", EmitDefaultValue = false)]
		public string? ParentId { get; set; }
		/// <summary>
		/// Gets or Sets Progress
		/// </summary>
		[DataMember(Name = "progress", EmitDefaultValue = false)]
		public string? Progress { get; set; }
		/// <summary>
		/// Gets or Sets RootId
		/// </summary>
		[DataMember(Name = "rootId", EmitDefaultValue = false)]
		public string? RootId { get; set; }
		/// <summary>
		/// Gets or Sets ServiceType
		/// </summary>
		[DataMember(Name = "serviceType", EmitDefaultValue = false)]
		public string? ServiceType { get; set; }
		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string? StartTime { get; set; }
		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string? Username { get; set; }
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
			sb.Append("class TaskDtoListResponseResponse {\n");
			sb.Append("  AdditionalStatusURL: ").Append(AdditionalStatusURL).Append("\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  ErrorKey: ").Append(ErrorKey).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  IsError: ").Append(IsError).Append("\n");
			sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
			sb.Append("  OperationIdList: ").Append(OperationIdList).Append("\n");
			sb.Append("  ParentId: ").Append(ParentId).Append("\n");
			sb.Append("  Progress: ").Append(Progress).Append("\n");
			sb.Append("  RootId: ").Append(RootId).Append("\n");
			sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
