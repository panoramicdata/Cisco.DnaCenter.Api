using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CollectionTemplateInfo
/// </summary>
[DataContract]
public class CollectionTemplateInfo : List<CollectionTemplateInfoInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionTemplateInfo" /> class.
	/// </summary>
	[JsonConstructor]
	public CollectionTemplateInfo()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CollectionTemplateInfo {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
