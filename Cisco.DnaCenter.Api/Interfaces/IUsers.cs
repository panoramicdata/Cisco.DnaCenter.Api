using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IUsers
	{
		#region Asynchronous Operations

		/// <summary>
		/// Get User Enrichment Details
		/// </summary>
		/// <remarks>
		/// Enriches a given network End User context (a network user-id or end user???s device Mac Address) with details about the user and devices that the user is connected to
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="entity_type">User enrichment details can be fetched based on either User ID or Client MAC address. This parameter value must either be network_user_id/mac_address</param>
		/// <param name="entity_value">Contains the actual value for the entity type that has been defined</param>
		/// <returns>Task of GetUserEnrichmentDetailsResponse</returns>
		[Get("/dna/intent/api/v1/user-enrichment-details")]
		System.Threading.Tasks.Task<GetUserEnrichmentDetailsResponse> GetUserEnrichmentDetails([Header("UserAgent")] string userAgent, string entity_type, string entity_value);
		#endregion Asynchronous Operations
	}
}
