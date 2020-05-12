using Cisco.DnaCenter.Api.Data;
using FluentAssertions;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class MapTests : Tests
	{
		public MapTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetRfModelsAsync_Succeeds()
		{
			var rfModelIdMappings = await Client.Maps.GetRfModelsAsync().ConfigureAwait(false);

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
}
