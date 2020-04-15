using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISiteDesign
	{
		#region Asynchronous Operations

		/// <summary>
		/// Get Device details by IP
		/// </summary>
		/// <remarks>
		/// Returns provisioning device information for the specified IP address.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="deviceIp">Device to which the provisioning detail has to be retrieved</param>
		/// <returns>Task of GetDeviceDetailsByIPResponse</returns>
		[Get("/dna/intent/api/v1/business/nfv/provisioningDetail")]
		System.Threading.Tasks.Task<GetDeviceDetailsByIPResponse> GetDeviceDetailsByIP([Header("UserAgent")] string userAgent, [Body]GetDeviceDetailsByIPRequest request, [AliasAs("deviceIp")]string deviceIp);

		/// <summary>
		/// NFV Provisioning Detail
		/// </summary>
		/// <remarks>
		/// Checks the provisioning detail of an ENCS device including log information.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="__runsynctimeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 10)</param>
		/// <returns>Task of NFVProvisioningDetailResponse</returns>
		[Post("/dna/intent/api/v1/nfv-provision-detail")]
		System.Threading.Tasks.Task<NFVProvisioningDetailResponse> NFVProvisioningDetail([Header("UserAgent")] string userAgent, [Body]NFVProvisioningDetailRequest request, bool? __runsync, bool? __persistbapioutput, decimal? __runsynctimeout = null);

		/// <summary>
		/// Provision NFV
		/// </summary>
		/// <remarks>
		/// Design and Provision single/multi NFV device with given site/area/building/floor .
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="__timeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 10)</param>
		/// <returns>Task of ProvisionNFVResponse</returns>
		[Post("/dna/intent/api/v1/business/nfv")]
		System.Threading.Tasks.Task<ProvisionNFVResponse> ProvisionNFV([Header("UserAgent")] string userAgent, [Body]ProvisionNFVRequest request, string __runsync, bool? __persistbapioutput, decimal? __timeout = null);
		#endregion Asynchronous Operations
	}
}
