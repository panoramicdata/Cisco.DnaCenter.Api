using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWirelessProfileResponseInnerProfileDetailsSsidDetails
	/// </summary>
	[DataContract]
	public partial class GetWirelessProfileResponseInnerProfileDetailsSsidDetails
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Guest for "Guest"
			/// </summary>
			[EnumMember(Value = "Guest")]
			Guest,

			/// <summary>
			/// Enum Enterprise for "Enterprise"
			/// </summary>
			[EnumMember(Value = "Enterprise")]
			Enterprise
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWirelessProfileResponseInnerProfileDetailsSsidDetails" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Type">Type.</param>
		/// <param name="EnableFabric">EnableFabric.</param>
		/// <param name="FlexConnect">FlexConnect.</param>
		/// <param name="InterfaceName">InterfaceName.</param>
		public GetWirelessProfileResponseInnerProfileDetailsSsidDetails(string? Name = default, TypeEnum? Type = default, bool? EnableFabric = default, GetWirelessProfileResponseInnerProfileDetailsFlexConnect FlexConnect = default, string? InterfaceName = default)
		{
			this.Name = Name;
			this.Type = Type;
			this.EnableFabric = EnableFabric;
			this.FlexConnect = FlexConnect;
			this.InterfaceName = InterfaceName;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets EnableFabric
		/// </summary>
		[DataMember(Name = "enableFabric", EmitDefaultValue = false)]
		public bool? EnableFabric { get; set; }
		/// <summary>
		/// Gets or Sets FlexConnect
		/// </summary>
		[DataMember(Name = "flexConnect", EmitDefaultValue = false)]
		public GetWirelessProfileResponseInnerProfileDetailsFlexConnect FlexConnect { get; set; }
		/// <summary>
		/// Gets or Sets InterfaceName
		/// </summary>
		[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
		public string? InterfaceName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWirelessProfileResponseInnerProfileDetailsSsidDetails {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  EnableFabric: ").Append(EnableFabric).Append("\n");
			sb.Append("  FlexConnect: ").Append(FlexConnect).Append("\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
