using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TagMemberDto
/// </summary>
[DataContract]
public class TagMemberDto
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TagMemberDto" /> class.
	/// </summary>
	/// <param name="MemberToTags">MemberToTags.</param>
	/// <param name="MemberType">MemberType.</param>
	public TagMemberDto(List<TagMemberDtoMemberToTags> MemberToTags = default, string? MemberType = default)
	{
		this.MemberToTags = MemberToTags;
		this.MemberType = MemberType;
	}

	/// <summary>
	/// Gets or Sets MemberToTags
	/// </summary>
	[DataMember(Name = "memberToTags", EmitDefaultValue = false)]
	public List<TagMemberDtoMemberToTags> MemberToTags { get; set; }

	/// <summary>
	/// Gets or Sets MemberType
	/// </summary>
	[DataMember(Name = "memberType", EmitDefaultValue = false)]
	public string? MemberType { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TagMemberDto {\n");
		sb.Append("  MemberToTags: ").Append(MemberToTags).Append("\n");
		sb.Append("  MemberType: ").Append(MemberType).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
