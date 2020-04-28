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
		public async void GetDeviceListAsync_Succeeds()
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

		private async Task<NetworkDeviceListResult> GetSitesAsync()
		{
			var devices = await Client
				.Devices
				.GetAllAsync()
				.ConfigureAwait(false);

			devices.Should().BeOfType<NetworkDeviceListResult>();
			devices.Should().NotBeNull();
			devices.Response.Should().NotBeNullOrEmpty();
			return devices;
		}

		[Fact]
		public async void GetAllInterfacesAsync_Succeeds()
		{
			var interfaces = await Client
				.Devices
				.GetAllInterfacesAsync()
				.ConfigureAwait(false);

			interfaces.Should().BeOfType<DeviceIfListResult>();
			interfaces.Should().NotBeNull();
			interfaces.Response.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async void GetDeviceCountAsync_Succeeds()
		{
			var deviceCount = await Client
				.Devices
				.GetCountAsync()
				.ConfigureAwait(false);

			deviceCount.Should().BeOfType<CountResult>();
			deviceCount.Response.Should().NotBeNull();
			deviceCount.Response.HasValue.Should().BeTrue();
			deviceCount.Response.Value.Should().NotBe(0);
		}
	}
}
