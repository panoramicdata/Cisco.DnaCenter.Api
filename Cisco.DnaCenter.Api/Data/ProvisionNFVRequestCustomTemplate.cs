using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestCustomTemplate
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequestCustomTemplate
	{
		/// <summary>
		/// Gets or Sets DeviceType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DeviceTypeEnum
		{

			/// <summary>
			/// Enum NFVIS for "NFVIS"
			/// </summary>
			[EnumMember(Value = "NFVIS")]
			NFVIS,

			/// <summary>
			/// Enum ASAv for "ASAv"
			/// </summary>
			[EnumMember(Value = "ASAv")]
			ASAv
		}

		/// <summary>
		/// Gets or Sets DeviceType
		/// </summary>
		[DataMember(Name = "deviceType", EmitDefaultValue = false)]
		public DeviceTypeEnum? DeviceType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestCustomTemplate" /> class.
		/// </summary>
		/// <param name="DeviceType">DeviceType.</param>
		/// <param name="Template">Template.</param>
		public ProvisionNFVRequestCustomTemplate(DeviceTypeEnum? DeviceType = default, string? Template = default)
		{
			this.DeviceType = DeviceType;
			this.Template = Template;
		}

		/// <summary>
		/// Gets or Sets Template
		/// </summary>
		[DataMember(Name = "template", EmitDefaultValue = false)]
		public string? Template { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestCustomTemplate {\n");
			sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
			sb.Append("  Template: ").Append(Template).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
