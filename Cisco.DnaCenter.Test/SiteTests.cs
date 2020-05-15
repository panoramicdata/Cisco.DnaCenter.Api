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
		private async Task FloorCrud_Succeeds()
		{
			var createSitesResponse = await Client
				.Sites
				.CreateAsync(new CreateSiteRequest
				{
					Type = CreateSiteRequest.TypeEnum.Floor,
					Site = new CreateSiteRequestSite
					{
						Floor = new CreateSiteRequestSiteFloor
						{
							Name = "Ground Floor",
							ParentName = "Global/Welsh Schools/School 2/Campus 1/Main Building",
							Height = 100,
							Width = 100,
							Length = 100,
							RfModel = RfModel.CubesAndWalledOffices
						}
					}
				}, false, true)
				.ConfigureAwait(false);

			createSitesResponse.Should().BeOfType<CreateSiteResponse>();
			createSitesResponse.Should().NotBeNull();
			createSitesResponse.ExecutionId.Should().NotBeNull();

			var executionStatus = await Client
				.GetFinalExecutionStatusAsync(createSitesResponse.ExecutionId!)
				.ConfigureAwait(false);

			executionStatus.Should().BeOfType<ExecutionStatus>();
			executionStatus.Should().NotBeNull();
			executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);
		}
	}
}
