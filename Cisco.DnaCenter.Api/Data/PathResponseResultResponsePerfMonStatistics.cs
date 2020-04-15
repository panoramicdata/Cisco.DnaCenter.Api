using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponsePerfMonStatistics
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponsePerfMonStatistics
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponsePerfMonStatistics" /> class.
		/// </summary>
		/// <param name="ByteRate">ByteRate.</param>
		/// <param name="DestIpAddress">DestIpAddress.</param>
		/// <param name="DestPort">DestPort.</param>
		/// <param name="InputInterface">InputInterface.</param>
		/// <param name="Ipv4DSCP">Ipv4DSCP.</param>
		/// <param name="Ipv4TTL">Ipv4TTL.</param>
		/// <param name="OutputInterface">OutputInterface.</param>
		/// <param name="PacketBytes">PacketBytes.</param>
		/// <param name="PacketCount">PacketCount.</param>
		/// <param name="PacketLoss">PacketLoss.</param>
		/// <param name="PacketLossPercentage">PacketLossPercentage.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="RefreshedAt">RefreshedAt.</param>
		/// <param name="RtpJitterMax">RtpJitterMax.</param>
		/// <param name="RtpJitterMean">RtpJitterMean.</param>
		/// <param name="RtpJitterMin">RtpJitterMin.</param>
		/// <param name="SourceIpAddress">SourceIpAddress.</param>
		/// <param name="SourcePort">SourcePort.</param>
		public PathResponseResultResponsePerfMonStatistics(int? ByteRate = default, string? DestIpAddress = default, string? DestPort = default, string? InputInterface = default, string? Ipv4DSCP = default, int? Ipv4TTL = default, string? OutputInterface = default, int? PacketBytes = default, int? PacketCount = default, int? PacketLoss = default, decimal? PacketLossPercentage = default, string? Protocol = default, int? RefreshedAt = default, int? RtpJitterMax = default, int? RtpJitterMean = default, int? RtpJitterMin = default, string? SourceIpAddress = default, string? SourcePort = default)
		{
			this.ByteRate = ByteRate;
			this.DestIpAddress = DestIpAddress;
			this.DestPort = DestPort;
			this.InputInterface = InputInterface;
			this.Ipv4DSCP = Ipv4DSCP;
			this.Ipv4TTL = Ipv4TTL;
			this.OutputInterface = OutputInterface;
			this.PacketBytes = PacketBytes;
			this.PacketCount = PacketCount;
			this.PacketLoss = PacketLoss;
			this.PacketLossPercentage = PacketLossPercentage;
			this.Protocol = Protocol;
			this.RefreshedAt = RefreshedAt;
			this.RtpJitterMax = RtpJitterMax;
			this.RtpJitterMean = RtpJitterMean;
			this.RtpJitterMin = RtpJitterMin;
			this.SourceIpAddress = SourceIpAddress;
			this.SourcePort = SourcePort;
		}

		/// <summary>
		/// Gets or Sets ByteRate
		/// </summary>
		[DataMember(Name = "byteRate", EmitDefaultValue = false)]
		public int? ByteRate { get; set; }
		/// <summary>
		/// Gets or Sets DestIpAddress
		/// </summary>
		[DataMember(Name = "destIpAddress", EmitDefaultValue = false)]
		public string? DestIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets DestPort
		/// </summary>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string? DestPort { get; set; }
		/// <summary>
		/// Gets or Sets InputInterface
		/// </summary>
		[DataMember(Name = "inputInterface", EmitDefaultValue = false)]
		public string? InputInterface { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4DSCP
		/// </summary>
		[DataMember(Name = "ipv4DSCP", EmitDefaultValue = false)]
		public string? Ipv4DSCP { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4TTL
		/// </summary>
		[DataMember(Name = "ipv4TTL", EmitDefaultValue = false)]
		public int? Ipv4TTL { get; set; }
		/// <summary>
		/// Gets or Sets OutputInterface
		/// </summary>
		[DataMember(Name = "outputInterface", EmitDefaultValue = false)]
		public string? OutputInterface { get; set; }
		/// <summary>
		/// Gets or Sets PacketBytes
		/// </summary>
		[DataMember(Name = "packetBytes", EmitDefaultValue = false)]
		public int? PacketBytes { get; set; }
		/// <summary>
		/// Gets or Sets PacketCount
		/// </summary>
		[DataMember(Name = "packetCount", EmitDefaultValue = false)]
		public int? PacketCount { get; set; }
		/// <summary>
		/// Gets or Sets PacketLoss
		/// </summary>
		[DataMember(Name = "packetLoss", EmitDefaultValue = false)]
		public int? PacketLoss { get; set; }
		/// <summary>
		/// Gets or Sets PacketLossPercentage
		/// </summary>
		[DataMember(Name = "packetLossPercentage", EmitDefaultValue = false)]
		public decimal? PacketLossPercentage { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Gets or Sets RefreshedAt
		/// </summary>
		[DataMember(Name = "refreshedAt", EmitDefaultValue = false)]
		public int? RefreshedAt { get; set; }
		/// <summary>
		/// Gets or Sets RtpJitterMax
		/// </summary>
		[DataMember(Name = "rtpJitterMax", EmitDefaultValue = false)]
		public int? RtpJitterMax { get; set; }
		/// <summary>
		/// Gets or Sets RtpJitterMean
		/// </summary>
		[DataMember(Name = "rtpJitterMean", EmitDefaultValue = false)]
		public int? RtpJitterMean { get; set; }
		/// <summary>
		/// Gets or Sets RtpJitterMin
		/// </summary>
		[DataMember(Name = "rtpJitterMin", EmitDefaultValue = false)]
		public int? RtpJitterMin { get; set; }
		/// <summary>
		/// Gets or Sets SourceIpAddress
		/// </summary>
		[DataMember(Name = "sourceIpAddress", EmitDefaultValue = false)]
		public string? SourceIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets SourcePort
		/// </summary>
		[DataMember(Name = "sourcePort", EmitDefaultValue = false)]
		public string? SourcePort { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponsePerfMonStatistics {\n");
			sb.Append("  ByteRate: ").Append(ByteRate).Append("\n");
			sb.Append("  DestIpAddress: ").Append(DestIpAddress).Append("\n");
			sb.Append("  DestPort: ").Append(DestPort).Append("\n");
			sb.Append("  InputInterface: ").Append(InputInterface).Append("\n");
			sb.Append("  Ipv4DSCP: ").Append(Ipv4DSCP).Append("\n");
			sb.Append("  Ipv4TTL: ").Append(Ipv4TTL).Append("\n");
			sb.Append("  OutputInterface: ").Append(OutputInterface).Append("\n");
			sb.Append("  PacketBytes: ").Append(PacketBytes).Append("\n");
			sb.Append("  PacketCount: ").Append(PacketCount).Append("\n");
			sb.Append("  PacketLoss: ").Append(PacketLoss).Append("\n");
			sb.Append("  PacketLossPercentage: ").Append(PacketLossPercentage).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  RefreshedAt: ").Append(RefreshedAt).Append("\n");
			sb.Append("  RtpJitterMax: ").Append(RtpJitterMax).Append("\n");
			sb.Append("  RtpJitterMean: ").Append(RtpJitterMean).Append("\n");
			sb.Append("  RtpJitterMin: ").Append(RtpJitterMin).Append("\n");
			sb.Append("  SourceIpAddress: ").Append(SourceIpAddress).Append("\n");
			sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
