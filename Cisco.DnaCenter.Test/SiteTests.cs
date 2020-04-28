using Cisco.DnaCenter.Api.Data;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class SiteTests : Tests
	{
		public SiteTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetSitesAsync_Succeeds()
		{
			var sites = await GetSitesAsync().ConfigureAwait(false);

			var sitesResponse = sites.Response[0];

			sitesResponse.Should().NotBeNull();
			sitesResponse.Id.Should().NotBeNull();
			var siteId = sites.Response[0].Id!;

			// Get details for the first device
			var siteDetails = await Client
				.Sites
				.GetAllAsync(siteId: siteId)
				.ConfigureAwait(false);
			siteDetails.Response.Should().NotBeEmpty();

			var firstSite = siteDetails.Response[0];

			firstSite.Id.Should().Be(siteId);
			firstSite.Name.Should().NotBeNullOrEmpty();
		}

		private async Task<GetSiteResponse> GetSitesAsync()
		{
			var sites = await Client
				.Sites
				.GetAllAsync()
				.ConfigureAwait(false);

			sites.Should().BeOfType<GetSiteResponse>();
			sites.Should().NotBeNull();
			sites.Response.Should().NotBeNullOrEmpty();
			return sites;
		}
	}
}
