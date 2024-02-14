using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// PathResponseResultResponseEgressPhysicalInterfaceQosStatistics
/// </summary>
[DataContract]
public class PathResponseResultResponseEgressPhysicalInterfaceQosStatistics
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceQosStatistics" /> class.
	/// </summary>
	/// <param name="ClassMapName">ClassMapName.</param>
	/// <param name="DropRate">DropRate.</param>
	/// <param name="NumBytes">NumBytes.</param>
	/// <param name="NumPackets">NumPackets.</param>
	/// <param name="OfferedRate">OfferedRate.</param>
	/// <param name="QueueBandwidthbps">QueueBandwidthbps.</param>
	/// <param name="QueueDepth">QueueDepth.</param>
	/// <param name="QueueNoBufferDrops">QueueNoBufferDrops.</param>
	/// <param name="QueueTotalDrops">QueueTotalDrops.</param>
	/// <param name="RefreshedAt">RefreshedAt.</param>
	public PathResponseResultResponseEgressPhysicalInterfaceQosStatistics(string? ClassMapName = default, int? DropRate = default, int? NumBytes = default, int? NumPackets = default, int? OfferedRate = default, string? QueueBandwidthbps = default, int? QueueDepth = default, int? QueueNoBufferDrops = default, int? QueueTotalDrops = default, int? RefreshedAt = default)
	{
		this.ClassMapName = ClassMapName;
		this.DropRate = DropRate;
		this.NumBytes = NumBytes;
		this.NumPackets = NumPackets;
		this.OfferedRate = OfferedRate;
		this.QueueBandwidthbps = QueueBandwidthbps;
		this.QueueDepth = QueueDepth;
		this.QueueNoBufferDrops = QueueNoBufferDrops;
		this.QueueTotalDrops = QueueTotalDrops;
		this.RefreshedAt = RefreshedAt;
	}

	/// <summary>
	/// Gets or Sets ClassMapName
	/// </summary>
	[DataMember(Name = "classMapName", EmitDefaultValue = false)]
	public string? ClassMapName { get; set; }

	/// <summary>
	/// Gets or Sets DropRate
	/// </summary>
	[DataMember(Name = "dropRate", EmitDefaultValue = false)]
	public int? DropRate { get; set; }

	/// <summary>
	/// Gets or Sets NumBytes
	/// </summary>
	[DataMember(Name = "numBytes", EmitDefaultValue = false)]
	public int? NumBytes { get; set; }

	/// <summary>
	/// Gets or Sets NumPackets
	/// </summary>
	[DataMember(Name = "numPackets", EmitDefaultValue = false)]
	public int? NumPackets { get; set; }

	/// <summary>
	/// Gets or Sets OfferedRate
	/// </summary>
	[DataMember(Name = "offeredRate", EmitDefaultValue = false)]
	public int? OfferedRate { get; set; }

	/// <summary>
	/// Gets or Sets QueueBandwidthbps
	/// </summary>
	[DataMember(Name = "queueBandwidthbps", EmitDefaultValue = false)]
	public string? QueueBandwidthbps { get; set; }

	/// <summary>
	/// Gets or Sets QueueDepth
	/// </summary>
	[DataMember(Name = "queueDepth", EmitDefaultValue = false)]
	public int? QueueDepth { get; set; }

	/// <summary>
	/// Gets or Sets QueueNoBufferDrops
	/// </summary>
	[DataMember(Name = "queueNoBufferDrops", EmitDefaultValue = false)]
	public int? QueueNoBufferDrops { get; set; }

	/// <summary>
	/// Gets or Sets QueueTotalDrops
	/// </summary>
	[DataMember(Name = "queueTotalDrops", EmitDefaultValue = false)]
	public int? QueueTotalDrops { get; set; }

	/// <summary>
	/// Gets or Sets RefreshedAt
	/// </summary>
	[DataMember(Name = "refreshedAt", EmitDefaultValue = false)]
	public int? RefreshedAt { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceQosStatistics {\n");
		sb.Append("  ClassMapName: ").Append(ClassMapName).Append("\n");
		sb.Append("  DropRate: ").Append(DropRate).Append("\n");
		sb.Append("  NumBytes: ").Append(NumBytes).Append("\n");
		sb.Append("  NumPackets: ").Append(NumPackets).Append("\n");
		sb.Append("  OfferedRate: ").Append(OfferedRate).Append("\n");
		sb.Append("  QueueBandwidthbps: ").Append(QueueBandwidthbps).Append("\n");
		sb.Append("  QueueDepth: ").Append(QueueDepth).Append("\n");
		sb.Append("  QueueNoBufferDrops: ").Append(QueueNoBufferDrops).Append("\n");
		sb.Append("  QueueTotalDrops: ").Append(QueueTotalDrops).Append("\n");
		sb.Append("  RefreshedAt: ").Append(RefreshedAt).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
