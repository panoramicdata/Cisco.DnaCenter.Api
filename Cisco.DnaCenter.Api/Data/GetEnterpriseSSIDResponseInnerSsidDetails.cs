using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEnterpriseSSIDResponseInnerSsidDetails
	/// </summary>
	[DataContract]
	public partial class GetEnterpriseSSIDResponseInnerSsidDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEnterpriseSSIDResponseInnerSsidDetails" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="WlanType">WlanType.</param>
		/// <param name="EnableFastLane">EnableFastLane.</param>
		/// <param name="SecurityLevel">SecurityLevel.</param>
		/// <param name="AuthServer">AuthServer.</param>
		/// <param name="Passphrase">Passphrase.</param>
		/// <param name="TrafficType">TrafficType.</param>
		/// <param name="EnableMACFiltering">EnableMACFiltering.</param>
		/// <param name="IsEnabled">IsEnabled.</param>
		/// <param name="IsFabric">IsFabric.</param>
		/// <param name="FastTransition">FastTransition.</param>
		/// <param name="RadioPolicy">RadioPolicy.</param>
		/// <param name="EnableBroadcastSSID">EnableBroadcastSSID.</param>
		public GetEnterpriseSSIDResponseInnerSsidDetails(string? Name = default, string? WlanType = default, bool? EnableFastLane = default, string? SecurityLevel = default, string? AuthServer = default, string? Passphrase = default, string? TrafficType = default, bool? EnableMACFiltering = default, bool? IsEnabled = default, bool? IsFabric = default, string? FastTransition = default, string? RadioPolicy = default, bool? EnableBroadcastSSID = default)
		{
			this.Name = Name;
			this.WlanType = WlanType;
			this.EnableFastLane = EnableFastLane;
			this.SecurityLevel = SecurityLevel;
			this.AuthServer = AuthServer;
			this.Passphrase = Passphrase;
			this.TrafficType = TrafficType;
			this.EnableMACFiltering = EnableMACFiltering;
			this.IsEnabled = IsEnabled;
			this.IsFabric = IsFabric;
			this.FastTransition = FastTransition;
			this.RadioPolicy = RadioPolicy;
			this.EnableBroadcastSSID = EnableBroadcastSSID;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets WlanType
		/// </summary>
		[DataMember(Name = "wlanType", EmitDefaultValue = false)]
		public string? WlanType { get; set; }
		/// <summary>
		/// Gets or Sets EnableFastLane
		/// </summary>
		[DataMember(Name = "enableFastLane", EmitDefaultValue = false)]
		public bool? EnableFastLane { get; set; }
		/// <summary>
		/// Gets or Sets SecurityLevel
		/// </summary>
		[DataMember(Name = "securityLevel", EmitDefaultValue = false)]
		public string? SecurityLevel { get; set; }
		/// <summary>
		/// Gets or Sets AuthServer
		/// </summary>
		[DataMember(Name = "authServer", EmitDefaultValue = false)]
		public string? AuthServer { get; set; }
		/// <summary>
		/// Gets or Sets Passphrase
		/// </summary>
		[DataMember(Name = "passphrase", EmitDefaultValue = false)]
		public string? Passphrase { get; set; }
		/// <summary>
		/// Gets or Sets TrafficType
		/// </summary>
		[DataMember(Name = "trafficType", EmitDefaultValue = false)]
		public string? TrafficType { get; set; }
		/// <summary>
		/// Gets or Sets EnableMACFiltering
		/// </summary>
		[DataMember(Name = "enableMACFiltering", EmitDefaultValue = false)]
		public bool? EnableMACFiltering { get; set; }
		/// <summary>
		/// Gets or Sets IsEnabled
		/// </summary>
		[DataMember(Name = "isEnabled", EmitDefaultValue = false)]
		public bool? IsEnabled { get; set; }
		/// <summary>
		/// Gets or Sets IsFabric
		/// </summary>
		[DataMember(Name = "isFabric", EmitDefaultValue = false)]
		public bool? IsFabric { get; set; }
		/// <summary>
		/// Gets or Sets FastTransition
		/// </summary>
		[DataMember(Name = "fastTransition", EmitDefaultValue = false)]
		public string? FastTransition { get; set; }
		/// <summary>
		/// Gets or Sets RadioPolicy
		/// </summary>
		[DataMember(Name = "radioPolicy", EmitDefaultValue = false)]
		public string? RadioPolicy { get; set; }
		/// <summary>
		/// Gets or Sets EnableBroadcastSSID
		/// </summary>
		[DataMember(Name = "enableBroadcastSSID", EmitDefaultValue = false)]
		public bool? EnableBroadcastSSID { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEnterpriseSSIDResponseInnerSsidDetails {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  WlanType: ").Append(WlanType).Append("\n");
			sb.Append("  EnableFastLane: ").Append(EnableFastLane).Append("\n");
			sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
			sb.Append("  AuthServer: ").Append(AuthServer).Append("\n");
			sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
			sb.Append("  TrafficType: ").Append(TrafficType).Append("\n");
			sb.Append("  EnableMACFiltering: ").Append(EnableMACFiltering).Append("\n");
			sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
			sb.Append("  IsFabric: ").Append(IsFabric).Append("\n");
			sb.Append("  FastTransition: ").Append(FastTransition).Append("\n");
			sb.Append("  RadioPolicy: ").Append(RadioPolicy).Append("\n");
			sb.Append("  EnableBroadcastSSID: ").Append(EnableBroadcastSSID).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
