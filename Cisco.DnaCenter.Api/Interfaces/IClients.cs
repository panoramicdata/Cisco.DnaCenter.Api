using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IClients
	{
		/// <summary>
		/// Get Client Detail
		/// </summary>
		/// <remarks>
		/// Returns detailed Client information retrieved by Mac Address for any given point of time.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="macAddress">MAC Address of the client</param>
		/// <param name="timestamp">Epoch time(in milliseconds) when the Client health data is required (optional, default to )</param>
		/// <returns>Task of GetClientDetailResponse</returns>
		[Get("/dna/intent/api/v1/client-detail")]
		Task<GetClientDetailResponse> GetClientDetail([AliasAs("macAddress")]string macAddress, [AliasAs("timestamp")]string timestamp = null);

		/// <summary>
		/// Get Client Enrichment Details
		/// </summary>
		/// <remarks>
		/// Enriches a given network End User context (a network user-id or end user???s device Mac Address) with details about the user, the devices that the user is connected to and the assurance issues that the user is impacted by
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="entity_type">Client enrichment details can be fetched based on either User ID or Client MAC address. This parameter value must either be network_user_id/mac_address</param>
		/// <param name="entity_value">Contains the actual value for the entity type that has been defined</param>
		/// <param name="issueCategory">The category of the DNA event based on which the underlying issues need to be fetched (optional, default to )</param>
		/// <returns>Task of GetClientEnrichmentDetailsResponse</returns>
		[Get("/dna/intent/api/v1/client-enrichment-details")]
		Task<GetClientEnrichmentDetailsResponse> GetClientEnrichmentDetails(string entity_type, string entity_value, string issueCategory = null);

		/// <summary>
		/// Get Overall Client Health
		/// </summary>
		/// <remarks>
		/// Returns Overall Client Health information by Client type (Wired and Wireless) for any given point of time
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="timestamp">Epoch time(in milliseconds) when the Client health data is required (optional, default to )</param>
		/// <returns>Task of GetOverallClientHealthResponse</returns>
		[Get("/dna/intent/api/v1/client-health")]
		Task<GetOverallClientHealthResponse> GetOverallClientHealth([AliasAs("timestamp")]string timestamp = null);
	}
}
