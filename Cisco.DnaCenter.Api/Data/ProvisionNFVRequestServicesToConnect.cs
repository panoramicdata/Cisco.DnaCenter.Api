namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestServicesToConnect
/// </summary>
[DataContract]
public class ProvisionNfvRequestServicesToConnect
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestServicesToConnect" /> class.
	/// </summary>
	public ProvisionNfvRequestServicesToConnect() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestServicesToConnect" /> class.
	/// </summary>
	/// <param name="Service">Service.</param>
	public ProvisionNfvRequestServicesToConnect(string? Service)
	{
		this.Service = Service;
	}

	/// <summary>
	/// Gets or Sets Service
	/// </summary>
	[DataMember(Name = "service", EmitDefaultValue = false)]
	public string? Service { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestServicesToConnect {\n");
		sb.Append("  Service: ").Append(Service).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
