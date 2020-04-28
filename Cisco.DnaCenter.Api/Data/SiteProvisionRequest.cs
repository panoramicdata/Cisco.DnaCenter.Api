using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SiteProvisionRequest" /> class.
		/// </summary>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="Type">Type.</param>
		public SiteProvisionRequest(string? DeviceId = default, string? SiteId = default, TypeEnum? Type = default)
		{
			this.DeviceId = DeviceId;
			this.SiteId = SiteId;
			this.Type = Type;
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
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SiteProvisionRequest {\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
