using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateVersionRequestDto
	/// </summary>
	[DataContract]
	public class TemplateVersionRequestDto
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateVersionRequestDto" /> class.
		/// </summary>
		/// <param name="Comments">Comments.</param>
		/// <param name="TemplateId">TemplateId.</param>
		public TemplateVersionRequestDto(string? Comments = default, string? TemplateId = default)
		{
			this.Comments = Comments;
			this.TemplateId = TemplateId;
		}

		/// <summary>
		/// Gets or Sets Comments
		/// </summary>
		[DataMember(Name = "comments", EmitDefaultValue = false)]
		public string? Comments { get; set; }
		/// <summary>
		/// Gets or Sets TemplateId
		/// </summary>
		[DataMember(Name = "templateId", EmitDefaultValue = false)]
		public string? TemplateId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateVersionRequestDto {\n");
			sb.Append("  Comments: ").Append(Comments).Append("\n");
			sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
