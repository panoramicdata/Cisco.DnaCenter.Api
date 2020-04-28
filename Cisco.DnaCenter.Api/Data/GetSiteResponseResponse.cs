using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSiteResponseResponse
	/// </summary>
	[DataContract]
	public class GetSiteResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSiteResponseResponse" /> class.
		/// </summary>
		/// <param name="ParentId">ParentId.</param>
		/// <param name="Name">Name.</param>
		/// <param name="AdditionalInfo">AdditionalInfo.</param>
		/// <param name="SiteHierarchy">SiteHierarchy.</param>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="Id">Id.</param>
		public GetSiteResponseResponse(string? ParentId = default, string? Name = default, List<string> AdditionalInfo = default, string? SiteHierarchy = default, string? SiteNameHierarchy = default, string? InstanceTenantId = default, string? Id = default)
		{
			this.ParentId = ParentId;
			this.Name = Name;
			this.AdditionalInfo = AdditionalInfo;
			this.SiteHierarchy = SiteHierarchy;
			this.SiteNameHierarchy = SiteNameHierarchy;
			this.InstanceTenantId = InstanceTenantId;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets ParentId
		/// </summary>
		[DataMember(Name = "parentId", EmitDefaultValue = false)]
		public string? ParentId { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalInfo
		/// </summary>
		[DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
		public List<string> AdditionalInfo { get; set; }

		/// <summary>
		/// Gets or Sets SiteHierarchy
		/// </summary>
		[DataMember(Name = "siteHierarchy", EmitDefaultValue = false)]
		public string? SiteHierarchy { get; set; }

		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }

		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSiteResponseResponse {\n");
			sb.Append("  ParentId: ").Append(ParentId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
			sb.Append("  SiteHierarchy: ").Append(SiteHierarchy).Append("\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
