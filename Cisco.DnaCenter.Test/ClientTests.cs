using Xunit;

namespace Cisco.DnaCenter.Test;

public class ClientTests : Tests
{
	public ClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, false)
	{
	}

	[Fact]
	public async Task ConnectAsync_Succeeds()
	{
		await Client
			.ConnectAsync(cancellationToken: TestContext.Current.CancellationToken);
	}

	[Fact]
	public async Task NoConnectAsync_Succeeds()
	{
		await Client
			.Devices
			.GetCountAsync(cancellationToken: TestContext.Current.CancellationToken);
	}
}
