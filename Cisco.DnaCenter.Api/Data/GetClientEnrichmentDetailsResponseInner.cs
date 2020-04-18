using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInner
	/// </summary>
	[DataContract]
	public class GetClientEnrichmentDetailsResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInner" /> class.
		/// </summary>
		/// <param name="UserDetails">UserDetails.</param>
		/// <param name="ConnectedDevice">ConnectedDevice.</param>
		/// <param name="IssueDetails">IssueDetails.</param>
		public GetClientEnrichmentDetailsResponseInner(GetClientEnrichmentDetailsResponseInnerUserDetails UserDetails = default, List<GetClientEnrichmentDetailsResponseInnerConnectedDevice> ConnectedDevice = default, GetClientEnrichmentDetailsResponseInnerIssueDetails IssueDetails = default)
		{
			this.UserDetails = UserDetails;
			this.ConnectedDevice = ConnectedDevice;
			this.IssueDetails = IssueDetails;
		}

		/// <summary>
		/// Gets or Sets UserDetails
		/// </summary>
		[DataMember(Name = "userDetails", EmitDefaultValue = false)]
		public GetClientEnrichmentDetailsResponseInnerUserDetails UserDetails { get; set; }
		/// <summary>
		/// Gets or Sets ConnectedDevice
		/// </summary>
		[DataMember(Name = "connectedDevice", EmitDefaultValue = false)]
		public List<GetClientEnrichmentDetailsResponseInnerConnectedDevice> ConnectedDevice { get; set; }
		/// <summary>
		/// Gets or Sets IssueDetails
		/// </summary>
		[DataMember(Name = "issueDetails", EmitDefaultValue = false)]
		public GetClientEnrichmentDetailsResponseInnerIssueDetails IssueDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInner {\n");
			sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
			sb.Append("  ConnectedDevice: ").Append(ConnectedDevice).Append("\n");
			sb.Append("  IssueDetails: ").Append(IssueDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
