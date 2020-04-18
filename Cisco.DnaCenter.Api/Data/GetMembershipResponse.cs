using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetMembershipResponse
	/// </summary>
	[DataContract]
	public class GetMembershipResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetMembershipResponse" /> class.
		/// </summary>
		/// <param name="Site">Site.</param>
		/// <param name="Device">Device.</param>
		public GetMembershipResponse(GetMembershipResponseSite Site = default, List<GetMembershipResponseDevice> Device = default)
		{
			this.Site = Site;
			this.Device = Device;
		}

		/// <summary>
		/// Gets or Sets Site
		/// </summary>
		[DataMember(Name = "site", EmitDefaultValue = false)]
		public GetMembershipResponseSite Site { get; set; }
		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public List<GetMembershipResponseDevice> Device { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetMembershipResponse {\n");
			sb.Append("  Site: ").Append(Site).Append("\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
