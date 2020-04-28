using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDeploymentInfo
	/// </summary>
	[DataContract]
	public class TemplateDeploymentInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDeploymentInfo" /> class.
		/// </summary>
		/// <param name="ForcePushTemplate">ForcePushTemplate.</param>
		/// <param name="IsComposite">IsComposite.</param>
		/// <param name="MainTemplateId">MainTemplateId.</param>
		/// <param name="MemberTemplateDeploymentInfo">MemberTemplateDeploymentInfo.</param>
		/// <param name="TargetInfo">TargetInfo.</param>
		/// <param name="TemplateId">TemplateId.</param>
		public TemplateDeploymentInfo(bool? ForcePushTemplate = default, bool? IsComposite = default, string? MainTemplateId = default, List<string> MemberTemplateDeploymentInfo = default, List<TemplateDeploymentInfoTargetInfo> TargetInfo = default, string? TemplateId = default)
		{
			this.ForcePushTemplate = ForcePushTemplate;
			this.IsComposite = IsComposite;
			this.MainTemplateId = MainTemplateId;
			this.MemberTemplateDeploymentInfo = MemberTemplateDeploymentInfo;
			this.TargetInfo = TargetInfo;
			this.TemplateId = TemplateId;
		}

		/// <summary>
		/// Gets or Sets ForcePushTemplate
		/// </summary>
		[DataMember(Name = "forcePushTemplate", EmitDefaultValue = false)]
		public bool? ForcePushTemplate { get; set; }

		/// <summary>
		/// Gets or Sets IsComposite
		/// </summary>
		[DataMember(Name = "isComposite", EmitDefaultValue = false)]
		public bool? IsComposite { get; set; }

		/// <summary>
		/// Gets or Sets MainTemplateId
		/// </summary>
		[DataMember(Name = "mainTemplateId", EmitDefaultValue = false)]
		public string? MainTemplateId { get; set; }

		/// <summary>
		/// Gets or Sets MemberTemplateDeploymentInfo
		/// </summary>
		[DataMember(Name = "memberTemplateDeploymentInfo", EmitDefaultValue = false)]
		public List<string> MemberTemplateDeploymentInfo { get; set; }

		/// <summary>
		/// Gets or Sets TargetInfo
		/// </summary>
		[DataMember(Name = "targetInfo", EmitDefaultValue = false)]
		public List<TemplateDeploymentInfoTargetInfo> TargetInfo { get; set; }

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
			sb.Append("class TemplateDeploymentInfo {\n");
			sb.Append("  ForcePushTemplate: ").Append(ForcePushTemplate).Append("\n");
			sb.Append("  IsComposite: ").Append(IsComposite).Append("\n");
			sb.Append("  MainTemplateId: ").Append(MainTemplateId).Append("\n");
			sb.Append("  MemberTemplateDeploymentInfo: ").Append(MemberTemplateDeploymentInfo).Append("\n");
			sb.Append("  TargetInfo: ").Append(TargetInfo).Append("\n");
			sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
