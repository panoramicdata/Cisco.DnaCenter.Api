[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# Cisco.DnaCenter.Api

[![Nuget](https://img.shields.io/nuget/v/Cisco.DnaCenter.Api)](https://www.nuget.org/packages/Cisco.DnaCenter.Api/)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/1dd6d6dbca1d45389c10ce38fd956769)](https://app.codacy.com/gh/panoramicdata/Cisco.DnaCenter.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

> **Need help with APIs or .NET?** Panoramic Data are experts in APIs and .NET, and we can help with your development. [Contact us](https://www.panoramicdata.com/contact-us) or see our [software services](https://www.panoramicdata.com/services/software).

Supports .NET 11.0.

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

## Breaking changes

Package versions follow the DNA Center API version and are driven by Nerdbank.GitVersioning, so these changes are not signalled by a major version bump. `main` breaks the public API of the published 1.3.175 release in the ways below (derived by comparing the public API of the 1.3.175 package with a build of `main`). Code compiled against 1.3.175 throws `MissingMethodException` until it is recompiled, and some call sites need editing.

### Target framework

1.3.175 targets `net11.0`. `main` targets `net11.0`.

### Methods that lost their optional parameters

Optional parameters were replaced with overloads, which changes the method signatures:

| Area | Member | Change |
|---|---|---|
| Client | `DnaCenterClient.GetFinalExecutionStatusAsync` | The single method with optional `timeout`, `pollingDelay`, `initialDelay` and `cancellationToken` is now `(executionId, timeout, pollingDelay, initialDelay, cancellationToken)` plus `(executionId, cancellationToken)`. Calls such as `GetFinalExecutionStatusAsync(id)` or `GetFinalExecutionStatusAsync(id, timeout: t)` no longer compile; pass a token. |
| Client | `DnaCenterClient` constructor and `ConnectAsync` | The optional `logger` and `cancellationToken` are now overloads. Source compatible, binary incompatible. |
| Sites | `ISiteExtensions.GetAllSitesAsync` | `name`, `siteId`, `type` and `cancellationToken` are now overloads. They bind only in that order, so a call using named arguments out of order, such as `GetAllSitesAsync(type: "area")`, no longer compiles. |
| PnP | `IDeviceOnBoardingPnpExtensions.GetAllPnpDeviceListAsync` | The single method with 17 optional filter parameters is replaced by overloads taking `sort`, `sort` and `sortOrder`, or a `PnpDeviceFilter` (new class holding every filter), each with a `cancellationToken`. Calls that pass `serialNumber`, `state`, `name` and other filters must move to `PnpDeviceFilter`. |

```csharp
// Before (1.3.175)
var devices = await client.DeviceOnboardingPnp.GetAllPnpDeviceListAsync(serialNumber: new List<string> { "FOC123" });
var status = await client.GetFinalExecutionStatusAsync(executionId);

// After
var devices = await client.DeviceOnboardingPnp.GetAllPnpDeviceListAsync(
	new PnpDeviceFilter { SerialNumber = new List<string> { "FOC123" } },
	cancellationToken);
var status = await client.GetFinalExecutionStatusAsync(executionId, cancellationToken);
```

### Other changes

- `AuthenticatedHttpClientHandler.Token` gained a getter (it was set-only). Not breaking.
- `DnaCenterClientOptions.IsReadOnly` and the `PnpDeviceFilter` class are new. Not breaking.

All other public types and members, including the generated interfaces and data classes, are unchanged.
## API Documentation

The DNA Center Intent API documentation can be found here:

- [DNA Center Intent API Documentation](https://developer.cisco.com/docs/dna-center/api/1-3-3-x/)

## Testing

You can test this using a DNA Center Sandbox here:

- [Cisco DNA Center AO 1.3.1.4](https://devnetsandbox.cisco.com/RM/Diagram/Index/471eb739-323e-4805-b2a6-d0ec813dc8fc?diagramType=Topology)
- [Cisco DNA Center Lab 1](https://devnetsandbox.cisco.com/RM/Diagram/Index/b8d7aa34-aa8f-4bf2-9c42-302aaa2daafb?diagramType=Topology)

After signing in, look in the lower left hand side of the page for your URL, username and password.
