using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITopologies
	{
		/// <summary>
		/// Get L3 Topology Details
		/// </summary>
		/// <remarks>
		/// Returns the Layer 3 network topology by routing protocol
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="topologyType">Type of topology(OSPF,ISIS,etc)</param>
		/// <returns>Task of TopologyResult</returns>
		[Get("/dna/intent/api/v1/topology/l3/{topologyType}")]
		Task<TopologyResult> GetL3TopologyDetails([AliasAs("topologyType")]string topologyType);

		/// <summary>
		/// Get Overall Network Health
		/// </summary>
		/// <remarks>
		/// Returns Overall Network Health information by Device category (Access, Distribution, Core, Router, Wireless) for any given point of time
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="timestamp">Epoch time(in milliseconds) when the Network health data is required (optional, default to )</param>
		/// <returns>Task of GetOverallNetworkHealthResponse</returns>
		[Get("/dna/intent/api/v1/network-health")]
		Task<GetOverallNetworkHealthResponse> GetOverallNetworkHealth([AliasAs("timestamp")]string timestamp = null);

		/// <summary>
		/// Get Physical Topology
		/// </summary>
		/// <remarks>
		/// Returns the raw physical topology by specified criteria of nodeType
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="nodeType">nodeType (optional)</param>
		/// <returns>Task of TopologyResult</returns>
		[Get("/dna/intent/api/v1/topology/physical-topology")]
		Task<TopologyResult> GetPhysicalTopology([AliasAs("nodeType")]string nodeType = null);

		/// <summary>
		/// Get Site Topology
		/// </summary>
		/// <remarks>
		/// Returns site topology
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of SiteResult</returns>
		[Get("/dna/intent/api/v1/topology/site-topology")]
		Task<SiteResult> GetSiteTopology();

		/// <summary>
		/// Get topology details
		/// </summary>
		/// <remarks>
		/// Returns Layer 2 network topology by specified VLAN ID
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="vlanID">Vlan Name for e.g Vlan1, Vlan23 etc</param>
		/// <returns>Task of TopologyResult</returns>
		[Get("/dna/intent/api/v1/topology/l2/{vlanID}")]
		Task<TopologyResult> GetTopologyDetails([AliasAs("vlanID")]string vlanID);

		/// <summary>
		/// Get VLAN details
		/// </summary>
		/// <remarks>
		/// Returns the list of VLAN names
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of VlanNamesResult</returns>
		[Get("/dna/intent/api/v1/topology/vlan/vlan-names")]
		Task<VlanNamesResult> GetVLANDetails();
	}
}
