using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SystemPropertyNameAndIntValueDto
/// </summary>
[DataContract]
public class SystemPropertyNameAndIntValueDto : List<SystemPropertyListResultResponse>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SystemPropertyNameAndIntValueDto" /> class.
	/// </summary>
	[JsonConstructor]
	public SystemPropertyNameAndIntValueDto()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SystemPropertyNameAndIntValueDto {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
