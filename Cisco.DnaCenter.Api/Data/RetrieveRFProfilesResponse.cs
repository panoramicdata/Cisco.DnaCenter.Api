namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// RetrieveRfProfilesResponse
/// </summary>
[DataContract]
public class RetrieveRfProfilesResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RetrieveRfProfilesResponse" /> class.
	/// </summary>
	public RetrieveRfProfilesResponse() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="RetrieveRfProfilesResponse" /> class.
	/// </summary>
	/// <param name="Response">Response.</param>
	public RetrieveRfProfilesResponse(List<RetrieveRfProfilesResponseResponse> Response)
	{
		this.Response = Response;
	}

	/// <summary>
	/// Gets or Sets Response
	/// </summary>
	[DataMember(Name = "response", EmitDefaultValue = false)]
	public List<RetrieveRfProfilesResponseResponse> Response { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class RetrieveRfProfilesResponse {\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
