using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis" /> class.
		/// </summary>
		/// <param name="AclName">AclName.</param>
		/// <param name="MatchingAces">MatchingAces.</param>
		/// <param name="Result">Result.</param>
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis(string? AclName = default, List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces> MatchingAces = default, string? Result = default)
		{
			this.AclName = AclName;
			this.MatchingAces = MatchingAces;
			this.Result = Result;
		}

		/// <summary>
		/// Gets or Sets AclName
		/// </summary>
		[DataMember(Name = "aclName", EmitDefaultValue = false)]
		public string? AclName { get; set; }
		/// <summary>
		/// Gets or Sets MatchingAces
		/// </summary>
		[DataMember(Name = "matchingAces", EmitDefaultValue = false)]
		public List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces> MatchingAces { get; set; }
		/// <summary>
		/// Gets or Sets Result
		/// </summary>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		public string? Result { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis {\n");
			sb.Append("  AclName: ").Append(AclName).Append("\n");
			sb.Append("  MatchingAces: ").Append(MatchingAces).Append("\n");
			sb.Append("  Result: ").Append(Result).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
