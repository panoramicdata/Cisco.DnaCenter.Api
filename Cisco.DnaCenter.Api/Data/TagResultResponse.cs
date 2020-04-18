using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TagResultResponse
	/// </summary>
	[DataContract]
	public class TagResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TagResultResponse" /> class.
		/// </summary>
		/// <param name="SystemTag">SystemTag.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DynamicRules">DynamicRules.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		public TagResultResponse(bool? SystemTag = default, string? Description = default, List<TagDtoDynamicRules> DynamicRules = default, string? Name = default, string? Id = default, string? InstanceTenantId = default)
		{
			this.SystemTag = SystemTag;
			this.Description = Description;
			this.DynamicRules = DynamicRules;
			this.Name = Name;
			this.Id = Id;
			this.InstanceTenantId = InstanceTenantId;
		}

		/// <summary>
		/// Gets or Sets SystemTag
		/// </summary>
		[DataMember(Name = "systemTag", EmitDefaultValue = false)]
		public bool? SystemTag { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets DynamicRules
		/// </summary>
		[DataMember(Name = "dynamicRules", EmitDefaultValue = false)]
		public List<TagDtoDynamicRules> DynamicRules { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TagResultResponse {\n");
			sb.Append("  SystemTag: ").Append(SystemTag).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DynamicRules: ").Append(DynamicRules).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
