using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseFlexConnect
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseFlexConnect
	{
		/// <summary>
		/// Gets or Sets Authentication
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum AuthenticationEnum
		{

			/// <summary>
			/// Enum LOCAL for "LOCAL"
			/// </summary>
			[EnumMember(Value = "LOCAL")]
			LOCAL,

			/// <summary>
			/// Enum CENTRAL for "CENTRAL"
			/// </summary>
			[EnumMember(Value = "CENTRAL")]
			CENTRAL
		}

		/// <summary>
		/// Gets or Sets DataSwitching
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DataSwitchingEnum
		{

			/// <summary>
			/// Enum LOCAL for "LOCAL"
			/// </summary>
			[EnumMember(Value = "LOCAL")]
			LOCAL,

			/// <summary>
			/// Enum CENTRAL for "CENTRAL"
			/// </summary>
			[EnumMember(Value = "CENTRAL")]
			CENTRAL
		}

		/// <summary>
		/// Gets or Sets Authentication
		/// </summary>
		[DataMember(Name = "authentication", EmitDefaultValue = false)]
		public AuthenticationEnum? Authentication { get; set; }
		/// <summary>
		/// Gets or Sets DataSwitching
		/// </summary>
		[DataMember(Name = "dataSwitching", EmitDefaultValue = false)]
		public DataSwitchingEnum? DataSwitching { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseFlexConnect" /> class.
		/// </summary>
		/// <param name="Authentication">Authentication.</param>
		/// <param name="DataSwitching">DataSwitching.</param>
		/// <param name="EgressAclAnalysis">EgressAclAnalysis.</param>
		/// <param name="IngressAclAnalysis">IngressAclAnalysis.</param>
		/// <param name="WirelessLanControllerId">WirelessLanControllerId.</param>
		/// <param name="WirelessLanControllerName">WirelessLanControllerName.</param>
		public PathResponseResultResponseFlexConnect(AuthenticationEnum? Authentication = default, DataSwitchingEnum? DataSwitching = default, PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis EgressAclAnalysis = default, PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis IngressAclAnalysis = default, string? WirelessLanControllerId = default, string? WirelessLanControllerName = default)
		{
			this.Authentication = Authentication;
			this.DataSwitching = DataSwitching;
			this.EgressAclAnalysis = EgressAclAnalysis;
			this.IngressAclAnalysis = IngressAclAnalysis;
			this.WirelessLanControllerId = WirelessLanControllerId;
			this.WirelessLanControllerName = WirelessLanControllerName;
		}

		/// <summary>
		/// Gets or Sets EgressAclAnalysis
		/// </summary>
		[DataMember(Name = "egressAclAnalysis", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis EgressAclAnalysis { get; set; }
		/// <summary>
		/// Gets or Sets IngressAclAnalysis
		/// </summary>
		[DataMember(Name = "ingressAclAnalysis", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis IngressAclAnalysis { get; set; }
		/// <summary>
		/// Gets or Sets WirelessLanControllerId
		/// </summary>
		[DataMember(Name = "wirelessLanControllerId", EmitDefaultValue = false)]
		public string? WirelessLanControllerId { get; set; }
		/// <summary>
		/// Gets or Sets WirelessLanControllerName
		/// </summary>
		[DataMember(Name = "wirelessLanControllerName", EmitDefaultValue = false)]
		public string? WirelessLanControllerName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseFlexConnect {\n");
			sb.Append("  Authentication: ").Append(Authentication).Append("\n");
			sb.Append("  DataSwitching: ").Append(DataSwitching).Append("\n");
			sb.Append("  EgressAclAnalysis: ").Append(EgressAclAnalysis).Append("\n");
			sb.Append("  IngressAclAnalysis: ").Append(IngressAclAnalysis).Append("\n");
			sb.Append("  WirelessLanControllerId: ").Append(WirelessLanControllerId).Append("\n");
			sb.Append("  WirelessLanControllerName: ").Append(WirelessLanControllerName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
