using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestProvisioning
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequestProvisioning
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestProvisioning" /> class.
		/// </summary>
		/// <param name="Site">Site.</param>
		/// <param name="Device">Device.</param>
		public ProvisionNFVRequestProvisioning(ProvisionNfvRequestSite Site = default, List<ProvisionNfvRequestDevice1> Device = default)
		{
			this.Site = Site;
			this.Device = Device;
		}

		/// <summary>
		/// Gets or Sets Site
		/// </summary>
		[DataMember(Name = "site", EmitDefaultValue = false)]
		public ProvisionNfvRequestSite Site { get; set; }
		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestDevice1> Device { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestProvisioning {\n");
			sb.Append("  Site: ").Append(Site).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
