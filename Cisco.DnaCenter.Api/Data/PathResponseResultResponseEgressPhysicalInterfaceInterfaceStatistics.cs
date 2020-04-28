using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics" /> class.
		/// </summary>
		/// <param name="AdminStatus">AdminStatus.</param>
		/// <param name="InputPackets">InputPackets.</param>
		/// <param name="InputQueueCount">InputQueueCount.</param>
		/// <param name="InputQueueDrops">InputQueueDrops.</param>
		/// <param name="InputQueueFlushes">InputQueueFlushes.</param>
		/// <param name="InputQueueMaxDepth">InputQueueMaxDepth.</param>
		/// <param name="InputRatebps">InputRatebps.</param>
		/// <param name="OperationalStatus">OperationalStatus.</param>
		/// <param name="OutputDrop">OutputDrop.</param>
		/// <param name="OutputPackets">OutputPackets.</param>
		/// <param name="OutputQueueCount">OutputQueueCount.</param>
		/// <param name="OutputQueueDepth">OutputQueueDepth.</param>
		/// <param name="OutputRatebps">OutputRatebps.</param>
		/// <param name="RefreshedAt">RefreshedAt.</param>
		public PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics(string? AdminStatus = default, int? InputPackets = default, int? InputQueueCount = default, int? InputQueueDrops = default, int? InputQueueFlushes = default, int? InputQueueMaxDepth = default, int? InputRatebps = default, string? OperationalStatus = default, int? OutputDrop = default, int? OutputPackets = default, int? OutputQueueCount = default, int? OutputQueueDepth = default, int? OutputRatebps = default, int? RefreshedAt = default)
		{
			this.AdminStatus = AdminStatus;
			this.InputPackets = InputPackets;
			this.InputQueueCount = InputQueueCount;
			this.InputQueueDrops = InputQueueDrops;
			this.InputQueueFlushes = InputQueueFlushes;
			this.InputQueueMaxDepth = InputQueueMaxDepth;
			this.InputRatebps = InputRatebps;
			this.OperationalStatus = OperationalStatus;
			this.OutputDrop = OutputDrop;
			this.OutputPackets = OutputPackets;
			this.OutputQueueCount = OutputQueueCount;
			this.OutputQueueDepth = OutputQueueDepth;
			this.OutputRatebps = OutputRatebps;
			this.RefreshedAt = RefreshedAt;
		}

		/// <summary>
		/// Gets or Sets AdminStatus
		/// </summary>
		[DataMember(Name = "adminStatus", EmitDefaultValue = false)]
		public string? AdminStatus { get; set; }

		/// <summary>
		/// Gets or Sets InputPackets
		/// </summary>
		[DataMember(Name = "inputPackets", EmitDefaultValue = false)]
		public int? InputPackets { get; set; }

		/// <summary>
		/// Gets or Sets InputQueueCount
		/// </summary>
		[DataMember(Name = "inputQueueCount", EmitDefaultValue = false)]
		public int? InputQueueCount { get; set; }

		/// <summary>
		/// Gets or Sets InputQueueDrops
		/// </summary>
		[DataMember(Name = "inputQueueDrops", EmitDefaultValue = false)]
		public int? InputQueueDrops { get; set; }

		/// <summary>
		/// Gets or Sets InputQueueFlushes
		/// </summary>
		[DataMember(Name = "inputQueueFlushes", EmitDefaultValue = false)]
		public int? InputQueueFlushes { get; set; }

		/// <summary>
		/// Gets or Sets InputQueueMaxDepth
		/// </summary>
		[DataMember(Name = "inputQueueMaxDepth", EmitDefaultValue = false)]
		public int? InputQueueMaxDepth { get; set; }

		/// <summary>
		/// Gets or Sets InputRatebps
		/// </summary>
		[DataMember(Name = "inputRatebps", EmitDefaultValue = false)]
		public int? InputRatebps { get; set; }

		/// <summary>
		/// Gets or Sets OperationalStatus
		/// </summary>
		[DataMember(Name = "operationalStatus", EmitDefaultValue = false)]
		public string? OperationalStatus { get; set; }

		/// <summary>
		/// Gets or Sets OutputDrop
		/// </summary>
		[DataMember(Name = "outputDrop", EmitDefaultValue = false)]
		public int? OutputDrop { get; set; }

		/// <summary>
		/// Gets or Sets OutputPackets
		/// </summary>
		[DataMember(Name = "outputPackets", EmitDefaultValue = false)]
		public int? OutputPackets { get; set; }

		/// <summary>
		/// Gets or Sets OutputQueueCount
		/// </summary>
		[DataMember(Name = "outputQueueCount", EmitDefaultValue = false)]
		public int? OutputQueueCount { get; set; }

		/// <summary>
		/// Gets or Sets OutputQueueDepth
		/// </summary>
		[DataMember(Name = "outputQueueDepth", EmitDefaultValue = false)]
		public int? OutputQueueDepth { get; set; }

		/// <summary>
		/// Gets or Sets OutputRatebps
		/// </summary>
		[DataMember(Name = "outputRatebps", EmitDefaultValue = false)]
		public int? OutputRatebps { get; set; }

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
			sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceInterfaceStatistics {\n");
			sb.Append("  AdminStatus: ").Append(AdminStatus).Append("\n");
			sb.Append("  InputPackets: ").Append(InputPackets).Append("\n");
			sb.Append("  InputQueueCount: ").Append(InputQueueCount).Append("\n");
			sb.Append("  InputQueueDrops: ").Append(InputQueueDrops).Append("\n");
			sb.Append("  InputQueueFlushes: ").Append(InputQueueFlushes).Append("\n");
			sb.Append("  InputQueueMaxDepth: ").Append(InputQueueMaxDepth).Append("\n");
			sb.Append("  InputRatebps: ").Append(InputRatebps).Append("\n");
			sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
			sb.Append("  OutputDrop: ").Append(OutputDrop).Append("\n");
			sb.Append("  OutputPackets: ").Append(OutputPackets).Append("\n");
			sb.Append("  OutputQueueCount: ").Append(OutputQueueCount).Append("\n");
			sb.Append("  OutputQueueDepth: ").Append(OutputQueueDepth).Append("\n");
			sb.Append("  OutputRatebps: ").Append(OutputRatebps).Append("\n");
			sb.Append("  RefreshedAt: ").Append(RefreshedAt).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
