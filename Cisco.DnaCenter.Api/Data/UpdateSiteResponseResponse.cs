using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteResponseResponse
	/// </summary>
	[DataContract]
	public class UpdateSiteResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSiteResponseResponse" /> class.
		/// </summary>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="Progress">Progress.</param>
		/// <param name="Data">Data.</param>
		/// <param name="ServiceType">ServiceType.</param>
		/// <param name="OperationIdList">OperationIdList.</param>
		/// <param name="IsError">IsError.</param>
		/// <param name="RootId">RootId.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="Id">Id.</param>
		public UpdateSiteResponseResponse(
			string? EndTime = default,
			string? _Version = default,
			string? StartTime = default,
			string? Progress = default,
			string? Data = default,
			string? ServiceType = default,
			List<string> OperationIdList = default,
			string? IsError = default,
			string? RootId = default,
			string? InstanceTenantId = default,
			string? Id = default)
		{
			this.EndTime = EndTime;
			this._Version = _Version;
			this.StartTime = StartTime;
			this.Progress = Progress;
			this.Data = Data;
			this.ServiceType = ServiceType;
			this.OperationIdList = OperationIdList;
			this.IsError = IsError;
			this.RootId = RootId;
			this.InstanceTenantId = InstanceTenantId;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public string? EndTime { get; set; }

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }

		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string? StartTime { get; set; }

		/// <summary>
		/// Gets or Sets Progress
		/// </summary>
		[DataMember(Name = "progress", EmitDefaultValue = false)]
		public string? Progress { get; set; }

		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public string? Data { get; set; }

		/// <summary>
		/// Gets or Sets ServiceType
		/// </summary>
		[DataMember(Name = "serviceType", EmitDefaultValue = false)]
		public string? ServiceType { get; set; }

		/// <summary>
		/// Gets or Sets OperationIdList
		/// </summary>
		[DataMember(Name = "operationIdList", EmitDefaultValue = false)]
		public List<string> OperationIdList { get; set; }

		/// <summary>
		/// Gets or Sets IsError
		/// </summary>
		[DataMember(Name = "isError", EmitDefaultValue = false)]
		public string? IsError { get; set; }

		/// <summary>
		/// Gets or Sets RootId
		/// </summary>
		[DataMember(Name = "rootId", EmitDefaultValue = false)]
		public string? RootId { get; set; }

		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSiteResponseResponse {\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  Progress: ").Append(Progress).Append("\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
			sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
			sb.Append("  OperationIdList: ").Append(OperationIdList).Append("\n");
			sb.Append("  IsError: ").Append(IsError).Append("\n");
			sb.Append("  RootId: ").Append(RootId).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
