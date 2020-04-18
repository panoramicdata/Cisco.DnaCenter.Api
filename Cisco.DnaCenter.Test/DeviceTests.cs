using Cisco.DnaCenter.Api.Data;
using FluentAssertions;
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
		public async void GetDeviceListAsync_Succeeds()
		{
			var devices = await GetDevices().ConfigureAwait(false);

			var device = devices.Response[0];

			device.Should().NotBeNull();
			device.Id.Should().NotBeNull();
			var deviceId = devices.Response[0].Id!;

			// Get details for the first device
			var deviceDetails = await Client
				.Devices
				.GetDeviceByIdAsync(deviceId)
				.ConfigureAwait(false);
			deviceDetails.Response.Should().NotBeNull();
			deviceDetails.Response.SerialNumber.Should().NotBeNullOrEmpty();
		}

		private async Task<NetworkDeviceListResult> GetDevices()
		{
			var devices = await Client
				.Devices
				.GetDeviceListAsync()
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
				.GetDeviceCountAsync()
				.ConfigureAwait(false);

			deviceCount.Should().BeOfType<CountResult>();
			deviceCount.Response.Should().NotBeNull();
			deviceCount.Response.HasValue.Should().BeTrue();
			deviceCount.Response.Value.Should().NotBe(0);
		}
	}
}
