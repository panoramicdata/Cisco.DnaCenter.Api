using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// AdditionalInfo
/// </summary>
[DataContract]
public class AdditionalInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteResponseResponse" /> class.
	/// </summary>
	/// <param name="NameSpace">NameSpace.</param>
	/// <param name="Attributes">Attributes.</param>
	public AdditionalInfo(
		string? NameSpace = default,
		Dictionary<string, string> Attributes = default)
	{
		this.NameSpace = NameSpace;
		this.Attributes = Attributes;
	}

	/// <summary>
	/// The namespace
	/// </summary>
	[DataMember(Name = "nameSpace", EmitDefaultValue = false)]
	public string? NameSpace { get; set; }

	/// <summary>
	/// Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	public Dictionary<string, string> Attributes { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSiteResponseResponse {\n");
		sb.Append("  NameSpace: ").Append(NameSpace).Append("\n");
		sb.Append("  Attributes: ").Append(Attributes?.Count ?? 0).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
