using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TagMembersResult
/// </summary>
[DataContract]
public class TagMembersResult
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TagMembersResult" /> class.
	/// </summary>
	/// <param name="_Version">_Version.</param>
	/// <param name="Response">Response.</param>
	public TagMembersResult(string? _Version = default, List<TagMembersResultResponse> Response = default)
	{
		this._Version = _Version;
		this.Response = Response;
	}

	/// <summary>
	/// Gets or Sets _Version
	/// </summary>
	[DataMember(Name = "version", EmitDefaultValue = false)]
	public string? _Version { get; set; }

	/// <summary>
	/// Gets or Sets Response
	/// </summary>
	[DataMember(Name = "response", EmitDefaultValue = false)]
	public List<TagMembersResultResponse> Response { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TagMembersResult {\n");
		sb.Append("  _Version: ").Append(_Version).Append("\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
