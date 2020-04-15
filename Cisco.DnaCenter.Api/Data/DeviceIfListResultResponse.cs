using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceIfListResultResponse
	/// </summary>
	[DataContract]
	public partial class DeviceIfListResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceIfListResultResponse" /> class.
		/// </summary>
		/// <param name="AdminStatus">AdminStatus.</param>
		/// <param name="ClassName">ClassName.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="Duplex">Duplex.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IfIndex">IfIndex.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="InterfaceType">InterfaceType.</param>
		/// <param name="Ipv4Address">Ipv4Address.</param>
		/// <param name="Ipv4Mask">Ipv4Mask.</param>
		/// <param name="IsisSupport">IsisSupport.</param>
		/// <param name="LastUpdated">LastUpdated.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="MappedPhysicalInterfaceId">MappedPhysicalInterfaceId.</param>
		/// <param name="MappedPhysicalInterfaceName">MappedPhysicalInterfaceName.</param>
		/// <param name="MediaType">MediaType.</param>
		/// <param name="NativeVlanId">NativeVlanId.</param>
		/// <param name="OspfSupport">OspfSupport.</param>
		/// <param name="Pid">Pid.</param>
		/// <param name="PortMode">PortMode.</param>
		/// <param name="PortName">PortName.</param>
		/// <param name="PortType">PortType.</param>
		/// <param name="SerialNo">SerialNo.</param>
		/// <param name="Series">Series.</param>
		/// <param name="Speed">Speed.</param>
		/// <param name="Status">Status.</param>
		/// <param name="VlanId">VlanId.</param>
		/// <param name="VoiceVlan">VoiceVlan.</param>
		public DeviceIfListResultResponse(string? AdminStatus = default, string? ClassName = default, string? Description = default, string? DeviceId = default, string? Duplex = default, string? Id = default, string? IfIndex = default, string? InstanceTenantId = default, string? InstanceUuid = default, string? InterfaceType = default, string? Ipv4Address = default, string? Ipv4Mask = default, string? IsisSupport = default, string? LastUpdated = default, string? MacAddress = default, string? MappedPhysicalInterfaceId = default, string? MappedPhysicalInterfaceName = default, string? MediaType = default, string? NativeVlanId = default, string? OspfSupport = default, string? Pid = default, string? PortMode = default, string? PortName = default, string? PortType = default, string? SerialNo = default, string? Series = default, string? Speed = default, string? Status = default, string? VlanId = default, string? VoiceVlan = default)
		{
			this.AdminStatus = AdminStatus;
			this.ClassName = ClassName;
			this.Description = Description;
			this.DeviceId = DeviceId;
			this.Duplex = Duplex;
			this.Id = Id;
			this.IfIndex = IfIndex;
			this.InstanceTenantId = InstanceTenantId;
			this.InstanceUuid = InstanceUuid;
			this.InterfaceType = InterfaceType;
			this.Ipv4Address = Ipv4Address;
			this.Ipv4Mask = Ipv4Mask;
			this.IsisSupport = IsisSupport;
			this.LastUpdated = LastUpdated;
			this.MacAddress = MacAddress;
			this.MappedPhysicalInterfaceId = MappedPhysicalInterfaceId;
			this.MappedPhysicalInterfaceName = MappedPhysicalInterfaceName;
			this.MediaType = MediaType;
			this.NativeVlanId = NativeVlanId;
			this.OspfSupport = OspfSupport;
			this.Pid = Pid;
			this.PortMode = PortMode;
			this.PortName = PortName;
			this.PortType = PortType;
			this.SerialNo = SerialNo;
			this.Series = Series;
			this.Speed = Speed;
			this.Status = Status;
			this.VlanId = VlanId;
			this.VoiceVlan = VoiceVlan;
		}

		/// <summary>
		/// Gets or Sets AdminStatus
		/// </summary>
		[DataMember(Name = "adminStatus", EmitDefaultValue = false)]
		public string? AdminStatus { get; set; }
		/// <summary>
		/// Gets or Sets ClassName
		/// </summary>
		[DataMember(Name = "className", EmitDefaultValue = false)]
		public string? ClassName { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets DeviceId
		/// </summary>
		[DataMember(Name = "deviceId", EmitDefaultValue = false)]
		public string? DeviceId { get; set; }
		/// <summary>
		/// Gets or Sets Duplex
		/// </summary>
		[DataMember(Name = "duplex", EmitDefaultValue = false)]
		public string? Duplex { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets IfIndex
		/// </summary>
		[DataMember(Name = "ifIndex", EmitDefaultValue = false)]
		public string? IfIndex { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }
		/// <summary>
		/// Gets or Sets InterfaceType
		/// </summary>
		[DataMember(Name = "interfaceType", EmitDefaultValue = false)]
		public string? InterfaceType { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4Address
		/// </summary>
		[DataMember(Name = "ipv4Address", EmitDefaultValue = false)]
		public string? Ipv4Address { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4Mask
		/// </summary>
		[DataMember(Name = "ipv4Mask", EmitDefaultValue = false)]
		public string? Ipv4Mask { get; set; }
		/// <summary>
		/// Gets or Sets IsisSupport
		/// </summary>
		[DataMember(Name = "isisSupport", EmitDefaultValue = false)]
		public string? IsisSupport { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdated
		/// </summary>
		[DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
		public string? LastUpdated { get; set; }
		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }
		/// <summary>
		/// Gets or Sets MappedPhysicalInterfaceId
		/// </summary>
		[DataMember(Name = "mappedPhysicalInterfaceId", EmitDefaultValue = false)]
		public string? MappedPhysicalInterfaceId { get; set; }
		/// <summary>
		/// Gets or Sets MappedPhysicalInterfaceName
		/// </summary>
		[DataMember(Name = "mappedPhysicalInterfaceName", EmitDefaultValue = false)]
		public string? MappedPhysicalInterfaceName { get; set; }
		/// <summary>
		/// Gets or Sets MediaType
		/// </summary>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public string? MediaType { get; set; }
		/// <summary>
		/// Gets or Sets NativeVlanId
		/// </summary>
		[DataMember(Name = "nativeVlanId", EmitDefaultValue = false)]
		public string? NativeVlanId { get; set; }
		/// <summary>
		/// Gets or Sets OspfSupport
		/// </summary>
		[DataMember(Name = "ospfSupport", EmitDefaultValue = false)]
		public string? OspfSupport { get; set; }
		/// <summary>
		/// Gets or Sets Pid
		/// </summary>
		[DataMember(Name = "pid", EmitDefaultValue = false)]
		public string? Pid { get; set; }
		/// <summary>
		/// Gets or Sets PortMode
		/// </summary>
		[DataMember(Name = "portMode", EmitDefaultValue = false)]
		public string? PortMode { get; set; }
		/// <summary>
		/// Gets or Sets PortName
		/// </summary>
		[DataMember(Name = "portName", EmitDefaultValue = false)]
		public string? PortName { get; set; }
		/// <summary>
		/// Gets or Sets PortType
		/// </summary>
		[DataMember(Name = "portType", EmitDefaultValue = false)]
		public string? PortType { get; set; }
		/// <summary>
		/// Gets or Sets SerialNo
		/// </summary>
		[DataMember(Name = "serialNo", EmitDefaultValue = false)]
		public string? SerialNo { get; set; }
		/// <summary>
		/// Gets or Sets Series
		/// </summary>
		[DataMember(Name = "series", EmitDefaultValue = false)]
		public string? Series { get; set; }
		/// <summary>
		/// Gets or Sets Speed
		/// </summary>
		[DataMember(Name = "speed", EmitDefaultValue = false)]
		public string? Speed { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets VlanId
		/// </summary>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public string? VlanId { get; set; }
		/// <summary>
		/// Gets or Sets VoiceVlan
		/// </summary>
		[DataMember(Name = "voiceVlan", EmitDefaultValue = false)]
		public string? VoiceVlan { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceIfListResultResponse {\n");
			sb.Append("  AdminStatus: ").Append(AdminStatus).Append("\n");
			sb.Append("  ClassName: ").Append(ClassName).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  Duplex: ").Append(Duplex).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IfIndex: ").Append(IfIndex).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("  InterfaceType: ").Append(InterfaceType).Append("\n");
			sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
			sb.Append("  Ipv4Mask: ").Append(Ipv4Mask).Append("\n");
			sb.Append("  IsisSupport: ").Append(IsisSupport).Append("\n");
			sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  MappedPhysicalInterfaceId: ").Append(MappedPhysicalInterfaceId).Append("\n");
			sb.Append("  MappedPhysicalInterfaceName: ").Append(MappedPhysicalInterfaceName).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  NativeVlanId: ").Append(NativeVlanId).Append("\n");
			sb.Append("  OspfSupport: ").Append(OspfSupport).Append("\n");
			sb.Append("  Pid: ").Append(Pid).Append("\n");
			sb.Append("  PortMode: ").Append(PortMode).Append("\n");
			sb.Append("  PortName: ").Append(PortName).Append("\n");
			sb.Append("  PortType: ").Append(PortType).Append("\n");
			sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
			sb.Append("  Series: ").Append(Series).Append("\n");
			sb.Append("  Speed: ").Append(Speed).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  VlanId: ").Append(VlanId).Append("\n");
			sb.Append("  VoiceVlan: ").Append(VoiceVlan).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
