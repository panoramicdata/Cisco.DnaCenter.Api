using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DiscoveryJobNioListResultResponse
	/// </summary>
	[DataContract]
	public partial class DiscoveryJobNioListResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DiscoveryJobNioListResultResponse" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="CliStatus">CliStatus.</param>
		/// <param name="DiscoveryStatus">DiscoveryStatus.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="HttpStatus">HttpStatus.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InventoryCollectionStatus">InventoryCollectionStatus.</param>
		/// <param name="InventoryReachabilityStatus">InventoryReachabilityStatus.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="JobStatus">JobStatus.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NetconfStatus">NetconfStatus.</param>
		/// <param name="PingStatus">PingStatus.</param>
		/// <param name="SnmpStatus">SnmpStatus.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="TaskId">TaskId.</param>
		public DiscoveryJobNioListResultResponse(Object AttributeInfo = default, string? CliStatus = default, string? DiscoveryStatus = default, string? EndTime = default, string? HttpStatus = default, string? Id = default, string? InventoryCollectionStatus = default, string? InventoryReachabilityStatus = default, string? IpAddress = default, string? JobStatus = default, string? Name = default, string? NetconfStatus = default, string? PingStatus = default, string? SnmpStatus = default, string? StartTime = default, string? TaskId = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.CliStatus = CliStatus;
			this.DiscoveryStatus = DiscoveryStatus;
			this.EndTime = EndTime;
			this.HttpStatus = HttpStatus;
			this.Id = Id;
			this.InventoryCollectionStatus = InventoryCollectionStatus;
			this.InventoryReachabilityStatus = InventoryReachabilityStatus;
			this.IpAddress = IpAddress;
			this.JobStatus = JobStatus;
			this.Name = Name;
			this.NetconfStatus = NetconfStatus;
			this.PingStatus = PingStatus;
			this.SnmpStatus = SnmpStatus;
			this.StartTime = StartTime;
			this.TaskId = TaskId;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets CliStatus
		/// </summary>
		[DataMember(Name = "cliStatus", EmitDefaultValue = false)]
		public string? CliStatus { get; set; }
		/// <summary>
		/// Gets or Sets DiscoveryStatus
		/// </summary>
		[DataMember(Name = "discoveryStatus", EmitDefaultValue = false)]
		public string? DiscoveryStatus { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public string? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets HttpStatus
		/// </summary>
		[DataMember(Name = "httpStatus", EmitDefaultValue = false)]
		public string? HttpStatus { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets InventoryCollectionStatus
		/// </summary>
		[DataMember(Name = "inventoryCollectionStatus", EmitDefaultValue = false)]
		public string? InventoryCollectionStatus { get; set; }
		/// <summary>
		/// Gets or Sets InventoryReachabilityStatus
		/// </summary>
		[DataMember(Name = "inventoryReachabilityStatus", EmitDefaultValue = false)]
		public string? InventoryReachabilityStatus { get; set; }
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string? IpAddress { get; set; }
		/// <summary>
		/// Gets or Sets JobStatus
		/// </summary>
		[DataMember(Name = "jobStatus", EmitDefaultValue = false)]
		public string? JobStatus { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets NetconfStatus
		/// </summary>
		[DataMember(Name = "netconfStatus", EmitDefaultValue = false)]
		public string? NetconfStatus { get; set; }
		/// <summary>
		/// Gets or Sets PingStatus
		/// </summary>
		[DataMember(Name = "pingStatus", EmitDefaultValue = false)]
		public string? PingStatus { get; set; }
		/// <summary>
		/// Gets or Sets SnmpStatus
		/// </summary>
		[DataMember(Name = "snmpStatus", EmitDefaultValue = false)]
		public string? SnmpStatus { get; set; }
		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string? StartTime { get; set; }
		/// <summary>
		/// Gets or Sets TaskId
		/// </summary>
		[DataMember(Name = "taskId", EmitDefaultValue = false)]
		public string? TaskId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DiscoveryJobNioListResultResponse {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  CliStatus: ").Append(CliStatus).Append("\n");
			sb.Append("  DiscoveryStatus: ").Append(DiscoveryStatus).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  HttpStatus: ").Append(HttpStatus).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InventoryCollectionStatus: ").Append(InventoryCollectionStatus).Append("\n");
			sb.Append("  InventoryReachabilityStatus: ").Append(InventoryReachabilityStatus).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  NetconfStatus: ").Append(NetconfStatus).Append("\n");
			sb.Append("  PingStatus: ").Append(PingStatus).Append("\n");
			sb.Append("  SnmpStatus: ").Append(SnmpStatus).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  TaskId: ").Append(TaskId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
