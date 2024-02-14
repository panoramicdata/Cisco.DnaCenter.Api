using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeleteSdaFabricRequest
/// </summary>
[DataContract]
public class DeleteSdaFabricRequest : List<GetSdaFabricInfoRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeleteSdaFabricRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public DeleteSdaFabricRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeleteSdaFabricRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
