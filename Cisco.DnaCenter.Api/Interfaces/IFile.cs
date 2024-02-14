using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IFiles
{
	/// <summary>
	/// Download a file by fileId
	/// </summary>
	/// <remarks>
	/// Downloads a file specified by fileId
	/// </remarks>
	/// <param name="fileId">File Identification number</param>
	/// <returns>Task of DownloadAFileByFileIdResponse</returns>
	[Get("/dna/intent/api/v1/file/{fileId}")]
	Task<DownloadFileByFileIdResponse> GetAsync(
		[AliasAs("fileId")]string fileId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get list of available namespaces
	/// </summary>
	/// <remarks>
	/// Returns list of available namespaces
	/// </remarks>
	/// <returns>Task of NameSpaceListResult</returns>
	[Get("/dna/intent/api/v1/file/namespace")]
	Task<NameSpaceListResult> GetNamespacesAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get list of files
	/// </summary>
	/// <remarks>
	/// Returns list of files under a specific namespace
	/// </remarks>
	/// <param name="_nameSpace">A listing of fileId&#39;s</param>
	/// <returns>Task of FileObjectListResult</returns>
	[Get("/dna/intent/api/v1/file/namespace/{nameSpace}")]
	Task<FileObjectListResult> GetAllAsync(
		[AliasAs("nameSpace")]string nameSpace,
		CancellationToken cancellationToken = default);
}
