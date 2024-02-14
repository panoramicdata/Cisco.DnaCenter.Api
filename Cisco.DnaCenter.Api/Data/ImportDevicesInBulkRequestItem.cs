using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeviceDeviceInfo
/// </summary>
[DataContract]
public class ImportDevicesInBulkRequestItem
{
	public ImportDevicesInBulkRequestItem(DeviceDeviceInfo DeviceInfo)
	{
		this.DeviceInfo = DeviceInfo;
	}

	/// <summary>
	/// DeviceDeviceInfo
	/// </summary>
	[DataMember(Name = "deviceInfo", EmitDefaultValue = false)]
	public DeviceDeviceInfo DeviceInfo { get; set; }
}
