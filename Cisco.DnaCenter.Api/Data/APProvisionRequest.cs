using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// APProvisionRequest
/// </summary>
[DataContract]
public class ApProvisionRequest : List<ApProvisionRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ApProvisionRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public ApProvisionRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class APProvisionRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
