namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWirelessProfileResponseInner
	/// </summary>
	[DataContract]
	public class GetWirelessProfileResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWirelessProfileResponseInner" /> class.
		/// </summary>
		/// <param name="ProfileDetails">ProfileDetails.</param>
		public GetWirelessProfileResponseInner() : this(default) { }

		public GetWirelessProfileResponseInner(GetWirelessProfileResponseInnerProfileDetails ProfileDetails)
		{
			this.ProfileDetails = ProfileDetails;
		}

		/// <summary>
		/// Gets or Sets ProfileDetails
		/// </summary>
		[DataMember(Name = "profileDetails", EmitDefaultValue = false)]
		public GetWirelessProfileResponseInnerProfileDetails ProfileDetails { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWirelessProfileResponseInner {\n");
			sb.Append("  ProfileDetails: ").Append(ProfileDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
