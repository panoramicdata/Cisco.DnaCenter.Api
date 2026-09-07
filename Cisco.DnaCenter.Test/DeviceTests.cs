using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Extensions;
using AwesomeAssertions;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Cisco.DnaCenter.Test;

public class DeviceTests : Tests
{
	public DeviceTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		var devices = await GetDevices();

		devices.Response.Should().NotBeNull();
		var device = devices.Response![0];

		device.Should().NotBeNull();
		device.Id.Should().NotBeNull();
		var deviceId = devices.Response[0].Id!;

		// Get details for the first device
		var deviceDetails = await Client
			.Devices
			.GetAsync(deviceId, cancellationToken: TestContext.Current.CancellationToken);
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
	public async Task GetAllInterfacesAsync_Succeeds()
	{
		var interfaces = await Client
			.Devices
			.GetAllInterfacesAsync(cancellationToken: TestContext.Current.CancellationToken);

		interfaces.Should().BeOfType<DeviceIfListResult>();
		interfaces.Should().NotBeNull();
		interfaces.Response.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetDeviceCountAsync_Succeeds()
	{
		var deviceCount = await Client
			.Devices
			.GetCountAsync(cancellationToken: TestContext.Current.CancellationToken);

		deviceCount.Should().BeOfType<CountResult>();
		deviceCount.Response.Should().NotBeNull();
		deviceCount.Response.HasValue.Should().BeTrue();
		deviceCount.Response.Value.Should().NotBe(0);
	}

	[Fact]
	public async Task GitHub_Demo()
	{
		var sites = await Client
			.Sites
			.GetSitesAsync(cancellationToken: TestContext.Current.CancellationToken);

		sites.Response.Should().NotBeNull();
		var firstSite = sites.Response![0];

		var devicesResponse = await Client
			.Devices
			.GetAllAsync(locationName: new List<string> { firstSite.SiteNameHierarchy! }, cancellationToken: TestContext.Current.CancellationToken);

		Logger.LogInformation("Devices:");
		devicesResponse.Response.Should().NotBeNull();
		foreach (var device in devicesResponse.Response!)
		{
			Logger.LogInformation($"    - {device.SerialNumber}: {device.Hostname}");
		}
	}

	[Fact]
	public async Task GetPnpDeviceListAsync_Succeeds()
	{
		var devices = await Client
			.DeviceOnboardingPnp
			.GetPnpDeviceListAsync(cancellationToken: TestContext.Current.CancellationToken);

		devices.Should().NotBeNull();
		devices.Count.Should().Be(50);
	}

	[Fact]
	public async Task GetAllPnpDeviceListAsync()
	{
		var devices = await Client
			.DeviceOnboardingPnp
			.GetAllPnpDeviceListAsync(cancellationToken: TestContext.Current.CancellationToken);

		devices.Should().NotBeNull();
		devices.Count.Should().BeGreaterThan(50);
	}
}
