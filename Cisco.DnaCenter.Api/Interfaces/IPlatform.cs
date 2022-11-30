using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IPlatform
	{
		/// <summary>
		/// Retrieves release summary
		/// </summary>
		/// <remarks>
		/// Provides information such as API version, mandatory core packages for installation or upgrade, optional packages, Cisco DNA Center name and version, supported direct updates, and tenant ID.
		/// </remarks>
		/// <returns>Task of GetCiscoDNACenterReleaseSummaryResponse</returns>
		[Get("/dna/intent/api/v1/dnac-release")]
		Task<CiscoDNACenterReleaseSummaryResponseResult> GetCiscoDNACenterReleaseSummaryAsync(
			CancellationToken cancellationToken = default);
	}
}
