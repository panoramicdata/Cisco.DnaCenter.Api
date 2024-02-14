using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CreateApplicationRequest
/// </summary>
[DataContract]
public class CreateApplicationRequest : List<CreateApplicationRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CreateApplicationRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public CreateApplicationRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CreateApplicationRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
