using Cisco.DnaCenter.Api.Data;
using FluentAssertions;
using System;
using System.Linq;
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
			var getSiteResponse = await Client
				.Sites
				.GetAsync(siteId)
				.ConfigureAwait(false);
			getSiteResponse.Should().BeOfType<GetSiteSingleResponse>();
			getSiteResponse.Should().NotBeNull();

			var response = getSiteResponse.Response;

			response.Id.Should().Be(siteId);
			response.Name.Should().NotBeNullOrEmpty();
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

		[Fact]
		private async Task AreaCrud_Succeeds()
		{
			// Create
			var guid = Guid.NewGuid().ToString().Substring(0, 10);
			const string parentName = "Global";
			var createSitesResponse = await Client
				.Sites
				.CreateAsync(new CreateSiteRequest
				{
					Type = CreateSiteRequest.TypeEnum.Area,
					Site = new CreateSiteRequestSite
					{
						Area = new CreateSiteRequestSiteArea
						{
							Name = guid,
							ParentName = parentName
						}
					}
				}, false, true)
				.ConfigureAwait(false);

			createSitesResponse.Should().BeOfType<ExecutionStatusResponse>();
			createSitesResponse.Should().NotBeNull();
			createSitesResponse.ExecutionId.Should().NotBeNull();

			var executionStatus = await Client
				.GetFinalExecutionStatusAsync(createSitesResponse.ExecutionId!)
				.ConfigureAwait(false);

			executionStatus.Should().BeOfType<ExecutionStatus>();
			executionStatus.Should().NotBeNull();
			executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);

			//	Get all sites
			var sitesResponse = await Client
				.Sites
				.GetAllAsync()
				.ConfigureAwait(false);

			var site = sitesResponse.Response.SingleOrDefault(s => s.Name == guid);
			site.Should().NotBeNull();
			site.Should().BeOfType<GetSiteResponseResponse>();
			site.Id.Should().NotBeNullOrEmpty();

			// Read
			var siteById = await Client
				.Sites
				.GetAsync(site.Id!)
				.ConfigureAwait(false);

			siteById.Should().BeOfType<GetSiteSingleResponse>();
			siteById.Should().NotBeNull();
			siteById.Response.Should().NotBeNull();
			siteById.Response.Should().BeOfType<GetSiteResponseResponse>();
			siteById.Response.Name.Should().Be(guid);

			// Delete
			var deleteSiteResponse = await Client
				.Sites
				.DeleteAsync(site.Id!)
				.ConfigureAwait(false);

			deleteSiteResponse.Should().BeOfType<ExecutionStatusResponse>();
			deleteSiteResponse.Should().NotBeNull();

			executionStatus = await Client
				.GetFinalExecutionStatusAsync(deleteSiteResponse.ExecutionId!)
				.ConfigureAwait(false);


			executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);
		}
	}
}
