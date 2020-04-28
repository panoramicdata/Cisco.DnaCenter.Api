using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo" /> class.
		/// </summary>
		/// <param name="ControlPlane">ControlPlane.</param>
		/// <param name="DataPacketEncapsulation">DataPacketEncapsulation.</param>
		/// <param name="DestIp">DestIp.</param>
		/// <param name="DestPort">DestPort.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="SourceIp">SourceIp.</param>
		/// <param name="SourcePort">SourcePort.</param>
		/// <param name="VxlanInfo">VxlanInfo.</param>
		public PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo(string? ControlPlane = default, string? DataPacketEncapsulation = default, string? DestIp = default, string? DestPort = default, string? Protocol = default, string? SourceIp = default, string? SourcePort = default, PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo VxlanInfo = default)
		{
			this.ControlPlane = ControlPlane;
			this.DataPacketEncapsulation = DataPacketEncapsulation;
			this.DestIp = DestIp;
			this.DestPort = DestPort;
			this.Protocol = Protocol;
			this.SourceIp = SourceIp;
			this.SourcePort = SourcePort;
			this.VxlanInfo = VxlanInfo;
		}

		/// <summary>
		/// Gets or Sets ControlPlane
		/// </summary>
		[DataMember(Name = "controlPlane", EmitDefaultValue = false)]
		public string? ControlPlane { get; set; }

		/// <summary>
		/// Gets or Sets DataPacketEncapsulation
		/// </summary>
		[DataMember(Name = "dataPacketEncapsulation", EmitDefaultValue = false)]
		public string? DataPacketEncapsulation { get; set; }

		/// <summary>
		/// Gets or Sets DestIp
		/// </summary>
		[DataMember(Name = "destIp", EmitDefaultValue = false)]
		public string? DestIp { get; set; }

		/// <summary>
		/// Gets or Sets DestPort
		/// </summary>
		[DataMember(Name = "destPort", EmitDefaultValue = false)]
		public string? DestPort { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }

		/// <summary>
		/// Gets or Sets SourceIp
		/// </summary>
		[DataMember(Name = "sourceIp", EmitDefaultValue = false)]
		public string? SourceIp { get; set; }

		/// <summary>
		/// Gets or Sets SourcePort
		/// </summary>
		[DataMember(Name = "sourcePort", EmitDefaultValue = false)]
		public string? SourcePort { get; set; }

		/// <summary>
		/// Gets or Sets VxlanInfo
		/// </summary>
		[DataMember(Name = "vxlanInfo", EmitDefaultValue = false)]
		public PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo VxlanInfo { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseEgressPhysicalInterfacePathOverlayInfo {\n");
			sb.Append("  ControlPlane: ").Append(ControlPlane).Append("\n");
			sb.Append("  DataPacketEncapsulation: ").Append(DataPacketEncapsulation).Append("\n");
			sb.Append("  DestIp: ").Append(DestIp).Append("\n");
			sb.Append("  DestPort: ").Append(DestPort).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
			sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
			sb.Append("  VxlanInfo: ").Append(VxlanInfo).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
