using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseNetworkElements
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseNetworkElements
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseNetworkElements" /> class.
		/// </summary>
		/// <param name="AccuracyList">AccuracyList.</param>
		/// <param name="DetailedStatus">DetailedStatus.</param>
		/// <param name="DeviceStatistics">DeviceStatistics.</param>
		/// <param name="DeviceStatsCollection">DeviceStatsCollection.</param>
		/// <param name="DeviceStatsCollectionFailureReason">DeviceStatsCollectionFailureReason.</param>
		/// <param name="EgressPhysicalInterface">EgressPhysicalInterface.</param>
		/// <param name="EgressVirtualInterface">EgressVirtualInterface.</param>
		/// <param name="FlexConnect">FlexConnect.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IngressPhysicalInterface">IngressPhysicalInterface.</param>
		/// <param name="IngressVirtualInterface">IngressVirtualInterface.</param>
		/// <param name="Ip">Ip.</param>
		/// <param name="LinkInformationSource">LinkInformationSource.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PerfMonCollection">PerfMonCollection.</param>
		/// <param name="PerfMonCollectionFailureReason">PerfMonCollectionFailureReason.</param>
		/// <param name="PerfMonStatistics">PerfMonStatistics.</param>
		/// <param name="Role">Role.</param>
		/// <param name="Ssid">Ssid.</param>
		/// <param name="Tunnels">Tunnels.</param>
		/// <param name="Type">Type.</param>
		/// <param name="WlanId">WlanId.</param>
		public PathResponseResultResponseNetworkElements(List<PathResponseResultResponseAccuracyList> AccuracyList = default, PathResponseResultResponseDetailedStatus DetailedStatus = default, PathResponseResultResponseDeviceStatistics DeviceStatistics = default, string? DeviceStatsCollection = default, string? DeviceStatsCollectionFailureReason = default, PathResponseResultResponseEgressPhysicalInterface EgressPhysicalInterface = default, PathResponseResultResponseEgressPhysicalInterface EgressVirtualInterface = default, PathResponseResultResponseFlexConnect FlexConnect = default, string? Id = default, PathResponseResultResponseEgressPhysicalInterface IngressPhysicalInterface = default, PathResponseResultResponseEgressPhysicalInterface IngressVirtualInterface = default, string? Ip = default, string? LinkInformationSource = default, string? Name = default, string? PerfMonCollection = default, string? PerfMonCollectionFailureReason = default, List<PathResponseResultResponsePerfMonStatistics> PerfMonStatistics = default, string? Role = default, string? Ssid = default, List<string> Tunnels = default, string? Type = default, string? WlanId = default)
		{
			this.AccuracyList = AccuracyList;
			this.DetailedStatus = DetailedStatus;
			this.DeviceStatistics = DeviceStatistics;
			this.DeviceStatsCollection = DeviceStatsCollection;
			this.DeviceStatsCollectionFailureReason = DeviceStatsCollectionFailureReason;
			this.EgressPhysicalInterface = EgressPhysicalInterface;
			this.EgressVirtualInterface = EgressVirtualInterface;
			this.FlexConnect = FlexConnect;
			this.Id = Id;
			this.IngressPhysicalInterface = IngressPhysicalInterface;
			this.IngressVirtualInterface = IngressVirtualInterface;
			this.Ip = Ip;
			this.LinkInformationSource = LinkInformationSource;
			this.Name = Name;
			this.PerfMonCollection = PerfMonCollection;
			this.PerfMonCollectionFailureReason = PerfMonCollectionFailureReason;
			this.PerfMonStatistics = PerfMonStatistics;
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
		/// Gets or Sets EgressPhysicalInterface
		/// </summary>
		[DataMember(Name = "egressPhysicalInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterface EgressPhysicalInterface { get; set; }
		/// <summary>
		/// Gets or Sets EgressVirtualInterface
		/// </summary>
		[DataMember(Name = "egressVirtualInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterface EgressVirtualInterface { get; set; }
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
		/// Gets or Sets IngressPhysicalInterface
		/// </summary>
		[DataMember(Name = "ingressPhysicalInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterface IngressPhysicalInterface { get; set; }
		/// <summary>
		/// Gets or Sets IngressVirtualInterface
		/// </summary>
		[DataMember(Name = "ingressVirtualInterface", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterface IngressVirtualInterface { get; set; }
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
		/// Gets or Sets PerfMonStatistics
		/// </summary>
		[DataMember(Name = "perfMonStatistics", EmitDefaultValue = false)]
		public List<PathResponseResultResponsePerfMonStatistics> PerfMonStatistics { get; set; }
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
			sb.Append("class PathResponseResultResponseNetworkElements {\n");
			sb.Append("  AccuracyList: ").Append(AccuracyList).Append("\n");
			sb.Append("  DetailedStatus: ").Append(DetailedStatus).Append("\n");
			sb.Append("  DeviceStatistics: ").Append(DeviceStatistics).Append("\n");
			sb.Append("  DeviceStatsCollection: ").Append(DeviceStatsCollection).Append("\n");
			sb.Append("  DeviceStatsCollectionFailureReason: ").Append(DeviceStatsCollectionFailureReason).Append("\n");
			sb.Append("  EgressPhysicalInterface: ").Append(EgressPhysicalInterface).Append("\n");
			sb.Append("  EgressVirtualInterface: ").Append(EgressVirtualInterface).Append("\n");
			sb.Append("  FlexConnect: ").Append(FlexConnect).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IngressPhysicalInterface: ").Append(IngressPhysicalInterface).Append("\n");
			sb.Append("  IngressVirtualInterface: ").Append(IngressVirtualInterface).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("  LinkInformationSource: ").Append(LinkInformationSource).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  PerfMonCollection: ").Append(PerfMonCollection).Append("\n");
			sb.Append("  PerfMonCollectionFailureReason: ").Append(PerfMonCollectionFailureReason).Append("\n");
			sb.Append("  PerfMonStatistics: ").Append(PerfMonStatistics).Append("\n");
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
