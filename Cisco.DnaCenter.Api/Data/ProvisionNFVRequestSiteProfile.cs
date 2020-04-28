using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestSiteProfile
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestSiteProfile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestSiteProfile" /> class.
		/// </summary>
		/// <param name="SiteProfileName">SiteProfileName.</param>
		/// <param name="Device">Device.</param>
		public ProvisionNfvRequestSiteProfile(string? SiteProfileName = default, List<ProvisionNfvRequestDevice> Device = default)
		{
			this.SiteProfileName = SiteProfileName;
			this.Device = Device;
		}

		/// <summary>
		/// Gets or Sets SiteProfileName
		/// </summary>
		[DataMember(Name = "siteProfileName", EmitDefaultValue = false)]
		public string? SiteProfileName { get; set; }

		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestDevice> Device { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestSiteProfile {\n");
			sb.Append("  SiteProfileName: ").Append(SiteProfileName).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
