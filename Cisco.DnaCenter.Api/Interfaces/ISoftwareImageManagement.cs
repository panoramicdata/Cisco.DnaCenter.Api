using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISoftwareImageManagement
	{
		/// <summary>
		/// Get software image details
		/// </summary>
		/// <remarks>
		/// Returns software image list based on a filter criteria. For example: \&quot;filterbyName &#x3D; cat3k%\&quot;
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="imageUuid">imageUuid (optional)</param>
		/// <param name="name">name (optional)</param>
		/// <param name="family">family (optional)</param>
		/// <param name="applicationType">applicationType (optional)</param>
		/// <param name="imageIntegrityStatus">imageIntegrityStatus - FAILURE, UNKNOWN, VERIFIED (optional)</param>
		/// <param name="_version">software Image Version (optional)</param>
		/// <param name="imageSeries">image Series (optional)</param>
		/// <param name="imageName">image Name (optional)</param>
		/// <param name="isTaggedGolden">is Tagged Golden (optional)</param>
		/// <param name="isCCORecommended">is recommended from cisco.com (optional)</param>
		/// <param name="isCCOLatest">is latest from cisco.com (optional)</param>
		/// <param name="createdTime">time in milliseconds (epoch format) (optional)</param>
		/// <param name="imageSizeGreaterThan">size in bytes (optional)</param>
		/// <param name="imageSizeLesserThan">size in bytes (optional)</param>
		/// <param name="sortBy">sort results by this field (optional)</param>
		/// <param name="sortOrder">sort order - &#39;asc&#39; or &#39;des&#39;. Default is asc (optional)</param>
		/// <param name="limit">limit (optional)</param>
		/// <param name="offset">offset (optional)</param>
		/// <returns>Task of ImageInfoListResponse</returns>
		[Get("/dna/intent/api/v1/image/importation")]
		Task<ImageInfoListResponse> GetSoftwareImageDetails([AliasAs("imageUuid")]string imageUuid = null, [AliasAs("name")]string name = null, [AliasAs("family")]string family = null, [AliasAs("applicationType")]string applicationType = null, [AliasAs("imageIntegrityStatus")]string imageIntegrityStatus = null, [AliasAs("_version")]string _version = null, [AliasAs("imageSeries")]string imageSeries = null, [AliasAs("imageName")]string imageName = null, [AliasAs("isTaggedGolden")]bool? isTaggedGolden = null, [AliasAs("isCCORecommended")]bool? isCCORecommended = null, [AliasAs("isCCOLatest")]bool? isCCOLatest = null, [AliasAs("createdTime")]int? createdTime = null, [AliasAs("imageSizeGreaterThan")]int? imageSizeGreaterThan = null, [AliasAs("imageSizeLesserThan")]int? imageSizeLesserThan = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("sortOrder")]string sortOrder = null, [AliasAs("limit")]int? limit = null, [AliasAs("offset")]int? offset = null);

		/// <summary>
		/// Import local software image
		/// </summary>
		/// <remarks>
		/// Fetches a software image from local file system and uploads to DNA Center. Supported software image files extensions are bin, img, tar, smu, pie, aes, iso, ova, tar_gz and qcow2
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="isThirdParty">Third party Image check (optional)</param>
		/// <param name="thirdPartyVendor">Third Party Vendor (optional)</param>
		/// <param name="thirdPartyImageFamily">Third Party image family (optional)</param>
		/// <param name="thirdPartyApplicationType">Third Party Application Type (optional)</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/image/importation/source/file")]
		Task<TaskIdResult> ImportLocalSoftwareImage(string Content_Type, [AliasAs("isThirdParty")]bool? isThirdParty = null, [AliasAs("thirdPartyVendor")]string thirdPartyVendor = null, [AliasAs("thirdPartyImageFamily")]string thirdPartyImageFamily = null, [AliasAs("thirdPartyApplicationType")]string thirdPartyApplicationType = null);

		/// <summary>
		/// Import software image via URL
		/// </summary>
		/// <remarks>
		/// Fetches a software image from remote file system (using URL for HTTP/FTP) and uploads to DNA Center. Supported image files extensions are bin, img, tar, smu, pie, aes, iso, ova, tar_gz and qcow2
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="scheduleAt">Epoch Time (The number of milli-seconds since January 1 1970 UTC) at which the distribution should be scheduled (Optional)  (optional)</param>
		/// <param name="scheduleDesc">Custom Description (Optional) (optional)</param>
		/// <param name="scheduleOrigin">Originator of this call (Optional) (optional)</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/image/importation/source/url")]
		Task<TaskIdResult> ImportSoftwareImageViaURL([Body]ImageImportFromUrlDto request, string Content_Type, [AliasAs("scheduleAt")]string scheduleAt = null, [AliasAs("scheduleDesc")]string scheduleDesc = null, [AliasAs("scheduleOrigin")]string scheduleOrigin = null);

		/// <summary>
		/// Trigger software image activation
		/// </summary>
		/// <remarks>
		/// Activates a software image on a given device. Software image must be present in the device flash
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Client_Type">Client-type (Optional) (optional)</param>
		/// <param name="Client_Url">Client-url (Optional) (optional)</param>
		/// <param name="scheduleValidate">scheduleValidate, validates data before schedule (Optional) (optional)</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/image/activation/device")]
		Task<TaskIdResult> TriggerSoftwareImageActivation([Body]ActivateDto request, string Content_Type, string Client_Type = null, string Client_Url = null, [AliasAs("scheduleValidate")]bool? scheduleValidate = null);

		/// <summary>
		/// Trigger software image distribution
		/// </summary>
		/// <remarks>
		/// Distributes a software image on a given device. Software image must be imported successfully into DNA Center before it can be distributed
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/image/distribution")]
		Task<TaskIdResult> TriggerSoftwareImageDistribution([Body]DistributeDto request);
	}
}
