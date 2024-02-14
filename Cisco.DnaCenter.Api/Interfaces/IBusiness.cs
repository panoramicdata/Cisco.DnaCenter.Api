using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the /dna/platform/management/business-api/v1/ endpoints
/// </summary>
public interface IBusiness
{
	/// <summary>
	/// Get execution status given and execution Id
	/// </summary>
	[Get("/dna/platform/management/business-api/v1/execution-status/{executionId}")]
	Task<ExecutionStatus> GetExecutionStatusAsync(
		string executionId,
		CancellationToken cancellationToken = default);
}
