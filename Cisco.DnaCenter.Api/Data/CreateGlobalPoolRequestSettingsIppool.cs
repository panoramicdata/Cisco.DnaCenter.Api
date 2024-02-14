using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CreateGlobalPoolRequestSettingsIppool
/// </summary>
[DataContract]
public class CreateGlobalPoolRequestSettingsIppool
{
	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TypeEnum
	{

		/// <summary>
		/// Enum Generic for "Generic"
		/// </summary>
		[EnumMember(Value = "Generic")]
		Generic,

		/// <summary>
		/// Enum Tunnel for "Tunnel"
		/// </summary>
		[EnumMember(Value = "Tunnel")]
		Tunnel
	}

	/// <summary>
	/// Gets or Sets IpAddressSpace
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IpAddressSpaceEnum
	{

		/// <summary>
		/// Enum IPv4 for "IPv6 or IPv4"
		/// </summary>
		[EnumMember(Value = "IPv6 or IPv4")]
		IPv4
	}

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public TypeEnum? Type { get; set; }

	/// <summary>
	/// Gets or Sets IpAddressSpace
	/// </summary>
	[DataMember(Name = "IpAddressSpace", EmitDefaultValue = false)]
	public IpAddressSpaceEnum? IpAddressSpace { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="CreateGlobalPoolRequestSettingsIppool" /> class.
	/// </summary>
	/// <param name="IpPoolName">IpPoolName.</param>
	/// <param name="Type">Type.</param>
	/// <param name="IpPoolCidr">IpPoolCidr.</param>
	/// <param name="Gateway">Gateway.</param>
	/// <param name="DhcpServerIps">DhcpServerIps.</param>
	/// <param name="DnsServerIps">DnsServerIps.</param>
	/// <param name="IpAddressSpace">IpAddressSpace.</param>
	public CreateGlobalPoolRequestSettingsIppool(string? IpPoolName = default, TypeEnum? Type = default, string? IpPoolCidr = default, string? Gateway = default, List<string> DhcpServerIps = default, List<string> DnsServerIps = default, IpAddressSpaceEnum? IpAddressSpace = default)
	{
		this.IpPoolName = IpPoolName;
		this.Type = Type;
		this.IpPoolCidr = IpPoolCidr;
		this.Gateway = Gateway;
		this.DhcpServerIps = DhcpServerIps;
		this.DnsServerIps = DnsServerIps;
		this.IpAddressSpace = IpAddressSpace;
	}

	/// <summary>
	/// Gets or Sets IpPoolName
	/// </summary>
	[DataMember(Name = "ipPoolName", EmitDefaultValue = false)]
	public string? IpPoolName { get; set; }

	/// <summary>
	/// Gets or Sets IpPoolCidr
	/// </summary>
	[DataMember(Name = "ipPoolCidr", EmitDefaultValue = false)]
	public string? IpPoolCidr { get; set; }

	/// <summary>
	/// Gets or Sets Gateway
	/// </summary>
	[DataMember(Name = "gateway", EmitDefaultValue = false)]
	public string? Gateway { get; set; }

	/// <summary>
	/// Gets or Sets DhcpServerIps
	/// </summary>
	[DataMember(Name = "dhcpServerIps", EmitDefaultValue = false)]
	public List<string> DhcpServerIps { get; set; }

	/// <summary>
	/// Gets or Sets DnsServerIps
	/// </summary>
	[DataMember(Name = "dnsServerIps", EmitDefaultValue = false)]
	public List<string> DnsServerIps { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CreateGlobalPoolRequestSettingsIppool {\n");
		sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("  IpPoolCidr: ").Append(IpPoolCidr).Append("\n");
		sb.Append("  Gateway: ").Append(Gateway).Append("\n");
		sb.Append("  DhcpServerIps: ").Append(DhcpServerIps).Append("\n");
		sb.Append("  DnsServerIps: ").Append(DnsServerIps).Append("\n");
		sb.Append("  IpAddressSpace: ").Append(IpAddressSpace).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
