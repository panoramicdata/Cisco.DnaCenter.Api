using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceDetailResponseResponse
	/// </summary>
	[DataContract]
	public partial class GetDeviceDetailResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailResponseResponse" /> class.
		/// </summary>
		/// <param name="HALastResetReason">HALastResetReason.</param>
		/// <param name="ManagementIpAddr">ManagementIpAddr.</param>
		/// <param name="HAPrimaryPowerStatus">HAPrimaryPowerStatus.</param>
		/// <param name="RedundancyMode">RedundancyMode.</param>
		/// <param name="CommunicationState">CommunicationState.</param>
		/// <param name="NwDeviceName">NwDeviceName.</param>
		/// <param name="RedundancyUnit">RedundancyUnit.</param>
		/// <param name="PlatformId">PlatformId.</param>
		/// <param name="RedundancyPeerState">RedundancyPeerState.</param>
		/// <param name="NwDeviceId">NwDeviceId.</param>
		/// <param name="RedundancyState">RedundancyState.</param>
		/// <param name="NwDeviceRole">NwDeviceRole.</param>
		/// <param name="NwDeviceFamily">NwDeviceFamily.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="CollectionStatus">CollectionStatus.</param>
		/// <param name="DeviceSeries">DeviceSeries.</param>
		/// <param name="OsType">OsType.</param>
		/// <param name="ClientCount">ClientCount.</param>
		/// <param name="HASecondaryPowerStatus">HASecondaryPowerStatus.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="NwDeviceType">NwDeviceType.</param>
		/// <param name="OverallHealth">OverallHealth.</param>
		/// <param name="MemoryScore">MemoryScore.</param>
		/// <param name="CpuScore">CpuScore.</param>
		/// <param name="NoiseScore">NoiseScore.</param>
		/// <param name="UtilizationScore">UtilizationScore.</param>
		/// <param name="AirQualityScore">AirQualityScore.</param>
		/// <param name="InterferenceScore">InterferenceScore.</param>
		/// <param name="WqeScore">WqeScore.</param>
		/// <param name="FreeMbufScore">FreeMbufScore.</param>
		/// <param name="PacketPoolScore">PacketPoolScore.</param>
		/// <param name="FreeTimerScore">FreeTimerScore.</param>
		/// <param name="Memory">Memory.</param>
		/// <param name="Cpu">Cpu.</param>
		/// <param name="Noise">Noise.</param>
		/// <param name="Utilization">Utilization.</param>
		/// <param name="AirQuality">AirQuality.</param>
		/// <param name="Interference">Interference.</param>
		/// <param name="Wqe">Wqe.</param>
		/// <param name="FreeMbuf">FreeMbuf.</param>
		/// <param name="PacketPool">PacketPool.</param>
		/// <param name="FreeTimer">FreeTimer.</param>
		/// <param name="Location">Location.</param>
		/// <param name="Timestamp">Timestamp.</param>
		public GetDeviceDetailResponseResponse(string? HALastResetReason = default, string? ManagementIpAddr = default, string? HAPrimaryPowerStatus = default, string? RedundancyMode = default, string? CommunicationState = default, string? NwDeviceName = default, string? RedundancyUnit = default, string? PlatformId = default, string? RedundancyPeerState = default, string? NwDeviceId = default, string? RedundancyState = default, string? NwDeviceRole = default, string? NwDeviceFamily = default, string? MacAddress = default, string? CollectionStatus = default, string? DeviceSeries = default, string? OsType = default, string? ClientCount = default, string? HASecondaryPowerStatus = default, string? SoftwareVersion = default, string? NwDeviceType = default, int? OverallHealth = default, int? MemoryScore = default, int? CpuScore = default, int? NoiseScore = default, int? UtilizationScore = default, int? AirQualityScore = default, int? InterferenceScore = default, int? WqeScore = default, int? FreeMbufScore = default, int? PacketPoolScore = default, int? FreeTimerScore = default, string? Memory = default, string? Cpu = default, string? Noise = default, string? Utilization = default, string? AirQuality = default, string? Interference = default, string? Wqe = default, string? FreeMbuf = default, string? PacketPool = default, string? FreeTimer = default, string? Location = default, string? Timestamp = default)
		{
			this.HALastResetReason = HALastResetReason;
			this.ManagementIpAddr = ManagementIpAddr;
			this.HAPrimaryPowerStatus = HAPrimaryPowerStatus;
			this.RedundancyMode = RedundancyMode;
			this.CommunicationState = CommunicationState;
			this.NwDeviceName = NwDeviceName;
			this.RedundancyUnit = RedundancyUnit;
			this.PlatformId = PlatformId;
			this.RedundancyPeerState = RedundancyPeerState;
			this.NwDeviceId = NwDeviceId;
			this.RedundancyState = RedundancyState;
			this.NwDeviceRole = NwDeviceRole;
			this.NwDeviceFamily = NwDeviceFamily;
			this.MacAddress = MacAddress;
			this.CollectionStatus = CollectionStatus;
			this.DeviceSeries = DeviceSeries;
			this.OsType = OsType;
			this.ClientCount = ClientCount;
			this.HASecondaryPowerStatus = HASecondaryPowerStatus;
			this.SoftwareVersion = SoftwareVersion;
			this.NwDeviceType = NwDeviceType;
			this.OverallHealth = OverallHealth;
			this.MemoryScore = MemoryScore;
			this.CpuScore = CpuScore;
			this.NoiseScore = NoiseScore;
			this.UtilizationScore = UtilizationScore;
			this.AirQualityScore = AirQualityScore;
			this.InterferenceScore = InterferenceScore;
			this.WqeScore = WqeScore;
			this.FreeMbufScore = FreeMbufScore;
			this.PacketPoolScore = PacketPoolScore;
			this.FreeTimerScore = FreeTimerScore;
			this.Memory = Memory;
			this.Cpu = Cpu;
			this.Noise = Noise;
			this.Utilization = Utilization;
			this.AirQuality = AirQuality;
			this.Interference = Interference;
			this.Wqe = Wqe;
			this.FreeMbuf = FreeMbuf;
			this.PacketPool = PacketPool;
			this.FreeTimer = FreeTimer;
			this.Location = Location;
			this.Timestamp = Timestamp;
		}

		/// <summary>
		/// Gets or Sets HALastResetReason
		/// </summary>
		[DataMember(Name = "HALastResetReason", EmitDefaultValue = false)]
		public string? HALastResetReason { get; set; }
		/// <summary>
		/// Gets or Sets ManagementIpAddr
		/// </summary>
		[DataMember(Name = "managementIpAddr", EmitDefaultValue = false)]
		public string? ManagementIpAddr { get; set; }
		/// <summary>
		/// Gets or Sets HAPrimaryPowerStatus
		/// </summary>
		[DataMember(Name = "HAPrimaryPowerStatus", EmitDefaultValue = false)]
		public string? HAPrimaryPowerStatus { get; set; }
		/// <summary>
		/// Gets or Sets RedundancyMode
		/// </summary>
		[DataMember(Name = "redundancyMode", EmitDefaultValue = false)]
		public string? RedundancyMode { get; set; }
		/// <summary>
		/// Gets or Sets CommunicationState
		/// </summary>
		[DataMember(Name = "communicationState", EmitDefaultValue = false)]
		public string? CommunicationState { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceName
		/// </summary>
		[DataMember(Name = "nwDeviceName", EmitDefaultValue = false)]
		public string? NwDeviceName { get; set; }
		/// <summary>
		/// Gets or Sets RedundancyUnit
		/// </summary>
		[DataMember(Name = "redundancyUnit", EmitDefaultValue = false)]
		public string? RedundancyUnit { get; set; }
		/// <summary>
		/// Gets or Sets PlatformId
		/// </summary>
		[DataMember(Name = "platformId", EmitDefaultValue = false)]
		public string? PlatformId { get; set; }
		/// <summary>
		/// Gets or Sets RedundancyPeerState
		/// </summary>
		[DataMember(Name = "redundancyPeerState", EmitDefaultValue = false)]
		public string? RedundancyPeerState { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceId
		/// </summary>
		[DataMember(Name = "nwDeviceId", EmitDefaultValue = false)]
		public string? NwDeviceId { get; set; }
		/// <summary>
		/// Gets or Sets RedundancyState
		/// </summary>
		[DataMember(Name = "redundancyState", EmitDefaultValue = false)]
		public string? RedundancyState { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceRole
		/// </summary>
		[DataMember(Name = "nwDeviceRole", EmitDefaultValue = false)]
		public string? NwDeviceRole { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceFamily
		/// </summary>
		[DataMember(Name = "nwDeviceFamily", EmitDefaultValue = false)]
		public string? NwDeviceFamily { get; set; }
		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }
		/// <summary>
		/// Gets or Sets CollectionStatus
		/// </summary>
		[DataMember(Name = "collectionStatus", EmitDefaultValue = false)]
		public string? CollectionStatus { get; set; }
		/// <summary>
		/// Gets or Sets DeviceSeries
		/// </summary>
		[DataMember(Name = "deviceSeries", EmitDefaultValue = false)]
		public string? DeviceSeries { get; set; }
		/// <summary>
		/// Gets or Sets OsType
		/// </summary>
		[DataMember(Name = "osType", EmitDefaultValue = false)]
		public string? OsType { get; set; }
		/// <summary>
		/// Gets or Sets ClientCount
		/// </summary>
		[DataMember(Name = "clientCount", EmitDefaultValue = false)]
		public string? ClientCount { get; set; }
		/// <summary>
		/// Gets or Sets HASecondaryPowerStatus
		/// </summary>
		[DataMember(Name = "HASecondaryPowerStatus", EmitDefaultValue = false)]
		public string? HASecondaryPowerStatus { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string? SoftwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets NwDeviceType
		/// </summary>
		[DataMember(Name = "nwDeviceType", EmitDefaultValue = false)]
		public string? NwDeviceType { get; set; }
		/// <summary>
		/// Gets or Sets OverallHealth
		/// </summary>
		[DataMember(Name = "overallHealth", EmitDefaultValue = false)]
		public int? OverallHealth { get; set; }
		/// <summary>
		/// Gets or Sets MemoryScore
		/// </summary>
		[DataMember(Name = "memoryScore", EmitDefaultValue = false)]
		public int? MemoryScore { get; set; }
		/// <summary>
		/// Gets or Sets CpuScore
		/// </summary>
		[DataMember(Name = "cpuScore", EmitDefaultValue = false)]
		public int? CpuScore { get; set; }
		/// <summary>
		/// Gets or Sets NoiseScore
		/// </summary>
		[DataMember(Name = "noiseScore", EmitDefaultValue = false)]
		public int? NoiseScore { get; set; }
		/// <summary>
		/// Gets or Sets UtilizationScore
		/// </summary>
		[DataMember(Name = "utilizationScore", EmitDefaultValue = false)]
		public int? UtilizationScore { get; set; }
		/// <summary>
		/// Gets or Sets AirQualityScore
		/// </summary>
		[DataMember(Name = "airQualityScore", EmitDefaultValue = false)]
		public int? AirQualityScore { get; set; }
		/// <summary>
		/// Gets or Sets InterferenceScore
		/// </summary>
		[DataMember(Name = "interferenceScore", EmitDefaultValue = false)]
		public int? InterferenceScore { get; set; }
		/// <summary>
		/// Gets or Sets WqeScore
		/// </summary>
		[DataMember(Name = "wqeScore", EmitDefaultValue = false)]
		public int? WqeScore { get; set; }
		/// <summary>
		/// Gets or Sets FreeMbufScore
		/// </summary>
		[DataMember(Name = "freeMbufScore", EmitDefaultValue = false)]
		public int? FreeMbufScore { get; set; }
		/// <summary>
		/// Gets or Sets PacketPoolScore
		/// </summary>
		[DataMember(Name = "packetPoolScore", EmitDefaultValue = false)]
		public int? PacketPoolScore { get; set; }
		/// <summary>
		/// Gets or Sets FreeTimerScore
		/// </summary>
		[DataMember(Name = "freeTimerScore", EmitDefaultValue = false)]
		public int? FreeTimerScore { get; set; }
		/// <summary>
		/// Gets or Sets Memory
		/// </summary>
		[DataMember(Name = "memory", EmitDefaultValue = false)]
		public string? Memory { get; set; }
		/// <summary>
		/// Gets or Sets Cpu
		/// </summary>
		[DataMember(Name = "cpu", EmitDefaultValue = false)]
		public string? Cpu { get; set; }
		/// <summary>
		/// Gets or Sets Noise
		/// </summary>
		[DataMember(Name = "noise", EmitDefaultValue = false)]
		public string? Noise { get; set; }
		/// <summary>
		/// Gets or Sets Utilization
		/// </summary>
		[DataMember(Name = "utilization", EmitDefaultValue = false)]
		public string? Utilization { get; set; }
		/// <summary>
		/// Gets or Sets AirQuality
		/// </summary>
		[DataMember(Name = "airQuality", EmitDefaultValue = false)]
		public string? AirQuality { get; set; }
		/// <summary>
		/// Gets or Sets Interference
		/// </summary>
		[DataMember(Name = "interference", EmitDefaultValue = false)]
		public string? Interference { get; set; }
		/// <summary>
		/// Gets or Sets Wqe
		/// </summary>
		[DataMember(Name = "wqe", EmitDefaultValue = false)]
		public string? Wqe { get; set; }
		/// <summary>
		/// Gets or Sets FreeMbuf
		/// </summary>
		[DataMember(Name = "freeMbuf", EmitDefaultValue = false)]
		public string? FreeMbuf { get; set; }
		/// <summary>
		/// Gets or Sets PacketPool
		/// </summary>
		[DataMember(Name = "packetPool", EmitDefaultValue = false)]
		public string? PacketPool { get; set; }
		/// <summary>
		/// Gets or Sets FreeTimer
		/// </summary>
		[DataMember(Name = "freeTimer", EmitDefaultValue = false)]
		public string? FreeTimer { get; set; }
		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public string? Location { get; set; }
		/// <summary>
		/// Gets or Sets Timestamp
		/// </summary>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public string? Timestamp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceDetailResponseResponse {\n");
			sb.Append("  HALastResetReason: ").Append(HALastResetReason).Append("\n");
			sb.Append("  ManagementIpAddr: ").Append(ManagementIpAddr).Append("\n");
			sb.Append("  HAPrimaryPowerStatus: ").Append(HAPrimaryPowerStatus).Append("\n");
			sb.Append("  RedundancyMode: ").Append(RedundancyMode).Append("\n");
			sb.Append("  CommunicationState: ").Append(CommunicationState).Append("\n");
			sb.Append("  NwDeviceName: ").Append(NwDeviceName).Append("\n");
			sb.Append("  RedundancyUnit: ").Append(RedundancyUnit).Append("\n");
			sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
			sb.Append("  RedundancyPeerState: ").Append(RedundancyPeerState).Append("\n");
			sb.Append("  NwDeviceId: ").Append(NwDeviceId).Append("\n");
			sb.Append("  RedundancyState: ").Append(RedundancyState).Append("\n");
			sb.Append("  NwDeviceRole: ").Append(NwDeviceRole).Append("\n");
			sb.Append("  NwDeviceFamily: ").Append(NwDeviceFamily).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  CollectionStatus: ").Append(CollectionStatus).Append("\n");
			sb.Append("  DeviceSeries: ").Append(DeviceSeries).Append("\n");
			sb.Append("  OsType: ").Append(OsType).Append("\n");
			sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
			sb.Append("  HASecondaryPowerStatus: ").Append(HASecondaryPowerStatus).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  NwDeviceType: ").Append(NwDeviceType).Append("\n");
			sb.Append("  OverallHealth: ").Append(OverallHealth).Append("\n");
			sb.Append("  MemoryScore: ").Append(MemoryScore).Append("\n");
			sb.Append("  CpuScore: ").Append(CpuScore).Append("\n");
			sb.Append("  NoiseScore: ").Append(NoiseScore).Append("\n");
			sb.Append("  UtilizationScore: ").Append(UtilizationScore).Append("\n");
			sb.Append("  AirQualityScore: ").Append(AirQualityScore).Append("\n");
			sb.Append("  InterferenceScore: ").Append(InterferenceScore).Append("\n");
			sb.Append("  WqeScore: ").Append(WqeScore).Append("\n");
			sb.Append("  FreeMbufScore: ").Append(FreeMbufScore).Append("\n");
			sb.Append("  PacketPoolScore: ").Append(PacketPoolScore).Append("\n");
			sb.Append("  FreeTimerScore: ").Append(FreeTimerScore).Append("\n");
			sb.Append("  Memory: ").Append(Memory).Append("\n");
			sb.Append("  Cpu: ").Append(Cpu).Append("\n");
			sb.Append("  Noise: ").Append(Noise).Append("\n");
			sb.Append("  Utilization: ").Append(Utilization).Append("\n");
			sb.Append("  AirQuality: ").Append(AirQuality).Append("\n");
			sb.Append("  Interference: ").Append(Interference).Append("\n");
			sb.Append("  Wqe: ").Append(Wqe).Append("\n");
			sb.Append("  FreeMbuf: ").Append(FreeMbuf).Append("\n");
			sb.Append("  PacketPool: ").Append(PacketPool).Append("\n");
			sb.Append("  FreeTimer: ").Append(FreeTimer).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
