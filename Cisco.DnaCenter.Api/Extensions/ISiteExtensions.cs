using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Extensions;

public static class ISiteExtensions
{
	/// <summary>
	/// Get Sites
	/// </summary>
	/// <remarks>
	/// Get sites with area/building/floor with specified hierarchy. List all sites if these parameters are not given as an input.
	/// </remarks>
	/// <param name="name">siteNameHierarchy (ex: global/groupName) (optional, default to )</param>
	/// <param name="siteId">Site id to which site details to retrieve. (optional, default to )</param>
	/// <param name="type">type (ex: area, building, floor) (optional, default to )</param>
	/// <returns>Task of GetSiteResponse</returns>
	public static async Task<GetSiteResponse> GetAllSitesAsync(this ISites site,

		string? name = null,
		string? siteId = null,
		string? type = null,
		CancellationToken cancellationToken = default)
	{
		var sitesResponses = new List<GetSiteResponseResponse>();
		var offset = 1;
		const int limit = 500;
		while (true)
		{
			var response = await
				site
					.GetSitesInternalAsync(
						name,
						siteId,
						type,
						offset.ToString(),
						limit.ToString(),
						cancellationToken)
					.ConfigureAwait(false);

			if (response.IsSuccessStatusCode == false)
			{
				throw new InvalidDataException(response.ReasonPhrase);
			}

			var items = response.Content.Response;

			// Global appears on every page, so we need to skip it on all but the first page
			if (offset != 1)
			{
				items = items[1..];
			}

			sitesResponses.AddRange(items);

			if (items.Count == 0)
			{
				break;
			}

			offset += limit;
		}

		var sites = new GetSiteResponse(sitesResponses);
		return sites;
	}
}
