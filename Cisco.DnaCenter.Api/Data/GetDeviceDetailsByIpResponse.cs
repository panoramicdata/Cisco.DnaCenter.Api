namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceDetailsByIPResponse
	/// </summary>
	[DataContract]
	public class GetDeviceDetailsByIpResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailsByIpResponse" /> class.
		/// </summary>
		public GetDeviceDetailsByIpResponse() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailsByIpResponse" /> class.
		/// </summary>
		/// <param name="ProvisionDetails">ProvisionDetails.</param>
		public GetDeviceDetailsByIpResponse(GetDeviceDetailsByIpResponseProvisionDetails? ProvisionDetails)
		{
			this.ProvisionDetails = ProvisionDetails;
		}

		/// <summary>
		/// Gets or Sets ProvisionDetails
		/// </summary>
		[DataMember(Name = "provisionDetails", EmitDefaultValue = false)]
		public GetDeviceDetailsByIpResponseProvisionDetails ProvisionDetails { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceDetailsByIPResponse {\n");
			sb.Append("  ProvisionDetails: ").Append(ProvisionDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
