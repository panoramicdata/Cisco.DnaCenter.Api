namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CountOfEventsResponse
	/// </summary>
	[DataContract]
	public class EventCountResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EventCountResponse" /> class.
		/// </summary>
		public EventCountResponse() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="EventCountResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		public EventCountResponse(decimal? Response)
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
			sb.Append("class CountOfEventsResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
