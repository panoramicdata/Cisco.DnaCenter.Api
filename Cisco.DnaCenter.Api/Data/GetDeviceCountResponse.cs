namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceCountResponse
	/// </summary>
	[DataContract]
	public class GetDeviceCountResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceCountResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		public GetDeviceCountResponse() : this(default) { }

		public GetDeviceCountResponse(decimal? Response)
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
			sb.Append("class GetDeviceCountResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
