using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
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
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of LegitCliKeyResult</returns>
		[Get("/dna/intent/api/v1/network-device-poller/cli/legit-reads")]
		Task<LegitCliKeyResult> GetAllKeywordsOfCLIsAcceptedByCommandRunner();

		/// <summary>
		/// Run read-only commands on devices to get their real-time configuration
		/// </summary>
		/// <remarks>
		/// Submit request for read-only CLIs
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/network-device-poller/cli/read-request")]
		Task<TaskIdResult> RunReadOnlyCommandsOnDevicesToGetTheirRealTimeConfiguration([Body]CommandRunnerDto request, string Content_Type);
	}
}
