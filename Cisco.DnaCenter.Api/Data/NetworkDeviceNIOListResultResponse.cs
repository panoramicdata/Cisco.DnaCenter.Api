using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// NetworkDeviceNioListResultResponse
/// </summary>
[DataContract]
public class NetworkDeviceNioListResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkDeviceNioListResultResponse" /> class.
	/// </summary>
	/// <param name="AnchorWlcForAp">AnchorWlcForAp.</param>
	/// <param name="AuthModelId">AuthModelId.</param>
	/// <param name="AvgUpdateFrequency">AvgUpdateFrequency.</param>
	/// <param name="BootDateTime">BootDateTime.</param>
	/// <param name="CliStatus">CliStatus.</param>
	/// <param name="DuplicateDeviceId">DuplicateDeviceId.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorDescription">ErrorDescription.</param>
	/// <param name="Family">Family.</param>
	/// <param name="Hostname">Hostname.</param>
	/// <param name="HttpStatus">HttpStatus.</param>
	/// <param name="Id">Id.</param>
	/// <param name="ImageName">ImageName.</param>
	/// <param name="IngressQueueConfig">IngressQueueConfig.</param>
	/// <param name="InterfaceCount">InterfaceCount.</param>
	/// <param name="InventoryCollectionStatus">InventoryCollectionStatus.</param>
	/// <param name="InventoryReachabilityStatus">InventoryReachabilityStatus.</param>
	/// <param name="LastUpdated">LastUpdated.</param>
	/// <param name="LineCardCount">LineCardCount.</param>
	/// <param name="LineCardId">LineCardId.</param>
	/// <param name="Location">Location.</param>
	/// <param name="LocationName">LocationName.</param>
	/// <param name="MacAddress">MacAddress.</param>
	/// <param name="ManagementIpAddress">ManagementIpAddress.</param>
	/// <param name="MemorySize">MemorySize.</param>
	/// <param name="NetconfStatus">NetconfStatus.</param>
	/// <param name="NumUpdates">NumUpdates.</param>
	/// <param name="PingStatus">PingStatus.</param>
	/// <param name="PlatformId">PlatformId.</param>
	/// <param name="PortRange">PortRange.</param>
	/// <param name="QosStatus">QosStatus.</param>
	/// <param name="ReachabilityFailureReason">ReachabilityFailureReason.</param>
	/// <param name="ReachabilityStatus">ReachabilityStatus.</param>
	/// <param name="Role">Role.</param>
	/// <param name="RoleSource">RoleSource.</param>
	/// <param name="SerialNumber">SerialNumber.</param>
	/// <param name="SnmpContact">SnmpContact.</param>
	/// <param name="SnmpLocation">SnmpLocation.</param>
	/// <param name="SnmpStatus">SnmpStatus.</param>
	/// <param name="SoftwareVersion">SoftwareVersion.</param>
	/// <param name="Tag">Tag.</param>
	/// <param name="TagCount">TagCount.</param>
	/// <param name="Type">Type.</param>
	/// <param name="UpTime">UpTime.</param>
	/// <param name="Vendor">Vendor.</param>
	/// <param name="WlcApDeviceStatus">WlcApDeviceStatus.</param>
	public NetworkDeviceNioListResultResponse(string? AnchorWlcForAp = default, string? AuthModelId = default, int? AvgUpdateFrequency = default, string? BootDateTime = default, string? CliStatus = default, string? DuplicateDeviceId = default, string? ErrorCode = default, string? ErrorDescription = default, string? Family = default, string? Hostname = default, string? HttpStatus = default, string? Id = default, string? ImageName = default, string? IngressQueueConfig = default, string? InterfaceCount = default, string? InventoryCollectionStatus = default, string? InventoryReachabilityStatus = default, string? LastUpdated = default, string? LineCardCount = default, string? LineCardId = default, string? Location = default, string? LocationName = default, string? MacAddress = default, string? ManagementIpAddress = default, string? MemorySize = default, string? NetconfStatus = default, int? NumUpdates = default, string? PingStatus = default, string? PlatformId = default, string? PortRange = default, string? QosStatus = default, string? ReachabilityFailureReason = default, string? ReachabilityStatus = default, string? Role = default, string? RoleSource = default, string? SerialNumber = default, string? SnmpContact = default, string? SnmpLocation = default, string? SnmpStatus = default, string? SoftwareVersion = default, string? Tag = default, int? TagCount = default, string? Type = default, string? UpTime = default, string? Vendor = default, string? WlcApDeviceStatus = default)
	{
		this.AnchorWlcForAp = AnchorWlcForAp;
		this.AuthModelId = AuthModelId;
		this.AvgUpdateFrequency = AvgUpdateFrequency;
		this.BootDateTime = BootDateTime;
		this.CliStatus = CliStatus;
		this.DuplicateDeviceId = DuplicateDeviceId;
		this.ErrorCode = ErrorCode;
		this.ErrorDescription = ErrorDescription;
		this.Family = Family;
		this.Hostname = Hostname;
		this.HttpStatus = HttpStatus;
		this.Id = Id;
		this.ImageName = ImageName;
		this.IngressQueueConfig = IngressQueueConfig;
		this.InterfaceCount = InterfaceCount;
		this.InventoryCollectionStatus = InventoryCollectionStatus;
		this.InventoryReachabilityStatus = InventoryReachabilityStatus;
		this.LastUpdated = LastUpdated;
		this.LineCardCount = LineCardCount;
		this.LineCardId = LineCardId;
		this.Location = Location;
		this.LocationName = LocationName;
		this.MacAddress = MacAddress;
		this.ManagementIpAddress = ManagementIpAddress;
		this.MemorySize = MemorySize;
		this.NetconfStatus = NetconfStatus;
		this.NumUpdates = NumUpdates;
		this.PingStatus = PingStatus;
		this.PlatformId = PlatformId;
		this.PortRange = PortRange;
		this.QosStatus = QosStatus;
		this.ReachabilityFailureReason = ReachabilityFailureReason;
		this.ReachabilityStatus = ReachabilityStatus;
		this.Role = Role;
		this.RoleSource = RoleSource;
		this.SerialNumber = SerialNumber;
		this.SnmpContact = SnmpContact;
		this.SnmpLocation = SnmpLocation;
		this.SnmpStatus = SnmpStatus;
		this.SoftwareVersion = SoftwareVersion;
		this.Tag = Tag;
		this.TagCount = TagCount;
		this.Type = Type;
		this.UpTime = UpTime;
		this.Vendor = Vendor;
		this.WlcApDeviceStatus = WlcApDeviceStatus;
	}

	/// <summary>
	/// Gets or Sets AnchorWlcForAp
	/// </summary>
	[DataMember(Name = "anchorWlcForAp", EmitDefaultValue = false)]
	public string? AnchorWlcForAp { get; set; }

	/// <summary>
	/// Gets or Sets AuthModelId
	/// </summary>
	[DataMember(Name = "authModelId", EmitDefaultValue = false)]
	public string? AuthModelId { get; set; }

	/// <summary>
	/// Gets or Sets AvgUpdateFrequency
	/// </summary>
	[DataMember(Name = "avgUpdateFrequency", EmitDefaultValue = false)]
	public int? AvgUpdateFrequency { get; set; }

	/// <summary>
	/// Gets or Sets BootDateTime
	/// </summary>
	[DataMember(Name = "bootDateTime", EmitDefaultValue = false)]
	public string? BootDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CliStatus
	/// </summary>
	[DataMember(Name = "cliStatus", EmitDefaultValue = false)]
	public string? CliStatus { get; set; }

	/// <summary>
	/// Gets or Sets DuplicateDeviceId
	/// </summary>
	[DataMember(Name = "duplicateDeviceId", EmitDefaultValue = false)]
	public string? DuplicateDeviceId { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string? ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorDescription
	/// </summary>
	[DataMember(Name = "errorDescription", EmitDefaultValue = false)]
	public string? ErrorDescription { get; set; }

	/// <summary>
	/// Gets or Sets Family
	/// </summary>
	[DataMember(Name = "family", EmitDefaultValue = false)]
	public string? Family { get; set; }

	/// <summary>
	/// Gets or Sets Hostname
	/// </summary>
	[DataMember(Name = "hostname", EmitDefaultValue = false)]
	public string? Hostname { get; set; }

	/// <summary>
	/// Gets or Sets HttpStatus
	/// </summary>
	[DataMember(Name = "httpStatus", EmitDefaultValue = false)]
	public string? HttpStatus { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets ImageName
	/// </summary>
	[DataMember(Name = "imageName", EmitDefaultValue = false)]
	public string? ImageName { get; set; }

	/// <summary>
	/// Gets or Sets IngressQueueConfig
	/// </summary>
	[DataMember(Name = "ingressQueueConfig", EmitDefaultValue = false)]
	public string? IngressQueueConfig { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceCount
	/// </summary>
	[DataMember(Name = "interfaceCount", EmitDefaultValue = false)]
	public string? InterfaceCount { get; set; }

	/// <summary>
	/// Gets or Sets InventoryCollectionStatus
	/// </summary>
	[DataMember(Name = "inventoryCollectionStatus", EmitDefaultValue = false)]
	public string? InventoryCollectionStatus { get; set; }

	/// <summary>
	/// Gets or Sets InventoryReachabilityStatus
	/// </summary>
	[DataMember(Name = "inventoryReachabilityStatus", EmitDefaultValue = false)]
	public string? InventoryReachabilityStatus { get; set; }

	/// <summary>
	/// Gets or Sets LastUpdated
	/// </summary>
	[DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
	public string? LastUpdated { get; set; }

	/// <summary>
	/// Gets or Sets LineCardCount
	/// </summary>
	[DataMember(Name = "lineCardCount", EmitDefaultValue = false)]
	public string? LineCardCount { get; set; }

	/// <summary>
	/// Gets or Sets LineCardId
	/// </summary>
	[DataMember(Name = "lineCardId", EmitDefaultValue = false)]
	public string? LineCardId { get; set; }

	/// <summary>
	/// Gets or Sets Location
	/// </summary>
	[DataMember(Name = "location", EmitDefaultValue = false)]
	public string? Location { get; set; }

	/// <summary>
	/// Gets or Sets LocationName
	/// </summary>
	[DataMember(Name = "locationName", EmitDefaultValue = false)]
	public string? LocationName { get; set; }

	/// <summary>
	/// Gets or Sets MacAddress
	/// </summary>
	[DataMember(Name = "macAddress", EmitDefaultValue = false)]
	public string? MacAddress { get; set; }

	/// <summary>
	/// Gets or Sets ManagementIpAddress
	/// </summary>
	[DataMember(Name = "managementIpAddress", EmitDefaultValue = false)]
	public string? ManagementIpAddress { get; set; }

	/// <summary>
	/// Gets or Sets MemorySize
	/// </summary>
	[DataMember(Name = "memorySize", EmitDefaultValue = false)]
	public string? MemorySize { get; set; }

	/// <summary>
	/// Gets or Sets NetconfStatus
	/// </summary>
	[DataMember(Name = "netconfStatus", EmitDefaultValue = false)]
	public string? NetconfStatus { get; set; }

	/// <summary>
	/// Gets or Sets NumUpdates
	/// </summary>
	[DataMember(Name = "numUpdates", EmitDefaultValue = false)]
	public int? NumUpdates { get; set; }

	/// <summary>
	/// Gets or Sets PingStatus
	/// </summary>
	[DataMember(Name = "pingStatus", EmitDefaultValue = false)]
	public string? PingStatus { get; set; }

	/// <summary>
	/// Gets or Sets PlatformId
	/// </summary>
	[DataMember(Name = "platformId", EmitDefaultValue = false)]
	public string? PlatformId { get; set; }

	/// <summary>
	/// Gets or Sets PortRange
	/// </summary>
	[DataMember(Name = "portRange", EmitDefaultValue = false)]
	public string? PortRange { get; set; }

	/// <summary>
	/// Gets or Sets QosStatus
	/// </summary>
	[DataMember(Name = "qosStatus", EmitDefaultValue = false)]
	public string? QosStatus { get; set; }

	/// <summary>
	/// Gets or Sets ReachabilityFailureReason
	/// </summary>
	[DataMember(Name = "reachabilityFailureReason", EmitDefaultValue = false)]
	public string? ReachabilityFailureReason { get; set; }

	/// <summary>
	/// Gets or Sets ReachabilityStatus
	/// </summary>
	[DataMember(Name = "reachabilityStatus", EmitDefaultValue = false)]
	public string? ReachabilityStatus { get; set; }

	/// <summary>
	/// Gets or Sets Role
	/// </summary>
	[DataMember(Name = "role", EmitDefaultValue = false)]
	public string? Role { get; set; }

	/// <summary>
	/// Gets or Sets RoleSource
	/// </summary>
	[DataMember(Name = "roleSource", EmitDefaultValue = false)]
	public string? RoleSource { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Gets or Sets SnmpContact
	/// </summary>
	[DataMember(Name = "snmpContact", EmitDefaultValue = false)]
	public string? SnmpContact { get; set; }

	/// <summary>
	/// Gets or Sets SnmpLocation
	/// </summary>
	[DataMember(Name = "snmpLocation", EmitDefaultValue = false)]
	public string? SnmpLocation { get; set; }

	/// <summary>
	/// Gets or Sets SnmpStatus
	/// </summary>
	[DataMember(Name = "snmpStatus", EmitDefaultValue = false)]
	public string? SnmpStatus { get; set; }

	/// <summary>
	/// Gets or Sets SoftwareVersion
	/// </summary>
	[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
	public string? SoftwareVersion { get; set; }

	/// <summary>
	/// Gets or Sets Tag
	/// </summary>
	[DataMember(Name = "tag", EmitDefaultValue = false)]
	public string? Tag { get; set; }

	/// <summary>
	/// Gets or Sets TagCount
	/// </summary>
	[DataMember(Name = "tagCount", EmitDefaultValue = false)]
	public int? TagCount { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string? Type { get; set; }

	/// <summary>
	/// Gets or Sets UpTime
	/// </summary>
	[DataMember(Name = "upTime", EmitDefaultValue = false)]
	public string? UpTime { get; set; }

	/// <summary>
	/// Gets or Sets Vendor
	/// </summary>
	[DataMember(Name = "vendor", EmitDefaultValue = false)]
	public string? Vendor { get; set; }

	/// <summary>
	/// Gets or Sets WlcApDeviceStatus
	/// </summary>
	[DataMember(Name = "wlcApDeviceStatus", EmitDefaultValue = false)]
	public string? WlcApDeviceStatus { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class NetworkDeviceNioListResultResponse {\n");
		sb.Append("  AnchorWlcForAp: ").Append(AnchorWlcForAp).Append("\n");
		sb.Append("  AuthModelId: ").Append(AuthModelId).Append("\n");
		sb.Append("  AvgUpdateFrequency: ").Append(AvgUpdateFrequency).Append("\n");
		sb.Append("  BootDateTime: ").Append(BootDateTime).Append("\n");
		sb.Append("  CliStatus: ").Append(CliStatus).Append("\n");
		sb.Append("  DuplicateDeviceId: ").Append(DuplicateDeviceId).Append("\n");
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
		sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
		sb.Append("  Family: ").Append(Family).Append("\n");
		sb.Append("  Hostname: ").Append(Hostname).Append("\n");
		sb.Append("  HttpStatus: ").Append(HttpStatus).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  ImageName: ").Append(ImageName).Append("\n");
		sb.Append("  IngressQueueConfig: ").Append(IngressQueueConfig).Append("\n");
		sb.Append("  InterfaceCount: ").Append(InterfaceCount).Append("\n");
		sb.Append("  InventoryCollectionStatus: ").Append(InventoryCollectionStatus).Append("\n");
		sb.Append("  InventoryReachabilityStatus: ").Append(InventoryReachabilityStatus).Append("\n");
		sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
		sb.Append("  LineCardCount: ").Append(LineCardCount).Append("\n");
		sb.Append("  LineCardId: ").Append(LineCardId).Append("\n");
		sb.Append("  Location: ").Append(Location).Append("\n");
		sb.Append("  LocationName: ").Append(LocationName).Append("\n");
		sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
		sb.Append("  ManagementIpAddress: ").Append(ManagementIpAddress).Append("\n");
		sb.Append("  MemorySize: ").Append(MemorySize).Append("\n");
		sb.Append("  NetconfStatus: ").Append(NetconfStatus).Append("\n");
		sb.Append("  NumUpdates: ").Append(NumUpdates).Append("\n");
		sb.Append("  PingStatus: ").Append(PingStatus).Append("\n");
		sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
		sb.Append("  PortRange: ").Append(PortRange).Append("\n");
		sb.Append("  QosStatus: ").Append(QosStatus).Append("\n");
		sb.Append("  ReachabilityFailureReason: ").Append(ReachabilityFailureReason).Append("\n");
		sb.Append("  ReachabilityStatus: ").Append(ReachabilityStatus).Append("\n");
		sb.Append("  Role: ").Append(Role).Append("\n");
		sb.Append("  RoleSource: ").Append(RoleSource).Append("\n");
		sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
		sb.Append("  SnmpContact: ").Append(SnmpContact).Append("\n");
		sb.Append("  SnmpLocation: ").Append(SnmpLocation).Append("\n");
		sb.Append("  SnmpStatus: ").Append(SnmpStatus).Append("\n");
		sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
		sb.Append("  Tag: ").Append(Tag).Append("\n");
		sb.Append("  TagCount: ").Append(TagCount).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("  UpTime: ").Append(UpTime).Append("\n");
		sb.Append("  Vendor: ").Append(Vendor).Append("\n");
		sb.Append("  WlcApDeviceStatus: ").Append(WlcApDeviceStatus).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
