using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TagDtoDynamicRules
	/// </summary>
	[DataContract]
	public class TagDtoDynamicRules
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TagDtoDynamicRules" /> class.
		/// </summary>
		/// <param name="MemberType">MemberType.</param>
		/// <param name="Rules">Rules.</param>
		public TagDtoDynamicRules(string? MemberType = default, TagDtoRules Rules = default)
		{
			this.MemberType = MemberType;
			this.Rules = Rules;
		}

		/// <summary>
		/// Gets or Sets MemberType
		/// </summary>
		[DataMember(Name = "memberType", EmitDefaultValue = false)]
		public string? MemberType { get; set; }

		/// <summary>
		/// Gets or Sets Rules
		/// </summary>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public TagDtoRules Rules { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TagDtoDynamicRules {\n");
			sb.Append("  MemberType: ").Append(MemberType).Append("\n");
			sb.Append("  Rules: ").Append(Rules).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
