using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DiscoveryNIOResultResponse
	/// </summary>
	[DataContract]
	public partial class DiscoveryNIOResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DiscoveryNIOResultResponse" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="CdpLevel">CdpLevel.</param>
		/// <param name="DeviceIds">DeviceIds.</param>
		/// <param name="DiscoveryCondition">DiscoveryCondition.</param>
		/// <param name="DiscoveryStatus">DiscoveryStatus.</param>
		/// <param name="DiscoveryType">DiscoveryType.</param>
		/// <param name="EnablePasswordList">EnablePasswordList.</param>
		/// <param name="GlobalCredentialIdList">GlobalCredentialIdList.</param>
		/// <param name="HttpReadCredential">HttpReadCredential.</param>
		/// <param name="HttpWriteCredential">HttpWriteCredential.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IpAddressList">IpAddressList.</param>
		/// <param name="IpFilterList">IpFilterList.</param>
		/// <param name="IsAutoCdp">IsAutoCdp.</param>
		/// <param name="LldpLevel">LldpLevel.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NetconfPort">NetconfPort.</param>
		/// <param name="NumDevices">NumDevices.</param>
		/// <param name="ParentDiscoveryId">ParentDiscoveryId.</param>
		/// <param name="PasswordList">PasswordList.</param>
		/// <param name="PreferredMgmtIPMethod">PreferredMgmtIPMethod.</param>
		/// <param name="ProtocolOrder">ProtocolOrder.</param>
		/// <param name="RetryCount">RetryCount.</param>
		/// <param name="SnmpAuthPassphrase">SnmpAuthPassphrase.</param>
		/// <param name="SnmpAuthProtocol">SnmpAuthProtocol.</param>
		/// <param name="SnmpMode">SnmpMode.</param>
		/// <param name="SnmpPrivPassphrase">SnmpPrivPassphrase.</param>
		/// <param name="SnmpPrivProtocol">SnmpPrivProtocol.</param>
		/// <param name="SnmpRoCommunity">SnmpRoCommunity.</param>
		/// <param name="SnmpRoCommunityDesc">SnmpRoCommunityDesc.</param>
		/// <param name="SnmpRwCommunity">SnmpRwCommunity.</param>
		/// <param name="SnmpRwCommunityDesc">SnmpRwCommunityDesc.</param>
		/// <param name="SnmpUserName">SnmpUserName.</param>
		/// <param name="TimeOut">TimeOut.</param>
		/// <param name="UpdateMgmtIp">UpdateMgmtIp.</param>
		/// <param name="UserNameList">UserNameList.</param>
		public DiscoveryNIOResultResponse(Object AttributeInfo = default, int? CdpLevel = default, string? DeviceIds = default, string? DiscoveryCondition = default, string? DiscoveryStatus = default, string? DiscoveryType = default, string? EnablePasswordList = default, List<string> GlobalCredentialIdList = default, InventoryRequestHttpReadCredential HttpReadCredential = default, InventoryRequestHttpReadCredential HttpWriteCredential = default, string? Id = default, string? IpAddressList = default, string? IpFilterList = default, bool? IsAutoCdp = default, int? LldpLevel = default, string? Name = default, string? NetconfPort = default, int? NumDevices = default, string? ParentDiscoveryId = default, string? PasswordList = default, string? PreferredMgmtIPMethod = default, string? ProtocolOrder = default, int? RetryCount = default, string? SnmpAuthPassphrase = default, string? SnmpAuthProtocol = default, string? SnmpMode = default, string? SnmpPrivPassphrase = default, string? SnmpPrivProtocol = default, string? SnmpRoCommunity = default, string? SnmpRoCommunityDesc = default, string? SnmpRwCommunity = default, string? SnmpRwCommunityDesc = default, string? SnmpUserName = default, int? TimeOut = default, bool? UpdateMgmtIp = default, string? UserNameList = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.CdpLevel = CdpLevel;
			this.DeviceIds = DeviceIds;
			this.DiscoveryCondition = DiscoveryCondition;
			this.DiscoveryStatus = DiscoveryStatus;
			this.DiscoveryType = DiscoveryType;
			this.EnablePasswordList = EnablePasswordList;
			this.GlobalCredentialIdList = GlobalCredentialIdList;
			this.HttpReadCredential = HttpReadCredential;
			this.HttpWriteCredential = HttpWriteCredential;
			this.Id = Id;
			this.IpAddressList = IpAddressList;
			this.IpFilterList = IpFilterList;
			this.IsAutoCdp = IsAutoCdp;
			this.LldpLevel = LldpLevel;
			this.Name = Name;
			this.NetconfPort = NetconfPort;
			this.NumDevices = NumDevices;
			this.ParentDiscoveryId = ParentDiscoveryId;
			this.PasswordList = PasswordList;
			this.PreferredMgmtIPMethod = PreferredMgmtIPMethod;
			this.ProtocolOrder = ProtocolOrder;
			this.RetryCount = RetryCount;
			this.SnmpAuthPassphrase = SnmpAuthPassphrase;
			this.SnmpAuthProtocol = SnmpAuthProtocol;
			this.SnmpMode = SnmpMode;
			this.SnmpPrivPassphrase = SnmpPrivPassphrase;
			this.SnmpPrivProtocol = SnmpPrivProtocol;
			this.SnmpRoCommunity = SnmpRoCommunity;
			this.SnmpRoCommunityDesc = SnmpRoCommunityDesc;
			this.SnmpRwCommunity = SnmpRwCommunity;
			this.SnmpRwCommunityDesc = SnmpRwCommunityDesc;
			this.SnmpUserName = SnmpUserName;
			this.TimeOut = TimeOut;
			this.UpdateMgmtIp = UpdateMgmtIp;
			this.UserNameList = UserNameList;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets CdpLevel
		/// </summary>
		[DataMember(Name = "cdpLevel", EmitDefaultValue = false)]
		public int? CdpLevel { get; set; }
		/// <summary>
		/// Gets or Sets DeviceIds
		/// </summary>
		[DataMember(Name = "deviceIds", EmitDefaultValue = false)]
		public string? DeviceIds { get; set; }
		/// <summary>
		/// Gets or Sets DiscoveryCondition
		/// </summary>
		[DataMember(Name = "discoveryCondition", EmitDefaultValue = false)]
		public string? DiscoveryCondition { get; set; }
		/// <summary>
		/// Gets or Sets DiscoveryStatus
		/// </summary>
		[DataMember(Name = "discoveryStatus", EmitDefaultValue = false)]
		public string? DiscoveryStatus { get; set; }
		/// <summary>
		/// Gets or Sets DiscoveryType
		/// </summary>
		[DataMember(Name = "discoveryType", EmitDefaultValue = false)]
		public string? DiscoveryType { get; set; }
		/// <summary>
		/// Gets or Sets EnablePasswordList
		/// </summary>
		[DataMember(Name = "enablePasswordList", EmitDefaultValue = false)]
		public string? EnablePasswordList { get; set; }
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
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets IpAddressList
		/// </summary>
		[DataMember(Name = "ipAddressList", EmitDefaultValue = false)]
		public string? IpAddressList { get; set; }
		/// <summary>
		/// Gets or Sets IpFilterList
		/// </summary>
		[DataMember(Name = "ipFilterList", EmitDefaultValue = false)]
		public string? IpFilterList { get; set; }
		/// <summary>
		/// Gets or Sets IsAutoCdp
		/// </summary>
		[DataMember(Name = "isAutoCdp", EmitDefaultValue = false)]
		public bool? IsAutoCdp { get; set; }
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
		/// Gets or Sets NumDevices
		/// </summary>
		[DataMember(Name = "numDevices", EmitDefaultValue = false)]
		public int? NumDevices { get; set; }
		/// <summary>
		/// Gets or Sets ParentDiscoveryId
		/// </summary>
		[DataMember(Name = "parentDiscoveryId", EmitDefaultValue = false)]
		public string? ParentDiscoveryId { get; set; }
		/// <summary>
		/// Gets or Sets PasswordList
		/// </summary>
		[DataMember(Name = "passwordList", EmitDefaultValue = false)]
		public string? PasswordList { get; set; }
		/// <summary>
		/// Gets or Sets PreferredMgmtIPMethod
		/// </summary>
		[DataMember(Name = "preferredMgmtIPMethod", EmitDefaultValue = false)]
		public string? PreferredMgmtIPMethod { get; set; }
		/// <summary>
		/// Gets or Sets ProtocolOrder
		/// </summary>
		[DataMember(Name = "protocolOrder", EmitDefaultValue = false)]
		public string? ProtocolOrder { get; set; }
		/// <summary>
		/// Gets or Sets RetryCount
		/// </summary>
		[DataMember(Name = "retryCount", EmitDefaultValue = false)]
		public int? RetryCount { get; set; }
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
		/// Gets or Sets SnmpRoCommunity
		/// </summary>
		[DataMember(Name = "snmpRoCommunity", EmitDefaultValue = false)]
		public string? SnmpRoCommunity { get; set; }
		/// <summary>
		/// Gets or Sets SnmpRoCommunityDesc
		/// </summary>
		[DataMember(Name = "snmpRoCommunityDesc", EmitDefaultValue = false)]
		public string? SnmpRoCommunityDesc { get; set; }
		/// <summary>
		/// Gets or Sets SnmpRwCommunity
		/// </summary>
		[DataMember(Name = "snmpRwCommunity", EmitDefaultValue = false)]
		public string? SnmpRwCommunity { get; set; }
		/// <summary>
		/// Gets or Sets SnmpRwCommunityDesc
		/// </summary>
		[DataMember(Name = "snmpRwCommunityDesc", EmitDefaultValue = false)]
		public string? SnmpRwCommunityDesc { get; set; }
		/// <summary>
		/// Gets or Sets SnmpUserName
		/// </summary>
		[DataMember(Name = "snmpUserName", EmitDefaultValue = false)]
		public string? SnmpUserName { get; set; }
		/// <summary>
		/// Gets or Sets TimeOut
		/// </summary>
		[DataMember(Name = "timeOut", EmitDefaultValue = false)]
		public int? TimeOut { get; set; }
		/// <summary>
		/// Gets or Sets UpdateMgmtIp
		/// </summary>
		[DataMember(Name = "updateMgmtIp", EmitDefaultValue = false)]
		public bool? UpdateMgmtIp { get; set; }
		/// <summary>
		/// Gets or Sets UserNameList
		/// </summary>
		[DataMember(Name = "userNameList", EmitDefaultValue = false)]
		public string? UserNameList { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DiscoveryNIOResultResponse {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  CdpLevel: ").Append(CdpLevel).Append("\n");
			sb.Append("  DeviceIds: ").Append(DeviceIds).Append("\n");
			sb.Append("  DiscoveryCondition: ").Append(DiscoveryCondition).Append("\n");
			sb.Append("  DiscoveryStatus: ").Append(DiscoveryStatus).Append("\n");
			sb.Append("  DiscoveryType: ").Append(DiscoveryType).Append("\n");
			sb.Append("  EnablePasswordList: ").Append(EnablePasswordList).Append("\n");
			sb.Append("  GlobalCredentialIdList: ").Append(GlobalCredentialIdList).Append("\n");
			sb.Append("  HttpReadCredential: ").Append(HttpReadCredential).Append("\n");
			sb.Append("  HttpWriteCredential: ").Append(HttpWriteCredential).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IpAddressList: ").Append(IpAddressList).Append("\n");
			sb.Append("  IpFilterList: ").Append(IpFilterList).Append("\n");
			sb.Append("  IsAutoCdp: ").Append(IsAutoCdp).Append("\n");
			sb.Append("  LldpLevel: ").Append(LldpLevel).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  NetconfPort: ").Append(NetconfPort).Append("\n");
			sb.Append("  NumDevices: ").Append(NumDevices).Append("\n");
			sb.Append("  ParentDiscoveryId: ").Append(ParentDiscoveryId).Append("\n");
			sb.Append("  PasswordList: ").Append(PasswordList).Append("\n");
			sb.Append("  PreferredMgmtIPMethod: ").Append(PreferredMgmtIPMethod).Append("\n");
			sb.Append("  ProtocolOrder: ").Append(ProtocolOrder).Append("\n");
			sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
			sb.Append("  SnmpAuthPassphrase: ").Append(SnmpAuthPassphrase).Append("\n");
			sb.Append("  SnmpAuthProtocol: ").Append(SnmpAuthProtocol).Append("\n");
			sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
			sb.Append("  SnmpPrivPassphrase: ").Append(SnmpPrivPassphrase).Append("\n");
			sb.Append("  SnmpPrivProtocol: ").Append(SnmpPrivProtocol).Append("\n");
			sb.Append("  SnmpRoCommunity: ").Append(SnmpRoCommunity).Append("\n");
			sb.Append("  SnmpRoCommunityDesc: ").Append(SnmpRoCommunityDesc).Append("\n");
			sb.Append("  SnmpRwCommunity: ").Append(SnmpRwCommunity).Append("\n");
			sb.Append("  SnmpRwCommunityDesc: ").Append(SnmpRwCommunityDesc).Append("\n");
			sb.Append("  SnmpUserName: ").Append(SnmpUserName).Append("\n");
			sb.Append("  TimeOut: ").Append(TimeOut).Append("\n");
			sb.Append("  UpdateMgmtIp: ").Append(UpdateMgmtIp).Append("\n");
			sb.Append("  UserNameList: ").Append(UserNameList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
