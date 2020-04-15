using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDto
	/// </summary>
	[DataContract]
	public partial class TemplateDto
	{
		/// <summary>
		/// Gets or Sets FailurePolicy
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FailurePolicyEnum
		{

			/// <summary>
			/// Enum ABORTONERROR for "ABORT_ON_ERROR"
			/// </summary>
			[EnumMember(Value = "ABORT_ON_ERROR")]
			ABORTONERROR,

			/// <summary>
			/// Enum CONTINUEONERROR for "CONTINUE_ON_ERROR"
			/// </summary>
			[EnumMember(Value = "CONTINUE_ON_ERROR")]
			CONTINUEONERROR,

			/// <summary>
			/// Enum ROLLBACKONERROR for "ROLLBACK_ON_ERROR"
			/// </summary>
			[EnumMember(Value = "ROLLBACK_ON_ERROR")]
			ROLLBACKONERROR,

			/// <summary>
			/// Enum ROLLBACKTARGETONERROR for "ROLLBACK_TARGET_ON_ERROR"
			/// </summary>
			[EnumMember(Value = "ROLLBACK_TARGET_ON_ERROR")]
			ROLLBACKTARGETONERROR,

			/// <summary>
			/// Enum ABORTTARGETONERROR for "ABORT_TARGET_ON_ERROR"
			/// </summary>
			[EnumMember(Value = "ABORT_TARGET_ON_ERROR")]
			ABORTTARGETONERROR
		}

		/// <summary>
		/// Gets or Sets FailurePolicy
		/// </summary>
		[DataMember(Name = "failurePolicy", EmitDefaultValue = false)]
		public FailurePolicyEnum? FailurePolicy { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDto" /> class.
		/// </summary>
		/// <param name="Author">Author.</param>
		/// <param name="Composite">Composite.</param>
		/// <param name="ContainingTemplates">ContainingTemplates.</param>
		/// <param name="CreateTime">CreateTime.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DeviceTypes">DeviceTypes.</param>
		/// <param name="FailurePolicy">FailurePolicy.</param>
		/// <param name="Id">Id.</param>
		/// <param name="LastUpdateTime">LastUpdateTime.</param>
		/// <param name="Name">Name.</param>
		/// <param name="ParentTemplateId">ParentTemplateId.</param>
		/// <param name="ProjectId">ProjectId.</param>
		/// <param name="ProjectName">ProjectName.</param>
		/// <param name="RollbackTemplateContent">RollbackTemplateContent.</param>
		/// <param name="RollbackTemplateParams">RollbackTemplateParams.</param>
		/// <param name="SoftwareType">SoftwareType.</param>
		/// <param name="SoftwareVariant">SoftwareVariant.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="Tags">Tags.</param>
		/// <param name="TemplateContent">TemplateContent.</param>
		/// <param name="TemplateParams">TemplateParams.</param>
		/// <param name="_Version">_Version.</param>
		public TemplateDto(string? Author = default, bool? Composite = default, List<TemplateDtoContainingTemplates> ContainingTemplates = default, int? CreateTime = default, string? Description = default, List<TemplateDtoDeviceTypes> DeviceTypes = default, FailurePolicyEnum? FailurePolicy = default, string? Id = default, int? LastUpdateTime = default, string? Name = default, string? ParentTemplateId = default, string? ProjectId = default, string? ProjectName = default, string? RollbackTemplateContent = default, List<TemplateDtoRollbackTemplateParams> RollbackTemplateParams = default, string? SoftwareType = default, string? SoftwareVariant = default, string? SoftwareVersion = default, List<string> Tags = default, string? TemplateContent = default, List<TemplateDtoRollbackTemplateParams> TemplateParams = default, string? _Version = default)
		{
			this.Author = Author;
			this.Composite = Composite;
			this.ContainingTemplates = ContainingTemplates;
			this.CreateTime = CreateTime;
			this.Description = Description;
			this.DeviceTypes = DeviceTypes;
			this.FailurePolicy = FailurePolicy;
			this.Id = Id;
			this.LastUpdateTime = LastUpdateTime;
			this.Name = Name;
			this.ParentTemplateId = ParentTemplateId;
			this.ProjectId = ProjectId;
			this.ProjectName = ProjectName;
			this.RollbackTemplateContent = RollbackTemplateContent;
			this.RollbackTemplateParams = RollbackTemplateParams;
			this.SoftwareType = SoftwareType;
			this.SoftwareVariant = SoftwareVariant;
			this.SoftwareVersion = SoftwareVersion;
			this.Tags = Tags;
			this.TemplateContent = TemplateContent;
			this.TemplateParams = TemplateParams;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets Author
		/// </summary>
		[DataMember(Name = "author", EmitDefaultValue = false)]
		public string? Author { get; set; }
		/// <summary>
		/// Gets or Sets Composite
		/// </summary>
		[DataMember(Name = "composite", EmitDefaultValue = false)]
		public bool? Composite { get; set; }
		/// <summary>
		/// Gets or Sets ContainingTemplates
		/// </summary>
		[DataMember(Name = "containingTemplates", EmitDefaultValue = false)]
		public List<TemplateDtoContainingTemplates> ContainingTemplates { get; set; }
		/// <summary>
		/// Gets or Sets CreateTime
		/// </summary>
		[DataMember(Name = "createTime", EmitDefaultValue = false)]
		public int? CreateTime { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets DeviceTypes
		/// </summary>
		[DataMember(Name = "deviceTypes", EmitDefaultValue = false)]
		public List<TemplateDtoDeviceTypes> DeviceTypes { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdateTime
		/// </summary>
		[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
		public int? LastUpdateTime { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets ParentTemplateId
		/// </summary>
		[DataMember(Name = "parentTemplateId", EmitDefaultValue = false)]
		public string? ParentTemplateId { get; set; }
		/// <summary>
		/// Gets or Sets ProjectId
		/// </summary>
		[DataMember(Name = "projectId", EmitDefaultValue = false)]
		public string? ProjectId { get; set; }
		/// <summary>
		/// Gets or Sets ProjectName
		/// </summary>
		[DataMember(Name = "projectName", EmitDefaultValue = false)]
		public string? ProjectName { get; set; }
		/// <summary>
		/// Gets or Sets RollbackTemplateContent
		/// </summary>
		[DataMember(Name = "rollbackTemplateContent", EmitDefaultValue = false)]
		public string? RollbackTemplateContent { get; set; }
		/// <summary>
		/// Gets or Sets RollbackTemplateParams
		/// </summary>
		[DataMember(Name = "rollbackTemplateParams", EmitDefaultValue = false)]
		public List<TemplateDtoRollbackTemplateParams> RollbackTemplateParams { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareType
		/// </summary>
		[DataMember(Name = "softwareType", EmitDefaultValue = false)]
		public string? SoftwareType { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVariant
		/// </summary>
		[DataMember(Name = "softwareVariant", EmitDefaultValue = false)]
		public string? SoftwareVariant { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string? SoftwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets Tags
		/// </summary>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; }
		/// <summary>
		/// Gets or Sets TemplateContent
		/// </summary>
		[DataMember(Name = "templateContent", EmitDefaultValue = false)]
		public string? TemplateContent { get; set; }
		/// <summary>
		/// Gets or Sets TemplateParams
		/// </summary>
		[DataMember(Name = "templateParams", EmitDefaultValue = false)]
		public List<TemplateDtoRollbackTemplateParams> TemplateParams { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDto {\n");
			sb.Append("  Author: ").Append(Author).Append("\n");
			sb.Append("  Composite: ").Append(Composite).Append("\n");
			sb.Append("  ContainingTemplates: ").Append(ContainingTemplates).Append("\n");
			sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DeviceTypes: ").Append(DeviceTypes).Append("\n");
			sb.Append("  FailurePolicy: ").Append(FailurePolicy).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ParentTemplateId: ").Append(ParentTemplateId).Append("\n");
			sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
			sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
			sb.Append("  RollbackTemplateContent: ").Append(RollbackTemplateContent).Append("\n");
			sb.Append("  RollbackTemplateParams: ").Append(RollbackTemplateParams).Append("\n");
			sb.Append("  SoftwareType: ").Append(SoftwareType).Append("\n");
			sb.Append("  SoftwareVariant: ").Append(SoftwareVariant).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
			sb.Append("  TemplateContent: ").Append(TemplateContent).Append("\n");
			sb.Append("  TemplateParams: ").Append(TemplateParams).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
