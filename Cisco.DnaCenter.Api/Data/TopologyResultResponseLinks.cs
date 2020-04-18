using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TopologyResultResponseLinks
	/// </summary>
	[DataContract]
	public class TopologyResultResponseLinks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TopologyResultResponseLinks" /> class.
		/// </summary>
		/// <param name="AdditionalInfo">AdditionalInfo.</param>
		/// <param name="EndPortID">EndPortID.</param>
		/// <param name="EndPortIpv4Address">EndPortIpv4Address.</param>
		/// <param name="EndPortIpv4Mask">EndPortIpv4Mask.</param>
		/// <param name="EndPortName">EndPortName.</param>
		/// <param name="EndPortSpeed">EndPortSpeed.</param>
		/// <param name="GreyOut">GreyOut.</param>
		/// <param name="Id">Id.</param>
		/// <param name="LinkStatus">LinkStatus.</param>
		/// <param name="Source">Source.</param>
		/// <param name="StartPortID">StartPortID.</param>
		/// <param name="StartPortIpv4Address">StartPortIpv4Address.</param>
		/// <param name="StartPortIpv4Mask">StartPortIpv4Mask.</param>
		/// <param name="StartPortName">StartPortName.</param>
		/// <param name="StartPortSpeed">StartPortSpeed.</param>
		/// <param name="Tag">Tag.</param>
		/// <param name="Target">Target.</param>
		public TopologyResultResponseLinks(Object AdditionalInfo = default, string? EndPortID = default, string? EndPortIpv4Address = default, string? EndPortIpv4Mask = default, string? EndPortName = default, string? EndPortSpeed = default, bool? GreyOut = default, string? Id = default, string? LinkStatus = default, string? Source = default, string? StartPortID = default, string? StartPortIpv4Address = default, string? StartPortIpv4Mask = default, string? StartPortName = default, string? StartPortSpeed = default, string? Tag = default, string? Target = default)
		{
			this.AdditionalInfo = AdditionalInfo;
			this.EndPortID = EndPortID;
			this.EndPortIpv4Address = EndPortIpv4Address;
			this.EndPortIpv4Mask = EndPortIpv4Mask;
			this.EndPortName = EndPortName;
			this.EndPortSpeed = EndPortSpeed;
			this.GreyOut = GreyOut;
			this.Id = Id;
			this.LinkStatus = LinkStatus;
			this.Source = Source;
			this.StartPortID = StartPortID;
			this.StartPortIpv4Address = StartPortIpv4Address;
			this.StartPortIpv4Mask = StartPortIpv4Mask;
			this.StartPortName = StartPortName;
			this.StartPortSpeed = StartPortSpeed;
			this.Tag = Tag;
			this.Target = Target;
		}

		/// <summary>
		/// Gets or Sets AdditionalInfo
		/// </summary>
		[DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
		public Object AdditionalInfo { get; set; }
		/// <summary>
		/// Gets or Sets EndPortID
		/// </summary>
		[DataMember(Name = "endPortID", EmitDefaultValue = false)]
		public string? EndPortID { get; set; }
		/// <summary>
		/// Gets or Sets EndPortIpv4Address
		/// </summary>
		[DataMember(Name = "endPortIpv4Address", EmitDefaultValue = false)]
		public string? EndPortIpv4Address { get; set; }
		/// <summary>
		/// Gets or Sets EndPortIpv4Mask
		/// </summary>
		[DataMember(Name = "endPortIpv4Mask", EmitDefaultValue = false)]
		public string? EndPortIpv4Mask { get; set; }
		/// <summary>
		/// Gets or Sets EndPortName
		/// </summary>
		[DataMember(Name = "endPortName", EmitDefaultValue = false)]
		public string? EndPortName { get; set; }
		/// <summary>
		/// Gets or Sets EndPortSpeed
		/// </summary>
		[DataMember(Name = "endPortSpeed", EmitDefaultValue = false)]
		public string? EndPortSpeed { get; set; }
		/// <summary>
		/// Gets or Sets GreyOut
		/// </summary>
		[DataMember(Name = "greyOut", EmitDefaultValue = false)]
		public bool? GreyOut { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets LinkStatus
		/// </summary>
		[DataMember(Name = "linkStatus", EmitDefaultValue = false)]
		public string? LinkStatus { get; set; }
		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string? Source { get; set; }
		/// <summary>
		/// Gets or Sets StartPortID
		/// </summary>
		[DataMember(Name = "startPortID", EmitDefaultValue = false)]
		public string? StartPortID { get; set; }
		/// <summary>
		/// Gets or Sets StartPortIpv4Address
		/// </summary>
		[DataMember(Name = "startPortIpv4Address", EmitDefaultValue = false)]
		public string? StartPortIpv4Address { get; set; }
		/// <summary>
		/// Gets or Sets StartPortIpv4Mask
		/// </summary>
		[DataMember(Name = "startPortIpv4Mask", EmitDefaultValue = false)]
		public string? StartPortIpv4Mask { get; set; }
		/// <summary>
		/// Gets or Sets StartPortName
		/// </summary>
		[DataMember(Name = "startPortName", EmitDefaultValue = false)]
		public string? StartPortName { get; set; }
		/// <summary>
		/// Gets or Sets StartPortSpeed
		/// </summary>
		[DataMember(Name = "startPortSpeed", EmitDefaultValue = false)]
		public string? StartPortSpeed { get; set; }
		/// <summary>
		/// Gets or Sets Tag
		/// </summary>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string? Tag { get; set; }
		/// <summary>
		/// Gets or Sets Target
		/// </summary>
		[DataMember(Name = "target", EmitDefaultValue = false)]
		public string? Target { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TopologyResultResponseLinks {\n");
			sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
			sb.Append("  EndPortID: ").Append(EndPortID).Append("\n");
			sb.Append("  EndPortIpv4Address: ").Append(EndPortIpv4Address).Append("\n");
			sb.Append("  EndPortIpv4Mask: ").Append(EndPortIpv4Mask).Append("\n");
			sb.Append("  EndPortName: ").Append(EndPortName).Append("\n");
			sb.Append("  EndPortSpeed: ").Append(EndPortSpeed).Append("\n");
			sb.Append("  GreyOut: ").Append(GreyOut).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  LinkStatus: ").Append(LinkStatus).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  StartPortID: ").Append(StartPortID).Append("\n");
			sb.Append("  StartPortIpv4Address: ").Append(StartPortIpv4Address).Append("\n");
			sb.Append("  StartPortIpv4Mask: ").Append(StartPortIpv4Mask).Append("\n");
			sb.Append("  StartPortName: ").Append(StartPortName).Append("\n");
			sb.Append("  StartPortSpeed: ").Append(StartPortSpeed).Append("\n");
			sb.Append("  Tag: ").Append(Tag).Append("\n");
			sb.Append("  Target: ").Append(Target).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
