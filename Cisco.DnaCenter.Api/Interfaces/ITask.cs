using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITask
	{
		/// <summary>
		/// Get task by Id
		/// </summary>
		/// <remarks>
		/// Returns a task by specified id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="taskId">UUID of the Task</param>
		/// <returns>Task of TaskDtoResponse</returns>
		[Get("/dna/intent/api/v1/task/{taskId}")]
		Task<TaskDtoResponse> GetTaskById([AliasAs("taskId")]string taskId);

		/// <summary>
		/// Get task by OperationId
		/// </summary>
		/// <remarks>
		/// Returns root tasks associated with an Operationid
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="operationId">operationId</param>
		/// <param name="offset">Index, minimum value is 0</param>
		/// <param name="limit">The maximum value of {limit} supported is 500. &lt;br/&gt; Base 1 indexing for {limit}, minimum value is 1</param>
		/// <returns>Task of TaskDtoListResponse</returns>
		[Get("/dna/intent/api/v1/task/operation/{operationId}/{offset}/{limit}")]
		Task<TaskDtoListResponse> GetTaskByOperationId([AliasAs("operationId")]string operationId, [AliasAs("offset")]int? offset, [AliasAs("limit")]int? limit);

		/// <summary>
		/// Get task count
		/// </summary>
		/// <remarks>
		/// Returns Task count
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startTime">This is the epoch start time from which tasks need to be fetched (optional)</param>
		/// <param name="endTime">This is the epoch end time upto which audit records need to be fetched (optional)</param>
		/// <param name="data">Fetch tasks that contains this data (optional)</param>
		/// <param name="errorCode">Fetch tasks that have this error code (optional)</param>
		/// <param name="serviceType">Fetch tasks with this service type (optional)</param>
		/// <param name="username">Fetch tasks with this username (optional)</param>
		/// <param name="progress">Fetch tasks that contains this progress (optional)</param>
		/// <param name="isError">Fetch tasks ended as success or failure. Valid values: true, false (optional)</param>
		/// <param name="failureReason">Fetch tasks that contains this failure reason (optional)</param>
		/// <param name="parentId">Fetch tasks that have this parent Id (optional)</param>
		/// <returns>Task of CountResult</returns>
		[Get("/dna/intent/api/v1/task/count")]
		Task<CountResult> GetTaskCount([AliasAs("startTime")]string startTime = null, [AliasAs("endTime")]string endTime = null, [AliasAs("data")]string data = null, [AliasAs("errorCode")]string errorCode = null, [AliasAs("serviceType")]string serviceType = null, [AliasAs("username")]string username = null, [AliasAs("progress")]string progress = null, [AliasAs("isError")]string isError = null, [AliasAs("failureReason")]string failureReason = null, [AliasAs("parentId")]string parentId = null);

		/// <summary>
		/// Get task tree
		/// </summary>
		/// <remarks>
		/// Returns a task with its children tasks by based on their id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="taskId">UUID of the Task</param>
		/// <returns>Task of TaskDtoListResponse</returns>
		[Get("/dna/intent/api/v1/task/{taskId}/tree")]
		Task<TaskDtoListResponse> GetTaskTree([AliasAs("taskId")]string taskId);

		/// <summary>
		/// Get tasks
		/// </summary>
		/// <remarks>
		/// Returns task(s) based on filter criteria
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startTime">This is the epoch start time from which tasks need to be fetched (optional)</param>
		/// <param name="endTime">This is the epoch end time upto which audit records need to be fetched (optional)</param>
		/// <param name="data">Fetch tasks that contains this data (optional)</param>
		/// <param name="errorCode">Fetch tasks that have this error code (optional)</param>
		/// <param name="serviceType">Fetch tasks with this service type (optional)</param>
		/// <param name="username">Fetch tasks with this username (optional)</param>
		/// <param name="progress">Fetch tasks that contains this progress (optional)</param>
		/// <param name="isError">Fetch tasks ended as success or failure. Valid values: true, false (optional)</param>
		/// <param name="failureReason">Fetch tasks that contains this failure reason (optional)</param>
		/// <param name="parentId">Fetch tasks that have this parent Id (optional)</param>
		/// <param name="offset">offset (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="sortBy">Sort results by this field (optional)</param>
		/// <param name="order">Sort order - asc or dsc (optional)</param>
		/// <returns>Task of TaskDtoListResponse</returns>
		[Get("/dna/intent/api/v1/task")]
		Task<TaskDtoListResponse> GetTasks([AliasAs("startTime")]string startTime = null, [AliasAs("endTime")]string endTime = null, [AliasAs("data")]string data = null, [AliasAs("errorCode")]string errorCode = null, [AliasAs("serviceType")]string serviceType = null, [AliasAs("username")]string username = null, [AliasAs("progress")]string progress = null, [AliasAs("isError")]string isError = null, [AliasAs("failureReason")]string failureReason = null, [AliasAs("parentId")]string parentId = null, [AliasAs("offset")]string offset = null, [AliasAs("limit")]string limit = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("order")]string order = null);
	}
}
