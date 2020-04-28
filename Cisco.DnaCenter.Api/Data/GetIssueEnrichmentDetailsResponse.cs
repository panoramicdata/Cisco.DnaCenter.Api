using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetIssueEnrichmentDetailsResponse
	/// </summary>
	[DataContract]
	public class GetIssueEnrichmentDetailsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetIssueEnrichmentDetailsResponse" /> class.
		/// </summary>
		/// <param name="IssueDetails">IssueDetails.</param>
		public GetIssueEnrichmentDetailsResponse(GetIssueEnrichmentDetailsResponseIssueDetails IssueDetails = default)
		{
			this.IssueDetails = IssueDetails;
		}

		/// <summary>
		/// Gets or Sets IssueDetails
		/// </summary>
		[DataMember(Name = "issueDetails", EmitDefaultValue = false)]
		public GetIssueEnrichmentDetailsResponseIssueDetails IssueDetails { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetIssueEnrichmentDetailsResponse {\n");
			sb.Append("  IssueDetails: ").Append(IssueDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
