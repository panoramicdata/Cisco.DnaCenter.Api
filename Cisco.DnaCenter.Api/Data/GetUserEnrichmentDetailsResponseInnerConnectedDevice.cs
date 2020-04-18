using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetUserEnrichmentDetailsResponseInnerConnectedDevice
	/// </summary>
	[DataContract]
	public class GetUserEnrichmentDetailsResponseInnerConnectedDevice
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetUserEnrichmentDetailsResponseInnerConnectedDevice" /> class.
		/// </summary>
		/// <param name="DeviceDetails">DeviceDetails.</param>
		public GetUserEnrichmentDetailsResponseInnerConnectedDevice(GetUserEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails = default)
		{
			this.DeviceDetails = DeviceDetails;
		}

		/// <summary>
		/// Gets or Sets DeviceDetails
		/// </summary>
		[DataMember(Name = "deviceDetails", EmitDefaultValue = false)]
		public GetUserEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetUserEnrichmentDetailsResponseInnerConnectedDevice {\n");
			sb.Append("  DeviceDetails: ").Append(DeviceDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
