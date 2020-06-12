using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SiteProvisionRequest
	/// </summary>
	[DataContract]
	public class SiteProvisionRequest
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Default for "Default"
			/// </summary>
			[EnumMember(Value = "Default")]
			Default,

			/// <summary>
			/// Enum AccessPoint for "AccessPoint"
			/// </summary>
			[EnumMember(Value = "AccessPoint")]
			AccessPoint,

			/// <summary>
			/// Enum StackSwitch for "StackSwitch"
			/// </summary>
			[EnumMember(Value = "StackSwitch")]
			StackSwitch,

			/// <summary>
			/// Enum Sensor for "Sensor"
			/// </summary>
			[EnumMember(Value = "Sensor")]
			Sensor,

			/// <summary>
			/// Enum MobilityExpress for "MobilityExpress"
			/// </summary>
			[EnumMember(Value = "MobilityExpress")]
			MobilityExpress
		}

		/// <summary>
		/// Gets or Sets CablingScheme
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SiteProvisionRequestCablingScheme
		{
			/// <summary>
			/// Enum OneB for "1B"
			/// </summary>
			[EnumMember(Value = "1B")]
			OneB,
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SiteProvisionRequest" /> class.
		/// </summary>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="Hostname">Hostname.</param>
		/// <param name="Type">Type.</param>
		/// <param name="ImageInfo">SiteId.</param>
		/// <param name="ConfigInfo">SiteId.</param>
		/// <param name="ConfigInfo">SiteId.</param>
		public SiteProvisionRequest(
			string? DeviceId = default,
			string? SiteId = default,
			string? Hostname = default,
			TypeEnum? Type = default,
			SiteProvisionRequestImageInfo? ImageInfo = default,
			SiteProvisionRequestConfigInfo? ConfigInfo = default,
			string? TopOfStackSerialNumber = default,
			SiteProvisionRequestCablingScheme CablingScheme = default
			)
		{
			this.DeviceId = DeviceId;
			this.SiteId = SiteId;
			this.Hostname = Hostname;
			this.CablingScheme = CablingScheme;
			this.Type = Type;
			this.ImageInfo = ImageInfo;
			this.ConfigInfo = ConfigInfo;
			this.TopOfStackSerialNumber = TopOfStackSerialNumber;
		}

		/// <summary>
		/// Gets or Sets DeviceId
		/// </summary>
		[DataMember(Name = "deviceId", EmitDefaultValue = false)]
		public string? DeviceId { get; set; }

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }

		/// <summary>
		/// Gets or Sets Hostname
		/// </summary>
		[DataMember(Name = "hostname", EmitDefaultValue = false)]
		public string? Hostname { get; set; }

		/// <summary>
		/// Gets or Sets CablingScheme
		/// </summary>
		[DataMember(Name = "cablingScheme", EmitDefaultValue = false)]
		public SiteProvisionRequestCablingScheme? CablingScheme { get; set; }

		/// <summary>
		/// Gets or Sets ImageInfo
		/// </summary>
		[DataMember(Name = "imageInfo", EmitDefaultValue = false)]
		public SiteProvisionRequestImageInfo? ImageInfo { get; set; }

		/// <summary>
		/// Gets or Sets ConfigInfo
		/// </summary>
		[DataMember(Name = "configInfo", EmitDefaultValue = false)]
		public SiteProvisionRequestConfigInfo? ConfigInfo { get; set; }

		/// <summary>
		/// Gets or Sets TopOfStackSerialNumber
		/// </summary>
		[DataMember(Name = "topOfStackSerialNumber", EmitDefaultValue = false)]
		public string? TopOfStackSerialNumber { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SiteProvisionRequest {\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  Hostname: ").Append(Hostname).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  ImageInfo: ").Append(ImageInfo?.ToString()).Append("\n");
			sb.Append("  ConfigInfo: ").Append(ConfigInfo?.ToString()).Append("\n");
			sb.Append("  TopOfStackSerialNumber: ").Append(TopOfStackSerialNumber).Append("\n");
			sb.Append("  CablingScheme: ").Append(CablingScheme).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
