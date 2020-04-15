using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts" /> class.
		/// </summary>
		/// <param name="Ports">Ports.</param>
		/// <param name="Protocol">Protocol.</param>
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts(List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts> Ports = default, string? Protocol = default)
		{
			this.Ports = Ports;
			this.Protocol = Protocol;
		}

		/// <summary>
		/// Gets or Sets Ports
		/// </summary>
		[DataMember(Name = "ports", EmitDefaultValue = false)]
		public List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts> Ports { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts {\n");
			sb.Append("  Ports: ").Append(Ports).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
