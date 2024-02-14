using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Extensions
{
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
		/// <returns>Task of List GetSiteResponse</returns>
		public static async Task<List<GetSiteResponseResponse>> GetAllSitesAsync(this ISites site,

			string? name = null,
			string? siteId = null,
			string? type = null,
			CancellationToken cancellationToken = default)
		{
			var sites = new List<GetSiteResponseResponse>();
			var offset = 1;
			const int limit = 500;
			while (true)
			{
				var sitesPage = await
					site
						.GetSitesAsync(
							name,
							siteId,
							type,
							offset.ToString(),
							limit.ToString(),
							cancellationToken)
						.ConfigureAwait(false);
				sites.AddRange(sitesPage.Response);

				if (sitesPage.Response.Count == 0)
				{
					break;
				}

				offset += limit;
			}
			return sites;
		}
	}
}
