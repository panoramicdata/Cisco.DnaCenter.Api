using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateAndProvisionSSIDRequestSsidDetails
	/// </summary>
	[DataContract]
	public partial class CreateAndProvisionSSIDRequestSsidDetails
	{
		/// <summary>
		/// Gets or Sets SecurityLevel
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SecurityLevelEnum
		{

			/// <summary>
			/// Enum WPA2ENTERPRISE for "WPA2_ENTERPRISE"
			/// </summary>
			[EnumMember(Value = "WPA2_ENTERPRISE")]
			WPA2ENTERPRISE,

			/// <summary>
			/// Enum WPA2PERSONAL for "WPA2_PERSONAL"
			/// </summary>
			[EnumMember(Value = "WPA2_PERSONAL")]
			WPA2PERSONAL,

			/// <summary>
			/// Enum OPEN for "OPEN"
			/// </summary>
			[EnumMember(Value = "OPEN")]
			OPEN,

			/// <summary>
			/// Enum WEBAUTH for "WEB_AUTH"
			/// </summary>
			[EnumMember(Value = "WEB_AUTH")]
			WEBAUTH
		}

		/// <summary>
		/// Gets or Sets TrafficType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TrafficTypeEnum
		{

			/// <summary>
			/// Enum Data for "data"
			/// </summary>
			[EnumMember(Value = "data")]
			Data,

			/// <summary>
			/// Enum Voicedata for "voicedata"
			/// </summary>
			[EnumMember(Value = "voicedata")]
			Voicedata
		}

		/// <summary>
		/// Gets or Sets RadioPolicy
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum RadioPolicyEnum
		{

			/// <summary>
			/// Enum Dualbandoperation24GHzand5GHz for "Dual band operation (2.4GHz and 5GHz)"
			/// </summary>
			[EnumMember(Value = "Dual band operation (2.4GHz and 5GHz)")]
			Dualbandoperation24GHzand5GHz,

			/// <summary>
			/// Enum Dualbandoperationwithbandselect for "Dual band operation with band select"
			/// </summary>
			[EnumMember(Value = "Dual band operation with band select")]
			Dualbandoperationwithbandselect,

			/// <summary>
			/// Enum _5GHzonly for "5GHz only"
			/// </summary>
			[EnumMember(Value = "5GHz only")]
			_5GHzonly,

			/// <summary>
			/// Enum _24GHzonly for "2.4GHz only"
			/// </summary>
			[EnumMember(Value = "2.4GHz only")]
			_24GHzonly
		}

		/// <summary>
		/// Gets or Sets FastTransition
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FastTransitionEnum
		{

			/// <summary>
			/// Enum Adaptive for "Adaptive"
			/// </summary>
			[EnumMember(Value = "Adaptive")]
			Adaptive,

			/// <summary>
			/// Enum Enable for "Enable"
			/// </summary>
			[EnumMember(Value = "Enable")]
			Enable,

			/// <summary>
			/// Enum Disable for "Disable"
			/// </summary>
			[EnumMember(Value = "Disable")]
			Disable
		}

		/// <summary>
		/// Gets or Sets SecurityLevel
		/// </summary>
		[DataMember(Name = "securityLevel", EmitDefaultValue = false)]
		public SecurityLevelEnum? SecurityLevel { get; set; }
		/// <summary>
		/// Gets or Sets TrafficType
		/// </summary>
		[DataMember(Name = "trafficType", EmitDefaultValue = false)]
		public TrafficTypeEnum? TrafficType { get; set; }
		/// <summary>
		/// Gets or Sets RadioPolicy
		/// </summary>
		[DataMember(Name = "radioPolicy", EmitDefaultValue = false)]
		public RadioPolicyEnum? RadioPolicy { get; set; }
		/// <summary>
		/// Gets or Sets FastTransition
		/// </summary>
		[DataMember(Name = "fastTransition", EmitDefaultValue = false)]
		public FastTransitionEnum? FastTransition { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateAndProvisionSSIDRequestSsidDetails" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="SecurityLevel">SecurityLevel.</param>
		/// <param name="EnableFastLane">EnableFastLane.</param>
		/// <param name="Passphrase">Passphrase.</param>
		/// <param name="TrafficType">TrafficType.</param>
		/// <param name="EnableBroadcastSSID">EnableBroadcastSSID.</param>
		/// <param name="RadioPolicy">RadioPolicy.</param>
		/// <param name="EnableMACFiltering">EnableMACFiltering.</param>
		/// <param name="FastTransition">FastTransition.</param>
		/// <param name="WebAuthURL">WebAuthURL.</param>
		public CreateAndProvisionSSIDRequestSsidDetails(string? Name = default, SecurityLevelEnum? SecurityLevel = default, bool? EnableFastLane = default, string? Passphrase = default, TrafficTypeEnum? TrafficType = default, bool? EnableBroadcastSSID = default, RadioPolicyEnum? RadioPolicy = default, bool? EnableMACFiltering = default, FastTransitionEnum? FastTransition = default, string? WebAuthURL = default)
		{
			this.Name = Name;
			this.SecurityLevel = SecurityLevel;
			this.EnableFastLane = EnableFastLane;
			this.Passphrase = Passphrase;
			this.TrafficType = TrafficType;
			this.EnableBroadcastSSID = EnableBroadcastSSID;
			this.RadioPolicy = RadioPolicy;
			this.EnableMACFiltering = EnableMACFiltering;
			this.FastTransition = FastTransition;
			this.WebAuthURL = WebAuthURL;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets EnableFastLane
		/// </summary>
		[DataMember(Name = "enableFastLane", EmitDefaultValue = false)]
		public bool? EnableFastLane { get; set; }
		/// <summary>
		/// Gets or Sets Passphrase
		/// </summary>
		[DataMember(Name = "passphrase", EmitDefaultValue = false)]
		public string? Passphrase { get; set; }
		/// <summary>
		/// Gets or Sets EnableBroadcastSSID
		/// </summary>
		[DataMember(Name = "enableBroadcastSSID", EmitDefaultValue = false)]
		public bool? EnableBroadcastSSID { get; set; }
		/// <summary>
		/// Gets or Sets EnableMACFiltering
		/// </summary>
		[DataMember(Name = "enableMACFiltering", EmitDefaultValue = false)]
		public bool? EnableMACFiltering { get; set; }
		/// <summary>
		/// Gets or Sets WebAuthURL
		/// </summary>
		[DataMember(Name = "webAuthURL", EmitDefaultValue = false)]
		public string? WebAuthURL { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateAndProvisionSSIDRequestSsidDetails {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
			sb.Append("  EnableFastLane: ").Append(EnableFastLane).Append("\n");
			sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
			sb.Append("  TrafficType: ").Append(TrafficType).Append("\n");
			sb.Append("  EnableBroadcastSSID: ").Append(EnableBroadcastSSID).Append("\n");
			sb.Append("  RadioPolicy: ").Append(RadioPolicy).Append("\n");
			sb.Append("  EnableMACFiltering: ").Append(EnableMACFiltering).Append("\n");
			sb.Append("  FastTransition: ").Append(FastTransition).Append("\n");
			sb.Append("  WebAuthURL: ").Append(WebAuthURL).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
