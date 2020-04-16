using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISites
	{
		/// <summary>
		/// Assign Device To Site
		/// </summary>
		/// <remarks>
		/// Assigns list of devices to a site
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="siteId">Site id to which site the device to assign</param>
		/// <param name="__runsynctimeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 55)</param>
		/// <returns>Task of AssignDeviceToSiteResponse</returns>
		[Post("/dna/system/api/v1/site/{siteId}/device")]
		Task<AssignDeviceToSiteResponse> AssignDeviceToSite([Body]AssignDeviceToSiteRequest request, bool? __runsync, bool? __persistbapioutput, [AliasAs("siteId")]string siteId, decimal? __runsynctimeout = null);

		/// <summary>
		/// Create Site
		/// </summary>
		/// <remarks>
		/// Creates site with area/building/floor with specified hierarchy.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="__timeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 30)</param>
		/// <returns>Task of CreateSiteResponse</returns>
		[Post("/dna/intent/api/v1/site")]
		Task<CreateSiteResponse> CreateSite([Body]CreateSiteRequest request, bool? __runsync, bool? __persistbapioutput, decimal? __timeout = null);

		/// <summary>
		/// Delete Site
		/// </summary>
		/// <remarks>
		/// Delete site with area/building/floor by siteId.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteId">Site id to which site details to be deleted.</param>
		/// <returns>Task of DeleteSiteResponse</returns>
		[Delete("/dna/intent/api/v1/site/{siteId}")]
		Task<DeleteSiteResponse> DeleteSite([AliasAs("siteId")]string siteId);

		/// <summary>
		/// Get Membership
		/// </summary>
		/// <remarks>
		/// Getting the site children details and device details.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteId">Site id to retrieve device associated with the site.</param>
		/// <returns>Task of GetMembershipResponse</returns>
		[Get("/dna/intent/api/v1/membership/{siteId}")]
		Task<GetMembershipResponse> GetMembership([AliasAs("siteId")]string siteId);

		/// <summary>
		/// Get Site
		/// </summary>
		/// <remarks>
		/// Get site with area/building/floor with specified hierarchy.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">siteNameHierarchy (ex: global/groupName) (optional, default to )</param>
		/// <param name="siteId">Site id to which site details to retrieve. (optional, default to )</param>
		/// <param name="type">type (ex: area, building, floor) (optional, default to )</param>
		/// <param name="offset">offset/starting row (optional, default to )</param>
		/// <param name="limit">Number of sites to be retrieved (optional, default to )</param>
		/// <returns>Task of GetSiteResponse</returns>
		[Get("/dna/intent/api/v1/site")]
		Task<GetSiteResponse> GetSite([AliasAs("name")]string name = null, [AliasAs("siteId")]string siteId = null, [AliasAs("type")]string type = null, [AliasAs("offset")]string offset = null, [AliasAs("limit")]string limit = null);

		/// <summary>
		/// Get Site Count
		/// </summary>
		/// <remarks>
		/// API to get site count
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="siteId"> Site id to retrieve site count. (optional, default to )</param>
		/// <returns>Task of GetSiteCountResponse</returns>
		[Get("/dna/intent/api/v1/site/count")]
		Task<GetSiteCountResponse> GetSiteCount([AliasAs("siteId")]string siteId = null);

		/// <summary>
		/// Get Site Health
		/// </summary>
		/// <remarks>
		/// Returns Overall Health information for all sites
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="timestamp">Epoch time(in milliseconds) when the Site Hierarchy data is required (optional, default to )</param>
		/// <returns>Task of GetSiteHealthResponse</returns>
		[Get("/dna/intent/api/v1/site-health")]
		Task<GetSiteHealthResponse> GetSiteHealth([AliasAs("timestamp")]string timestamp = null);

		/// <summary>
		/// Update Site
		/// </summary>
		/// <remarks>
		/// Update site area/building/floor with specified hierarchy and new values
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="siteId">Site id to which site details to be updated.</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously (optional, default to false)</param>
		/// <param name="__timeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 10)</param>
		/// <returns>Task of UpdateSiteResponse</returns>
		[Put("/dna/intent/api/v1/site/{siteId}")]
		Task<UpdateSiteResponse> UpdateSite([Body]UpdateSiteRequest request, bool? __persistbapioutput, [AliasAs("siteId")]string siteId, bool? __runsync = null, decimal? __timeout = null);
	}
}
