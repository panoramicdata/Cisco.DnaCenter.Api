using Cisco.DnaCenter.Api;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class ClientTests : Tests
	{
		public ClientTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void CreateClient()
		{
			var dnaCenterClient = new DnaCenterClient(new DnaCenterClientOptions
			{
				Uri = new Uri("https://sandboxdnac2.cisco.com/"),
				Username = "devnetuser",
				Password = "Cisco123!"
			});

			await dnaCenterClient
				.ConnectAsync()
				.ConfigureAwait(false);
		}
	}
}
