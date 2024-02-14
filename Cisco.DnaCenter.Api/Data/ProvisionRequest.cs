using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionRequest
/// </summary>
[DataContract]
public class ProvisionRequest : List<ProvisionRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public ProvisionRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
