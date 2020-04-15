using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts" /> class.
		/// </summary>
		/// <param name="DestPorts">DestPorts.</param>
		/// <param name="SourcePorts">SourcePorts.</param>
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts(List<string> DestPorts = default, List<string> SourcePorts = default)
		{
			this.DestPorts = DestPorts;
			this.SourcePorts = SourcePorts;
		}

		/// <summary>
		/// Gets or Sets DestPorts
		/// </summary>
		[DataMember(Name = "destPorts", EmitDefaultValue = false)]
		public List<string> DestPorts { get; set; }
		/// <summary>
		/// Gets or Sets SourcePorts
		/// </summary>
		[DataMember(Name = "sourcePorts", EmitDefaultValue = false)]
		public List<string> SourcePorts { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisPorts {\n");
			sb.Append("  DestPorts: ").Append(DestPorts).Append("\n");
			sb.Append("  SourcePorts: ").Append(SourcePorts).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
