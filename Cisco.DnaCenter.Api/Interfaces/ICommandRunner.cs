using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICommandRunner
{
	/// <summary>
	/// Get all keywords of CLIs accepted by command runner
	/// </summary>
	/// <remarks>
	/// Get valid keywords
	/// </remarks>
	/// <returns>Task of LegitCliKeyResult</returns>
	[Get("/dna/intent/api/v1/network-device-poller/cli/legit-reads")]
	Task<LegitCliKeyResult> GetAllKeywordsOfClisAcceptedByCommandRunnerAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Run read-only commands on devices to get their real-time configuration
	/// </summary>
	/// <remarks>
	/// Submit request for read-only CLIs
	/// </remarks>
	/// <param name="request">request</param>
	/// <returns>Task of TaskIdResult</returns>
	[Post("/dna/intent/api/v1/network-device-poller/cli/read-request")]
	Task<TaskIdResult> RunReadOnlyCommandsOnDevicesToGetTheirRealTimeConfigurationAsync(
		[Body]CommandRunnerDto request,
		CancellationToken cancellationToken = default);
}
