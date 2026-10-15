using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Extensions;

/// <summary>
/// Extension methods for <see cref="ISites" />.
/// </summary>
public static class ISiteExtensions
{
	/// <summary>
	/// Get Sites
	/// </summary>
	/// <remarks>
	/// Get sites with area/building/floor with specified hierarchy. List all sites if these parameters are not given as an input.
	/// </remarks>
	/// <param name="site">The sites API.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Task of GetSiteResponse</returns>
	public static Task<GetSiteResponse> GetAllSitesAsync(this ISites site, CancellationToken cancellationToken = default)
	{
		return GetAllSitesAsync(site, name: null, siteId: null, type: null, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Get Sites
	/// </summary>
	/// <remarks>
	/// Get sites with area/building/floor with specified hierarchy. List all sites if these parameters are not given as an input.
	/// </remarks>
	/// <param name="name">siteNameHierarchy (ex: global/groupName)</param>
	/// <param name="site">The sites API.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Task of GetSiteResponse</returns>
	public static Task<GetSiteResponse> GetAllSitesAsync(this ISites site, string? name, CancellationToken cancellationToken = default)
	{
		return GetAllSitesAsync(site, name: name, siteId: null, type: null, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Get Sites
	/// </summary>
	/// <remarks>
	/// Get sites with area/building/floor with specified hierarchy. List all sites if these parameters are not given as an input.
	/// </remarks>
	/// <param name="name">siteNameHierarchy (ex: global/groupName)</param>
	/// <param name="siteId">Site id to which site details to retrieve.</param>
	/// <param name="site">The sites API.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Task of GetSiteResponse</returns>
	public static Task<GetSiteResponse> GetAllSitesAsync(this ISites site, string? name, string? siteId, CancellationToken cancellationToken = default)
	{
		return GetAllSitesAsync(site, name: name, siteId: siteId, type: null, cancellationToken: cancellationToken);
	}

	/// <summary>
	/// Get Sites
	/// </summary>
	/// <remarks>
	/// Get sites with area/building/floor with specified hierarchy. List all sites if these parameters are not given as an input.
	/// </remarks>
	/// <param name="name">siteNameHierarchy (ex: global/groupName)</param>
	/// <param name="siteId">Site id to which site details to retrieve.</param>
	/// <param name="type">type (ex: area, building, floor)</param>
	/// <param name="site">The sites API.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Task of GetSiteResponse</returns>
	public static async Task<GetSiteResponse> GetAllSitesAsync(this ISites site, string? name, string? siteId, string? type, CancellationToken cancellationToken = default)
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

			var items = response.Content?.Response
				?? throw new InvalidDataException("The site response contained no sites.");

			// Global appears on every page, so we need to skip it on all but the first page
			if (offset != 1)
			{
				items = items[1..];
			}

			sitesResponses.AddRange(items);

			// If we got less results back than the requested limit, we are done
			if (items.Count < limit)
			{
				break;
			}

			offset += limit;
		}

		var sites = new GetSiteResponse(sitesResponses);
		return sites;
	}
}
