using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ActivateDto
/// </summary>
[DataContract]
public class ActivateDto : List<ActivateDtoInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ActivateDto" /> class.
	/// </summary>
	[JsonConstructor]
	public ActivateDto()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ActivateDto {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
