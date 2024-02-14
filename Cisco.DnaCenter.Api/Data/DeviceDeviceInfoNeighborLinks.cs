using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeviceDeviceInfoNeighborLinks
/// </summary>
[DataContract]
public class DeviceDeviceInfoNeighborLinks
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeviceDeviceInfoNeighborLinks" /> class.
	/// </summary>
	/// <param name="LocalInterfaceName">LocalInterfaceName.</param>
	/// <param name="LocalShortInterfaceName">LocalShortInterfaceName.</param>
	/// <param name="LocalMacAddress">LocalMacAddress.</param>
	/// <param name="RemoteInterfaceName">RemoteInterfaceName.</param>
	/// <param name="RemoteShortInterfaceName">RemoteShortInterfaceName.</param>
	/// <param name="RemoteMacAddress">RemoteMacAddress.</param>
	/// <param name="RemoteDeviceName">RemoteDeviceName.</param>
	/// <param name="RemotePlatform">RemotePlatform.</param>
	/// <param name="RemoteVersion">RemoteVersion.</param>
	public DeviceDeviceInfoNeighborLinks(string? LocalInterfaceName = default, string? LocalShortInterfaceName = default, string? LocalMacAddress = default, string? RemoteInterfaceName = default, string? RemoteShortInterfaceName = default, string? RemoteMacAddress = default, string? RemoteDeviceName = default, string? RemotePlatform = default, string? RemoteVersion = default)
	{
		this.LocalInterfaceName = LocalInterfaceName;
		this.LocalShortInterfaceName = LocalShortInterfaceName;
		this.LocalMacAddress = LocalMacAddress;
		this.RemoteInterfaceName = RemoteInterfaceName;
		this.RemoteShortInterfaceName = RemoteShortInterfaceName;
		this.RemoteMacAddress = RemoteMacAddress;
		this.RemoteDeviceName = RemoteDeviceName;
		this.RemotePlatform = RemotePlatform;
		this.RemoteVersion = RemoteVersion;
	}

	/// <summary>
	/// Gets or Sets LocalInterfaceName
	/// </summary>
	[DataMember(Name = "localInterfaceName", EmitDefaultValue = false)]
	public string? LocalInterfaceName { get; set; }

	/// <summary>
	/// Gets or Sets LocalShortInterfaceName
	/// </summary>
	[DataMember(Name = "localShortInterfaceName", EmitDefaultValue = false)]
	public string? LocalShortInterfaceName { get; set; }

	/// <summary>
	/// Gets or Sets LocalMacAddress
	/// </summary>
	[DataMember(Name = "localMacAddress", EmitDefaultValue = false)]
	public string? LocalMacAddress { get; set; }

	/// <summary>
	/// Gets or Sets RemoteInterfaceName
	/// </summary>
	[DataMember(Name = "remoteInterfaceName", EmitDefaultValue = false)]
	public string? RemoteInterfaceName { get; set; }

	/// <summary>
	/// Gets or Sets RemoteShortInterfaceName
	/// </summary>
	[DataMember(Name = "remoteShortInterfaceName", EmitDefaultValue = false)]
	public string? RemoteShortInterfaceName { get; set; }

	/// <summary>
	/// Gets or Sets RemoteMacAddress
	/// </summary>
	[DataMember(Name = "remoteMacAddress", EmitDefaultValue = false)]
	public string? RemoteMacAddress { get; set; }

	/// <summary>
	/// Gets or Sets RemoteDeviceName
	/// </summary>
	[DataMember(Name = "remoteDeviceName", EmitDefaultValue = false)]
	public string? RemoteDeviceName { get; set; }

	/// <summary>
	/// Gets or Sets RemotePlatform
	/// </summary>
	[DataMember(Name = "remotePlatform", EmitDefaultValue = false)]
	public string? RemotePlatform { get; set; }

	/// <summary>
	/// Gets or Sets RemoteVersion
	/// </summary>
	[DataMember(Name = "remoteVersion", EmitDefaultValue = false)]
	public string? RemoteVersion { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeviceDeviceInfoNeighborLinks {\n");
		sb.Append("  LocalInterfaceName: ").Append(LocalInterfaceName).Append("\n");
		sb.Append("  LocalShortInterfaceName: ").Append(LocalShortInterfaceName).Append("\n");
		sb.Append("  LocalMacAddress: ").Append(LocalMacAddress).Append("\n");
		sb.Append("  RemoteInterfaceName: ").Append(RemoteInterfaceName).Append("\n");
		sb.Append("  RemoteShortInterfaceName: ").Append(RemoteShortInterfaceName).Append("\n");
		sb.Append("  RemoteMacAddress: ").Append(RemoteMacAddress).Append("\n");
		sb.Append("  RemoteDeviceName: ").Append(RemoteDeviceName).Append("\n");
		sb.Append("  RemotePlatform: ").Append(RemotePlatform).Append("\n");
		sb.Append("  RemoteVersion: ").Append(RemoteVersion).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
