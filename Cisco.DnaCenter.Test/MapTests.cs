using Cisco.DnaCenter.Api.Data;
using AwesomeAssertions;
using System;
using Xunit;

namespace Cisco.DnaCenter.Test;

public class MapTests : Tests
{
	public MapTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetRfModelsAsync_Succeeds()
	{
		var rfModelIdMappings = await Client.Maps.GetRfModelsAsync(cancellationToken: TestContext.Current.CancellationToken);

		rfModelIdMappings.Should().NotBeNull();
		rfModelIdMappings.Should().NotBeEmpty();
		foreach (var item in rfModelIdMappings)
		{
			item.Id.Should().BePositive();
			// These should be 2 until something tells us otherwise
			item.Status.Should().Be(2);
			// The name returned on the mapping should correspond to an RfModel enum entry
			Enum.IsDefined(typeof(RfModel), item.Name).Should().BeTrue();
		}
	}
}
