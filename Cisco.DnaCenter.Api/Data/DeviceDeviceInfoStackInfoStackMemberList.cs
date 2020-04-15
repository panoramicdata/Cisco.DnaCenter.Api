using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoStackInfoStackMemberList
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoStackInfoStackMemberList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoStackInfoStackMemberList" /> class.
		/// </summary>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="State">State.</param>
		/// <param name="Role">Role.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="Pid">Pid.</param>
		/// <param name="LicenseLevel">LicenseLevel.</param>
		/// <param name="LicenseType">LicenseType.</param>
		/// <param name="SudiSerialNumber">SudiSerialNumber.</param>
		/// <param name="HardwareVersion">HardwareVersion.</param>
		/// <param name="StackNumber">StackNumber.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="Priority">Priority.</param>
		public DeviceDeviceInfoStackInfoStackMemberList(string? SerialNumber = default, string? State = default, string? Role = default, string? MacAddress = default, string? Pid = default, string? LicenseLevel = default, string? LicenseType = default, string? SudiSerialNumber = default, string? HardwareVersion = default, decimal? StackNumber = default, string? SoftwareVersion = default, decimal? Priority = default)
		{
			this.SerialNumber = SerialNumber;
			this.State = State;
			this.Role = Role;
			this.MacAddress = MacAddress;
			this.Pid = Pid;
			this.LicenseLevel = LicenseLevel;
			this.LicenseType = LicenseType;
			this.SudiSerialNumber = SudiSerialNumber;
			this.HardwareVersion = HardwareVersion;
			this.StackNumber = StackNumber;
			this.SoftwareVersion = SoftwareVersion;
			this.Priority = Priority;
		}

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
		public string? SerialNumber { get; set; }
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string? State { get; set; }
		/// <summary>
		/// Gets or Sets Role
		/// </summary>
		[DataMember(Name = "role", EmitDefaultValue = false)]
		public string? Role { get; set; }
		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }
		/// <summary>
		/// Gets or Sets Pid
		/// </summary>
		[DataMember(Name = "pid", EmitDefaultValue = false)]
		public string? Pid { get; set; }
		/// <summary>
		/// Gets or Sets LicenseLevel
		/// </summary>
		[DataMember(Name = "licenseLevel", EmitDefaultValue = false)]
		public string? LicenseLevel { get; set; }
		/// <summary>
		/// Gets or Sets LicenseType
		/// </summary>
		[DataMember(Name = "licenseType", EmitDefaultValue = false)]
		public string? LicenseType { get; set; }
		/// <summary>
		/// Gets or Sets SudiSerialNumber
		/// </summary>
		[DataMember(Name = "sudiSerialNumber", EmitDefaultValue = false)]
		public string? SudiSerialNumber { get; set; }
		/// <summary>
		/// Gets or Sets HardwareVersion
		/// </summary>
		[DataMember(Name = "hardwareVersion", EmitDefaultValue = false)]
		public string? HardwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets StackNumber
		/// </summary>
		[DataMember(Name = "stackNumber", EmitDefaultValue = false)]
		public decimal? StackNumber { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string? SoftwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets Priority
		/// </summary>
		[DataMember(Name = "priority", EmitDefaultValue = false)]
		public decimal? Priority { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoStackInfoStackMemberList {\n");
			sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Role: ").Append(Role).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  Pid: ").Append(Pid).Append("\n");
			sb.Append("  LicenseLevel: ").Append(LicenseLevel).Append("\n");
			sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
			sb.Append("  SudiSerialNumber: ").Append(SudiSerialNumber).Append("\n");
			sb.Append("  HardwareVersion: ").Append(HardwareVersion).Append("\n");
			sb.Append("  StackNumber: ").Append(StackNumber).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  Priority: ").Append(Priority).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
