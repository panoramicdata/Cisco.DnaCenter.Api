using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions
/// </summary>
[DataContract]
public class GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions" /> class.
	/// </summary>
	/// <param name="Message">Message.</param>
	/// <param name="Steps">Steps.</param>
	public GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions(string? Message = default, List<Object> Steps = default)
	{
		this.Message = Message;
		this.Steps = Steps;
	}

	/// <summary>
	/// Gets or Sets Message
	/// </summary>
	[DataMember(Name = "message", EmitDefaultValue = false)]
	public string? Message { get; set; }

	/// <summary>
	/// Gets or Sets Steps
	/// </summary>
	[DataMember(Name = "steps", EmitDefaultValue = false)]
	public List<Object> Steps { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetClientEnrichmentDetailsResponseInnerIssueDetailsSuggestedActions {\n");
		sb.Append("  Message: ").Append(Message).Append("\n");
		sb.Append("  Steps: ").Append(Steps).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
