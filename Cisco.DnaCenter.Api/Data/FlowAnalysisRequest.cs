using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// FlowAnalysisRequest
	/// </summary>
	[DataContract]
	public class FlowAnalysisRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowAnalysisRequest" /> class.
		/// </summary>
		/// <param name="ControlPath">ControlPath.</param>
		/// <param name="DestinationIp">DestIP.</param>
		/// <param name="DestinationPort">DestPort.</param>
		/// <param name="Inclusions">Inclusions.</param>
		/// <param name="PeriodicRefresh">PeriodicRefresh.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="SourceIp">SourceIP.</param>
		/// <param name="SourcePort">SourcePort.</param>
		public FlowAnalysisRequest(bool? ControlPath = default, string? DestinationIp = default, string? DestinationPort = default, List<string> Inclusions = default, bool? PeriodicRefresh = default, string? Protocol = default, string? SourceIp = default, string? SourcePort = default)
		{
			this.ControlPath = ControlPath;
			this.DestinationIp = DestinationIp;
			this.DestinationPort = DestinationPort;
			this.Inclusions = Inclusions;
			this.PeriodicRefresh = PeriodicRefresh;
			this.Protocol = Protocol;
			this.SourceIp = SourceIp;
			this.SourcePort = SourcePort;
		}

		/// <summary>
		/// Gets or Sets ControlPath
		/// </summary>
		[DataMember(Name = "controlPath", EmitDefaultValue = false)]
		public bool? ControlPath { get; set; }
		/// <summary>
		/// Gets or Sets DestIP
		/// </summary>
		[DataMember(Name = "destIP", EmitDefaultValue = false)]
		public string? DestinationIp { get; set; }
		/// <summary>
		/// Gets or Sets DestPort
		/// </summary>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string? DestinationPort { get; set; }
		/// <summary>
		/// Gets or Sets Inclusions
		/// </summary>
		[DataMember(Name = "inclusions", EmitDefaultValue = false)]
		public List<string> Inclusions { get; set; }
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
		public string? SourceIp { get; set; }
		/// <summary>
		/// Gets or Sets SourcePort
		/// </summary>
		[DataMember(Name = "sourcePort", EmitDefaultValue = false)]
		public string? SourcePort { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowAnalysisRequest {\n");
			sb.Append("  ControlPath: ").Append(ControlPath).Append("\n");
			sb.Append("  DestIP: ").Append(DestinationIp).Append("\n");
			sb.Append("  DestPort: ").Append(DestinationPort).Append("\n");
			sb.Append("  Inclusions: ").Append(Inclusions).Append("\n");
			sb.Append("  PeriodicRefresh: ").Append(PeriodicRefresh).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  SourceIP: ").Append(SourceIp).Append("\n");
			sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
