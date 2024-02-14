using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestWanInterface
/// </summary>
[DataContract]
public class ProvisionNfvRequestWanInterface
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestWanInterface" /> class.
	/// </summary>
	/// <param name="IpAddress">IpAddress.</param>
	/// <param name="InterfaceName">InterfaceName.</param>
	/// <param name="Subnetmask">Subnetmask.</param>
	/// <param name="Bandwidth">Bandwidth.</param>
	/// <param name="Gateway">Gateway.</param>
	public ProvisionNfvRequestWanInterface(string? IpAddress = default, string? InterfaceName = default, string? Subnetmask = default, string? Bandwidth = default, string? Gateway = default)
	{
		this.IpAddress = IpAddress;
		this.InterfaceName = InterfaceName;
		this.Subnetmask = Subnetmask;
		this.Bandwidth = Bandwidth;
		this.Gateway = Gateway;
	}

	/// <summary>
	/// Gets or Sets IpAddress
	/// </summary>
	[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
	public string? IpAddress { get; set; }

	/// <summary>
	/// Gets or Sets InterfaceName
	/// </summary>
	[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
	public string? InterfaceName { get; set; }

	/// <summary>
	/// Gets or Sets Subnetmask
	/// </summary>
	[DataMember(Name = "subnetmask", EmitDefaultValue = false)]
	public string? Subnetmask { get; set; }

	/// <summary>
	/// Gets or Sets Bandwidth
	/// </summary>
	[DataMember(Name = "bandwidth", EmitDefaultValue = false)]
	public string? Bandwidth { get; set; }

	/// <summary>
	/// Gets or Sets Gateway
	/// </summary>
	[DataMember(Name = "gateway", EmitDefaultValue = false)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestWanInterface {\n");
		sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
		sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
		sb.Append("  Subnetmask: ").Append(Subnetmask).Append("\n");
		sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
		sb.Append("  Gateway: ").Append(Gateway).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
