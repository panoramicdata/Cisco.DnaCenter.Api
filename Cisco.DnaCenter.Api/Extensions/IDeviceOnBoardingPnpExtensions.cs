using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Extensions
{
	public static class IDeviceOnBoardingPnpExtensions
	{
		public static async Task<List<Device>> GetAllPnpDeviceListAsync(this IDeviceOnboardingPnp deviceOnboardingPnp,

			List<string> sort = null,
			string sortOrder = null,
			List<string> serialNumber = null,
			List<string> state = null,
			List<string> onbState = null,
			List<string> cmState = null,
			List<string> name = null,
			List<string> pid = null,
			List<string> source = null,
			List<string> projectId = null,
			List<string> workflowId = null,
			List<string> projectName = null,
			List<string> siteName = null,
			List<string> workflowName = null,
			List<string> smartAccountId = null,
			List<string> virtualAccountId = null,
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
}
