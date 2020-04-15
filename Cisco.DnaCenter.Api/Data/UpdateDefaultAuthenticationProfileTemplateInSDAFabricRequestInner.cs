using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner
	/// </summary>
	[DataContract]
	public partial class UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner" /> class.
		/// </summary>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		/// <param name="AuthenticateTemplateName">AuthenticateTemplateName.</param>
		public UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner(string? SiteNameHierarchy = default, string? AuthenticateTemplateName = default)
		{
			this.SiteNameHierarchy = SiteNameHierarchy;
			this.AuthenticateTemplateName = AuthenticateTemplateName;
		}

		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }
		/// <summary>
		/// Gets or Sets AuthenticateTemplateName
		/// </summary>
		[DataMember(Name = "authenticateTemplateName", EmitDefaultValue = false)]
		public string? AuthenticateTemplateName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner {\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("  AuthenticateTemplateName: ").Append(AuthenticateTemplateName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
