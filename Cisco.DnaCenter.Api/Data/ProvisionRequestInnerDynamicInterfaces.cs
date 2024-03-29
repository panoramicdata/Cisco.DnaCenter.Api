using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionRequestInnerDynamicInterfaces
/// </summary>
[DataContract]
public class ProvisionRequestInnerDynamicInterfaces
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionRequestInnerDynamicInterfaces" /> class.
	/// </summary>
	/// <param name="InterfaceIpAddress">InterfaceIPAddress.</param>
	/// <param name="InterfaceNetmaskInCidr">InterfaceNetmaskInCIDR.</param>
	/// <param name="InterfaceGateway">InterfaceGateway.</param>
	/// <param name="LagOrPortNumber">LagOrPortNumber.</param>
	/// <param name="VlanId">VlanId.</param>
	/// <param name="InterfaceName">InterfaceName.</param>
	public ProvisionRequestInnerDynamicInterfaces(string? InterfaceIpAddress = default, int? InterfaceNetmaskInCidr = default, string? InterfaceGateway = default, int? LagOrPortNumber = default, int? VlanId = default, string? InterfaceName = default)
	{
		this.InterfaceIpAddress = InterfaceIpAddress;
		this.InterfaceNetmaskInCidr = InterfaceNetmaskInCidr;
		this.InterfaceGateway = InterfaceGateway;
		this.LagOrPortNumber = LagOrPortNumber;
		this.VlanId = VlanId;
		this.InterfaceName = InterfaceName;
	}

	/// <summary>
	/// Gets or Sets InterfaceIPAddress
	/// </summary>
	[DataMember(Name = "interfaceIPAddress", EmitDefaultValue = false)]
	public string? InterfaceIpAddress { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceNetmaskInCIDR
	/// </summary>
	[DataMember(Name = "interfaceNetmaskInCIDR", EmitDefaultValue = false)]
	public int? InterfaceNetmaskInCidr { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceGateway
	/// </summary>
	[DataMember(Name = "interfaceGateway", EmitDefaultValue = false)]
	public string? InterfaceGateway { get; set; }

	/// <summary>
	/// Gets or Sets LagOrPortNumber
	/// </summary>
	[DataMember(Name = "lagOrPortNumber", EmitDefaultValue = false)]
	public int? LagOrPortNumber { get; set; }

	/// <summary>
	/// Gets or Sets VlanId
	/// </summary>
	[DataMember(Name = "vlanId", EmitDefaultValue = false)]
	public int? VlanId { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceName
	/// </summary>
	[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
	public string? InterfaceName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionRequestInnerDynamicInterfaces {\n");
		sb.Append("  InterfaceIPAddress: ").Append(InterfaceIpAddress).Append("\n");
		sb.Append("  InterfaceNetmaskInCIDR: ").Append(InterfaceNetmaskInCidr).Append("\n");
		sb.Append("  InterfaceGateway: ").Append(InterfaceGateway).Append("\n");
		sb.Append("  LagOrPortNumber: ").Append(LagOrPortNumber).Append("\n");
		sb.Append("  VlanId: ").Append(VlanId).Append("\n");
		sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
