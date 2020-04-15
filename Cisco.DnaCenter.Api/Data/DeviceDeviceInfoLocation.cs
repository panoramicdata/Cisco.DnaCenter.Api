using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoLocation
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoLocation
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoLocation" /> class.
		/// </summary>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="Address">Address.</param>
		/// <param name="Latitude">Latitude.</param>
		/// <param name="Longitude">Longitude.</param>
		/// <param name="Altitude">Altitude.</param>
		public DeviceDeviceInfoLocation(string? SiteId = default, string? Address = default, string? Latitude = default, string? Longitude = default, string? Altitude = default)
		{
			this.SiteId = SiteId;
			this.Address = Address;
			this.Latitude = Latitude;
			this.Longitude = Longitude;
			this.Altitude = Altitude;
		}

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }
		/// <summary>
		/// Gets or Sets Address
		/// </summary>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string? Address { get; set; }
		/// <summary>
		/// Gets or Sets Latitude
		/// </summary>
		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		public string? Latitude { get; set; }
		/// <summary>
		/// Gets or Sets Longitude
		/// </summary>
		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		public string? Longitude { get; set; }
		/// <summary>
		/// Gets or Sets Altitude
		/// </summary>
		[DataMember(Name = "altitude", EmitDefaultValue = false)]
		public string? Altitude { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoLocation {\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  Latitude: ").Append(Latitude).Append("\n");
			sb.Append("  Longitude: ").Append(Longitude).Append("\n");
			sb.Append("  Altitude: ").Append(Altitude).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
