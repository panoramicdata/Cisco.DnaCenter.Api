using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionUpdateRequest
/// </summary>
[DataContract]
public class ProvisionUpdateRequest : List<ProvisionUpdateRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionUpdateRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public ProvisionUpdateRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionUpdateRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
