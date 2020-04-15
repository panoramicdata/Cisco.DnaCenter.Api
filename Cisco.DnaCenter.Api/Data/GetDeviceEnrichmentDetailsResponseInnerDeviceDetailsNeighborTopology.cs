using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology
	/// </summary>
	[DataContract]
	public partial class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology" /> class.
		/// </summary>
		/// <param name="Nodes">Nodes.</param>
		/// <param name="Links">Links.</param>
		public GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology(List<GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes> Nodes = default, List<GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks> Links = default)
		{
			this.Nodes = Nodes;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets Nodes
		/// </summary>
		[DataMember(Name = "nodes", EmitDefaultValue = false)]
		public List<GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes> Nodes { get; set; }
		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public List<GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks> Links { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology {\n");
			sb.Append("  Nodes: ").Append(Nodes).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
