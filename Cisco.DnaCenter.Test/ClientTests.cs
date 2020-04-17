using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class ClientTests : Tests
	{
		public ClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper, false)
		{
		}

		[Fact]
		public async void CreateClient()
		{
			await Client
				.ConnectAsync()
				.ConfigureAwait(false);
		}
	}
}
