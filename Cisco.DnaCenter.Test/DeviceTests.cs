using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class DeviceTests : Tests
	{
		public DeviceTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetAllInterfacesAsync_Succeeds()
		{
			var interfaces = await Client
				.Devices
				.GetAllInterfacesAsync()
				.ConfigureAwait(false);

			interfaces.Should().NotBeNull();
			interfaces.Response.Should().NotBeNullOrEmpty();
		}
	}
}
