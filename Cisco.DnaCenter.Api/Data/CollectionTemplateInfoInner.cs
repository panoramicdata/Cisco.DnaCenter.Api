using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CollectionTemplateInfoInner
	/// </summary>
	[DataContract]
	public class CollectionTemplateInfoInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionTemplateInfoInner" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ProjectName">ProjectName.</param>
		/// <param name="ProjectId">ProjectId.</param>
		/// <param name="TemplateId">TemplateId.</param>
		/// <param name="VersionsInfo">VersionsInfo.</param>
		/// <param name="Composite">Composite.</param>
		public CollectionTemplateInfoInner(string? Name = default, string? ProjectName = default, string? ProjectId = default, string? TemplateId = default, List<CollectionTemplateInfoInnerVersionsInfo> VersionsInfo = default, bool? Composite = default)
		{
			this.Name = Name;
			this.ProjectName = ProjectName;
			this.ProjectId = ProjectId;
			this.TemplateId = TemplateId;
			this.VersionsInfo = VersionsInfo;
			this.Composite = Composite;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets ProjectName
		/// </summary>
		[DataMember(Name = "projectName", EmitDefaultValue = false)]
		public string? ProjectName { get; set; }

		/// <summary>
		/// Gets or Sets ProjectId
		/// </summary>
		[DataMember(Name = "projectId", EmitDefaultValue = false)]
		public string? ProjectId { get; set; }

		/// <summary>
		/// Gets or Sets TemplateId
		/// </summary>
		[DataMember(Name = "templateId", EmitDefaultValue = false)]
		public string? TemplateId { get; set; }

		/// <summary>
		/// Gets or Sets VersionsInfo
		/// </summary>
		[DataMember(Name = "versionsInfo", EmitDefaultValue = false)]
		public List<CollectionTemplateInfoInnerVersionsInfo> VersionsInfo { get; set; }

		/// <summary>
		/// Gets or Sets Composite
		/// </summary>
		[DataMember(Name = "composite", EmitDefaultValue = false)]
		public bool? Composite { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CollectionTemplateInfoInner {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
			sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
			sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
			sb.Append("  VersionsInfo: ").Append(VersionsInfo).Append("\n");
			sb.Append("  Composite: ").Append(Composite).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
