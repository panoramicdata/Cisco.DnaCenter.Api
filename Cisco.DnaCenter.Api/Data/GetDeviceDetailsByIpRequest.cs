namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetDeviceDetailsByIPRequest
/// </summary>
[DataContract]
public class GetDeviceDetailsByIpRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetDeviceDetailsByIpRequest" /> class.
	/// </summary>
	public GetDeviceDetailsByIpRequest() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="GetDeviceDetailsByIpRequest" /> class.
	/// </summary>
	/// <param name="DeviceIp">DeviceIp.</param>
	public GetDeviceDetailsByIpRequest(string? DeviceIp)
	{
		this.DeviceIp = DeviceIp;
	}

	/// <summary>
	/// Gets or Sets DeviceIp
	/// </summary>
	[DataMember(Name = "device_ip", EmitDefaultValue = false)]
	public string? DeviceIp { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetDeviceDetailsByIPRequest {\n");
		sb.Append("  DeviceIp: ").Append(DeviceIp).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
