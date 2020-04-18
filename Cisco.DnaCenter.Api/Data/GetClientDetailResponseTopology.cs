using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientDetailResponseTopology
	/// </summary>
	[DataContract]
	public class GetClientDetailResponseTopology
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientDetailResponseTopology" /> class.
		/// </summary>
		/// <param name="Nodes">Nodes.</param>
		/// <param name="Links">Links.</param>
		public GetClientDetailResponseTopology(List<GetClientDetailResponseTopologyNodes> Nodes = default, List<GetClientDetailResponseTopologyLinks> Links = default)
		{
			this.Nodes = Nodes;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets Nodes
		/// </summary>
		[DataMember(Name = "nodes", EmitDefaultValue = false)]
		public List<GetClientDetailResponseTopologyNodes> Nodes { get; set; }
		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public List<GetClientDetailResponseTopologyLinks> Links { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientDetailResponseTopology {\n");
			sb.Append("  Nodes: ").Append(Nodes).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
