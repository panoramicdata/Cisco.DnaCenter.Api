using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetSdaFabricInfoRequest
/// </summary>
[DataContract]
public class GetSdaFabricInfoRequest : List<GetSdaFabricInfoRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSdaFabricInfoRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public GetSdaFabricInfoRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSdaFabricInfoRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
