using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// FlowAnalysisListOutputResponse
	/// </summary>
	[DataContract]
	public partial class FlowAnalysisListOutputResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowAnalysisListOutputResponse" /> class.
		/// </summary>
		/// <param name="ControlPath">ControlPath.</param>
		/// <param name="CreateTime">CreateTime.</param>
		/// <param name="DestIP">DestIP.</param>
		/// <param name="DestPort">DestPort.</param>
		/// <param name="FailureReason">FailureReason.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Inclusions">Inclusions.</param>
		/// <param name="LastUpdateTime">LastUpdateTime.</param>
		/// <param name="PeriodicRefresh">PeriodicRefresh.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="SourceIP">SourceIP.</param>
		/// <param name="SourcePort">SourcePort.</param>
		/// <param name="Status">Status.</param>
		public FlowAnalysisListOutputResponse(bool? ControlPath = default, int? CreateTime = default, string? DestIP = default, string? DestPort = default, string? FailureReason = default, string? Id = default, List<string> Inclusions = default, int? LastUpdateTime = default, bool? PeriodicRefresh = default, string? Protocol = default, string? SourceIP = default, string? SourcePort = default, string? Status = default)
		{
			this.ControlPath = ControlPath;
			this.CreateTime = CreateTime;
			this.DestIP = DestIP;
			this.DestPort = DestPort;
			this.FailureReason = FailureReason;
			this.Id = Id;
			this.Inclusions = Inclusions;
			this.LastUpdateTime = LastUpdateTime;
			this.PeriodicRefresh = PeriodicRefresh;
			this.Protocol = Protocol;
			this.SourceIP = SourceIP;
			this.SourcePort = SourcePort;
			this.Status = Status;
		}

		/// <summary>
		/// Gets or Sets ControlPath
		/// </summary>
		[DataMember(Name = "controlPath", EmitDefaultValue = false)]
		public bool? ControlPath { get; set; }
		/// <summary>
		/// Gets or Sets CreateTime
		/// </summary>
		[DataMember(Name = "createTime", EmitDefaultValue = false)]
		public int? CreateTime { get; set; }
		/// <summary>
		/// Gets or Sets DestIP
		/// </summary>
		[DataMember(Name = "destIP", EmitDefaultValue = false)]
		public string? DestIP { get; set; }
		/// <summary>
		/// Gets or Sets DestPort
		/// </summary>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string? DestPort { get; set; }
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
		/// Gets or Sets Inclusions
		/// </summary>
		[DataMember(Name = "inclusions", EmitDefaultValue = false)]
		public List<string> Inclusions { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdateTime
		/// </summary>
		[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
		public int? LastUpdateTime { get; set; }
		/// <summary>
		/// Gets or Sets PeriodicRefresh
		/// </summary>
		[DataMember(Name = "periodicRefresh", EmitDefaultValue = false)]
		public bool? PeriodicRefresh { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Gets or Sets SourceIP
		/// </summary>
		[DataMember(Name = "sourceIP", EmitDefaultValue = false)]
		public string? SourceIP { get; set; }
		/// <summary>
		/// Gets or Sets SourcePort
		/// </summary>
		[DataMember(Name = "sourcePort", EmitDefaultValue = false)]
		public string? SourcePort { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowAnalysisListOutputResponse {\n");
			sb.Append("  ControlPath: ").Append(ControlPath).Append("\n");
			sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
			sb.Append("  DestIP: ").Append(DestIP).Append("\n");
			sb.Append("  DestPort: ").Append(DestPort).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Inclusions: ").Append(Inclusions).Append("\n");
			sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
			sb.Append("  PeriodicRefresh: ").Append(PeriodicRefresh).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  SourceIP: ").Append(SourceIP).Append("\n");
			sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
