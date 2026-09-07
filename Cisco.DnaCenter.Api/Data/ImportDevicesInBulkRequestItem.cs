using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// A single device in a bulk device import request.
/// </summary>
[DataContract]
public class ImportDevicesInBulkRequestItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ImportDevicesInBulkRequestItem" /> class.
	/// </summary>
	/// <param name="DeviceInfo">The device to import.</param>
	public ImportDevicesInBulkRequestItem(DeviceDeviceInfo? DeviceInfo)
	{
		this.DeviceInfo = DeviceInfo;
	}

	/// <summary>
	/// DeviceDeviceInfo
	/// </summary>
	[DataMember(Name = "deviceInfo", EmitDefaultValue = false)]
	public DeviceDeviceInfo? DeviceInfo { get; set; }
}
