using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IApplicationPolicy
	{
		/// <summary>
		/// Create Application
		/// </summary>
		/// <remarks>
		/// Create new Custom application
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of CreateApplicationResponse</returns>
		[Post("/dna/intent/api/v1/applications")]
		Task<CreateApplicationResponse> CreateApplication([Body]CreateApplicationRequest request);

		/// <summary>
		/// Create Application Set
		/// </summary>
		/// <remarks>
		/// Create new custom application-set/s
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of CreateApplicationSetResponse</returns>
		[Post("/dna/intent/api/v1/application-policy-application-set")]
		Task<CreateApplicationSetResponse> CreateApplicationSet([Body]CreateApplicationSetRequest request);

		/// <summary>
		/// Delete Application
		/// </summary>
		/// <remarks>
		/// Delete existing application by its id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">Application&#39;s Id</param>
		/// <returns>Task of DeleteApplicationResponse</returns>
		[Delete("/dna/intent/api/v1/applications")]
		Task<DeleteApplicationResponse> DeleteApplication([AliasAs("id")]string id);

		/// <summary>
		/// Delete Application Set
		/// </summary>
		/// <remarks>
		/// Delete existing application-set by it&#39;s id
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id"></param>
		/// <returns>Task of DeleteApplicationSetResponse</returns>
		[Delete("/dna/intent/api/v1/application-policy-application-set")]
		Task<DeleteApplicationSetResponse> DeleteApplicationSet([AliasAs("id")]string id);

		/// <summary>
		/// Edit Application
		/// </summary>
		/// <remarks>
		/// Edit the attributes of an existing application
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of EditApplicationResponse</returns>
		[Put("/dna/intent/api/v1/applications")]
		Task<EditApplicationResponse> EditApplication([Body]EditApplicationRequest request);

		/// <summary>
		/// Get Application Sets
		/// </summary>
		/// <remarks>
		/// Get appllication-sets by offset/limit or by name
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="offset"> (optional, default to 1)</param>
		/// <param name="limit"> (optional, default to 500)</param>
		/// <param name="name"> (optional, default to )</param>
		/// <returns>Task of GetApplicationSetsResponse</returns>
		[Get("/dna/intent/api/v1/application-policy-application-set")]
		Task<GetApplicationSetsResponse> GetApplicationSets([AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null, [AliasAs("name")]string name = null);

		/// <summary>
		/// Get Application Sets Count
		/// </summary>
		/// <remarks>
		/// Get the number of existing application-sets
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GetApplicationSetsCountResponse</returns>
		[Get("/dna/intent/api/v1/application-policy-application-set-count")]
		Task<GetApplicationSetsCountResponse> GetApplicationSetsCount([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Get Applications
		/// </summary>
		/// <remarks>
		/// Get applications by offset/limit or by name
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="offset">The offset of the first application to be returned (optional, default to 1)</param>
		/// <param name="limit">The maximum number of applications to be returned (optional, default to 500)</param>
		/// <param name="name">Application&#39;s name (optional, default to )</param>
		/// <returns>Task of GetApplicationsResponse</returns>
		[Get("/dna/intent/api/v1/applications")]
		Task<GetApplicationsResponse> GetApplications([AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null, [AliasAs("name")]string name = null);

		/// <summary>
		/// Get Applications Count
		/// </summary>
		/// <remarks>
		/// Get the number of all existing applications
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of GetApplicationsCountResponse</returns>
		[Get("/dna/intent/api/v1/applications-count")]
		Task<GetApplicationsCountResponse> GetApplicationsCount([Header("UserAgent")] string userAgent);
	}
}
