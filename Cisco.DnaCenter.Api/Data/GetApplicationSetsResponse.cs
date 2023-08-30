namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetApplicationSetsResponse
	/// </summary>
	[DataContract]
	public class GetApplicationSetsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetApplicationSetsResponse" /> class.
		/// </summary>
		public GetApplicationSetsResponse() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetApplicationSetsResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		public GetApplicationSetsResponse(List<GetApplicationSetsResponseResponse>? Response)
		{
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<GetApplicationSetsResponseResponse> Response { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetApplicationSetsResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
