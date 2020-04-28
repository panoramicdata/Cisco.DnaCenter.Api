using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// InventoryRequest
	/// </summary>
	[DataContract]
	public class InventoryRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryRequest" /> class.
		/// </summary>
		/// <param name="CdpLevel">CdpLevel.</param>
		/// <param name="DiscoveryType">DiscoveryType.</param>
		/// <param name="EnablePasswordList">EnablePasswordList.</param>
		/// <param name="GlobalCredentialIdList">GlobalCredentialIdList.</param>
		/// <param name="HttpReadCredential">HttpReadCredential.</param>
		/// <param name="HttpWriteCredential">HttpWriteCredential.</param>
		/// <param name="IpAddressList">IpAddressList.</param>
		/// <param name="IpFilterList">IpFilterList.</param>
		/// <param name="LldpLevel">LldpLevel.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NetconfPort">NetconfPort.</param>
		/// <param name="NoAddNewDevice">NoAddNewDevice.</param>
		/// <param name="ParentDiscoveryId">ParentDiscoveryId.</param>
		/// <param name="PasswordList">PasswordList.</param>
		/// <param name="PreferredManagementIpMethod">PreferredMgmtIPMethod.</param>
		/// <param name="ProtocolOrder">ProtocolOrder.</param>
		/// <param name="ReDiscovery">ReDiscovery.</param>
		/// <param name="Retry">Retry.</param>
		/// <param name="SnmpAuthPassphrase">SnmpAuthPassphrase.</param>
		/// <param name="SnmpAuthProtocol">SnmpAuthProtocol.</param>
		/// <param name="SnmpMode">SnmpMode.</param>
		/// <param name="SnmpPrivPassphrase">SnmpPrivPassphrase.</param>
		/// <param name="SnmpPrivProtocol">SnmpPrivProtocol.</param>
		/// <param name="SnmpROCommunity">SnmpROCommunity.</param>
		/// <param name="SnmpROCommunityDesc">SnmpROCommunityDesc.</param>
		/// <param name="SnmpRWCommunity">SnmpRWCommunity.</param>
		/// <param name="SnmpRWCommunityDesc">SnmpRWCommunityDesc.</param>
		/// <param name="SnmpUserName">SnmpUserName.</param>
		/// <param name="SnmpVersion">SnmpVersion.</param>
		/// <param name="Timeout">Timeout.</param>
		/// <param name="UpdateMgmtIp">UpdateMgmtIp.</param>
		/// <param name="UserNameList">UserNameList.</param>
		public InventoryRequest(int? CdpLevel = default, string? DiscoveryType = default, List<string> EnablePasswordList = default, List<string> GlobalCredentialIdList = default, InventoryRequestHttpReadCredential HttpReadCredential = default, InventoryRequestHttpReadCredential HttpWriteCredential = default, string? IpAddressList = default, List<string> IpFilterList = default, int? LldpLevel = default, string? Name = default, string? NetconfPort = default, bool? NoAddNewDevice = default, string? ParentDiscoveryId = default, List<string> PasswordList = default, string? PreferredManagementIpMethod = default, string? ProtocolOrder = default, bool? ReDiscovery = default, int? Retry = default, string? SnmpAuthPassphrase = default, string? SnmpAuthProtocol = default, string? SnmpMode = default, string? SnmpPrivPassphrase = default, string? SnmpPrivProtocol = default, string? SnmpROCommunity = default, string? SnmpROCommunityDesc = default, string? SnmpRWCommunity = default, string? SnmpRWCommunityDesc = default, string? SnmpUserName = default, string? SnmpVersion = default, int? Timeout = default, bool? UpdateMgmtIp = default, List<string> UserNameList = default)
		{
			this.CdpLevel = CdpLevel;
			this.DiscoveryType = DiscoveryType;
			this.EnablePasswordList = EnablePasswordList;
			this.GlobalCredentialIdList = GlobalCredentialIdList;
			this.HttpReadCredential = HttpReadCredential;
			this.HttpWriteCredential = HttpWriteCredential;
			this.IpAddressList = IpAddressList;
			this.IpFilterList = IpFilterList;
			this.LldpLevel = LldpLevel;
			this.Name = Name;
			this.NetconfPort = NetconfPort;
			this.NoAddNewDevice = NoAddNewDevice;
			this.ParentDiscoveryId = ParentDiscoveryId;
			this.PasswordList = PasswordList;
			this.PreferredManagementIpMethod = PreferredManagementIpMethod;
			this.ProtocolOrder = ProtocolOrder;
			this.ReDiscovery = ReDiscovery;
			this.Retry = Retry;
			this.SnmpAuthPassphrase = SnmpAuthPassphrase;
			this.SnmpAuthProtocol = SnmpAuthProtocol;
			this.SnmpMode = SnmpMode;
			this.SnmpPrivPassphrase = SnmpPrivPassphrase;
			this.SnmpPrivProtocol = SnmpPrivProtocol;
			this.SnmpROCommunity = SnmpROCommunity;
			this.SnmpROCommunityDesc = SnmpROCommunityDesc;
			this.SnmpRWCommunity = SnmpRWCommunity;
			this.SnmpRWCommunityDesc = SnmpRWCommunityDesc;
			this.SnmpUserName = SnmpUserName;
			this.SnmpVersion = SnmpVersion;
			this.Timeout = Timeout;
			this.UpdateMgmtIp = UpdateMgmtIp;
			this.UserNameList = UserNameList;
		}

		/// <summary>
		/// Gets or Sets CdpLevel
		/// </summary>
		[DataMember(Name = "cdpLevel", EmitDefaultValue = false)]
		public int? CdpLevel { get; set; }

		/// <summary>
		/// Gets or Sets DiscoveryType
		/// </summary>
		[DataMember(Name = "discoveryType", EmitDefaultValue = false)]
		public string? DiscoveryType { get; set; }

		/// <summary>
		/// Gets or Sets EnablePasswordList
		/// </summary>
		[DataMember(Name = "enablePasswordList", EmitDefaultValue = false)]
		public List<string> EnablePasswordList { get; set; }

		/// <summary>
		/// Gets or Sets GlobalCredentialIdList
		/// </summary>
		[DataMember(Name = "globalCredentialIdList", EmitDefaultValue = false)]
		public List<string> GlobalCredentialIdList { get; set; }

		/// <summary>
		/// Gets or Sets HttpReadCredential
		/// </summary>
		[DataMember(Name = "httpReadCredential", EmitDefaultValue = false)]
		public InventoryRequestHttpReadCredential HttpReadCredential { get; set; }

		/// <summary>
		/// Gets or Sets HttpWriteCredential
		/// </summary>
		[DataMember(Name = "httpWriteCredential", EmitDefaultValue = false)]
		public InventoryRequestHttpReadCredential HttpWriteCredential { get; set; }

		/// <summary>
		/// Gets or Sets IpAddressList
		/// </summary>
		[DataMember(Name = "ipAddressList", EmitDefaultValue = false)]
		public string? IpAddressList { get; set; }

		/// <summary>
		/// Gets or Sets IpFilterList
		/// </summary>
		[DataMember(Name = "ipFilterList", EmitDefaultValue = false)]
		public List<string> IpFilterList { get; set; }

		/// <summary>
		/// Gets or Sets LldpLevel
		/// </summary>
		[DataMember(Name = "lldpLevel", EmitDefaultValue = false)]
		public int? LldpLevel { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets NetconfPort
		/// </summary>
		[DataMember(Name = "netconfPort", EmitDefaultValue = false)]
		public string? NetconfPort { get; set; }

		/// <summary>
		/// Gets or Sets NoAddNewDevice
		/// </summary>
		[DataMember(Name = "noAddNewDevice", EmitDefaultValue = false)]
		public bool? NoAddNewDevice { get; set; }

		/// <summary>
		/// Gets or Sets ParentDiscoveryId
		/// </summary>
		[DataMember(Name = "parentDiscoveryId", EmitDefaultValue = false)]
		public string? ParentDiscoveryId { get; set; }

		/// <summary>
		/// Gets or Sets PasswordList
		/// </summary>
		[DataMember(Name = "passwordList", EmitDefaultValue = false)]
		public List<string> PasswordList { get; set; }

		/// <summary>
		/// Gets or Sets PreferredMgmtIPMethod
		/// </summary>
		[DataMember(Name = "preferredMgmtIPMethod", EmitDefaultValue = false)]
		public string? PreferredManagementIpMethod { get; set; }

		/// <summary>
		/// Gets or Sets ProtocolOrder
		/// </summary>
		[DataMember(Name = "protocolOrder", EmitDefaultValue = false)]
		public string? ProtocolOrder { get; set; }

		/// <summary>
		/// Gets or Sets ReDiscovery
		/// </summary>
		[DataMember(Name = "reDiscovery", EmitDefaultValue = false)]
		public bool? ReDiscovery { get; set; }

		/// <summary>
		/// Gets or Sets Retry
		/// </summary>
		[DataMember(Name = "retry", EmitDefaultValue = false)]
		public int? Retry { get; set; }

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
		/// Gets or Sets SnmpROCommunityDesc
		/// </summary>
		[DataMember(Name = "snmpROCommunityDesc", EmitDefaultValue = false)]
		public string? SnmpROCommunityDesc { get; set; }

		/// <summary>
		/// Gets or Sets SnmpRWCommunity
		/// </summary>
		[DataMember(Name = "snmpRWCommunity", EmitDefaultValue = false)]
		public string? SnmpRWCommunity { get; set; }

		/// <summary>
		/// Gets or Sets SnmpRWCommunityDesc
		/// </summary>
		[DataMember(Name = "snmpRWCommunityDesc", EmitDefaultValue = false)]
		public string? SnmpRWCommunityDesc { get; set; }

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
		/// Gets or Sets Timeout
		/// </summary>
		[DataMember(Name = "timeout", EmitDefaultValue = false)]
		public int? Timeout { get; set; }

		/// <summary>
		/// Gets or Sets UpdateMgmtIp
		/// </summary>
		[DataMember(Name = "updateMgmtIp", EmitDefaultValue = false)]
		public bool? UpdateMgmtIp { get; set; }

		/// <summary>
		/// Gets or Sets UserNameList
		/// </summary>
		[DataMember(Name = "userNameList", EmitDefaultValue = false)]
		public List<string> UserNameList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InventoryRequest {\n");
			sb.Append("  CdpLevel: ").Append(CdpLevel).Append("\n");
			sb.Append("  DiscoveryType: ").Append(DiscoveryType).Append("\n");
			sb.Append("  EnablePasswordList: ").Append(EnablePasswordList).Append("\n");
			sb.Append("  GlobalCredentialIdList: ").Append(GlobalCredentialIdList).Append("\n");
			sb.Append("  HttpReadCredential: ").Append(HttpReadCredential).Append("\n");
			sb.Append("  HttpWriteCredential: ").Append(HttpWriteCredential).Append("\n");
			sb.Append("  IpAddressList: ").Append(IpAddressList).Append("\n");
			sb.Append("  IpFilterList: ").Append(IpFilterList).Append("\n");
			sb.Append("  LldpLevel: ").Append(LldpLevel).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  NetconfPort: ").Append(NetconfPort).Append("\n");
			sb.Append("  NoAddNewDevice: ").Append(NoAddNewDevice).Append("\n");
			sb.Append("  ParentDiscoveryId: ").Append(ParentDiscoveryId).Append("\n");
			sb.Append("  PasswordList: ").Append(PasswordList).Append("\n");
			sb.Append("  PreferredMgmtIPMethod: ").Append(PreferredManagementIpMethod).Append("\n");
			sb.Append("  ProtocolOrder: ").Append(ProtocolOrder).Append("\n");
			sb.Append("  ReDiscovery: ").Append(ReDiscovery).Append("\n");
			sb.Append("  Retry: ").Append(Retry).Append("\n");
			sb.Append("  SnmpAuthPassphrase: ").Append(SnmpAuthPassphrase).Append("\n");
			sb.Append("  SnmpAuthProtocol: ").Append(SnmpAuthProtocol).Append("\n");
			sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
			sb.Append("  SnmpPrivPassphrase: ").Append(SnmpPrivPassphrase).Append("\n");
			sb.Append("  SnmpPrivProtocol: ").Append(SnmpPrivProtocol).Append("\n");
			sb.Append("  SnmpROCommunity: ").Append(SnmpROCommunity).Append("\n");
			sb.Append("  SnmpROCommunityDesc: ").Append(SnmpROCommunityDesc).Append("\n");
			sb.Append("  SnmpRWCommunity: ").Append(SnmpRWCommunity).Append("\n");
			sb.Append("  SnmpRWCommunityDesc: ").Append(SnmpRWCommunityDesc).Append("\n");
			sb.Append("  SnmpUserName: ").Append(SnmpUserName).Append("\n");
			sb.Append("  SnmpVersion: ").Append(SnmpVersion).Append("\n");
			sb.Append("  Timeout: ").Append(Timeout).Append("\n");
			sb.Append("  UpdateMgmtIp: ").Append(UpdateMgmtIp).Append("\n");
			sb.Append("  UserNameList: ").Append(UserNameList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
