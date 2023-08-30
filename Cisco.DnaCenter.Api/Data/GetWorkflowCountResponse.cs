namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWorkflowCountResponse
	/// </summary>
	[DataContract]
	public class GetWorkflowCountResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWorkflowCountResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		public GetWorkflowCountResponse() : this(default) { }

		public GetWorkflowCountResponse(decimal? Response)
		{
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public decimal? Response { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWorkflowCountResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
