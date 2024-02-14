using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// AddSiteInSdaFabricRequest
/// </summary>
[DataContract]
public class AddSiteInSdaFabricRequest : List<AddSiteInSdaFabricRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddSiteInSdaFabricRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public AddSiteInSdaFabricRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AddSiteInSdaFabricRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
