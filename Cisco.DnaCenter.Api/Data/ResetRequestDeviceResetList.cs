using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ResetRequestDeviceResetList
	/// </summary>
	[DataContract]
	public class ResetRequestDeviceResetList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetRequestDeviceResetList" /> class.
		/// </summary>
		/// <param name="ConfigList">ConfigList.</param>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="LicenseLevel">LicenseLevel.</param>
		/// <param name="LicenseType">LicenseType.</param>
		/// <param name="TopOfStackSerialNumber">TopOfStackSerialNumber.</param>
		public ResetRequestDeviceResetList(List<ResetRequestConfigList> ConfigList = default, string? DeviceId = default, string? LicenseLevel = default, string? LicenseType = default, string? TopOfStackSerialNumber = default)
		{
			this.ConfigList = ConfigList;
			this.DeviceId = DeviceId;
			this.LicenseLevel = LicenseLevel;
			this.LicenseType = LicenseType;
			this.TopOfStackSerialNumber = TopOfStackSerialNumber;
		}

		/// <summary>
		/// Gets or Sets ConfigList
		/// </summary>
		[DataMember(Name = "configList", EmitDefaultValue = false)]
		public List<ResetRequestConfigList> ConfigList { get; set; }
		/// <summary>
		/// Gets or Sets DeviceId
		/// </summary>
		[DataMember(Name = "deviceId", EmitDefaultValue = false)]
		public string? DeviceId { get; set; }
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
		/// Gets or Sets TopOfStackSerialNumber
		/// </summary>
		[DataMember(Name = "topOfStackSerialNumber", EmitDefaultValue = false)]
		public string? TopOfStackSerialNumber { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ResetRequestDeviceResetList {\n");
			sb.Append("  ConfigList: ").Append(ConfigList).Append("\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  LicenseLevel: ").Append(LicenseLevel).Append("\n");
			sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
			sb.Append("  TopOfStackSerialNumber: ").Append(TopOfStackSerialNumber).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
