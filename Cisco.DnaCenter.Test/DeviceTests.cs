using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Extensions;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
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
		public async void GetAllAsync_Succeeds()
		{
			var devices = await GetDevices().ConfigureAwait(false);

			var device = devices.Response[0];

			device.Should().NotBeNull();
			device.Id.Should().NotBeNull();
			var deviceId = devices.Response[0].Id!;

			// Get details for the first device
			var deviceDetails = await Client
				.Devices
				.GetAsync(deviceId)
				.ConfigureAwait(false);
			deviceDetails.Response.Should().NotBeNull();
			deviceDetails.Response.SerialNumber.Should().NotBeNullOrEmpty();
		}

		private async Task<NetworkDeviceListResult> GetDevices()
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

		[Fact]
		public async void GitHub_Demo()
		{
			var sites = await Client
				.Sites
				.GetSitesAsync()
				.ConfigureAwait(false);

			var firstSite = sites.Response[0];

			var devicesResponse = await Client
				.Devices
				.GetAllAsync(locationName: new List<string> { firstSite.SiteNameHierarchy })
				.ConfigureAwait(false);

			Logger.LogInformation("Devices:");
			foreach (var device in devicesResponse.Response)
			{
				Logger.LogInformation($"    - {device.SerialNumber}: {device.Hostname}");
			}
		}

		[Fact]
		public async Task GetPnpDeviceListAsync_Succeeds()
		{
			var devices = await Client
				.DeviceOnboardingPnp
				.GetPnpDeviceListAsync()
				.ConfigureAwait(false);

			devices.Should().NotBeNull();
			devices.Count.Should().Be(50);
		}

		[Fact]
		public async Task GetAllPnpDeviceListAsync()
		{
			var devices = await Client
				.DeviceOnboardingPnp
				.GetAllPnpDeviceListAsync()
				.ConfigureAwait(false);

			devices.Should().NotBeNull();
			devices.Count.Should().BeGreaterThan(50);
		}

		//[Fact(Skip = "Unit test not finished")]
		//public async Task CreateAsync_Succeeds()
		//{
		//	var device = new Device
		//	{
		//		DeviceInfo = new DeviceDeviceInfo(),
		//	};

		//	var result = await Client
		//		.DeviceOnboardingPnp
		//		.ImportDevicesInBulkAsync(device)
		//		.ConfigureAwait(false);

		//	result.Should().NotBeNull();
		//	result.Should().BeOfType<TaskIdResult>();
		//}
	}
}
