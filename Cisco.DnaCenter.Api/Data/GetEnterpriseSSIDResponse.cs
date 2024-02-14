using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetEnterpriseSSIDResponse
/// </summary>
[DataContract]
public class GetEnterpriseSsidResponse : List<GetEnterpriseSsidResponseInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetEnterpriseSsidResponse" /> class.
	/// </summary>
	[JsonConstructor]
	public GetEnterpriseSsidResponse()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetEnterpriseSSIDResponse {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
