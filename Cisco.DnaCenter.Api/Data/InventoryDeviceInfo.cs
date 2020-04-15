using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// InventoryDeviceInfo
	/// </summary>
	[DataContract]
	public partial class InventoryDeviceInfo
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum COMPUTEDEVICE for "COMPUTE_DEVICE"
			/// </summary>
			[EnumMember(Value = "COMPUTE_DEVICE")]
			COMPUTEDEVICE,

			/// <summary>
			/// Enum MERAKIDASHBOARD for "MERAKI_DASHBOARD"
			/// </summary>
			[EnumMember(Value = "MERAKI_DASHBOARD")]
			MERAKIDASHBOARD,

			/// <summary>
			/// Enum NETWORKDEVICE for "NETWORK_DEVICE"
			/// </summary>
			[EnumMember(Value = "NETWORK_DEVICE")]
			NETWORKDEVICE,

			/// <summary>
			/// Enum NODATACHANGE for "NODATACHANGE"
			/// </summary>
			[EnumMember(Value = "NODATACHANGE")]
			NODATACHANGE
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryDeviceInfo" /> class.
		/// </summary>
		/// <param name="CliTransport">CliTransport.</param>
		/// <param name="ComputeDevice">ComputeDevice.</param>
		/// <param name="EnablePassword">EnablePassword.</param>
		/// <param name="ExtendedDiscoveryInfo">ExtendedDiscoveryInfo.</param>
		/// <param name="HttpPassword">HttpPassword.</param>
		/// <param name="HttpPort">HttpPort.</param>
		/// <param name="HttpSecure">HttpSecure.</param>
		/// <param name="HttpUserName">HttpUserName.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="MerakiOrgId">MerakiOrgId.</param>
		/// <param name="NetconfPort">NetconfPort.</param>
		/// <param name="Password">Password.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="SnmpAuthPassphrase">SnmpAuthPassphrase.</param>
		/// <param name="SnmpAuthProtocol">SnmpAuthProtocol.</param>
		/// <param name="SnmpMode">SnmpMode.</param>
		/// <param name="SnmpPrivPassphrase">SnmpPrivPassphrase.</param>
		/// <param name="SnmpPrivProtocol">SnmpPrivProtocol.</param>
		/// <param name="SnmpROCommunity">SnmpROCommunity.</param>
		/// <param name="SnmpRWCommunity">SnmpRWCommunity.</param>
		/// <param name="SnmpRetry">SnmpRetry.</param>
		/// <param name="SnmpTimeout">SnmpTimeout.</param>
		/// <param name="SnmpUserName">SnmpUserName.</param>
		/// <param name="SnmpVersion">SnmpVersion.</param>
		/// <param name="Type">Type.</param>
		/// <param name="UpdateMgmtIPaddressList">UpdateMgmtIPaddressList.</param>
		/// <param name="UserName">UserName.</param>
		public InventoryDeviceInfo(string? CliTransport = default, bool? ComputeDevice = default, string? EnablePassword = default, string? ExtendedDiscoveryInfo = default, string? HttpPassword = default, string? HttpPort = default, bool? HttpSecure = default, string? HttpUserName = default, List<string> IpAddress = default, List<string> MerakiOrgId = default, string? NetconfPort = default, string? Password = default, string? SerialNumber = default, string? SnmpAuthPassphrase = default, string? SnmpAuthProtocol = default, string? SnmpMode = default, string? SnmpPrivPassphrase = default, string? SnmpPrivProtocol = default, string? SnmpROCommunity = default, string? SnmpRWCommunity = default, int? SnmpRetry = default, int? SnmpTimeout = default, string? SnmpUserName = default, string? SnmpVersion = default, TypeEnum? Type = default, List<InventoryDeviceInfoUpdateMgmtIPaddressList> UpdateMgmtIPaddressList = default, string? UserName = default)
		{
			this.CliTransport = CliTransport;
			this.ComputeDevice = ComputeDevice;
			this.EnablePassword = EnablePassword;
			this.ExtendedDiscoveryInfo = ExtendedDiscoveryInfo;
			this.HttpPassword = HttpPassword;
			this.HttpPort = HttpPort;
			this.HttpSecure = HttpSecure;
			this.HttpUserName = HttpUserName;
			this.IpAddress = IpAddress;
			this.MerakiOrgId = MerakiOrgId;
			this.NetconfPort = NetconfPort;
			this.Password = Password;
			this.SerialNumber = SerialNumber;
			this.SnmpAuthPassphrase = SnmpAuthPassphrase;
			this.SnmpAuthProtocol = SnmpAuthProtocol;
			this.SnmpMode = SnmpMode;
			this.SnmpPrivPassphrase = SnmpPrivPassphrase;
			this.SnmpPrivProtocol = SnmpPrivProtocol;
			this.SnmpROCommunity = SnmpROCommunity;
			this.SnmpRWCommunity = SnmpRWCommunity;
			this.SnmpRetry = SnmpRetry;
			this.SnmpTimeout = SnmpTimeout;
			this.SnmpUserName = SnmpUserName;
			this.SnmpVersion = SnmpVersion;
			this.Type = Type;
			this.UpdateMgmtIPaddressList = UpdateMgmtIPaddressList;
			this.UserName = UserName;
		}

		/// <summary>
		/// Gets or Sets CliTransport
		/// </summary>
		[DataMember(Name = "cliTransport", EmitDefaultValue = false)]
		public string? CliTransport { get; set; }
		/// <summary>
		/// Gets or Sets ComputeDevice
		/// </summary>
		[DataMember(Name = "computeDevice", EmitDefaultValue = false)]
		public bool? ComputeDevice { get; set; }
		/// <summary>
		/// Gets or Sets EnablePassword
		/// </summary>
		[DataMember(Name = "enablePassword", EmitDefaultValue = false)]
		public string? EnablePassword { get; set; }
		/// <summary>
		/// Gets or Sets ExtendedDiscoveryInfo
		/// </summary>
		[DataMember(Name = "extendedDiscoveryInfo", EmitDefaultValue = false)]
		public string? ExtendedDiscoveryInfo { get; set; }
		/// <summary>
		/// Gets or Sets HttpPassword
		/// </summary>
		[DataMember(Name = "httpPassword", EmitDefaultValue = false)]
		public string? HttpPassword { get; set; }
		/// <summary>
		/// Gets or Sets HttpPort
		/// </summary>
		[DataMember(Name = "httpPort", EmitDefaultValue = false)]
		public string? HttpPort { get; set; }
		/// <summary>
		/// Gets or Sets HttpSecure
		/// </summary>
		[DataMember(Name = "httpSecure", EmitDefaultValue = false)]
		public bool? HttpSecure { get; set; }
		/// <summary>
		/// Gets or Sets HttpUserName
		/// </summary>
		[DataMember(Name = "httpUserName", EmitDefaultValue = false)]
		public string? HttpUserName { get; set; }
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public List<string> IpAddress { get; set; }
		/// <summary>
		/// Gets or Sets MerakiOrgId
		/// </summary>
		[DataMember(Name = "merakiOrgId", EmitDefaultValue = false)]
		public List<string> MerakiOrgId { get; set; }
		/// <summary>
		/// Gets or Sets NetconfPort
		/// </summary>
		[DataMember(Name = "netconfPort", EmitDefaultValue = false)]
		public string? NetconfPort { get; set; }
		/// <summary>
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "password", EmitDefaultValue = false)]
		public string? Password { get; set; }
		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
		public string? SerialNumber { get; set; }
		/// <summary>
		/// Gets or Sets SnmpAuthPassphrase
		/// </summary>
		[DataMember(Name = "snmpAuthPassphrase", EmitDefaultValue = false)]
		public string? SnmpAuthPassphrase { get; set; }
		/// <summary>
		/// Gets or Sets SnmpAuthProtocol
		/// </summary>
		[DataMember(Name = "snmpAuthProtocol", EmitDefaultValue = false)]
		public string? SnmpAuthProtocol { get; set; }
		/// <summary>
		/// Gets or Sets SnmpMode
		/// </summary>
		[DataMember(Name = "snmpMode", EmitDefaultValue = false)]
		public string? SnmpMode { get; set; }
		/// <summary>
		/// Gets or Sets SnmpPrivPassphrase
		/// </summary>
		[DataMember(Name = "snmpPrivPassphrase", EmitDefaultValue = false)]
		public string? SnmpPrivPassphrase { get; set; }
		/// <summary>
		/// Gets or Sets SnmpPrivProtocol
		/// </summary>
		[DataMember(Name = "snmpPrivProtocol", EmitDefaultValue = false)]
		public string? SnmpPrivProtocol { get; set; }
		/// <summary>
		/// Gets or Sets SnmpROCommunity
		/// </summary>
		[DataMember(Name = "snmpROCommunity", EmitDefaultValue = false)]
		public string? SnmpROCommunity { get; set; }
		/// <summary>
		/// Gets or Sets SnmpRWCommunity
		/// </summary>
		[DataMember(Name = "snmpRWCommunity", EmitDefaultValue = false)]
		public string? SnmpRWCommunity { get; set; }
		/// <summary>
		/// Gets or Sets SnmpRetry
		/// </summary>
		[DataMember(Name = "snmpRetry", EmitDefaultValue = false)]
		public int? SnmpRetry { get; set; }
		/// <summary>
		/// Gets or Sets SnmpTimeout
		/// </summary>
		[DataMember(Name = "snmpTimeout", EmitDefaultValue = false)]
		public int? SnmpTimeout { get; set; }
		/// <summary>
		/// Gets or Sets SnmpUserName
		/// </summary>
		[DataMember(Name = "snmpUserName", EmitDefaultValue = false)]
		public string? SnmpUserName { get; set; }
		/// <summary>
		/// Gets or Sets SnmpVersion
		/// </summary>
		[DataMember(Name = "snmpVersion", EmitDefaultValue = false)]
		public string? SnmpVersion { get; set; }
		/// <summary>
		/// Gets or Sets UpdateMgmtIPaddressList
		/// </summary>
		[DataMember(Name = "updateMgmtIPaddressList", EmitDefaultValue = false)]
		public List<InventoryDeviceInfoUpdateMgmtIPaddressList> UpdateMgmtIPaddressList { get; set; }
		/// <summary>
		/// Gets or Sets UserName
		/// </summary>
		[DataMember(Name = "userName", EmitDefaultValue = false)]
		public string? UserName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InventoryDeviceInfo {\n");
			sb.Append("  CliTransport: ").Append(CliTransport).Append("\n");
			sb.Append("  ComputeDevice: ").Append(ComputeDevice).Append("\n");
			sb.Append("  EnablePassword: ").Append(EnablePassword).Append("\n");
			sb.Append("  ExtendedDiscoveryInfo: ").Append(ExtendedDiscoveryInfo).Append("\n");
			sb.Append("  HttpPassword: ").Append(HttpPassword).Append("\n");
			sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
			sb.Append("  HttpSecure: ").Append(HttpSecure).Append("\n");
			sb.Append("  HttpUserName: ").Append(HttpUserName).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  MerakiOrgId: ").Append(MerakiOrgId).Append("\n");
			sb.Append("  NetconfPort: ").Append(NetconfPort).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
			sb.Append("  SnmpAuthPassphrase: ").Append(SnmpAuthPassphrase).Append("\n");
			sb.Append("  SnmpAuthProtocol: ").Append(SnmpAuthProtocol).Append("\n");
			sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
			sb.Append("  SnmpPrivPassphrase: ").Append(SnmpPrivPassphrase).Append("\n");
			sb.Append("  SnmpPrivProtocol: ").Append(SnmpPrivProtocol).Append("\n");
			sb.Append("  SnmpROCommunity: ").Append(SnmpROCommunity).Append("\n");
			sb.Append("  SnmpRWCommunity: ").Append(SnmpRWCommunity).Append("\n");
			sb.Append("  SnmpRetry: ").Append(SnmpRetry).Append("\n");
			sb.Append("  SnmpTimeout: ").Append(SnmpTimeout).Append("\n");
			sb.Append("  SnmpUserName: ").Append(SnmpUserName).Append("\n");
			sb.Append("  SnmpVersion: ").Append(SnmpVersion).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  UpdateMgmtIPaddressList: ").Append(UpdateMgmtIPaddressList).Append("\n");
			sb.Append("  UserName: ").Append(UserName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
