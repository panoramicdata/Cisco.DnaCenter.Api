using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetSmartAccountListResponse
/// </summary>
[DataContract]
public class GetSmartAccountListResponse : List<string>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSmartAccountListResponse" /> class.
	/// </summary>
	[JsonConstructor]
	public GetSmartAccountListResponse()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSmartAccountListResponse {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
