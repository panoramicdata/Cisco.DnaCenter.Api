using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetUserEnrichmentDetailsResponseInner
	/// </summary>
	[DataContract]
	public class GetUserEnrichmentDetailsResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetUserEnrichmentDetailsResponseInner" /> class.
		/// </summary>
		/// <param name="UserDetails">UserDetails.</param>
		/// <param name="ConnectedDevice">ConnectedDevice.</param>
		public GetUserEnrichmentDetailsResponseInner(GetUserEnrichmentDetailsResponseInnerUserDetails UserDetails = default, List<GetUserEnrichmentDetailsResponseInnerConnectedDevice> ConnectedDevice = default)
		{
			this.UserDetails = UserDetails;
			this.ConnectedDevice = ConnectedDevice;
		}

		/// <summary>
		/// Gets or Sets UserDetails
		/// </summary>
		[DataMember(Name = "userDetails", EmitDefaultValue = false)]
		public GetUserEnrichmentDetailsResponseInnerUserDetails UserDetails { get; set; }
		/// <summary>
		/// Gets or Sets ConnectedDevice
		/// </summary>
		[DataMember(Name = "connectedDevice", EmitDefaultValue = false)]
		public List<GetUserEnrichmentDetailsResponseInnerConnectedDevice> ConnectedDevice { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetUserEnrichmentDetailsResponseInner {\n");
			sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
			sb.Append("  ConnectedDevice: ").Append(ConnectedDevice).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
