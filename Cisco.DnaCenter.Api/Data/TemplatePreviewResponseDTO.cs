using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplatePreviewResponseDto
	/// </summary>
	[DataContract]
	public partial class TemplatePreviewResponseDto
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplatePreviewResponseDto" /> class.
		/// </summary>
		/// <param name="CliPreview">CliPreview.</param>
		/// <param name="TemplateId">TemplateId.</param>
		/// <param name="ValidationErrors">ValidationErrors.</param>
		public TemplatePreviewResponseDto(string? CliPreview = default, string? TemplateId = default, Object ValidationErrors = default)
		{
			this.CliPreview = CliPreview;
			this.TemplateId = TemplateId;
			this.ValidationErrors = ValidationErrors;
		}

		/// <summary>
		/// Gets or Sets CliPreview
		/// </summary>
		[DataMember(Name = "cliPreview", EmitDefaultValue = false)]
		public string? CliPreview { get; set; }
		/// <summary>
		/// Gets or Sets TemplateId
		/// </summary>
		[DataMember(Name = "templateId", EmitDefaultValue = false)]
		public string? TemplateId { get; set; }
		/// <summary>
		/// Gets or Sets ValidationErrors
		/// </summary>
		[DataMember(Name = "validationErrors", EmitDefaultValue = false)]
		public Object ValidationErrors { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplatePreviewResponseDto {\n");
			sb.Append("  CliPreview: ").Append(CliPreview).Append("\n");
			sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
			sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
