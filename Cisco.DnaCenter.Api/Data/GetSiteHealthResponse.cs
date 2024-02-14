namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetSiteHealthResponse
/// </summary>
[DataContract]
public class GetSiteHealthResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteHealthResponse" /> class.
	/// </summary>
	public GetSiteHealthResponse() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteHealthResponse" /> class.
	/// </summary>
	/// <param name="Response">Response.</param>
	public GetSiteHealthResponse(List<GetSiteHealthResponseResponse> Response)
	{
		this.Response = Response;
	}

	/// <summary>
	/// Gets or Sets Response
	/// </summary>
	[DataMember(Name = "response", EmitDefaultValue = false)]
	public List<GetSiteHealthResponseResponse> Response { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSiteHealthResponse {\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
