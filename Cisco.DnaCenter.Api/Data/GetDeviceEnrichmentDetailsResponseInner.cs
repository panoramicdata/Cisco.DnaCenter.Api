namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceEnrichmentDetailsResponseInner
	/// </summary>
	[DataContract]
	public class GetDeviceEnrichmentDetailsResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponseInner" /> class.
		/// </summary>
		public GetDeviceEnrichmentDetailsResponseInner() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponseInner" /> class.
		/// </summary>
		/// <param name="DeviceDetails">DeviceDetails.</param>
		public GetDeviceEnrichmentDetailsResponseInner(GetDeviceEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails)
		{
			this.DeviceDetails = DeviceDetails;
		}

		/// <summary>
		/// Gets or Sets DeviceDetails
		/// </summary>
		[DataMember(Name = "deviceDetails", EmitDefaultValue = false)]
		public GetDeviceEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceEnrichmentDetailsResponseInner {\n");
			sb.Append("  DeviceDetails: ").Append(DeviceDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
