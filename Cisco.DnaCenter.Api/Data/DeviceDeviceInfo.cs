using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfo
	/// </summary>
	[DataContract]
	public class DeviceDeviceInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfo" /> class.
		/// </summary>
		/// <param name="Source">Source.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="Stack">Stack.</param>
		/// <param name="Mode">Mode.</param>
		/// <param name="State">State.</param>
		/// <param name="Location">Location.</param>
		/// <param name="Description">Description.</param>
		/// <param name="OnbState">OnbState.</param>
		/// <param name="AuthenticatedMicNumber">AuthenticatedMicNumber.</param>
		/// <param name="AuthenticatedSudiSerialNo">AuthenticatedSudiSerialNo.</param>
		/// <param name="CapabilitiesSupported">CapabilitiesSupported.</param>
		/// <param name="FeaturesSupported">FeaturesSupported.</param>
		/// <param name="CmState">CmState.</param>
		/// <param name="FirstContact">FirstContact.</param>
		/// <param name="LastContact">LastContact.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="Pid">Pid.</param>
		/// <param name="DeviceSudiSerialNos">DeviceSudiSerialNos.</param>
		/// <param name="LastUpdateOn">LastUpdateOn.</param>
		/// <param name="WorkflowId">WorkflowId.</param>
		/// <param name="WorkflowName">WorkflowName.</param>
		/// <param name="ProjectId">ProjectId.</param>
		/// <param name="ProjectName">ProjectName.</param>
		/// <param name="DeviceType">DeviceType.</param>
		/// <param name="AgentType">AgentType.</param>
		/// <param name="ImageVersion">ImageVersion.</param>
		/// <param name="FileSystemList">FileSystemList.</param>
		/// <param name="PnpProfileList">PnpProfileList.</param>
		/// <param name="ImageFile">ImageFile.</param>
		/// <param name="HttpHeaders">HttpHeaders.</param>
		/// <param name="NeighborLinks">NeighborLinks.</param>
		/// <param name="LastSyncTime">LastSyncTime.</param>
		/// <param name="IpInterfaces">IpInterfaces.</param>
		/// <param name="Hostname">Hostname.</param>
		/// <param name="AuthStatus">AuthStatus.</param>
		/// <param name="StackInfo">StackInfo.</param>
		/// <param name="ReloadRequested">ReloadRequested.</param>
		/// <param name="AddedOn">AddedOn.</param>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="AaaCredentials">AaaCredentials.</param>
		/// <param name="UserMicNumbers">UserMicNumbers.</param>
		/// <param name="UserSudiSerialNos">UserSudiSerialNos.</param>
		/// <param name="AddnMacAddrs">AddnMacAddrs.</param>
		/// <param name="PreWorkflowCliOuputs">PreWorkflowCliOuputs.</param>
		/// <param name="Tags">Tags.</param>
		/// <param name="SudiRequired">SudiRequired.</param>
		/// <param name="SmartAccountId">SmartAccountId.</param>
		/// <param name="VirtualAccountId">VirtualAccountId.</param>
		/// <param name="PopulateInventory">PopulateInventory.</param>
		/// <param name="SiteName">SiteName.</param>
		/// <param name="Name">Name.</param>
		public DeviceDeviceInfo(
			string? Source = default,
			string? SerialNumber = default,
			bool? Stack = default,
			string? Mode = default,
			string? State = default,
			DeviceDeviceInfoLocation Location = default,
			string? Description = default,
			string? OnbState = default,
			string? AuthenticatedMicNumber = default,
			string? AuthenticatedSudiSerialNo = default,
			List<string> CapabilitiesSupported = default,
			List<string> FeaturesSupported = default,
			string? CmState = default,
			decimal? FirstContact = default,
			decimal? LastContact = default,
			string? MacAddress = default,
			string? Pid = default,
			List<string> DeviceSudiSerialNos = default,
			long? LastupdateOn = default,
			string? WorkflowId = default,
			string? WorkflowName = default,
			string? ProjectId = default,
			string? ProjectName = default,
			string? DeviceType = default,
			string? AgentType = default,
			string? ImageVersion = default,
			List<DeviceDeviceInfoFileSystemList> FileSystemList = default,
			List<DeviceDeviceInfoPnpProfileList> PnpProfileList = default,
			string? ImageFile = default,
			List<DeviceDeviceInfoHttpHeaders> HttpHeaders = default,
			List<DeviceDeviceInfoNeighborLinks> NeighborLinks = default,
			decimal? LastSyncTime = default,
			List<DeviceDeviceInfoIpInterfaces> IpInterfaces = default,
			string? Hostname = default,
			string? AuthStatus = default,
			DeviceDeviceInfoStackInfo StackInfo = default,
			bool? ReloadRequested = default,
			long? AddedOn = default,
			string? SiteId = default,
			DeviceDeviceInfoAaaCredentials AaaCredentials = default,
			List<string> UserMicNumbers = default,
			List<string> UserSudiSerialNos = default,
			List<string> AddnMacAddrs = default,
			List<DeviceDeviceInfoPreWorkflowCliOuputs> PreWorkflowCliOuputs = default,
			List<TagDto>? Tags = default,
			bool? SudiRequired = default,
			string? SmartAccountId = default,
			string? VirtualAccountId = default,
			bool? PopulateInventory = default,
			string? SiteName = default,
			string? Name = default)
		{
			this.Source = Source;
			this.SerialNumber = SerialNumber;
			this.Stack = Stack;
			this.Mode = Mode;
			this.State = State;
			this.Location = Location;
			this.Description = Description;
			this.OnbState = OnbState;
			this.AuthenticatedMicNumber = AuthenticatedMicNumber;
			this.AuthenticatedSudiSerialNo = AuthenticatedSudiSerialNo;
			this.CapabilitiesSupported = CapabilitiesSupported;
			this.FeaturesSupported = FeaturesSupported;
			this.CmState = CmState;
			this.FirstContact = FirstContact;
			this.LastContact = LastContact;
			this.MacAddress = MacAddress;
			this.Pid = Pid;
			this.DeviceSudiSerialNos = DeviceSudiSerialNos;
			this.LastUpdateOn = LastUpdateOn;
			this.WorkflowId = WorkflowId;
			this.WorkflowName = WorkflowName;
			this.ProjectId = ProjectId;
			this.ProjectName = ProjectName;
			this.DeviceType = DeviceType;
			this.AgentType = AgentType;
			this.ImageVersion = ImageVersion;
			this.FileSystemList = FileSystemList;
			this.PnpProfileList = PnpProfileList;
			this.ImageFile = ImageFile;
			this.HttpHeaders = HttpHeaders;
			this.NeighborLinks = NeighborLinks;
			this.LastSyncTime = LastSyncTime;
			this.IpInterfaces = IpInterfaces;
			this.Hostname = Hostname;
			this.AuthStatus = AuthStatus;
			this.StackInfo = StackInfo;
			this.ReloadRequested = ReloadRequested;
			this.AddedOn = AddedOn;
			this.SiteId = SiteId;
			this.AaaCredentials = AaaCredentials;
			this.UserMicNumbers = UserMicNumbers;
			this.UserSudiSerialNos = UserSudiSerialNos;
			this.AddnMacAddrs = AddnMacAddrs;
			this.PreWorkflowCliOuputs = PreWorkflowCliOuputs;
			this.Tags = Tags;
			this.SudiRequired = SudiRequired;
			this.SmartAccountId = SmartAccountId;
			this.VirtualAccountId = VirtualAccountId;
			this.PopulateInventory = PopulateInventory;
			this.SiteName = SiteName;
			this.Name = Name;
		}

		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string? Source { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
		public string? SerialNumber { get; set; }

		/// <summary>
		/// Gets or Sets Stack
		/// </summary>
		[DataMember(Name = "stack", EmitDefaultValue = false)]
		public bool? Stack { get; set; }

		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public string? Mode { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }

		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public DeviceDeviceInfoLocation Location { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or Sets OnbState
		/// </summary>
		[DataMember(Name = "onbState", EmitDefaultValue = false)]
		public string? OnbState { get; set; }

		/// <summary>
		/// Gets or Sets AuthenticatedMicNumber
		/// </summary>
		[DataMember(Name = "authenticatedMicNumber", EmitDefaultValue = false)]
		public string? AuthenticatedMicNumber { get; set; }

		/// <summary>
		/// Gets or Sets AuthenticatedSudiSerialNo
		/// </summary>
		[DataMember(Name = "authenticatedSudiSerialNo", EmitDefaultValue = false)]
		public string? AuthenticatedSudiSerialNo { get; set; }

		/// <summary>
		/// Gets or Sets CapabilitiesSupported
		/// </summary>
		[DataMember(Name = "capabilitiesSupported", EmitDefaultValue = false)]
		public List<string> CapabilitiesSupported { get; set; }

		/// <summary>
		/// Gets or Sets FeaturesSupported
		/// </summary>
		[DataMember(Name = "featuresSupported", EmitDefaultValue = false)]
		public List<string> FeaturesSupported { get; set; }

		/// <summary>
		/// Gets or Sets CmState
		/// </summary>
		[DataMember(Name = "cmState", EmitDefaultValue = false)]
		public string? CmState { get; set; }

		/// <summary>
		/// Gets or Sets FirstContact
		/// </summary>
		[DataMember(Name = "firstContact", EmitDefaultValue = false)]
		public decimal? FirstContact { get; set; }

		/// <summary>
		/// Gets or Sets LastContact
		/// </summary>
		[DataMember(Name = "lastContact", EmitDefaultValue = false)]
		public decimal? LastContact { get; set; }

		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }

		/// <summary>
		/// Gets or Sets Pid
		/// </summary>
		[DataMember(Name = "pid", EmitDefaultValue = false)]
		public string? Pid { get; set; }

		/// <summary>
		/// Gets or Sets DeviceSudiSerialNos
		/// </summary>
		[DataMember(Name = "deviceSudiSerialNos", EmitDefaultValue = false)]
		public List<string> DeviceSudiSerialNos { get; set; }

		/// <summary>
		/// Gets or Sets LastUpdateOn
		/// </summary>
		[DataMember(Name = "lastUpdateOn", EmitDefaultValue = false)]
		public long? LastupdateOn { get; set; }

		/// <summary>
		/// Gets or Sets WorkflowId
		/// </summary>
		[DataMember(Name = "workflowId", EmitDefaultValue = false)]
		public string? WorkflowId { get; set; }

		/// <summary>
		/// Gets or Sets WorkflowName
		/// </summary>
		[DataMember(Name = "workflowName", EmitDefaultValue = false)]
		public string? WorkflowName { get; set; }

		/// <summary>
		/// Gets or Sets ProjectId
		/// </summary>
		[DataMember(Name = "projectId", EmitDefaultValue = false)]
		public string? ProjectId { get; set; }

		/// <summary>
		/// Gets or Sets ProjectName
		/// </summary>
		[DataMember(Name = "projectName", EmitDefaultValue = false)]
		public string? ProjectName { get; set; }

		/// <summary>
		/// Gets or Sets DeviceType
		/// </summary>
		[DataMember(Name = "deviceType", EmitDefaultValue = false)]
		public string? DeviceType { get; set; }

		/// <summary>
		/// Gets or Sets AgentType
		/// </summary>
		[DataMember(Name = "agentType", EmitDefaultValue = false)]
		public string? AgentType { get; set; }

		/// <summary>
		/// Gets or Sets ImageVersion
		/// </summary>
		[DataMember(Name = "imageVersion", EmitDefaultValue = false)]
		public string? ImageVersion { get; set; }

		/// <summary>
		/// Gets or Sets FileSystemList
		/// </summary>
		[DataMember(Name = "fileSystemList", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoFileSystemList> FileSystemList { get; set; }

		/// <summary>
		/// Gets or Sets PnpProfileList
		/// </summary>
		[DataMember(Name = "pnpProfileList", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoPnpProfileList> PnpProfileList { get; set; }

		/// <summary>
		/// Gets or Sets ImageFile
		/// </summary>
		[DataMember(Name = "imageFile", EmitDefaultValue = false)]
		public string? ImageFile { get; set; }

		/// <summary>
		/// Gets or Sets HttpHeaders
		/// </summary>
		[DataMember(Name = "httpHeaders", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoHttpHeaders> HttpHeaders { get; set; }

		/// <summary>
		/// Gets or Sets NeighborLinks
		/// </summary>
		[DataMember(Name = "neighborLinks", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoNeighborLinks> NeighborLinks { get; set; }

		/// <summary>
		/// Gets or Sets LastSyncTime
		/// </summary>
		[DataMember(Name = "lastSyncTime", EmitDefaultValue = false)]
		public decimal? LastSyncTime { get; set; }

		/// <summary>
		/// Gets or Sets IpInterfaces
		/// </summary>
		[DataMember(Name = "ipInterfaces", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoIpInterfaces> IpInterfaces { get; set; }

		/// <summary>
		/// Gets or Sets Hostname
		/// </summary>
		[DataMember(Name = "hostname", EmitDefaultValue = false)]
		public string? Hostname { get; set; }

		/// <summary>
		/// Gets or Sets AuthStatus
		/// </summary>
		[DataMember(Name = "authStatus", EmitDefaultValue = false)]
		public string? AuthStatus { get; set; }

		/// <summary>
		/// Gets or Sets StackInfo
		/// </summary>
		[DataMember(Name = "stackInfo", EmitDefaultValue = false)]
		public DeviceDeviceInfoStackInfo StackInfo { get; set; }

		/// <summary>
		/// Gets or Sets ReloadRequested
		/// </summary>
		[DataMember(Name = "reloadRequested", EmitDefaultValue = false)]
		public bool? ReloadRequested { get; set; }

		/// <summary>
		/// Gets or Sets AddedOn
		/// </summary>
		[DataMember(Name = "addedOn", EmitDefaultValue = false)]
		public long? AddedOn { get; set; }

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }

		/// <summary>
		/// Gets or Sets AaaCredentials
		/// </summary>
		[DataMember(Name = "aaaCredentials", EmitDefaultValue = false)]
		public DeviceDeviceInfoAaaCredentials AaaCredentials { get; set; }

		/// <summary>
		/// Gets or Sets UserMicNumbers
		/// </summary>
		[DataMember(Name = "userMicNumbers", EmitDefaultValue = false)]
		public List<string> UserMicNumbers { get; set; }

		/// <summary>
		/// Gets or Sets UserSudiSerialNos
		/// </summary>
		[DataMember(Name = "userSudiSerialNos", EmitDefaultValue = false)]
		public List<string> UserSudiSerialNos { get; set; }

		/// <summary>
		/// Gets or Sets AddnMacAddrs
		/// </summary>
		[DataMember(Name = "addnMacAddrs", EmitDefaultValue = false)]
		public List<string> AddnMacAddrs { get; set; }

		/// <summary>
		/// Gets or Sets PreWorkflowCliOuputs
		/// </summary>
		[DataMember(Name = "preWorkflowCliOuputs", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoPreWorkflowCliOuputs> PreWorkflowCliOuputs { get; set; }

		/// <summary>
		/// Gets or Sets Tags
		/// </summary>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<TagDto>? Tags { get; set; }

		/// <summary>
		/// Gets or Sets SudiRequired
		/// </summary>
		[DataMember(Name = "sudiRequired", EmitDefaultValue = false)]
		public bool? SudiRequired { get; set; }

		/// <summary>
		/// Gets or Sets SmartAccountId
		/// </summary>
		[DataMember(Name = "smartAccountId", EmitDefaultValue = false)]
		public string? SmartAccountId { get; set; }

		/// <summary>
		/// Gets or Sets VirtualAccountId
		/// </summary>
		[DataMember(Name = "virtualAccountId", EmitDefaultValue = false)]
		public string? VirtualAccountId { get; set; }

		/// <summary>
		/// Gets or Sets PopulateInventory
		/// </summary>
		[DataMember(Name = "populateInventory", EmitDefaultValue = false)]
		public bool? PopulateInventory { get; set; }

		/// <summary>
		/// Gets or Sets SiteName
		/// </summary>
		[DataMember(Name = "siteName", EmitDefaultValue = false)]
		public string? SiteName { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfo {\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
			sb.Append("  Stack: ").Append(Stack).Append("\n");
			sb.Append("  Mode: ").Append(Mode).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  OnbState: ").Append(OnbState).Append("\n");
			sb.Append("  AuthenticatedMicNumber: ").Append(AuthenticatedMicNumber).Append("\n");
			sb.Append("  AuthenticatedSudiSerialNo: ").Append(AuthenticatedSudiSerialNo).Append("\n");
			sb.Append("  CapabilitiesSupported: ").Append(CapabilitiesSupported).Append("\n");
			sb.Append("  FeaturesSupported: ").Append(FeaturesSupported).Append("\n");
			sb.Append("  CmState: ").Append(CmState).Append("\n");
			sb.Append("  FirstContact: ").Append(FirstContact).Append("\n");
			sb.Append("  LastContact: ").Append(LastContact).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  Pid: ").Append(Pid).Append("\n");
			sb.Append("  DeviceSudiSerialNos: ").Append(DeviceSudiSerialNos).Append("\n");
			sb.Append("  LastUpdateOn: ").Append(LastUpdateOn).Append("\n");
			sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
			sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
			sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
			sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
			sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
			sb.Append("  AgentType: ").Append(AgentType).Append("\n");
			sb.Append("  ImageVersion: ").Append(ImageVersion).Append("\n");
			sb.Append("  FileSystemList: ").Append(FileSystemList).Append("\n");
			sb.Append("  PnpProfileList: ").Append(PnpProfileList).Append("\n");
			sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
			sb.Append("  HttpHeaders: ").Append(HttpHeaders).Append("\n");
			sb.Append("  NeighborLinks: ").Append(NeighborLinks).Append("\n");
			sb.Append("  LastSyncTime: ").Append(LastSyncTime).Append("\n");
			sb.Append("  IpInterfaces: ").Append(IpInterfaces).Append("\n");
			sb.Append("  Hostname: ").Append(Hostname).Append("\n");
			sb.Append("  AuthStatus: ").Append(AuthStatus).Append("\n");
			sb.Append("  StackInfo: ").Append(StackInfo).Append("\n");
			sb.Append("  ReloadRequested: ").Append(ReloadRequested).Append("\n");
			sb.Append("  AddedOn: ").Append(AddedOn).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  AaaCredentials: ").Append(AaaCredentials).Append("\n");
			sb.Append("  UserMicNumbers: ").Append(UserMicNumbers).Append("\n");
			sb.Append("  UserSudiSerialNos: ").Append(UserSudiSerialNos).Append("\n");
			sb.Append("  AddnMacAddrs: ").Append(AddnMacAddrs).Append("\n");
			sb.Append("  PreWorkflowCliOuputs: ").Append(PreWorkflowCliOuputs).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
			sb.Append("  SudiRequired: ").Append(SudiRequired).Append("\n");
			sb.Append("  SmartAccountId: ").Append(SmartAccountId).Append("\n");
			sb.Append("  VirtualAccountId: ").Append(VirtualAccountId).Append("\n");
			sb.Append("  PopulateInventory: ").Append(PopulateInventory).Append("\n");
			sb.Append("  SiteName: ").Append(SiteName).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
