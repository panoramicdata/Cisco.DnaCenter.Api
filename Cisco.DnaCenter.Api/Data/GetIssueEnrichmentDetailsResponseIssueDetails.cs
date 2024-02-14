namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetIssueEnrichmentDetailsResponseIssueDetails
/// </summary>
[DataContract]
public class GetIssueEnrichmentDetailsResponseIssueDetails
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetIssueEnrichmentDetailsResponseIssueDetails" /> class.
	/// </summary>
	public GetIssueEnrichmentDetailsResponseIssueDetails() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="GetIssueEnrichmentDetailsResponseIssueDetails" /> class.
	/// </summary>
	/// <param name="Issue">Issue.</param>
	public GetIssueEnrichmentDetailsResponseIssueDetails(List<GetIssueEnrichmentDetailsResponseIssueDetailsIssue> Issue)
	{
		this.Issue = Issue;
	}

	/// <summary>
	/// Gets or Sets Issue
	/// </summary>
	[DataMember(Name = "issue", EmitDefaultValue = false)]
	public List<GetIssueEnrichmentDetailsResponseIssueDetailsIssue> Issue { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetIssueEnrichmentDetailsResponseIssueDetails {\n");
		sb.Append("  Issue: ").Append(Issue).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
