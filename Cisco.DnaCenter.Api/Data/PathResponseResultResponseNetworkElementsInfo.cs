using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseNetworkElementsInfo
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseNetworkElementsInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseNetworkElementsInfo" /> class.
		/// </summary>
		/// <param name="AccuracyList">AccuracyList.</param>
		/// <param name="DetailedStatus">DetailedStatus.</param>
		/// <param name="DeviceStatistics">DeviceStatistics.</param>
		/// <param name="DeviceStatsCollection">DeviceStatsCollection.</param>
		/// <param name="DeviceStatsCollectionFailureReason">DeviceStatsCollectionFailureReason.</param>
		/// <param name="EgressInterface">EgressInterface.</param>
		/// <param name="FlexConnect">FlexConnect.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IngressInterface">IngressInterface.</param>
		/// <param name="Ip">Ip.</param>
		/// <param name="LinkInformationSource">LinkInformationSource.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PerfMonCollection">PerfMonCollection.</param>
		/// <param name="PerfMonCollectionFailureReason">PerfMonCollectionFailureReason.</param>
		/// <param name="PerfMonitorStatistics">PerfMonitorStatistics.</param>
		/// <param name="Role">Role.</param>
		/// <param name="Ssid">Ssid.</param>
		/// <param name="Tunnels">Tunnels.</param>
		/// <param name="Type">Type.</param>
		/// <param name="WlanId">WlanId.</param>
		public PathResponseResultResponseNetworkElementsInfo(List<PathResponseResultResponseAccuracyList> AccuracyList = default, PathResponseResultResponseDetailedStatus DetailedStatus = default, PathResponseResultResponseDeviceStatistics DeviceStatistics = default, string? DeviceStatsCollection = default, string? DeviceStatsCollectionFailureReason = default, PathResponseResultResponseEgressInterface EgressInterface = default, PathResponseResultResponseFlexConnect FlexConnect = default, string? Id = default, PathResponseResultResponseEgressInterface IngressInterface = default, string? Ip = default, string? LinkInformationSource = default, string? Name = default, string? PerfMonCollection = default, string? PerfMonCollectionFailureReason = default, List<PathResponseResultResponsePerfMonStatistics> PerfMonitorStatistics = default, string? Role = default, string? Ssid = default, List<string> Tunnels = default, string? Type = default, string? WlanId = default)
		{
			this.AccuracyList = AccuracyList;
			this.DetailedStatus = DetailedStatus;
			this.DeviceStatistics = DeviceStatistics;
			this.DeviceStatsCollection = DeviceStatsCollection;
			this.DeviceStatsCollectionFailureReason = DeviceStatsCollectionFailureReason;
			this.EgressInterface = EgressInterface;
			this.FlexConnect = FlexConnect;
			this.Id = Id;
			this.IngressInterface = IngressInterface;
			this.Ip = Ip;
			this.LinkInformationSource = LinkInformationSource;
			this.Name = Name;
			this.PerfMonCollection = PerfMonCollection;
			this.PerfMonCollectionFailureReason = PerfMonCollectionFailureReason;
			this.PerfMonitorStatistics = PerfMonitorStatistics;
			this.Role = Role;
			this.Ssid = Ssid;
			this.Tunnels = Tunnels;
			this.Type = Type;
			this.WlanId = WlanId;
		}

		/// <summary>
		/// Gets or Sets AccuracyList
		/// </summary>
		[DataMember(Name = "accuracyList", EmitDefaultValue = false)]
		public List<PathResponseResultResponseAccuracyList> AccuracyList { get; set; }

		/// <summary>
		/// Gets or Sets DetailedStatus
		/// </summary>
		[DataMember(Name = "detailedStatus", EmitDefaultValue = false)]
		public PathResponseResultResponseDetailedStatus DetailedStatus { get; set; }

		/// <summary>
		/// Gets or Sets DeviceStatistics
		/// </summary>
		[DataMember(Name = "deviceStatistics", EmitDefaultValue = false)]
		public PathResponseResultResponseDeviceStatistics DeviceStatistics { get; set; }

		/// <summary>
		/// Gets or Sets DeviceStatsCollection
		/// </summary>
		[DataMember(Name = "deviceStatsCollection", EmitDefaultValue = false)]
		public string? DeviceStatsCollection { get; set; }

		/// <summary>
		/// Gets or Sets DeviceStatsCollectionFailureReason
		/// </summary>
		[DataMember(Name = "deviceStatsCollectionFailureReason", EmitDefaultValue = false)]
		public string? DeviceStatsCollectionFailureReason { get; set; }

		/// <summary>
		/// Gets or Sets EgressInterface
		/// </summary>
		[DataMember(Name = "egressInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressInterface EgressInterface { get; set; }

		/// <summary>
		/// Gets or Sets FlexConnect
		/// </summary>
		[DataMember(Name = "flexConnect", EmitDefaultValue = false)]
		public PathResponseResultResponseFlexConnect FlexConnect { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets IngressInterface
		/// </summary>
		[DataMember(Name = "ingressInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressInterface IngressInterface { get; set; }

		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string? Ip { get; set; }

		/// <summary>
		/// Gets or Sets LinkInformationSource
		/// </summary>
		[DataMember(Name = "linkInformationSource", EmitDefaultValue = false)]
		public string? LinkInformationSource { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets PerfMonCollection
		/// </summary>
		[DataMember(Name = "perfMonCollection", EmitDefaultValue = false)]
		public string? PerfMonCollection { get; set; }

		/// <summary>
		/// Gets or Sets PerfMonCollectionFailureReason
		/// </summary>
		[DataMember(Name = "perfMonCollectionFailureReason", EmitDefaultValue = false)]
		public string? PerfMonCollectionFailureReason { get; set; }

		/// <summary>
		/// Gets or Sets PerfMonitorStatistics
		/// </summary>
		[DataMember(Name = "perfMonitorStatistics", EmitDefaultValue = false)]
		public List<PathResponseResultResponsePerfMonStatistics> PerfMonitorStatistics { get; set; }

		/// <summary>
		/// Gets or Sets Role
		/// </summary>
		[DataMember(Name = "role", EmitDefaultValue = false)]
		public string? Role { get; set; }

		/// <summary>
		/// Gets or Sets Ssid
		/// </summary>
		[DataMember(Name = "ssid", EmitDefaultValue = false)]
		public string? Ssid { get; set; }

		/// <summary>
		/// Gets or Sets Tunnels
		/// </summary>
		[DataMember(Name = "tunnels", EmitDefaultValue = false)]
		public List<string> Tunnels { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets WlanId
		/// </summary>
		[DataMember(Name = "wlanId", EmitDefaultValue = false)]
		public string? WlanId { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseNetworkElementsInfo {\n");
			sb.Append("  AccuracyList: ").Append(AccuracyList).Append("\n");
			sb.Append("  DetailedStatus: ").Append(DetailedStatus).Append("\n");
			sb.Append("  DeviceStatistics: ").Append(DeviceStatistics).Append("\n");
			sb.Append("  DeviceStatsCollection: ").Append(DeviceStatsCollection).Append("\n");
			sb.Append("  DeviceStatsCollectionFailureReason: ").Append(DeviceStatsCollectionFailureReason).Append("\n");
			sb.Append("  EgressInterface: ").Append(EgressInterface).Append("\n");
			sb.Append("  FlexConnect: ").Append(FlexConnect).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IngressInterface: ").Append(IngressInterface).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("  LinkInformationSource: ").Append(LinkInformationSource).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  PerfMonCollection: ").Append(PerfMonCollection).Append("\n");
			sb.Append("  PerfMonCollectionFailureReason: ").Append(PerfMonCollectionFailureReason).Append("\n");
			sb.Append("  PerfMonitorStatistics: ").Append(PerfMonitorStatistics).Append("\n");
			sb.Append("  Role: ").Append(Role).Append("\n");
			sb.Append("  Ssid: ").Append(Ssid).Append("\n");
			sb.Append("  Tunnels: ").Append(Tunnels).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  WlanId: ").Append(WlanId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
