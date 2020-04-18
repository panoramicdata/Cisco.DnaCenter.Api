using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientDetailResponseConnectionInfo
	/// </summary>
	[DataContract]
	public class GetClientDetailResponseConnectionInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientDetailResponseConnectionInfo" /> class.
		/// </summary>
		/// <param name="HostType">HostType.</param>
		/// <param name="NwDeviceName">NwDeviceName.</param>
		/// <param name="NwDeviceMac">NwDeviceMac.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="Band">Band.</param>
		/// <param name="SpatialStream">SpatialStream.</param>
		/// <param name="Channel">Channel.</param>
		/// <param name="ChannelWidth">ChannelWidth.</param>
		/// <param name="Wmm">Wmm.</param>
		/// <param name="Uapsd">Uapsd.</param>
		/// <param name="Timestamp">Timestamp.</param>
		public GetClientDetailResponseConnectionInfo(string? HostType = default, string? NwDeviceName = default, string? NwDeviceMac = default, string? Protocol = default, string? Band = default, string? SpatialStream = default, string? Channel = default, string? ChannelWidth = default, string? Wmm = default, string? Uapsd = default, int? Timestamp = default)
		{
			this.HostType = HostType;
			this.NwDeviceName = NwDeviceName;
			this.NwDeviceMac = NwDeviceMac;
			this.Protocol = Protocol;
			this.Band = Band;
			this.SpatialStream = SpatialStream;
			this.Channel = Channel;
			this.ChannelWidth = ChannelWidth;
			this.Wmm = Wmm;
			this.Uapsd = Uapsd;
			this.Timestamp = Timestamp;
		}

		/// <summary>
		/// Gets or Sets HostType
		/// </summary>
		[DataMember(Name = "hostType", EmitDefaultValue = false)]
		public string? HostType { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceName
		/// </summary>
		[DataMember(Name = "nwDeviceName", EmitDefaultValue = false)]
		public string? NwDeviceName { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceMac
		/// </summary>
		[DataMember(Name = "nwDeviceMac", EmitDefaultValue = false)]
		public string? NwDeviceMac { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Gets or Sets Band
		/// </summary>
		[DataMember(Name = "band", EmitDefaultValue = false)]
		public string? Band { get; set; }
		/// <summary>
		/// Gets or Sets SpatialStream
		/// </summary>
		[DataMember(Name = "spatialStream", EmitDefaultValue = false)]
		public string? SpatialStream { get; set; }
		/// <summary>
		/// Gets or Sets Channel
		/// </summary>
		[DataMember(Name = "channel", EmitDefaultValue = false)]
		public string? Channel { get; set; }
		/// <summary>
		/// Gets or Sets ChannelWidth
		/// </summary>
		[DataMember(Name = "channelWidth", EmitDefaultValue = false)]
		public string? ChannelWidth { get; set; }
		/// <summary>
		/// Gets or Sets Wmm
		/// </summary>
		[DataMember(Name = "wmm", EmitDefaultValue = false)]
		public string? Wmm { get; set; }
		/// <summary>
		/// Gets or Sets Uapsd
		/// </summary>
		[DataMember(Name = "uapsd", EmitDefaultValue = false)]
		public string? Uapsd { get; set; }
		/// <summary>
		/// Gets or Sets Timestamp
		/// </summary>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public int? Timestamp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientDetailResponseConnectionInfo {\n");
			sb.Append("  HostType: ").Append(HostType).Append("\n");
			sb.Append("  NwDeviceName: ").Append(NwDeviceName).Append("\n");
			sb.Append("  NwDeviceMac: ").Append(NwDeviceMac).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  Band: ").Append(Band).Append("\n");
			sb.Append("  SpatialStream: ").Append(SpatialStream).Append("\n");
			sb.Append("  Channel: ").Append(Channel).Append("\n");
			sb.Append("  ChannelWidth: ").Append(ChannelWidth).Append("\n");
			sb.Append("  Wmm: ").Append(Wmm).Append("\n");
			sb.Append("  Uapsd: ").Append(Uapsd).Append("\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
