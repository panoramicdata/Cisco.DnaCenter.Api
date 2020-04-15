using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerConnectedDevice
	/// </summary>
	[DataContract]
	public partial class GetClientEnrichmentDetailsResponseInnerConnectedDevice
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerConnectedDevice" /> class.
		/// </summary>
		/// <param name="DeviceDetails">DeviceDetails.</param>
		public GetClientEnrichmentDetailsResponseInnerConnectedDevice(GetClientEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails = default)
		{
			this.DeviceDetails = DeviceDetails;
		}

		/// <summary>
		/// Gets or Sets DeviceDetails
		/// </summary>
		[DataMember(Name = "deviceDetails", EmitDefaultValue = false)]
		public GetClientEnrichmentDetailsResponseInnerDeviceDetails DeviceDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerConnectedDevice {\n");
			sb.Append("  DeviceDetails: ").Append(DeviceDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
