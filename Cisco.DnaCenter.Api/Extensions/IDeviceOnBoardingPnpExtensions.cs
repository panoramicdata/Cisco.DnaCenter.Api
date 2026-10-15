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
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Every PnP device.</returns>
	public static Task<List<Device>> GetAllPnpDeviceListAsync(
		this IDeviceOnboardingPnp deviceOnboardingPnp,
		CancellationToken cancellationToken)
	{
		return GetAllPnpDeviceListAsync(deviceOnboardingPnp, new PnpDeviceFilter(), cancellationToken);
	}

	/// <summary>
	/// Retrieves every PnP device, following pagination until the list is exhausted.
	/// </summary>
	/// <param name="deviceOnboardingPnp">The device onboarding (PnP) API.</param>
	/// <param name="sort">The fields to sort by.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Every PnP device matching the supplied filters.</returns>
	public static Task<List<Device>> GetAllPnpDeviceListAsync(
		this IDeviceOnboardingPnp deviceOnboardingPnp,
		List<string>? sort,
		CancellationToken cancellationToken)
	{
		return GetAllPnpDeviceListAsync(deviceOnboardingPnp, new PnpDeviceFilter { Sort = sort }, cancellationToken);
	}

	/// <summary>
	/// Retrieves every PnP device, following pagination until the list is exhausted.
	/// </summary>
	/// <param name="deviceOnboardingPnp">The device onboarding (PnP) API.</param>
	/// <param name="sort">The fields to sort by.</param>
	/// <param name="sortOrder">The sort order, ascending or descending.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Every PnP device matching the supplied filters.</returns>
	public static Task<List<Device>> GetAllPnpDeviceListAsync(
		this IDeviceOnboardingPnp deviceOnboardingPnp,
		List<string>? sort,
		string? sortOrder,
		CancellationToken cancellationToken)
	{
		return GetAllPnpDeviceListAsync(
			deviceOnboardingPnp,
			new PnpDeviceFilter { Sort = sort, SortOrder = sortOrder },
			cancellationToken);
	}

	/// <summary>
	/// Retrieves every PnP device, following pagination until the list is exhausted.
	/// </summary>
	/// <param name="deviceOnboardingPnp">The device onboarding (PnP) API.</param>
	/// <param name="filter">The filter criteria to apply.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>Every PnP device matching the supplied filters.</returns>
	public static async Task<List<Device>> GetAllPnpDeviceListAsync(
		this IDeviceOnboardingPnp deviceOnboardingPnp,
		PnpDeviceFilter? filter,
		CancellationToken cancellationToken)
	{
		var filterCriteria = filter ?? new PnpDeviceFilter();
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
						filterCriteria.Sort,
						filterCriteria.SortOrder,
						filterCriteria.SerialNumber,
						filterCriteria.State,
						filterCriteria.OnbState,
						filterCriteria.CmState,
						filterCriteria.Name,
						filterCriteria.Pid,
						filterCriteria.Source,
						filterCriteria.ProjectId,
						filterCriteria.WorkflowId,
						filterCriteria.ProjectName,
						filterCriteria.SiteName,
						filterCriteria.WorkflowName,
						filterCriteria.SmartAccountId,
						filterCriteria.VirtualAccountId,
						filterCriteria.LastContact,
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
