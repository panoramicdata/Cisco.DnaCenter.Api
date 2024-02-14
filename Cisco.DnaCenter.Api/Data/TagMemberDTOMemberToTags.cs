namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TagMemberDtoMemberToTags
/// </summary>
[DataContract]
public class TagMemberDtoMemberToTags
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TagMemberDtoMemberToTags" /> class.
	/// </summary>
	public TagMemberDtoMemberToTags() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="TagMemberDtoMemberToTags" /> class.
	/// </summary>
	/// <param name="Key">Key.</param>
	public TagMemberDtoMemberToTags(List<string> Key)
	{
		this.Key = Key;
	}

	/// <summary>
	/// Gets or Sets Key
	/// </summary>
	[DataMember(Name = "key", EmitDefaultValue = false)]
	public List<string> Key { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TagMemberDtoMemberToTags {\n");
		sb.Append("  Key: ").Append(Key).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
