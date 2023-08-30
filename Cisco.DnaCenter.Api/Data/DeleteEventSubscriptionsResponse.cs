namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteEventSubscriptionsResponse
	/// </summary>
	[DataContract]
	public class DeleteEventSubscriptionsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteEventSubscriptionsResponse" /> class.
		/// </summary>
		public DeleteEventSubscriptionsResponse() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteEventSubscriptionsResponse" /> class.
		/// </summary>
		/// <param name="StatusUri">StatusUri.</param>
		public DeleteEventSubscriptionsResponse(string? StatusUri)
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
			sb.Append("class DeleteEventSubscriptionsResponse {\n");
			sb.Append("  StatusUri: ").Append(StatusUri).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
