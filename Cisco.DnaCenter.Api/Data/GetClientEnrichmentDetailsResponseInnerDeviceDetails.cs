using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetClientEnrichmentDetailsResponseInnerDeviceDetails
/// </summary>
[DataContract]
public class GetClientEnrichmentDetailsResponseInnerDeviceDetails
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerDeviceDetails" /> class.
	/// </summary>
	/// <param name="Family">Family.</param>
	/// <param name="Type">Type.</param>
	/// <param name="Location">Location.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="MacAddress">MacAddress.</param>
	/// <param name="Role">Role.</param>
	/// <param name="ApManagerInterfaceIp">ApManagerInterfaceIp.</param>
	/// <param name="AssociatedWlcIp">AssociatedWlcIp.</param>
	/// <param name="BootDateTime">BootDateTime.</param>
	/// <param name="CollectionStatus">CollectionStatus.</param>
	/// <param name="InterfaceCount">InterfaceCount.</param>
	/// <param name="LineCardCount">LineCardCount.</param>
	/// <param name="LineCardId">LineCardId.</param>
	/// <param name="ManagementIpAddress">ManagementIpAddress.</param>
	/// <param name="MemorySize">MemorySize.</param>
	/// <param name="PlatformId">PlatformId.</param>
	/// <param name="ReachabilityFailureReason">ReachabilityFailureReason.</param>
	/// <param name="ReachabilityStatus">ReachabilityStatus.</param>
	/// <param name="SnmpContact">SnmpContact.</param>
	/// <param name="SnmpLocation">SnmpLocation.</param>
	/// <param name="TunnelUdpPort">TunnelUdpPort.</param>
	/// <param name="WaasDeviceMode">WaasDeviceMode.</param>
	/// <param name="Series">Series.</param>
	/// <param name="InventoryStatusDetail">InventoryStatusDetail.</param>
	/// <param name="CollectionInterval">CollectionInterval.</param>
	/// <param name="SerialNumber">SerialNumber.</param>
	/// <param name="SoftwareVersion">SoftwareVersion.</param>
	/// <param name="RoleSource">RoleSource.</param>
	/// <param name="Hostname">Hostname.</param>
	/// <param name="UpTime">UpTime.</param>
	/// <param name="LastUpdateTime">LastUpdateTime.</param>
	/// <param name="ErrorDescription">ErrorDescription.</param>
	/// <param name="LocationName">LocationName.</param>
	/// <param name="TagCount">TagCount.</param>
	/// <param name="LastUpdated">LastUpdated.</param>
	/// <param name="InstanceUuid">InstanceUuid.</param>
	/// <param name="Id">Id.</param>
	/// <param name="NeighborTopology">NeighborTopology.</param>
	/// <param name="Cisco360view">Cisco360view.</param>
	public GetClientEnrichmentDetailsResponseInnerDeviceDetails(string? Family = default, string? Type = default, Object Location = default, string? ErrorCode = default, string? MacAddress = default, string? Role = default, string? ApManagerInterfaceIp = default, string? AssociatedWlcIp = default, Object BootDateTime = default, string? CollectionStatus = default, Object InterfaceCount = default, Object LineCardCount = default, Object LineCardId = default, string? ManagementIpAddress = default, string? MemorySize = default, string? PlatformId = default, string? ReachabilityFailureReason = default, string? ReachabilityStatus = default, string? SnmpContact = default, string? SnmpLocation = default, string? TunnelUdpPort = default, Object WaasDeviceMode = default, string? Series = default, string? InventoryStatusDetail = default, string? CollectionInterval = default, string? SerialNumber = default, string? SoftwareVersion = default, string? RoleSource = default, string? Hostname = default, string? UpTime = default, long? LastUpdateTime = default, Object ErrorDescription = default, Object LocationName = default, string? TagCount = default, string? LastUpdated = default, string? InstanceUuid = default, string? Id = default, List<GetClientEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology> NeighborTopology = default, string? Cisco360view = default)
	{
		this.Family = Family;
		this.Type = Type;
		this.Location = Location;
		this.ErrorCode = ErrorCode;
		this.MacAddress = MacAddress;
		this.Role = Role;
		this.ApManagerInterfaceIp = ApManagerInterfaceIp;
		this.AssociatedWlcIp = AssociatedWlcIp;
		this.BootDateTime = BootDateTime;
		this.CollectionStatus = CollectionStatus;
		this.InterfaceCount = InterfaceCount;
		this.LineCardCount = LineCardCount;
		this.LineCardId = LineCardId;
		this.ManagementIpAddress = ManagementIpAddress;
		this.MemorySize = MemorySize;
		this.PlatformId = PlatformId;
		this.ReachabilityFailureReason = ReachabilityFailureReason;
		this.ReachabilityStatus = ReachabilityStatus;
		this.SnmpContact = SnmpContact;
		this.SnmpLocation = SnmpLocation;
		this.TunnelUdpPort = TunnelUdpPort;
		this.WaasDeviceMode = WaasDeviceMode;
		this.Series = Series;
		this.InventoryStatusDetail = InventoryStatusDetail;
		this.CollectionInterval = CollectionInterval;
		this.SerialNumber = SerialNumber;
		this.SoftwareVersion = SoftwareVersion;
		this.RoleSource = RoleSource;
		this.Hostname = Hostname;
		this.UpTime = UpTime;
		this.LastUpdateTime = LastUpdateTime;
		this.ErrorDescription = ErrorDescription;
		this.LocationName = LocationName;
		this.TagCount = TagCount;
		this.LastUpdated = LastUpdated;
		this.InstanceUuid = InstanceUuid;
		this.Id = Id;
		this.NeighborTopology = NeighborTopology;
		this.Cisco360view = Cisco360view;
	}

	/// <summary>
	/// Gets or Sets Family
	/// </summary>
	[DataMember(Name = "family", EmitDefaultValue = false)]
	public string? Family { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string? Type { get; set; }

	/// <summary>
	/// Gets or Sets Location
	/// </summary>
	[DataMember(Name = "location", EmitDefaultValue = false)]
	public Object Location { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string? ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets MacAddress
	/// </summary>
	[DataMember(Name = "macAddress", EmitDefaultValue = false)]
	public string? MacAddress { get; set; }

	/// <summary>
	/// Gets or Sets Role
	/// </summary>
	[DataMember(Name = "role", EmitDefaultValue = false)]
	public string? Role { get; set; }

	/// <summary>
	/// Gets or Sets ApManagerInterfaceIp
	/// </summary>
	[DataMember(Name = "apManagerInterfaceIp", EmitDefaultValue = false)]
	public string? ApManagerInterfaceIp { get; set; }

	/// <summary>
	/// Gets or Sets AssociatedWlcIp
	/// </summary>
	[DataMember(Name = "associatedWlcIp", EmitDefaultValue = false)]
	public string? AssociatedWlcIp { get; set; }

	/// <summary>
	/// Gets or Sets BootDateTime
	/// </summary>
	[DataMember(Name = "bootDateTime", EmitDefaultValue = false)]
	public Object BootDateTime { get; set; }

	/// <summary>
	/// Gets or Sets CollectionStatus
	/// </summary>
	[DataMember(Name = "collectionStatus", EmitDefaultValue = false)]
	public string? CollectionStatus { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceCount
	/// </summary>
	[DataMember(Name = "interfaceCount", EmitDefaultValue = false)]
	public Object InterfaceCount { get; set; }

	/// <summary>
	/// Gets or Sets LineCardCount
	/// </summary>
	[DataMember(Name = "lineCardCount", EmitDefaultValue = false)]
	public Object LineCardCount { get; set; }

	/// <summary>
	/// Gets or Sets LineCardId
	/// </summary>
	[DataMember(Name = "lineCardId", EmitDefaultValue = false)]
	public Object LineCardId { get; set; }

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
	/// Gets or Sets PlatformId
	/// </summary>
	[DataMember(Name = "platformId", EmitDefaultValue = false)]
	public string? PlatformId { get; set; }

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
	/// Gets or Sets TunnelUdpPort
	/// </summary>
	[DataMember(Name = "tunnelUdpPort", EmitDefaultValue = false)]
	public string? TunnelUdpPort { get; set; }

	/// <summary>
	/// Gets or Sets WaasDeviceMode
	/// </summary>
	[DataMember(Name = "waasDeviceMode", EmitDefaultValue = false)]
	public Object WaasDeviceMode { get; set; }

	/// <summary>
	/// Gets or Sets Series
	/// </summary>
	[DataMember(Name = "series", EmitDefaultValue = false)]
	public string? Series { get; set; }

	/// <summary>
	/// Gets or Sets InventoryStatusDetail
	/// </summary>
	[DataMember(Name = "inventoryStatusDetail", EmitDefaultValue = false)]
	public string? InventoryStatusDetail { get; set; }

	/// <summary>
	/// Gets or Sets CollectionInterval
	/// </summary>
	[DataMember(Name = "collectionInterval", EmitDefaultValue = false)]
	public string? CollectionInterval { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Gets or Sets SoftwareVersion
	/// </summary>
	[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
	public string? SoftwareVersion { get; set; }

	/// <summary>
	/// Gets or Sets RoleSource
	/// </summary>
	[DataMember(Name = "roleSource", EmitDefaultValue = false)]
	public string? RoleSource { get; set; }

	/// <summary>
	/// Gets or Sets Hostname
	/// </summary>
	[DataMember(Name = "hostname", EmitDefaultValue = false)]
	public string? Hostname { get; set; }

	/// <summary>
	/// Gets or Sets UpTime
	/// </summary>
	[DataMember(Name = "upTime", EmitDefaultValue = false)]
	public string? UpTime { get; set; }

	/// <summary>
	/// Gets or Sets LastUpdateTime
	/// </summary>
	[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
	public long? LastUpdateTime { get; set; }

	/// <summary>
	/// Gets or Sets ErrorDescription
	/// </summary>
	[DataMember(Name = "errorDescription", EmitDefaultValue = false)]
	public Object ErrorDescription { get; set; }

	/// <summary>
	/// Gets or Sets LocationName
	/// </summary>
	[DataMember(Name = "locationName", EmitDefaultValue = false)]
	public Object LocationName { get; set; }

	/// <summary>
	/// Gets or Sets TagCount
	/// </summary>
	[DataMember(Name = "tagCount", EmitDefaultValue = false)]
	public string? TagCount { get; set; }

	/// <summary>
	/// Gets or Sets LastUpdated
	/// </summary>
	[DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
	public string? LastUpdated { get; set; }

	/// <summary>
	/// Gets or Sets InstanceUuid
	/// </summary>
	[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
	public string? InstanceUuid { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets NeighborTopology
	/// </summary>
	[DataMember(Name = "neighborTopology", EmitDefaultValue = false)]
	public List<GetClientEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology> NeighborTopology { get; set; }

	/// <summary>
	/// Gets or Sets Cisco360view
	/// </summary>
	[DataMember(Name = "cisco360view", EmitDefaultValue = false)]
	public string? Cisco360view { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetClientEnrichmentDetailsResponseInnerDeviceDetails {\n");
		sb.Append("  Family: ").Append(Family).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("  Location: ").Append(Location).Append("\n");
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
		sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
		sb.Append("  Role: ").Append(Role).Append("\n");
		sb.Append("  ApManagerInterfaceIp: ").Append(ApManagerInterfaceIp).Append("\n");
		sb.Append("  AssociatedWlcIp: ").Append(AssociatedWlcIp).Append("\n");
		sb.Append("  BootDateTime: ").Append(BootDateTime).Append("\n");
		sb.Append("  CollectionStatus: ").Append(CollectionStatus).Append("\n");
		sb.Append("  InterfaceCount: ").Append(InterfaceCount).Append("\n");
		sb.Append("  LineCardCount: ").Append(LineCardCount).Append("\n");
		sb.Append("  LineCardId: ").Append(LineCardId).Append("\n");
		sb.Append("  ManagementIpAddress: ").Append(ManagementIpAddress).Append("\n");
		sb.Append("  MemorySize: ").Append(MemorySize).Append("\n");
		sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
		sb.Append("  ReachabilityFailureReason: ").Append(ReachabilityFailureReason).Append("\n");
		sb.Append("  ReachabilityStatus: ").Append(ReachabilityStatus).Append("\n");
		sb.Append("  SnmpContact: ").Append(SnmpContact).Append("\n");
		sb.Append("  SnmpLocation: ").Append(SnmpLocation).Append("\n");
		sb.Append("  TunnelUdpPort: ").Append(TunnelUdpPort).Append("\n");
		sb.Append("  WaasDeviceMode: ").Append(WaasDeviceMode).Append("\n");
		sb.Append("  Series: ").Append(Series).Append("\n");
		sb.Append("  InventoryStatusDetail: ").Append(InventoryStatusDetail).Append("\n");
		sb.Append("  CollectionInterval: ").Append(CollectionInterval).Append("\n");
		sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
		sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
		sb.Append("  RoleSource: ").Append(RoleSource).Append("\n");
		sb.Append("  Hostname: ").Append(Hostname).Append("\n");
		sb.Append("  UpTime: ").Append(UpTime).Append("\n");
		sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
		sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
		sb.Append("  LocationName: ").Append(LocationName).Append("\n");
		sb.Append("  TagCount: ").Append(TagCount).Append("\n");
		sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
		sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  NeighborTopology: ").Append(NeighborTopology).Append("\n");
		sb.Append("  Cisco360view: ").Append(Cisco360view).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
