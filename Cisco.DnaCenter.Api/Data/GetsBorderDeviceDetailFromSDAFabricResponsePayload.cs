using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSdaFabricResponsePayload
	/// </summary>
	[DataContract]
	public class GetsBorderDeviceDetailFromSdaFabricResponsePayload
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSdaFabricResponsePayload" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceId">InstanceId.</param>
		/// <param name="AuthEntityId">AuthEntityId.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="AuthEntityClass">AuthEntityClass.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="DeployPending">DeployPending.</param>
		/// <param name="InstanceVersion">InstanceVersion.</param>
		/// <param name="CreateTime">CreateTime.</param>
		/// <param name="Deployed">Deployed.</param>
		/// <param name="IsSeeded">IsSeeded.</param>
		/// <param name="IsStale">IsStale.</param>
		/// <param name="LastUpdateTime">LastUpdateTime.</param>
		/// <param name="Name">Name.</param>
		/// <param name="_Namespace">_Namespace.</param>
		/// <param name="ProvisioningState">ProvisioningState.</param>
		/// <param name="ResourceVersion">ResourceVersion.</param>
		/// <param name="TargetIdList">TargetIdList.</param>
		/// <param name="Type">Type.</param>
		/// <param name="CfsChangeInfo">CfsChangeInfo.</param>
		/// <param name="CustomProvisions">CustomProvisions.</param>
		/// <param name="Configs">Configs.</param>
		/// <param name="ManagedSites">ManagedSites.</param>
		/// <param name="NetworkDeviceId">NetworkDeviceId.</param>
		/// <param name="Roles">Roles.</param>
		/// <param name="SaveWanConnectivityDetailsOnly">SaveWanConnectivityDetailsOnly.</param>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="AkcSettingsCfs">AkcSettingsCfs.</param>
		/// <param name="DeviceInterfaceInfo">DeviceInterfaceInfo.</param>
		/// <param name="DeviceSettings">DeviceSettings.</param>
		/// <param name="NetworkWideSettings">NetworkWideSettings.</param>
		/// <param name="OtherDevice">OtherDevice.</param>
		/// <param name="TransitNetworks">TransitNetworks.</param>
		/// <param name="VirtualNetwork">VirtualNetwork.</param>
		/// <param name="Wlan">Wlan.</param>
		public GetsBorderDeviceDetailFromSdaFabricResponsePayload(string? Id = default, int? InstanceId = default, int? AuthEntityId = default, string? DisplayName = default, int? AuthEntityClass = default, string? InstanceTenantId = default, string? DeployPending = default, int? InstanceVersion = default, int? CreateTime = default, bool? Deployed = default, bool? IsSeeded = default, bool? IsStale = default, int? LastUpdateTime = default, string? Name = default, string? _Namespace = default, string? ProvisioningState = default, int? ResourceVersion = default, List<Object> TargetIdList = default, string? Type = default, List<Object> CfsChangeInfo = default, List<Object> CustomProvisions = default, List<Object> Configs = default, List<Object> ManagedSites = default, string? NetworkDeviceId = default, List<string> Roles = default, bool? SaveWanConnectivityDetailsOnly = default, string? SiteId = default, List<Object> AkcSettingsCfs = default, List<Object> DeviceInterfaceInfo = default, GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings DeviceSettings = default, GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings NetworkWideSettings = default, List<Object> OtherDevice = default, List<EditApplicationRequestInnerApplicationSet> TransitNetworks = default, List<Object> VirtualNetwork = default, List<Object> Wlan = default)
		{
			this.Id = Id;
			this.InstanceId = InstanceId;
			this.AuthEntityId = AuthEntityId;
			this.DisplayName = DisplayName;
			this.AuthEntityClass = AuthEntityClass;
			this.InstanceTenantId = InstanceTenantId;
			this.DeployPending = DeployPending;
			this.InstanceVersion = InstanceVersion;
			this.CreateTime = CreateTime;
			this.Deployed = Deployed;
			this.IsSeeded = IsSeeded;
			this.IsStale = IsStale;
			this.LastUpdateTime = LastUpdateTime;
			this.Name = Name;
			this._Namespace = _Namespace;
			this.ProvisioningState = ProvisioningState;
			this.ResourceVersion = ResourceVersion;
			this.TargetIdList = TargetIdList;
			this.Type = Type;
			this.CfsChangeInfo = CfsChangeInfo;
			this.CustomProvisions = CustomProvisions;
			this.Configs = Configs;
			this.ManagedSites = ManagedSites;
			this.NetworkDeviceId = NetworkDeviceId;
			this.Roles = Roles;
			this.SaveWanConnectivityDetailsOnly = SaveWanConnectivityDetailsOnly;
			this.SiteId = SiteId;
			this.AkcSettingsCfs = AkcSettingsCfs;
			this.DeviceInterfaceInfo = DeviceInterfaceInfo;
			this.DeviceSettings = DeviceSettings;
			this.NetworkWideSettings = NetworkWideSettings;
			this.OtherDevice = OtherDevice;
			this.TransitNetworks = TransitNetworks;
			this.VirtualNetwork = VirtualNetwork;
			this.Wlan = Wlan;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets InstanceId
		/// </summary>
		[DataMember(Name = "instanceId", EmitDefaultValue = false)]
		public int? InstanceId { get; set; }

		/// <summary>
		/// Gets or Sets AuthEntityId
		/// </summary>
		[DataMember(Name = "authEntityId", EmitDefaultValue = false)]
		public int? AuthEntityId { get; set; }

		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string? DisplayName { get; set; }

		/// <summary>
		/// Gets or Sets AuthEntityClass
		/// </summary>
		[DataMember(Name = "authEntityClass", EmitDefaultValue = false)]
		public int? AuthEntityClass { get; set; }

		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }

		/// <summary>
		/// Gets or Sets DeployPending
		/// </summary>
		[DataMember(Name = "deployPending", EmitDefaultValue = false)]
		public string? DeployPending { get; set; }

		/// <summary>
		/// Gets or Sets InstanceVersion
		/// </summary>
		[DataMember(Name = "instanceVersion", EmitDefaultValue = false)]
		public int? InstanceVersion { get; set; }

		/// <summary>
		/// Gets or Sets CreateTime
		/// </summary>
		[DataMember(Name = "createTime", EmitDefaultValue = false)]
		public int? CreateTime { get; set; }

		/// <summary>
		/// Gets or Sets Deployed
		/// </summary>
		[DataMember(Name = "deployed", EmitDefaultValue = false)]
		public bool? Deployed { get; set; }

		/// <summary>
		/// Gets or Sets IsSeeded
		/// </summary>
		[DataMember(Name = "isSeeded", EmitDefaultValue = false)]
		public bool? IsSeeded { get; set; }

		/// <summary>
		/// Gets or Sets IsStale
		/// </summary>
		[DataMember(Name = "isStale", EmitDefaultValue = false)]
		public bool? IsStale { get; set; }

		/// <summary>
		/// Gets or Sets LastUpdateTime
		/// </summary>
		[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
		public int? LastUpdateTime { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets _Namespace
		/// </summary>
		[DataMember(Name = "namespace", EmitDefaultValue = false)]
		public string? _Namespace { get; set; }

		/// <summary>
		/// Gets or Sets ProvisioningState
		/// </summary>
		[DataMember(Name = "provisioningState", EmitDefaultValue = false)]
		public string? ProvisioningState { get; set; }

		/// <summary>
		/// Gets or Sets ResourceVersion
		/// </summary>
		[DataMember(Name = "resourceVersion", EmitDefaultValue = false)]
		public int? ResourceVersion { get; set; }

		/// <summary>
		/// Gets or Sets TargetIdList
		/// </summary>
		[DataMember(Name = "targetIdList", EmitDefaultValue = false)]
		public List<Object> TargetIdList { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets CfsChangeInfo
		/// </summary>
		[DataMember(Name = "cfsChangeInfo", EmitDefaultValue = false)]
		public List<Object> CfsChangeInfo { get; set; }

		/// <summary>
		/// Gets or Sets CustomProvisions
		/// </summary>
		[DataMember(Name = "customProvisions", EmitDefaultValue = false)]
		public List<Object> CustomProvisions { get; set; }

		/// <summary>
		/// Gets or Sets Configs
		/// </summary>
		[DataMember(Name = "configs", EmitDefaultValue = false)]
		public List<Object> Configs { get; set; }

		/// <summary>
		/// Gets or Sets ManagedSites
		/// </summary>
		[DataMember(Name = "managedSites", EmitDefaultValue = false)]
		public List<Object> ManagedSites { get; set; }

		/// <summary>
		/// Gets or Sets NetworkDeviceId
		/// </summary>
		[DataMember(Name = "networkDeviceId", EmitDefaultValue = false)]
		public string? NetworkDeviceId { get; set; }

		/// <summary>
		/// Gets or Sets Roles
		/// </summary>
		[DataMember(Name = "roles", EmitDefaultValue = false)]
		public List<string> Roles { get; set; }

		/// <summary>
		/// Gets or Sets SaveWanConnectivityDetailsOnly
		/// </summary>
		[DataMember(Name = "saveWanConnectivityDetailsOnly", EmitDefaultValue = false)]
		public bool? SaveWanConnectivityDetailsOnly { get; set; }

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }

		/// <summary>
		/// Gets or Sets AkcSettingsCfs
		/// </summary>
		[DataMember(Name = "akcSettingsCfs", EmitDefaultValue = false)]
		public List<Object> AkcSettingsCfs { get; set; }

		/// <summary>
		/// Gets or Sets DeviceInterfaceInfo
		/// </summary>
		[DataMember(Name = "deviceInterfaceInfo", EmitDefaultValue = false)]
		public List<Object> DeviceInterfaceInfo { get; set; }

		/// <summary>
		/// Gets or Sets DeviceSettings
		/// </summary>
		[DataMember(Name = "deviceSettings", EmitDefaultValue = false)]
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadDeviceSettings DeviceSettings { get; set; }

		/// <summary>
		/// Gets or Sets NetworkWideSettings
		/// </summary>
		[DataMember(Name = "networkWideSettings", EmitDefaultValue = false)]
		public GetsBorderDeviceDetailFromSdaFabricResponsePayloadNetworkWideSettings NetworkWideSettings { get; set; }

		/// <summary>
		/// Gets or Sets OtherDevice
		/// </summary>
		[DataMember(Name = "otherDevice", EmitDefaultValue = false)]
		public List<Object> OtherDevice { get; set; }

		/// <summary>
		/// Gets or Sets TransitNetworks
		/// </summary>
		[DataMember(Name = "transitNetworks", EmitDefaultValue = false)]
		public List<EditApplicationRequestInnerApplicationSet> TransitNetworks { get; set; }

		/// <summary>
		/// Gets or Sets VirtualNetwork
		/// </summary>
		[DataMember(Name = "virtualNetwork", EmitDefaultValue = false)]
		public List<Object> VirtualNetwork { get; set; }

		/// <summary>
		/// Gets or Sets Wlan
		/// </summary>
		[DataMember(Name = "wlan", EmitDefaultValue = false)]
		public List<Object> Wlan { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSdaFabricResponsePayload {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
			sb.Append("  AuthEntityId: ").Append(AuthEntityId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  AuthEntityClass: ").Append(AuthEntityClass).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  DeployPending: ").Append(DeployPending).Append("\n");
			sb.Append("  InstanceVersion: ").Append(InstanceVersion).Append("\n");
			sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
			sb.Append("  Deployed: ").Append(Deployed).Append("\n");
			sb.Append("  IsSeeded: ").Append(IsSeeded).Append("\n");
			sb.Append("  IsStale: ").Append(IsStale).Append("\n");
			sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
			sb.Append("  ProvisioningState: ").Append(ProvisioningState).Append("\n");
			sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
			sb.Append("  TargetIdList: ").Append(TargetIdList).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  CfsChangeInfo: ").Append(CfsChangeInfo).Append("\n");
			sb.Append("  CustomProvisions: ").Append(CustomProvisions).Append("\n");
			sb.Append("  Configs: ").Append(Configs).Append("\n");
			sb.Append("  ManagedSites: ").Append(ManagedSites).Append("\n");
			sb.Append("  NetworkDeviceId: ").Append(NetworkDeviceId).Append("\n");
			sb.Append("  Roles: ").Append(Roles).Append("\n");
			sb.Append("  SaveWanConnectivityDetailsOnly: ").Append(SaveWanConnectivityDetailsOnly).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  AkcSettingsCfs: ").Append(AkcSettingsCfs).Append("\n");
			sb.Append("  DeviceInterfaceInfo: ").Append(DeviceInterfaceInfo).Append("\n");
			sb.Append("  DeviceSettings: ").Append(DeviceSettings).Append("\n");
			sb.Append("  NetworkWideSettings: ").Append(NetworkWideSettings).Append("\n");
			sb.Append("  OtherDevice: ").Append(OtherDevice).Append("\n");
			sb.Append("  TransitNetworks: ").Append(TransitNetworks).Append("\n");
			sb.Append("  VirtualNetwork: ").Append(VirtualNetwork).Append("\n");
			sb.Append("  Wlan: ").Append(Wlan).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
