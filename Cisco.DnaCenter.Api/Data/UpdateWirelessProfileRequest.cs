using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateWirelessProfileRequest
	/// </summary>
	[DataContract]
	public class UpdateWirelessProfileRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateWirelessProfileRequest" /> class.
		/// </summary>
		/// <param name="ProfileDetails">ProfileDetails.</param>
		public UpdateWirelessProfileRequest(GetWirelessProfileResponseInnerProfileDetails ProfileDetails = default)
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
			sb.Append("class UpdateWirelessProfileRequest {\n");
			sb.Append("  ProfileDetails: ").Append(ProfileDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
