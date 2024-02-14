using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetDeviceEnrichmentDetailsResponse
/// </summary>
[DataContract]
public class GetDeviceEnrichmentDetailsResponse : List<GetDeviceEnrichmentDetailsResponseInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponse" /> class.
	/// </summary>
	[JsonConstructor]
	public GetDeviceEnrichmentDetailsResponse()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetDeviceEnrichmentDetailsResponse {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
