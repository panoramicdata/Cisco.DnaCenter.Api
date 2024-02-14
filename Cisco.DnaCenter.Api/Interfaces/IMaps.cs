using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the /api/v1/dna-maps-service/ endpoints
/// </summary>
public interface IMaps
{
	/// <summary>
	/// Get RFModels
	/// </summary>
	/// <returns>A list of RF Models</returns>
	[Get("/api/v1/dna-maps-service/calibration/rfmodels")]
	Task<List<RfModelIdMapping>> GetRfModelsAsync(CancellationToken cancellationToken = default);
}
