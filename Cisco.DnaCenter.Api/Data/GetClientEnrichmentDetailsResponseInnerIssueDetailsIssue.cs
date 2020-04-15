using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue
	/// </summary>
	[DataContract]
	public partial class GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue" /> class.
		/// </summary>
		/// <param name="IssueId">IssueId.</param>
		/// <param name="IssueSource">IssueSource.</param>
		/// <param name="IssueCategory">IssueCategory.</param>
		/// <param name="IssueName">IssueName.</param>
		/// <param name="IssueDescription">IssueDescription.</param>
		/// <param name="IssueEntity">IssueEntity.</param>
		/// <param name="IssueEntityValue">IssueEntityValue.</param>
		/// <param name="IssueSeverity">IssueSeverity.</param>
		/// <param name="IssuePriority">IssuePriority.</param>
		/// <param name="IssueSummary">IssueSummary.</param>
		/// <param name="IssueTimestamp">IssueTimestamp.</param>
		/// <param name="SuggestedActions">SuggestedActions.</param>
		/// <param name="ImpactedHosts">ImpactedHosts.</param>
		public GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue(string? IssueId = default, string? IssueSource = default, string? IssueCategory = default, string? IssueName = default, string? IssueDescription = default, string? IssueEntity = default, string? IssueEntityValue = default, string? IssueSeverity = default, string? IssuePriority = default, string? IssueSummary = default, int? IssueTimestamp = default, List<GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions> SuggestedActions = default, List<GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts> ImpactedHosts = default)
		{
			this.IssueId = IssueId;
			this.IssueSource = IssueSource;
			this.IssueCategory = IssueCategory;
			this.IssueName = IssueName;
			this.IssueDescription = IssueDescription;
			this.IssueEntity = IssueEntity;
			this.IssueEntityValue = IssueEntityValue;
			this.IssueSeverity = IssueSeverity;
			this.IssuePriority = IssuePriority;
			this.IssueSummary = IssueSummary;
			this.IssueTimestamp = IssueTimestamp;
			this.SuggestedActions = SuggestedActions;
			this.ImpactedHosts = ImpactedHosts;
		}

		/// <summary>
		/// Gets or Sets IssueId
		/// </summary>
		[DataMember(Name = "issueId", EmitDefaultValue = false)]
		public string? IssueId { get; set; }
		/// <summary>
		/// Gets or Sets IssueSource
		/// </summary>
		[DataMember(Name = "issueSource", EmitDefaultValue = false)]
		public string? IssueSource { get; set; }
		/// <summary>
		/// Gets or Sets IssueCategory
		/// </summary>
		[DataMember(Name = "issueCategory", EmitDefaultValue = false)]
		public string? IssueCategory { get; set; }
		/// <summary>
		/// Gets or Sets IssueName
		/// </summary>
		[DataMember(Name = "issueName", EmitDefaultValue = false)]
		public string? IssueName { get; set; }
		/// <summary>
		/// Gets or Sets IssueDescription
		/// </summary>
		[DataMember(Name = "issueDescription", EmitDefaultValue = false)]
		public string? IssueDescription { get; set; }
		/// <summary>
		/// Gets or Sets IssueEntity
		/// </summary>
		[DataMember(Name = "issueEntity", EmitDefaultValue = false)]
		public string? IssueEntity { get; set; }
		/// <summary>
		/// Gets or Sets IssueEntityValue
		/// </summary>
		[DataMember(Name = "issueEntityValue", EmitDefaultValue = false)]
		public string? IssueEntityValue { get; set; }
		/// <summary>
		/// Gets or Sets IssueSeverity
		/// </summary>
		[DataMember(Name = "issueSeverity", EmitDefaultValue = false)]
		public string? IssueSeverity { get; set; }
		/// <summary>
		/// Gets or Sets IssuePriority
		/// </summary>
		[DataMember(Name = "issuePriority", EmitDefaultValue = false)]
		public string? IssuePriority { get; set; }
		/// <summary>
		/// Gets or Sets IssueSummary
		/// </summary>
		[DataMember(Name = "issueSummary", EmitDefaultValue = false)]
		public string? IssueSummary { get; set; }
		/// <summary>
		/// Gets or Sets IssueTimestamp
		/// </summary>
		[DataMember(Name = "issueTimestamp", EmitDefaultValue = false)]
		public int? IssueTimestamp { get; set; }
		/// <summary>
		/// Gets or Sets SuggestedActions
		/// </summary>
		[DataMember(Name = "suggestedActions", EmitDefaultValue = false)]
		public List<GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions> SuggestedActions { get; set; }
		/// <summary>
		/// Gets or Sets ImpactedHosts
		/// </summary>
		[DataMember(Name = "impactedHosts", EmitDefaultValue = false)]
		public List<GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts> ImpactedHosts { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerIssueDetailsIssue {\n");
			sb.Append("  IssueId: ").Append(IssueId).Append("\n");
			sb.Append("  IssueSource: ").Append(IssueSource).Append("\n");
			sb.Append("  IssueCategory: ").Append(IssueCategory).Append("\n");
			sb.Append("  IssueName: ").Append(IssueName).Append("\n");
			sb.Append("  IssueDescription: ").Append(IssueDescription).Append("\n");
			sb.Append("  IssueEntity: ").Append(IssueEntity).Append("\n");
			sb.Append("  IssueEntityValue: ").Append(IssueEntityValue).Append("\n");
			sb.Append("  IssueSeverity: ").Append(IssueSeverity).Append("\n");
			sb.Append("  IssuePriority: ").Append(IssuePriority).Append("\n");
			sb.Append("  IssueSummary: ").Append(IssueSummary).Append("\n");
			sb.Append("  IssueTimestamp: ").Append(IssueTimestamp).Append("\n");
			sb.Append("  SuggestedActions: ").Append(SuggestedActions).Append("\n");
			sb.Append("  ImpactedHosts: ").Append(ImpactedHosts).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
