using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequest
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequest" /> class.
		/// </summary>
		/// <param name="SiteProfile">SiteProfile.</param>
		/// <param name="Provisioning">Provisioning.</param>
		public ProvisionNFVRequest(List<ProvisionNFVRequestSiteProfile> SiteProfile = default, List<ProvisionNFVRequestProvisioning> Provisioning = default)
		{
			this.SiteProfile = SiteProfile;
			this.Provisioning = Provisioning;
		}

		/// <summary>
		/// Gets or Sets SiteProfile
		/// </summary>
		[DataMember(Name = "siteProfile", EmitDefaultValue = false)]
		public List<ProvisionNFVRequestSiteProfile> SiteProfile { get; set; }
		/// <summary>
		/// Gets or Sets Provisioning
		/// </summary>
		[DataMember(Name = "provisioning", EmitDefaultValue = false)]
		public List<ProvisionNFVRequestProvisioning> Provisioning { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequest {\n");
			sb.Append("  SiteProfile: ").Append(SiteProfile).Append("\n");
			sb.Append("  Provisioning: ").Append(Provisioning).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
