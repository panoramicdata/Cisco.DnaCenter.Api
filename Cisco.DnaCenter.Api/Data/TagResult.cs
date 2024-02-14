using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TagResult
/// </summary>
[DataContract]
public class TagResult
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TagResult" /> class.
	/// </summary>
	/// <param name="_Version">_Version.</param>
	/// <param name="Response">Response.</param>
	public TagResult(string? _Version = default, TagResultResponse Response = default)
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
	public TagResultResponse Response { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TagResult {\n");
		sb.Append("  _Version: ").Append(_Version).Append("\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
