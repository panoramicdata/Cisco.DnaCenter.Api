using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplatePreviewRequestDto
	/// </summary>
	[DataContract]
	public class TemplatePreviewRequestDto
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplatePreviewRequestDto" /> class.
		/// </summary>
		/// <param name="_Params">_Params.</param>
		/// <param name="TemplateId">TemplateId.</param>
		public TemplatePreviewRequestDto(Object _Params = default, string? TemplateId = default)
		{
			this._Params = _Params;
			this.TemplateId = TemplateId;
		}

		/// <summary>
		/// Gets or Sets _Params
		/// </summary>
		[DataMember(Name = "params", EmitDefaultValue = false)]
		public Object _Params { get; set; }
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
			sb.Append("class TemplatePreviewRequestDto {\n");
			sb.Append("  _Params: ").Append(_Params).Append("\n");
			sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
