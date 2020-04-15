using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFile
	{
		#region Asynchronous Operations

		/// <summary>
		/// Download a file by fileId
		/// </summary>
		/// <remarks>
		/// Downloads a file specified by fileId
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="fileId">File Identification number</param>
		/// <returns>Task of DownloadAFileByFileIdResponse</returns>
		[Get("/dna/intent/api/v1/file/{fileId}")]
		System.Threading.Tasks.Task<DownloadAFileByFileIdResponse> DownloadAFileByFileId([Header("UserAgent")] string userAgent, [AliasAs("fileId")]string fileId);

		/// <summary>
		/// Get list of available namespaces
		/// </summary>
		/// <remarks>
		/// Returns list of available namespaces
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of NameSpaceListResult</returns>
		[Get("/dna/intent/api/v1/file/namespace")]
		System.Threading.Tasks.Task<NameSpaceListResult> GetListOfAvailableNamespaces([Header("UserAgent")] string userAgent);

		/// <summary>
		/// Get list of files
		/// </summary>
		/// <remarks>
		/// Returns list of files under a specific namespace
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="_nameSpace">A listing of fileId&#39;s</param>
		/// <returns>Task of FileObjectListResult</returns>
		[Get("/dna/intent/api/v1/file/namespace/{nameSpace}")]
		System.Threading.Tasks.Task<FileObjectListResult> GetListOfFiles([Header("UserAgent")] string userAgent, [AliasAs("_nameSpace")]string _nameSpace);
		#endregion Asynchronous Operations
	}
}
