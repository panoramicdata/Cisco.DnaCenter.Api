using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateWirelessProfileRequest
	/// </summary>
	[DataContract]
	public class CreateWirelessProfileRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateWirelessProfileRequest" /> class.
		/// </summary>
		/// <param name="ProfileDetails">ProfileDetails.</param>
		public CreateWirelessProfileRequest(GetWirelessProfileResponseInnerProfileDetails ProfileDetails = default)
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
			sb.Append("class CreateWirelessProfileRequest {\n");
			sb.Append("  ProfileDetails: ").Append(ProfileDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
