using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IPathTrace
	{
		/// <summary>
		/// Deletes Pathtrace by Id
		/// </summary>
		/// <remarks>
		/// Deletes a flow analysis request by its id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="flowAnalysisId">Flow analysis request id</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/flow-analysis/{flowAnalysisId}")]
		Task<TaskIdResult> DeletesPathtraceById([AliasAs("flowAnalysisId")]string flowAnalysisId);

		/// <summary>
		/// Initiate a new Pathtrace
		/// </summary>
		/// <remarks>
		/// Initiates a new flow analysis with periodic refresh and stat collection options. Returns a request id and a task id to get results and follow progress.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of FlowAnalysisRequestResultOutput</returns>
		[Post("/dna/intent/api/v1/flow-analysis")]
		Task<FlowAnalysisRequestResultOutput> InitiateANewPathtrace([Body]FlowAnalysisRequest request);

		/// <summary>
		/// Retrieves previous Pathtrace
		/// </summary>
		/// <remarks>
		/// Returns result of a previously requested flow analysis by its Flow Analysis id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="flowAnalysisId">Flow analysis request id</param>
		/// <returns>Task of PathResponseResult</returns>
		[Get("/dna/intent/api/v1/flow-analysis/{flowAnalysisId}")]
		Task<PathResponseResult> RetrievesPreviousPathtrace([AliasAs("flowAnalysisId")]string flowAnalysisId);

		/// <summary>
		/// Retrives all previous Pathtraces summary
		/// </summary>
		/// <remarks>
		/// Returns a summary of all flow analyses stored. Results can be filtered by specified parameters.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="periodicRefresh">Is analysis periodically refreshed? (optional)</param>
		/// <param name="sourceIP">Source IP address (optional)</param>
		/// <param name="destIP">Destination IP adress (optional)</param>
		/// <param name="sourcePort">Source port (optional)</param>
		/// <param name="destPort">Destination port (optional)</param>
		/// <param name="gtCreateTime">Analyses requested after this time (optional)</param>
		/// <param name="ltCreateTime">Analyses requested before this time (optional)</param>
		/// <param name="protocol">Protocol (optional)</param>
		/// <param name="status">Status (optional)</param>
		/// <param name="taskId">Task ID (optional)</param>
		/// <param name="lastUpdateTime">Last update time (optional)</param>
		/// <param name="limit">Number of resources returned (optional)</param>
		/// <param name="offset">Start index of resources returned (1-based) (optional)</param>
		/// <param name="order">Order by this field (optional)</param>
		/// <param name="sortBy">Sort by this field (optional)</param>
		/// <returns>Task of FlowAnalysisListOutput</returns>
		[Get("/dna/intent/api/v1/flow-analysis")]
		Task<FlowAnalysisListOutput> RetrivesAllPreviousPathtracesSummary([AliasAs("periodicRefresh")]bool? periodicRefresh = null, [AliasAs("sourceIP")]string sourceIP = null, [AliasAs("destIP")]string destIP = null, [AliasAs("sourcePort")]string sourcePort = null, [AliasAs("destPort")]string destPort = null, [AliasAs("gtCreateTime")]string gtCreateTime = null, [AliasAs("ltCreateTime")]string ltCreateTime = null, [AliasAs("protocol")]string protocol = null, [AliasAs("status")]string status = null, [AliasAs("taskId")]string taskId = null, [AliasAs("lastUpdateTime")]string lastUpdateTime = null, [AliasAs("limit")]string limit = null, [AliasAs("offset")]string offset = null, [AliasAs("order")]string order = null, [AliasAs("sortBy")]string sortBy = null);
	}
}
