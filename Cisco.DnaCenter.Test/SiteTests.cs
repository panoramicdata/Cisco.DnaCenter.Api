using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Extensions;
using AwesomeAssertions;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Cisco.DnaCenter.Test;

public class SiteTests : Tests
{
	public SiteTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetSitesAsync_Succeeds()
	{
		var sites = await GetSitesAsync();

		sites.Response.Should().NotBeNull();
		var sitesResponse = sites.Response![0];

		sitesResponse.Should().NotBeNull();
		sitesResponse.Id.Should().NotBeNull();
		var siteId = sitesResponse.Id!;

		// Get details for the first device
		var getSiteResponse = await Client
			.Sites
			.GetSiteAsync(siteId, cancellationToken: TestContext.Current.CancellationToken);
		getSiteResponse.Should().BeOfType<GetSiteSingleResponse>();
		getSiteResponse.Should().NotBeNull();

		var response = getSiteResponse.Response;
		response.Should().NotBeNull();

		response!.Id.Should().Be(siteId);
		response.Name.Should().NotBeNullOrEmpty();
	}

	private async Task<GetSiteResponse> GetSitesAsync()
	{
		var sites = await Client
			.Sites
			.GetSitesAsync()
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
			.CreateSiteAsync(new CreateSiteRequest
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
			}, false, true,
				cancellationToken: TestContext.Current.CancellationToken);

		createSitesResponse.Should().BeOfType<ExecutionStatusResponse>();
		createSitesResponse.Should().NotBeNull();
		createSitesResponse.ExecutionId.Should().NotBeNull();

		var executionStatus = await Client
			.GetFinalExecutionStatusAsync(createSitesResponse.ExecutionId!, cancellationToken: TestContext.Current.CancellationToken);

		executionStatus.Should().BeOfType<ExecutionStatus>();
		executionStatus.Should().NotBeNull();
		executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);

		//	Get site (first page only)
		var sitesResponse = await Client
			.Sites
			.GetSitesAsync(cancellationToken: TestContext.Current.CancellationToken);

		sitesResponse.Response.Should().NotBeNull();
		var site = sitesResponse.Response!.SingleOrDefault(s => s.Name == guid);
		site.Should().NotBeNull();
		site.Should().BeOfType<GetSiteResponseResponse>();
		site!.Id.Should().NotBeNullOrEmpty();

		//	Get all sites
		await Client
			.Sites
			.GetAllSitesAsync(cancellationToken: TestContext.Current.CancellationToken);

		var sites = sitesResponse.Response!.SingleOrDefault(s => s.Name == guid);
		sites.Should().NotBeNull();
		sites.Should().BeOfType<GetSiteResponseResponse>();
		sites.Id.Should().NotBeNullOrEmpty();

		// Read
		var siteById = await Client
			.Sites
			.GetSiteAsync(site.Id!, cancellationToken: TestContext.Current.CancellationToken);

		siteById.Should().BeOfType<GetSiteSingleResponse>();
		siteById.Should().NotBeNull();
		siteById.Response.Should().NotBeNull();
		siteById.Response.Should().BeOfType<GetSiteResponseResponse>();
		siteById.Response.Name.Should().Be(guid);

		// Update
		var updateSiteRequest = new UpdateSiteRequest(
			UpdateSiteRequest.TypeEnum.Area,
			new UpdateSiteRequestSite(new CreateSiteRequestSiteArea("Name is changed", parentName)));

		var updatedSite = await Client
			.Sites
			.UpdateSiteAsync(updateSiteRequest, null, site.Id!, cancellationToken: TestContext.Current.CancellationToken);

		executionStatus = await Client
			.GetFinalExecutionStatusAsync(updatedSite.ExecutionId!, cancellationToken: TestContext.Current.CancellationToken);
		executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);

		// Delete
		var deleteSiteResponse = await Client
			.Sites
			.DeleteSiteAsync(site.Id!, cancellationToken: TestContext.Current.CancellationToken);

		deleteSiteResponse.Should().BeOfType<ExecutionStatusResponse>();
		deleteSiteResponse.Should().NotBeNull();

		executionStatus = await Client
			.GetFinalExecutionStatusAsync(deleteSiteResponse.ExecutionId!, cancellationToken: TestContext.Current.CancellationToken);

		executionStatus.Status.Should().Be(ExecutionStatusStatus.Success);
	}

	[Fact]
	public async Task GetAllSitesAsync_MultipleRequests_LogsUnauthorizedResponses()
	{
		for (int i = 1; i <= 160; i++)
		{
			try
			{
				var result = await Client.Sites.GetAllSitesAsync(cancellationToken: TestContext.Current.CancellationToken);
				Logger.LogInformation("Request {RequestNumber}: Success. Result count: {Count}", i, result.Response?.Count ?? 0);

				// Should always have 7 results
				result.Response.Should().NotBeNull();
				result.Response!.Count.Should().Be(7, "There should always be 7 sites");
			}
			catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.Unauthorized)
			{
				Logger.LogWarning("Request {RequestNumber}: Unauthorized (401). Exception: {Message}", i, ex.Message);

				// Quit
				break;
			}
			catch (Exception ex)
			{
				Logger.LogError("Request {RequestNumber}: Exception: {Message}", i, ex.Message);
				
				// Quit
				break;
			}
		}
	}
}
