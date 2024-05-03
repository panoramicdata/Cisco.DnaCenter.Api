namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ImportDevicesInBulkRequestItem
/// </summary>
[DataContract]
public class ImportDevicesInBulkRequestItem
{
	public ImportDevicesInBulkRequestItem(DeviceDeviceInfo DeviceInfo, DeviceDayZeroConfig? DeviceDayZeroConfig = null)
	{
		this.DeviceInfo = DeviceInfo;
		this.DayZeroConfig = DeviceDayZeroConfig;
	}

	/// <summary>
	/// DeviceDeviceInfo
	/// </summary>
	[DataMember(Name = "deviceInfo", EmitDefaultValue = false)]
	public DeviceDeviceInfo DeviceInfo { get; set; }

	/// <summary>
	/// DayZeroConfig
	/// </summary>
	[DataMember(Name = "dayZeroConfig", EmitDefaultValue = false)]
	public DeviceDayZeroConfig? DayZeroConfig { get; set; }
}
