using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ActivateDtoInner
	/// </summary>
	[DataContract]
	public class ActivateDtoInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ActivateDtoInner" /> class.
		/// </summary>
		/// <param name="ActivateLowerImageVersion">ActivateLowerImageVersion.</param>
		/// <param name="DeviceUpgradeMode">DeviceUpgradeMode.</param>
		/// <param name="DeviceUuid">DeviceUuid.</param>
		/// <param name="DistributeIfNeeded">DistributeIfNeeded.</param>
		/// <param name="ImageUuidList">ImageUuidList.</param>
		/// <param name="SmuImageUuidList">SmuImageUuidList.</param>
		public ActivateDtoInner(bool? ActivateLowerImageVersion = default, string? DeviceUpgradeMode = default, string? DeviceUuid = default, bool? DistributeIfNeeded = default, List<string> ImageUuidList = default, List<string> SmuImageUuidList = default)
		{
			this.ActivateLowerImageVersion = ActivateLowerImageVersion;
			this.DeviceUpgradeMode = DeviceUpgradeMode;
			this.DeviceUuid = DeviceUuid;
			this.DistributeIfNeeded = DistributeIfNeeded;
			this.ImageUuidList = ImageUuidList;
			this.SmuImageUuidList = SmuImageUuidList;
		}

		/// <summary>
		/// Gets or Sets ActivateLowerImageVersion
		/// </summary>
		[DataMember(Name = "activateLowerImageVersion", EmitDefaultValue = false)]
		public bool? ActivateLowerImageVersion { get; set; }

		/// <summary>
		/// Gets or Sets DeviceUpgradeMode
		/// </summary>
		[DataMember(Name = "deviceUpgradeMode", EmitDefaultValue = false)]
		public string? DeviceUpgradeMode { get; set; }

		/// <summary>
		/// Gets or Sets DeviceUuid
		/// </summary>
		[DataMember(Name = "deviceUuid", EmitDefaultValue = false)]
		public string? DeviceUuid { get; set; }

		/// <summary>
		/// Gets or Sets DistributeIfNeeded
		/// </summary>
		[DataMember(Name = "distributeIfNeeded", EmitDefaultValue = false)]
		public bool? DistributeIfNeeded { get; set; }

		/// <summary>
		/// Gets or Sets ImageUuidList
		/// </summary>
		[DataMember(Name = "imageUuidList", EmitDefaultValue = false)]
		public List<string> ImageUuidList { get; set; }

		/// <summary>
		/// Gets or Sets SmuImageUuidList
		/// </summary>
		[DataMember(Name = "smuImageUuidList", EmitDefaultValue = false)]
		public List<string> SmuImageUuidList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActivateDtoInner {\n");
			sb.Append("  ActivateLowerImageVersion: ").Append(ActivateLowerImageVersion).Append("\n");
			sb.Append("  DeviceUpgradeMode: ").Append(DeviceUpgradeMode).Append("\n");
			sb.Append("  DeviceUuid: ").Append(DeviceUuid).Append("\n");
			sb.Append("  DistributeIfNeeded: ").Append(DistributeIfNeeded).Append("\n");
			sb.Append("  ImageUuidList: ").Append(ImageUuidList).Append("\n");
			sb.Append("  SmuImageUuidList: ").Append(SmuImageUuidList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
