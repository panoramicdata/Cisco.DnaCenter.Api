using Cisco.DnaCenter.Api.Data;
using AwesomeAssertions;
using Xunit;

namespace Cisco.DnaCenter.Test;

public class PlatformTests : Tests
{
	public PlatformTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetReleaseSummaryAsync_Succeeds()
	{
		var getCiscoDNACenterReleaseSummaryResponseResult = await Client
			.Platform
			.GetCiscoDNACenterReleaseSummaryAsync(cancellationToken: TestContext.Current.CancellationToken);

		getCiscoDNACenterReleaseSummaryResponseResult.Should().BeOfType<CiscoDNACenterReleaseSummaryResponseResult>();
		getCiscoDNACenterReleaseSummaryResponseResult.Should().NotBeNull();

		var getCiscoDNACenterReleaseSummaryResponseResultResponse = getCiscoDNACenterReleaseSummaryResponseResult.Response;

		getCiscoDNACenterReleaseSummaryResponseResultResponse.Should().NotBeNull();
		getCiscoDNACenterReleaseSummaryResponseResultResponse.InstalledVersion.Should().NotBeNull();
	}
}
