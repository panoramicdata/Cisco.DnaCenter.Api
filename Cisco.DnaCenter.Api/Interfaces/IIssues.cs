using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IIssues
	{
		#region Asynchronous Operations

		/// <summary>
		/// Get Issue Enrichment Details
		/// </summary>
		/// <remarks>
		/// Enriches a given network issue context (an issue id or end user???s Mac Address) with details about the issue(s), impacted hosts and suggested actions for remediation
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="entity_type">Issue enrichment details can be fetched based on either Issue ID or Client MAC address. This parameter value must either be issue_id/mac_address</param>
		/// <param name="entity_value">Contains the actual value for the entity type that has been defined</param>
		/// <returns>Task of GetIssueEnrichmentDetailsResponse</returns>
		[Get("/dna/intent/api/v1/issue-enrichment-details")]
		System.Threading.Tasks.Task<GetIssueEnrichmentDetailsResponse> GetIssueEnrichmentDetails([Header("UserAgent")] string userAgent, string entity_type, string entity_value);
		#endregion Asynchronous Operations
	}
}
