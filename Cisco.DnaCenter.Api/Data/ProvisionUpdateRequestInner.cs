using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionUpdateRequestInner
/// </summary>
[DataContract]
public class ProvisionUpdateRequestInner
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionUpdateRequestInner" /> class.
	/// </summary>
	/// <param name="DeviceName">DeviceName.</param>
	/// <param name="ManagedAPLocations">ManagedAPLocations.</param>
	/// <param name="DynamicInterfaces">DynamicInterfaces.</param>
	public ProvisionUpdateRequestInner(string? DeviceName = default, List<string> ManagedAPLocations = default, List<ProvisionRequestInnerDynamicInterfaces> DynamicInterfaces = default)
	{
		this.DeviceName = DeviceName;
		this.ManagedAPLocations = ManagedAPLocations;
		this.DynamicInterfaces = DynamicInterfaces;
	}

	/// <summary>
	/// Gets or Sets DeviceName
	/// </summary>
	[DataMember(Name = "deviceName", EmitDefaultValue = false)]
	public string? DeviceName { get; set; }

	/// <summary>
	/// Gets or Sets ManagedAPLocations
	/// </summary>
	[DataMember(Name = "managedAPLocations", EmitDefaultValue = false)]
	public List<string> ManagedAPLocations { get; set; }

	/// <summary>
	/// Gets or Sets DynamicInterfaces
	/// </summary>
	[DataMember(Name = "dynamicInterfaces", EmitDefaultValue = false)]
	public List<ProvisionRequestInnerDynamicInterfaces> DynamicInterfaces { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionUpdateRequestInner {\n");
		sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
		sb.Append("  ManagedAPLocations: ").Append(ManagedAPLocations).Append("\n");
		sb.Append("  DynamicInterfaces: ").Append(DynamicInterfaces).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
