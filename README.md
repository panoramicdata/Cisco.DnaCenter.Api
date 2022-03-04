# Cisco.DnaCenter.Api

[![Nuget](https://img.shields.io/nuget/v/Cisco.DnaCenter.Api)](https://www.nuget.org/packages/Cisco.DnaCenter.Api/)

To use the Cisco DNA Center nuget package:

## Visual Studio

1. Open your project in Visual Studio
1. Right-click on the project and click "Manage Nuget packages"
1. Find the package "Cisco.DnaCenter.Api" - install the latest version

## Example code (C# 8.0):

``` C#
using Cisco.DnaCenter.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My.Project
{
	public static class Program
	{
		public static async Task Main()
		{
			var dnaCenterClient = new DnaCenterClient(new DnaCenterClientOptions
			{
				Uri = new Uri("https://mydnac.example.com/"),
				Username = "username",
				Password = "password"
			});

			var sites = await dnaCenterClient
				.Sites
				.GetAllAsync()
				.ConfigureAwait(false);

			var firstSite = sites.Response[0];

			var devicesResponse = await dnaCenterClient
				.Devices
				.GetAllAsync(locationName: new List<string> { firstSite.SiteNameHierarchy })
				.ConfigureAwait(false);

			Console.WriteLine("Devices:");
			foreach (var device in devicesResponse.Response)
			{
				Console.WriteLine($"    - {device.SerialNumber}: {device.Hostname}");
			}
		}
	}
}
````

## API Documentation

The DNA Center Intent API documentation can be found here:

- [DNA Center Intent API Documentation](https://developer.cisco.com/docs/dna-center/api/1-3-3-x/)

## Testing

You can test this using a DNA Center Sandbox here:

- [Cisco DNA Center AO 1.3.1.4](https://devnetsandbox.cisco.com/RM/Diagram/Index/471eb739-323e-4805-b2a6-d0ec813dc8fc?diagramType=Topology)
- [Cisco DNA Center Lab 1](https://devnetsandbox.cisco.com/RM/Diagram/Index/b8d7aa34-aa8f-4bf2-9c42-302aaa2daafb?diagramType=Topology)

After signing in, look in the lower left hand side of the page for your URL, username and password.
