using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetSiteHealthResponseResponse
/// </summary>
[DataContract]
public class GetSiteHealthResponseResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSiteHealthResponseResponse" /> class.
	/// </summary>
	/// <param name="SiteName">SiteName.</param>
	/// <param name="SiteId">SiteId.</param>
	/// <param name="ParentSiteId">ParentSiteId.</param>
	/// <param name="ParentSiteName">ParentSiteName.</param>
	/// <param name="SiteType">SiteType.</param>
	/// <param name="Latitude">Latitude.</param>
	/// <param name="Longitude">Longitude.</param>
	/// <param name="HealthyNetworkDevicePercentage">HealthyNetworkDevicePercentage.</param>
	/// <param name="HealthyClientsPercentage">HealthyClientsPercentage.</param>
	/// <param name="ClientHealthWired">ClientHealthWired.</param>
	/// <param name="ClientHealthWireless">ClientHealthWireless.</param>
	/// <param name="NumberOfClients">NumberOfClients.</param>
	/// <param name="ClientNumberOfIssues">ClientNumberOfIssues.</param>
	/// <param name="NetworkNumberOfIssues">NetworkNumberOfIssues.</param>
	/// <param name="NumberOfNetworkDevice">NumberOfNetworkDevice.</param>
	/// <param name="NetworkHealthAverage">NetworkHealthAverage.</param>
	/// <param name="NetworkHealthAccess">NetworkHealthAccess.</param>
	/// <param name="NetworkHealthCore">NetworkHealthCore.</param>
	/// <param name="NetworkHealthDistribution">NetworkHealthDistribution.</param>
	/// <param name="NetworkHealthRouter">NetworkHealthRouter.</param>
	/// <param name="NetworkHealthWireless">NetworkHealthWireless.</param>
	/// <param name="NetworkHealthOthers">NetworkHealthOthers.</param>
	/// <param name="NumberOfWiredClients">NumberOfWiredClients.</param>
	/// <param name="NumberOfWirelessClients">NumberOfWirelessClients.</param>
	/// <param name="WiredGoodClients">WiredGoodClients.</param>
	/// <param name="WirelessGoodClients">WirelessGoodClients.</param>
	/// <param name="ClientIssueCount">ClientIssueCount.</param>
	/// <param name="OverallGoodDevices">OverallGoodDevices.</param>
	/// <param name="AccessGoodCount">AccessGoodCount.</param>
	/// <param name="AccessTotalCount">AccessTotalCount.</param>
	/// <param name="CoreGoodCount">CoreGoodCount.</param>
	/// <param name="CoreTotalCount">CoreTotalCount.</param>
	/// <param name="DistributionGoodCount">DistributionGoodCount.</param>
	/// <param name="DistributionTotalCount">DistributionTotalCount.</param>
	/// <param name="RouterGoodCount">RouterGoodCount.</param>
	/// <param name="RouterTotalCount">RouterTotalCount.</param>
	/// <param name="WirelessDeviceGoodCount">WirelessDeviceGoodCount.</param>
	/// <param name="WirelessDeviceTotalCount">WirelessDeviceTotalCount.</param>
	/// <param name="ApplicationHealth">ApplicationHealth.</param>
	/// <param name="ApplicationGoodCount">ApplicationGoodCount.</param>
	/// <param name="ApplicationTotalCount">ApplicationTotalCount.</param>
	/// <param name="ApplicationBytesTotalCount">ApplicationBytesTotalCount.</param>
	public GetSiteHealthResponseResponse(string? SiteName = default, string? SiteId = default, string? ParentSiteId = default, string? ParentSiteName = default, string? SiteType = default, Object Latitude = default, Object Longitude = default, string? HealthyNetworkDevicePercentage = default, string? HealthyClientsPercentage = default, string? ClientHealthWired = default, Object ClientHealthWireless = default, string? NumberOfClients = default, Object ClientNumberOfIssues = default, Object NetworkNumberOfIssues = default, string? NumberOfNetworkDevice = default, Object NetworkHealthAverage = default, string? NetworkHealthAccess = default, string? NetworkHealthCore = default, string? NetworkHealthDistribution = default, string? NetworkHealthRouter = default, Object NetworkHealthWireless = default, Object NetworkHealthOthers = default, string? NumberOfWiredClients = default, Object NumberOfWirelessClients = default, string? WiredGoodClients = default, Object WirelessGoodClients = default, Object ClientIssueCount = default, string? OverallGoodDevices = default, string? AccessGoodCount = default, string? AccessTotalCount = default, string? CoreGoodCount = default, string? CoreTotalCount = default, string? DistributionGoodCount = default, string? DistributionTotalCount = default, string? RouterGoodCount = default, string? RouterTotalCount = default, string? WirelessDeviceGoodCount = default, string? WirelessDeviceTotalCount = default, Object ApplicationHealth = default, Object ApplicationGoodCount = default, Object ApplicationTotalCount = default, Object ApplicationBytesTotalCount = default)
	{
		this.SiteName = SiteName;
		this.SiteId = SiteId;
		this.ParentSiteId = ParentSiteId;
		this.ParentSiteName = ParentSiteName;
		this.SiteType = SiteType;
		this.Latitude = Latitude;
		this.Longitude = Longitude;
		this.HealthyNetworkDevicePercentage = HealthyNetworkDevicePercentage;
		this.HealthyClientsPercentage = HealthyClientsPercentage;
		this.ClientHealthWired = ClientHealthWired;
		this.ClientHealthWireless = ClientHealthWireless;
		this.NumberOfClients = NumberOfClients;
		this.ClientNumberOfIssues = ClientNumberOfIssues;
		this.NetworkNumberOfIssues = NetworkNumberOfIssues;
		this.NumberOfNetworkDevice = NumberOfNetworkDevice;
		this.NetworkHealthAverage = NetworkHealthAverage;
		this.NetworkHealthAccess = NetworkHealthAccess;
		this.NetworkHealthCore = NetworkHealthCore;
		this.NetworkHealthDistribution = NetworkHealthDistribution;
		this.NetworkHealthRouter = NetworkHealthRouter;
		this.NetworkHealthWireless = NetworkHealthWireless;
		this.NetworkHealthOthers = NetworkHealthOthers;
		this.NumberOfWiredClients = NumberOfWiredClients;
		this.NumberOfWirelessClients = NumberOfWirelessClients;
		this.WiredGoodClients = WiredGoodClients;
		this.WirelessGoodClients = WirelessGoodClients;
		this.ClientIssueCount = ClientIssueCount;
		this.OverallGoodDevices = OverallGoodDevices;
		this.AccessGoodCount = AccessGoodCount;
		this.AccessTotalCount = AccessTotalCount;
		this.CoreGoodCount = CoreGoodCount;
		this.CoreTotalCount = CoreTotalCount;
		this.DistributionGoodCount = DistributionGoodCount;
		this.DistributionTotalCount = DistributionTotalCount;
		this.RouterGoodCount = RouterGoodCount;
		this.RouterTotalCount = RouterTotalCount;
		this.WirelessDeviceGoodCount = WirelessDeviceGoodCount;
		this.WirelessDeviceTotalCount = WirelessDeviceTotalCount;
		this.ApplicationHealth = ApplicationHealth;
		this.ApplicationGoodCount = ApplicationGoodCount;
		this.ApplicationTotalCount = ApplicationTotalCount;
		this.ApplicationBytesTotalCount = ApplicationBytesTotalCount;
	}

	/// <summary>
	/// Gets or Sets SiteName
	/// </summary>
	[DataMember(Name = "siteName", EmitDefaultValue = false)]
	public string? SiteName { get; set; }

	/// <summary>
	/// Gets or Sets SiteId
	/// </summary>
	[DataMember(Name = "siteId", EmitDefaultValue = false)]
	public string? SiteId { get; set; }

	/// <summary>
	/// Gets or Sets ParentSiteId
	/// </summary>
	[DataMember(Name = "parentSiteId", EmitDefaultValue = false)]
	public string? ParentSiteId { get; set; }

	/// <summary>
	/// Gets or Sets ParentSiteName
	/// </summary>
	[DataMember(Name = "parentSiteName", EmitDefaultValue = false)]
	public string? ParentSiteName { get; set; }

	/// <summary>
	/// Gets or Sets SiteType
	/// </summary>
	[DataMember(Name = "siteType", EmitDefaultValue = false)]
	public string? SiteType { get; set; }

	/// <summary>
	/// Gets or Sets Latitude
	/// </summary>
	[DataMember(Name = "latitude", EmitDefaultValue = false)]
	public Object Latitude { get; set; }

	/// <summary>
	/// Gets or Sets Longitude
	/// </summary>
	[DataMember(Name = "longitude", EmitDefaultValue = false)]
	public Object Longitude { get; set; }

	/// <summary>
	/// Gets or Sets HealthyNetworkDevicePercentage
	/// </summary>
	[DataMember(Name = "healthyNetworkDevicePercentage", EmitDefaultValue = false)]
	public string? HealthyNetworkDevicePercentage { get; set; }

	/// <summary>
	/// Gets or Sets HealthyClientsPercentage
	/// </summary>
	[DataMember(Name = "healthyClientsPercentage", EmitDefaultValue = false)]
	public string? HealthyClientsPercentage { get; set; }

	/// <summary>
	/// Gets or Sets ClientHealthWired
	/// </summary>
	[DataMember(Name = "clientHealthWired", EmitDefaultValue = false)]
	public string? ClientHealthWired { get; set; }

	/// <summary>
	/// Gets or Sets ClientHealthWireless
	/// </summary>
	[DataMember(Name = "clientHealthWireless", EmitDefaultValue = false)]
	public Object ClientHealthWireless { get; set; }

	/// <summary>
	/// Gets or Sets NumberOfClients
	/// </summary>
	[DataMember(Name = "numberOfClients", EmitDefaultValue = false)]
	public string? NumberOfClients { get; set; }

	/// <summary>
	/// Gets or Sets ClientNumberOfIssues
	/// </summary>
	[DataMember(Name = "clientNumberOfIssues", EmitDefaultValue = false)]
	public Object ClientNumberOfIssues { get; set; }

	/// <summary>
	/// Gets or Sets NetworkNumberOfIssues
	/// </summary>
	[DataMember(Name = "networkNumberOfIssues", EmitDefaultValue = false)]
	public Object NetworkNumberOfIssues { get; set; }

	/// <summary>
	/// Gets or Sets NumberOfNetworkDevice
	/// </summary>
	[DataMember(Name = "numberOfNetworkDevice", EmitDefaultValue = false)]
	public string? NumberOfNetworkDevice { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthAverage
	/// </summary>
	[DataMember(Name = "networkHealthAverage", EmitDefaultValue = false)]
	public Object NetworkHealthAverage { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthAccess
	/// </summary>
	[DataMember(Name = "networkHealthAccess", EmitDefaultValue = false)]
	public string? NetworkHealthAccess { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthCore
	/// </summary>
	[DataMember(Name = "networkHealthCore", EmitDefaultValue = false)]
	public string? NetworkHealthCore { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthDistribution
	/// </summary>
	[DataMember(Name = "networkHealthDistribution", EmitDefaultValue = false)]
	public string? NetworkHealthDistribution { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthRouter
	/// </summary>
	[DataMember(Name = "networkHealthRouter", EmitDefaultValue = false)]
	public string? NetworkHealthRouter { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthWireless
	/// </summary>
	[DataMember(Name = "networkHealthWireless", EmitDefaultValue = false)]
	public Object NetworkHealthWireless { get; set; }

	/// <summary>
	/// Gets or Sets NetworkHealthOthers
	/// </summary>
	[DataMember(Name = "networkHealthOthers", EmitDefaultValue = false)]
	public Object NetworkHealthOthers { get; set; }

	/// <summary>
	/// Gets or Sets NumberOfWiredClients
	/// </summary>
	[DataMember(Name = "numberOfWiredClients", EmitDefaultValue = false)]
	public string? NumberOfWiredClients { get; set; }

	/// <summary>
	/// Gets or Sets NumberOfWirelessClients
	/// </summary>
	[DataMember(Name = "numberOfWirelessClients", EmitDefaultValue = false)]
	public Object NumberOfWirelessClients { get; set; }

	/// <summary>
	/// Gets or Sets WiredGoodClients
	/// </summary>
	[DataMember(Name = "wiredGoodClients", EmitDefaultValue = false)]
	public string? WiredGoodClients { get; set; }

	/// <summary>
	/// Gets or Sets WirelessGoodClients
	/// </summary>
	[DataMember(Name = "wirelessGoodClients", EmitDefaultValue = false)]
	public Object WirelessGoodClients { get; set; }

	/// <summary>
	/// Gets or Sets ClientIssueCount
	/// </summary>
	[DataMember(Name = "clientIssueCount", EmitDefaultValue = false)]
	public Object ClientIssueCount { get; set; }

	/// <summary>
	/// Gets or Sets OverallGoodDevices
	/// </summary>
	[DataMember(Name = "overallGoodDevices", EmitDefaultValue = false)]
	public string? OverallGoodDevices { get; set; }

	/// <summary>
	/// Gets or Sets AccessGoodCount
	/// </summary>
	[DataMember(Name = "accessGoodCount", EmitDefaultValue = false)]
	public string? AccessGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets AccessTotalCount
	/// </summary>
	[DataMember(Name = "accessTotalCount", EmitDefaultValue = false)]
	public string? AccessTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets CoreGoodCount
	/// </summary>
	[DataMember(Name = "coreGoodCount", EmitDefaultValue = false)]
	public string? CoreGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets CoreTotalCount
	/// </summary>
	[DataMember(Name = "coreTotalCount", EmitDefaultValue = false)]
	public string? CoreTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets DistributionGoodCount
	/// </summary>
	[DataMember(Name = "distributionGoodCount", EmitDefaultValue = false)]
	public string? DistributionGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets DistributionTotalCount
	/// </summary>
	[DataMember(Name = "distributionTotalCount", EmitDefaultValue = false)]
	public string? DistributionTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets RouterGoodCount
	/// </summary>
	[DataMember(Name = "routerGoodCount", EmitDefaultValue = false)]
	public string? RouterGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets RouterTotalCount
	/// </summary>
	[DataMember(Name = "routerTotalCount", EmitDefaultValue = false)]
	public string? RouterTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets WirelessDeviceGoodCount
	/// </summary>
	[DataMember(Name = "wirelessDeviceGoodCount", EmitDefaultValue = false)]
	public string? WirelessDeviceGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets WirelessDeviceTotalCount
	/// </summary>
	[DataMember(Name = "wirelessDeviceTotalCount", EmitDefaultValue = false)]
	public string? WirelessDeviceTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets ApplicationHealth
	/// </summary>
	[DataMember(Name = "applicationHealth", EmitDefaultValue = false)]
	public Object ApplicationHealth { get; set; }

	/// <summary>
	/// Gets or Sets ApplicationGoodCount
	/// </summary>
	[DataMember(Name = "applicationGoodCount", EmitDefaultValue = false)]
	public Object ApplicationGoodCount { get; set; }

	/// <summary>
	/// Gets or Sets ApplicationTotalCount
	/// </summary>
	[DataMember(Name = "applicationTotalCount", EmitDefaultValue = false)]
	public Object ApplicationTotalCount { get; set; }

	/// <summary>
	/// Gets or Sets ApplicationBytesTotalCount
	/// </summary>
	[DataMember(Name = "applicationBytesTotalCount", EmitDefaultValue = false)]
	public Object ApplicationBytesTotalCount { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetSiteHealthResponseResponse {\n");
		sb.Append("  SiteName: ").Append(SiteName).Append("\n");
		sb.Append("  SiteId: ").Append(SiteId).Append("\n");
		sb.Append("  ParentSiteId: ").Append(ParentSiteId).Append("\n");
		sb.Append("  ParentSiteName: ").Append(ParentSiteName).Append("\n");
		sb.Append("  SiteType: ").Append(SiteType).Append("\n");
		sb.Append("  Latitude: ").Append(Latitude).Append("\n");
		sb.Append("  Longitude: ").Append(Longitude).Append("\n");
		sb.Append("  HealthyNetworkDevicePercentage: ").Append(HealthyNetworkDevicePercentage).Append("\n");
		sb.Append("  HealthyClientsPercentage: ").Append(HealthyClientsPercentage).Append("\n");
		sb.Append("  ClientHealthWired: ").Append(ClientHealthWired).Append("\n");
		sb.Append("  ClientHealthWireless: ").Append(ClientHealthWireless).Append("\n");
		sb.Append("  NumberOfClients: ").Append(NumberOfClients).Append("\n");
		sb.Append("  ClientNumberOfIssues: ").Append(ClientNumberOfIssues).Append("\n");
		sb.Append("  NetworkNumberOfIssues: ").Append(NetworkNumberOfIssues).Append("\n");
		sb.Append("  NumberOfNetworkDevice: ").Append(NumberOfNetworkDevice).Append("\n");
		sb.Append("  NetworkHealthAverage: ").Append(NetworkHealthAverage).Append("\n");
		sb.Append("  NetworkHealthAccess: ").Append(NetworkHealthAccess).Append("\n");
		sb.Append("  NetworkHealthCore: ").Append(NetworkHealthCore).Append("\n");
		sb.Append("  NetworkHealthDistribution: ").Append(NetworkHealthDistribution).Append("\n");
		sb.Append("  NetworkHealthRouter: ").Append(NetworkHealthRouter).Append("\n");
		sb.Append("  NetworkHealthWireless: ").Append(NetworkHealthWireless).Append("\n");
		sb.Append("  NetworkHealthOthers: ").Append(NetworkHealthOthers).Append("\n");
		sb.Append("  NumberOfWiredClients: ").Append(NumberOfWiredClients).Append("\n");
		sb.Append("  NumberOfWirelessClients: ").Append(NumberOfWirelessClients).Append("\n");
		sb.Append("  WiredGoodClients: ").Append(WiredGoodClients).Append("\n");
		sb.Append("  WirelessGoodClients: ").Append(WirelessGoodClients).Append("\n");
		sb.Append("  ClientIssueCount: ").Append(ClientIssueCount).Append("\n");
		sb.Append("  OverallGoodDevices: ").Append(OverallGoodDevices).Append("\n");
		sb.Append("  AccessGoodCount: ").Append(AccessGoodCount).Append("\n");
		sb.Append("  AccessTotalCount: ").Append(AccessTotalCount).Append("\n");
		sb.Append("  CoreGoodCount: ").Append(CoreGoodCount).Append("\n");
		sb.Append("  CoreTotalCount: ").Append(CoreTotalCount).Append("\n");
		sb.Append("  DistributionGoodCount: ").Append(DistributionGoodCount).Append("\n");
		sb.Append("  DistributionTotalCount: ").Append(DistributionTotalCount).Append("\n");
		sb.Append("  RouterGoodCount: ").Append(RouterGoodCount).Append("\n");
		sb.Append("  RouterTotalCount: ").Append(RouterTotalCount).Append("\n");
		sb.Append("  WirelessDeviceGoodCount: ").Append(WirelessDeviceGoodCount).Append("\n");
		sb.Append("  WirelessDeviceTotalCount: ").Append(WirelessDeviceTotalCount).Append("\n");
		sb.Append("  ApplicationHealth: ").Append(ApplicationHealth).Append("\n");
		sb.Append("  ApplicationGoodCount: ").Append(ApplicationGoodCount).Append("\n");
		sb.Append("  ApplicationTotalCount: ").Append(ApplicationTotalCount).Append("\n");
		sb.Append("  ApplicationBytesTotalCount: ").Append(ApplicationBytesTotalCount).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
