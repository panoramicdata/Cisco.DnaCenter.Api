using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TopologyResultResponse
/// </summary>
[DataContract]
public class TopologyResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TopologyResultResponse" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="Links">Links.</param>
	/// <param name="Nodes">Nodes.</param>
	public TopologyResultResponse(string? Id = default, List<TopologyResultResponseLinks> Links = default, List<TopologyResultResponseNodes> Nodes = default)
	{
		this.Id = Id;
		this.Links = Links;
		this.Nodes = Nodes;
	}

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<TopologyResultResponseLinks> Links { get; set; }

	/// <summary>
	/// Gets or Sets Nodes
	/// </summary>
	[DataMember(Name = "nodes", EmitDefaultValue = false)]
	public List<TopologyResultResponseNodes> Nodes { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TopologyResultResponse {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  Links: ").Append(Links).Append("\n");
		sb.Append("  Nodes: ").Append(Nodes).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
