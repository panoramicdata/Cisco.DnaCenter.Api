using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerIssueDetails
	/// </summary>
	[DataContract]
	public partial class GetClientEnrichmentDetailsResponseInnerIssueDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerIssueDetails" /> class.
		/// </summary>
		/// <param name="Issue">Issue.</param>
		public GetClientEnrichmentDetailsResponseInnerIssueDetails(List<GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue> Issue = default)
		{
			this.Issue = Issue;
		}

		/// <summary>
		/// Gets or Sets Issue
		/// </summary>
		[DataMember(Name = "issue", EmitDefaultValue = false)]
		public List<GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue> Issue { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerIssueDetails {\n");
			sb.Append("  Issue: ").Append(Issue).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
