using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IIssues
	{
		/// <summary>
		/// Get Issue Enrichment Details
		/// </summary>
		/// <remarks>
		/// Enriches a given network issue context (an issue id or end user???s Mac Address) with details about the issue(s), impacted hosts and suggested actions for remediation
		/// </remarks>
		/// <param name="entity_type">Issue enrichment details can be fetched based on either Issue ID or Client MAC address. This parameter value must either be issue_id/mac_address</param>
		/// <param name="entity_value">Contains the actual value for the entity type that has been defined</param>
		/// <returns>Task of GetIssueEnrichmentDetailsResponse</returns>
		[Get("/dna/intent/api/v1/issue-enrichment-details")]
		Task<GetIssueEnrichmentDetailsResponse> GetAsync(
			string entity_type,
			string entity_value,
			CancellationToken cancellationToken = default);
	}
}
