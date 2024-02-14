using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces
/// </summary>
[DataContract]
public class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces" /> class.
	/// </summary>
	/// <param name="Ace">Ace.</param>
	/// <param name="MatchingPorts">MatchingPorts.</param>
	/// <param name="Result">Result.</param>
	public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces(string? Ace = default, List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts> MatchingPorts = default, string? Result = default)
	{
		this.Ace = Ace;
		this.MatchingPorts = MatchingPorts;
		this.Result = Result;
	}

	/// <summary>
	/// Gets or Sets Ace
	/// </summary>
	[DataMember(Name = "ace", EmitDefaultValue = false)]
	public string? Ace { get; set; }

	/// <summary>
	/// Gets or Sets MatchingPorts
	/// </summary>
	[DataMember(Name = "matchingPorts", EmitDefaultValue = false)]
	public List<PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingPorts> MatchingPorts { get; set; }

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
		sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceAclAnalysisMatchingAces {\n");
		sb.Append("  Ace: ").Append(Ace).Append("\n");
		sb.Append("  MatchingPorts: ").Append(MatchingPorts).Append("\n");
		sb.Append("  Result: ").Append(Result).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
