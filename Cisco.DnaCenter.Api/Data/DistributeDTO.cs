using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DistributeDto
/// </summary>
[DataContract]
public class DistributeDto : List<DistributeDtoInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DistributeDto" /> class.
	/// </summary>
	[JsonConstructor]
	public DistributeDto()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DistributeDto {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
