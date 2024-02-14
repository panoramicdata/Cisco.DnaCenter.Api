using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// AddVNInSdaFabricRequest
/// </summary>
[DataContract]
public class AddVnInSdaFabricRequest : List<AddVNInSdaFabricRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddVnInSdaFabricRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public AddVnInSdaFabricRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AddVNInSdaFabricRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
