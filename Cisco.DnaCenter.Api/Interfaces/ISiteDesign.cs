using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISiteDesign
	{
		/// <summary>
		/// Get Device details by IP
		/// </summary>
		/// <remarks>
		/// Returns provisioning device information for the specified IP address.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="deviceIp">Device to which the provisioning detail has to be retrieved</param>
		/// <returns>Task of GetDeviceDetailsByIPResponse</returns>
		[Get("/dna/intent/api/v1/business/nfv/provisioningDetail")]
		Task<GetDeviceDetailsByIpResponse> GetDeviceDetailsByIpAsync(
			[Body]GetDeviceDetailsByIPRequest request,
			[AliasAs("deviceIp")]string deviceIp,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// NFV Provisioning Detail
		/// </summary>
		/// <remarks>
		/// Checks the provisioning detail of an ENCS device including log information.
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="__runsynctimeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 10)</param>
		/// <returns>Task of NFVProvisioningDetailResponse</returns>
		[Post("/dna/intent/api/v1/nfv-provision-detail")]
		Task<NfvProvisioningDetailResponse> NfvProvisioningDetail(
			[Body]NfvProvisioningDetailRequest request,
			bool? __runsync,
			bool? __persistbapioutput,
			decimal? __runsynctimeout = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Provision NFV
		/// </summary>
		/// <remarks>
		/// Design and Provision single/multi NFV device with given site/area/building/floor .
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="__runsync">Enable this parameter to execute the API and return a response synchronously</param>
		/// <param name="__persistbapioutput">Persist bapi sync response</param>
		/// <param name="__timeout">During synchronous execution, this defines the maximum time to wait for a response, before the API execution is terminated (optional, default to 10)</param>
		/// <returns>Task of ProvisionNFVResponse</returns>
		[Post("/dna/intent/api/v1/business/nfv")]
		Task<ProvisionNfvResponse> ProvisionNfvAsync(
			[Body]ProvisionNFVRequest request,
			string __runsync,
			bool? __persistbapioutput,
			decimal? __timeout = null,
			CancellationToken cancellationToken = default);
	}
}
