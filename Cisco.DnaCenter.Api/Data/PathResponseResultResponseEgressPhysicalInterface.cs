using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterface
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseEgressPhysicalInterface
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterface" /> class.
		/// </summary>
		/// <param name="AclAnalysis">AclAnalysis.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InterfaceStatistics">InterfaceStatistics.</param>
		/// <param name="InterfaceStatsCollection">InterfaceStatsCollection.</param>
		/// <param name="InterfaceStatsCollectionFailureReason">InterfaceStatsCollectionFailureReason.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PathOverlayInfo">PathOverlayInfo.</param>
		/// <param name="QosStatistics">QosStatistics.</param>
		/// <param name="QosStatsCollection">QosStatsCollection.</param>
		/// <param name="QosStatsCollectionFailureReason">QosStatsCollectionFailureReason.</param>
		/// <param name="UsedVlan">UsedVlan.</param>
		/// <param name="VrfName">VrfName.</param>
		public PathResponseResultResponseEgressPhysicalInterface(PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis AclAnalysis = default, string? Id = default, PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics InterfaceStatistics = default, string? InterfaceStatsCollection = default, string? InterfaceStatsCollectionFailureReason = default, string? Name = default, List<PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo> PathOverlayInfo = default, List<PathResponseResultResponseEgressPhysicalInterfaceQosStatistics> QosStatistics = default, string? QosStatsCollection = default, string? QosStatsCollectionFailureReason = default, string? UsedVlan = default, string? VrfName = default)
		{
			this.AclAnalysis = AclAnalysis;
			this.Id = Id;
			this.InterfaceStatistics = InterfaceStatistics;
			this.InterfaceStatsCollection = InterfaceStatsCollection;
			this.InterfaceStatsCollectionFailureReason = InterfaceStatsCollectionFailureReason;
			this.Name = Name;
			this.PathOverlayInfo = PathOverlayInfo;
			this.QosStatistics = QosStatistics;
			this.QosStatsCollection = QosStatsCollection;
			this.QosStatsCollectionFailureReason = QosStatsCollectionFailureReason;
			this.UsedVlan = UsedVlan;
			this.VrfName = VrfName;
		}

		/// <summary>
		/// Gets or Sets AclAnalysis
		/// </summary>
		[DataMember(Name = "aclAnalysis", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterfaceAclAnalysis AclAnalysis { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets InterfaceStatistics
		/// </summary>
		[DataMember(Name = "interfaceStatistics", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics InterfaceStatistics { get; set; }

		/// <summary>
		/// Gets or Sets InterfaceStatsCollection
		/// </summary>
		[DataMember(Name = "interfaceStatsCollection", EmitDefaultValue = false)]
		public string? InterfaceStatsCollection { get; set; }

		/// <summary>
		/// Gets or Sets InterfaceStatsCollectionFailureReason
		/// </summary>
		[DataMember(Name = "interfaceStatsCollectionFailureReason", EmitDefaultValue = false)]
		public string? InterfaceStatsCollectionFailureReason { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets PathOverlayInfo
		/// </summary>
		[DataMember(Name = "pathOverlayInfo", EmitDefaultValue = false)]
		public List<PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo> PathOverlayInfo { get; set; }

		/// <summary>
		/// Gets or Sets QosStatistics
		/// </summary>
		[DataMember(Name = "qosStatistics", EmitDefaultValue = false)]
		public List<PathResponseResultResponseEgressPhysicalInterfaceQosStatistics> QosStatistics { get; set; }

		/// <summary>
		/// Gets or Sets QosStatsCollection
		/// </summary>
		[DataMember(Name = "qosStatsCollection", EmitDefaultValue = false)]
		public string? QosStatsCollection { get; set; }

		/// <summary>
		/// Gets or Sets QosStatsCollectionFailureReason
		/// </summary>
		[DataMember(Name = "qosStatsCollectionFailureReason", EmitDefaultValue = false)]
		public string? QosStatsCollectionFailureReason { get; set; }

		/// <summary>
		/// Gets or Sets UsedVlan
		/// </summary>
		[DataMember(Name = "usedVlan", EmitDefaultValue = false)]
		public string? UsedVlan { get; set; }

		/// <summary>
		/// Gets or Sets VrfName
		/// </summary>
		[DataMember(Name = "vrfName", EmitDefaultValue = false)]
		public string? VrfName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseEgressPhysicalInterface {\n");
			sb.Append("  AclAnalysis: ").Append(AclAnalysis).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InterfaceStatistics: ").Append(InterfaceStatistics).Append("\n");
			sb.Append("  InterfaceStatsCollection: ").Append(InterfaceStatsCollection).Append("\n");
			sb.Append("  InterfaceStatsCollectionFailureReason: ").Append(InterfaceStatsCollectionFailureReason).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  PathOverlayInfo: ").Append(PathOverlayInfo).Append("\n");
			sb.Append("  QosStatistics: ").Append(QosStatistics).Append("\n");
			sb.Append("  QosStatsCollection: ").Append(QosStatsCollection).Append("\n");
			sb.Append("  QosStatsCollectionFailureReason: ").Append(QosStatsCollectionFailureReason).Append("\n");
			sb.Append("  UsedVlan: ").Append(UsedVlan).Append("\n");
			sb.Append("  VrfName: ").Append(VrfName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
