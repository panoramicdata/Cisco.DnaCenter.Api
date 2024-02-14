namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetSiteResponse
/// </summary>
[DataContract]
public class GetSiteSingleResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteSingleResponse" /> class.
	/// </summary>
	public GetSiteSingleResponse() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteSingleResponse" /> class.
	/// </summary>
	/// <param name="Response">Response.</param>
	public GetSiteSingleResponse(GetSiteResponseResponse Response)
	{
		this.Response = Response;
	}

	/// <summary>
	/// Gets or Sets Response
	/// </summary>
	[DataMember(Name = "response", EmitDefaultValue = false)]
	public GetSiteResponseResponse Response { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSiteResponse {\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
