using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestServiceProviders1
/// </summary>
[DataContract]
public class ProvisionNfvRequestServiceProviders1
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestServiceProviders1" /> class.
	/// </summary>
	/// <param name="ServiceProvider">ServiceProvider.</param>
	/// <param name="WanInterface">WanInterface.</param>
	public ProvisionNfvRequestServiceProviders1(string? ServiceProvider = default, ProvisionNfvRequestWanInterface WanInterface = default)
	{
		this.ServiceProvider = ServiceProvider;
		this.WanInterface = WanInterface;
	}

	/// <summary>
	/// Gets or Sets ServiceProvider
	/// </summary>
	[DataMember(Name = "serviceProvider", EmitDefaultValue = false)]
	public string? ServiceProvider { get; set; }

	/// <summary>
	/// Gets or Sets WanInterface
	/// </summary>
	[DataMember(Name = "wanInterface", EmitDefaultValue = false)]
	public ProvisionNfvRequestWanInterface WanInterface { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestServiceProviders1 {\n");
		sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
		sb.Append("  WanInterface: ").Append(WanInterface).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
