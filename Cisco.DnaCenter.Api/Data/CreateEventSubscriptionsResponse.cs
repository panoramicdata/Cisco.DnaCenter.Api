namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateEventSubscriptionsResponse
	/// </summary>
	[DataContract]
	public class CreateEventSubscriptionsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsResponse" /> class.
		/// </summary>
		public CreateEventSubscriptionsResponse() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsResponse" /> class.
		/// </summary>
		/// <param name="StatusUri">StatusUri.</param>
		public CreateEventSubscriptionsResponse(string? StatusUri)
		{
			this.StatusUri = StatusUri;
		}

		/// <summary>
		/// Gets or Sets StatusUri
		/// </summary>
		[DataMember(Name = "statusUri", EmitDefaultValue = false)]
		public string? StatusUri { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateEventSubscriptionsResponse {\n");
			sb.Append("  StatusUri: ").Append(StatusUri).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
