using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test;

public class ClientTests : Tests
{
	public ClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, false)
	{
	}

	[Fact]
	public async void ConnectAsync_Succeeds()
	{
		await Client
			.ConnectAsync()
			.ConfigureAwait(false);
	}

	[Fact]
	public async void NoConnectAsync_Succeeds()
	{
		await Client
			.Devices
			.GetCountAsync()
			.ConfigureAwait(false);
	}
}
