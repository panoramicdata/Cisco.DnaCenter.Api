﻿using Cisco.DnaCenter.Api.Data;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class PlatformTests : Tests
	{
		public PlatformTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetReleaseSummaryAsync_Succeeds()
		{
			var getCiscoDNACenterReleaseSummaryResponseResult = await Client
				.Platform
				.GetCiscoDNACenterReleaseSummaryAsync()
				.ConfigureAwait(false);

			getCiscoDNACenterReleaseSummaryResponseResult.Should().BeOfType<GetCiscoDNACenterReleaseSummaryResponseResult>();
			getCiscoDNACenterReleaseSummaryResponseResult.Should().NotBeNull();

			var getCiscoDNACenterReleaseSummaryResponseResultResponse = getCiscoDNACenterReleaseSummaryResponseResult.Response;

			getCiscoDNACenterReleaseSummaryResponseResultResponse.Should().NotBeNull();
			getCiscoDNACenterReleaseSummaryResponseResultResponse.InstalledVersion.Should().NotBeNull();
		}

		// TODO
		// [Fact]
		// public async void GetNodesConfigurationSummaryAsync_Succeeds() {}

	}
}
