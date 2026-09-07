using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Extensions;

/// <summary>
/// Extension methods for <see cref="IDeviceOnboardingPnp" />.
/// </summary>
public static class IDeviceOnBoardingPnpExtensions
{
	/// <summary>
	/// Retrieves every PnP device, following pagination until the list is exhausted.
	/// </summary>
	/// <param name="deviceOnboardingPnp">The device onboarding (PnP) API.</param>
	/// <param name="sort">The fields to sort by.</param>
	/// <param name="sortOrder">The sort order, ascending or descending.</param>
	/// <param name="serialNumber">Serial numbers to filter by.</param>
	/// <param name="state">Device states to filter by.</param>
	/// <param name="onbState">Onboarding states to filter by.</param>
	/// <param name="cmState">Connection manager states to filter by.</param>
	/// <param name="name">Device names to filter by.</param>
	/// <param name="pid">Product IDs to filter by.</param>
	/// <param name="source">Device sources to filter by.</param>
	/// <param name="projectId">Project IDs to filter by.</param>
	/// <param name="workflowId">Workflow IDs to filter by.</param>
	/// <param name="projectName">Project names to filter by.</param>
	/// <param name="siteName">Site names to filter by.</param>
	/// <param name="workflowName">Workflow names to filter by.</param>
	/// <param name="smartAccountId">Smart account IDs to filter by.</param>
	/// <param name="virtualAccountId">Virtual account IDs to filter by.</param>
	/// <param name="lastContact">Whether to filter to devices with a last contact time.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Every PnP device matching the supplied filters.</returns>
	public static async Task<List<Device>> GetAllPnpDeviceListAsync(this IDeviceOnboardingPnp deviceOnboardingPnp,

		List<string>? sort = null,
		string? sortOrder = null,
		List<string>? serialNumber = null,
		List<string>? state = null,
		List<string>? onbState = null,
		List<string>? cmState = null,
		List<string>? name = null,
		List<string>? pid = null,
		List<string>? source = null,
		List<string>? projectId = null,
		List<string>? workflowId = null,
		List<string>? projectName = null,
		List<string>? siteName = null,
		List<string>? workflowName = null,
		List<string>? smartAccountId = null,
		List<string>? virtualAccountId = null,
		bool? lastContact = null,
		CancellationToken cancellationToken = default)
	{
		var devices = new List<Device>();
		const int limit = 50;
		var offset = 0;
		while (true)
		{
			var devicesPage = await
				deviceOnboardingPnp
					.GetPnpDeviceListAsync(
						limit,
						offset,
						sort,
						sortOrder,
						serialNumber,
						state,
						onbState,
						cmState,
						name,
						pid,
						source,
						projectId,
						workflowId,
						projectName,
						siteName,
						workflowName,
						smartAccountId,
						virtualAccountId,
						lastContact,
						cancellationToken)
					.ConfigureAwait(false);
			devices.AddRange(devicesPage);

			if (devicesPage.Count == 0)
			{
				break;
			}

			offset += limit;
		}
		return devices;
	}
}
