using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetPnpGlobalSettingsResponseDefaultProfile
/// </summary>
[DataContract]
public class GetPnpGlobalSettingsResponseDefaultProfile
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetPnpGlobalSettingsResponseDefaultProfile" /> class.
	/// </summary>
	/// <param name="FqdnAddresses">FqdnAddresses.</param>
	/// <param name="Proxy">Proxy.</param>
	/// <param name="Cert">Cert.</param>
	/// <param name="IpAddresses">IpAddresses.</param>
	/// <param name="Port">Port.</param>
	public GetPnpGlobalSettingsResponseDefaultProfile(List<string> FqdnAddresses = default, bool? Proxy = default, string? Cert = default, List<string> IpAddresses = default, decimal? Port = default)
	{
		this.FqdnAddresses = FqdnAddresses;
		this.Proxy = Proxy;
		this.Cert = Cert;
		this.IpAddresses = IpAddresses;
		this.Port = Port;
	}

	/// <summary>
	/// Gets or Sets FqdnAddresses
	/// </summary>
	[DataMember(Name = "fqdnAddresses", EmitDefaultValue = false)]
	public List<string> FqdnAddresses { get; set; }

	/// <summary>
	/// Gets or Sets Proxy
	/// </summary>
	[DataMember(Name = "proxy", EmitDefaultValue = false)]
	public bool? Proxy { get; set; }

	/// <summary>
	/// Gets or Sets Cert
	/// </summary>
	[DataMember(Name = "cert", EmitDefaultValue = false)]
	public string? Cert { get; set; }

	/// <summary>
	/// Gets or Sets IpAddresses
	/// </summary>
	[DataMember(Name = "ipAddresses", EmitDefaultValue = false)]
	public List<string> IpAddresses { get; set; }

	/// <summary>
	/// Gets or Sets Port
	/// </summary>
	[DataMember(Name = "port", EmitDefaultValue = false)]
	public decimal? Port { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetPnpGlobalSettingsResponseDefaultProfile {\n");
		sb.Append("  FqdnAddresses: ").Append(FqdnAddresses).Append("\n");
		sb.Append("  Proxy: ").Append(Proxy).Append("\n");
		sb.Append("  Cert: ").Append(Cert).Append("\n");
		sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
		sb.Append("  Port: ").Append(Port).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
