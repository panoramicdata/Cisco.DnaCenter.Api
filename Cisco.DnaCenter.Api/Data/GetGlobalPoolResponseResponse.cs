using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetGlobalPoolResponseResponse
/// </summary>
[DataContract]
public class GetGlobalPoolResponseResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetGlobalPoolResponseResponse" /> class.
	/// </summary>
	/// <param name="IpPoolName">IpPoolName.</param>
	/// <param name="DhcpServerIps">DhcpServerIps.</param>
	/// <param name="Gateways">Gateways.</param>
	/// <param name="CreateTime">CreateTime.</param>
	/// <param name="LastUpdateTime">LastUpdateTime.</param>
	/// <param name="TotalIpAddressCount">TotalIpAddressCount.</param>
	/// <param name="UsedIpAddressCount">UsedIpAddressCount.</param>
	/// <param name="ParentUuid">ParentUuid.</param>
	/// <param name="Owner">Owner.</param>
	/// <param name="Shared">Shared.</param>
	/// <param name="Overlapping">Overlapping.</param>
	/// <param name="ConfigureExternalDhcp">ConfigureExternalDhcp.</param>
	/// <param name="UsedPercentage">UsedPercentage.</param>
	/// <param name="ClientOptions">ClientOptions.</param>
	/// <param name="DnsServerIps">DnsServerIps.</param>
	/// <param name="Context">Context.</param>
	/// <param name="Ipv6">Ipv6.</param>
	/// <param name="Id">Id.</param>
	/// <param name="IpPoolCidr">IpPoolCidr.</param>
	public GetGlobalPoolResponseResponse(string? IpPoolName = default, List<string> DhcpServerIps = default, List<string> Gateways = default, string? CreateTime = default, string? LastUpdateTime = default, string? TotalIpAddressCount = default, string? UsedIpAddressCount = default, string? ParentUuid = default, string? Owner = default, string? Shared = default, string? Overlapping = default, string? ConfigureExternalDhcp = default, string? UsedPercentage = default, Object ClientOptions = default, List<string> DnsServerIps = default, List<GetGlobalPoolResponseContext> Context = default, string? Ipv6 = default, string? Id = default, string? IpPoolCidr = default)
	{
		this.IpPoolName = IpPoolName;
		this.DhcpServerIps = DhcpServerIps;
		this.Gateways = Gateways;
		this.CreateTime = CreateTime;
		this.LastUpdateTime = LastUpdateTime;
		this.TotalIpAddressCount = TotalIpAddressCount;
		this.UsedIpAddressCount = UsedIpAddressCount;
		this.ParentUuid = ParentUuid;
		this.Owner = Owner;
		this.Shared = Shared;
		this.Overlapping = Overlapping;
		this.ConfigureExternalDhcp = ConfigureExternalDhcp;
		this.UsedPercentage = UsedPercentage;
		this.ClientOptions = ClientOptions;
		this.DnsServerIps = DnsServerIps;
		this.Context = Context;
		this.Ipv6 = Ipv6;
		this.Id = Id;
		this.IpPoolCidr = IpPoolCidr;
	}

	/// <summary>
	/// Gets or Sets IpPoolName
	/// </summary>
	[DataMember(Name = "ipPoolName", EmitDefaultValue = false)]
	public string? IpPoolName { get; set; }

	/// <summary>
	/// Gets or Sets DhcpServerIps
	/// </summary>
	[DataMember(Name = "dhcpServerIps", EmitDefaultValue = false)]
	public List<string> DhcpServerIps { get; set; }

	/// <summary>
	/// Gets or Sets Gateways
	/// </summary>
	[DataMember(Name = "gateways", EmitDefaultValue = false)]
	public List<string> Gateways { get; set; }

	/// <summary>
	/// Gets or Sets CreateTime
	/// </summary>
	[DataMember(Name = "createTime", EmitDefaultValue = false)]
	public string? CreateTime { get; set; }

	/// <summary>
	/// Gets or Sets LastUpdateTime
	/// </summary>
	[DataMember(Name = "lastUpdateTime", EmitDefaultValue = false)]
	public string? LastUpdateTime { get; set; }

	/// <summary>
	/// Gets or Sets TotalIpAddressCount
	/// </summary>
	[DataMember(Name = "totalIpAddressCount", EmitDefaultValue = false)]
	public string? TotalIpAddressCount { get; set; }

	/// <summary>
	/// Gets or Sets UsedIpAddressCount
	/// </summary>
	[DataMember(Name = "usedIpAddressCount", EmitDefaultValue = false)]
	public string? UsedIpAddressCount { get; set; }

	/// <summary>
	/// Gets or Sets ParentUuid
	/// </summary>
	[DataMember(Name = "parentUuid", EmitDefaultValue = false)]
	public string? ParentUuid { get; set; }

	/// <summary>
	/// Gets or Sets Owner
	/// </summary>
	[DataMember(Name = "owner", EmitDefaultValue = false)]
	public string? Owner { get; set; }

	/// <summary>
	/// Gets or Sets Shared
	/// </summary>
	[DataMember(Name = "shared", EmitDefaultValue = false)]
	public string? Shared { get; set; }

	/// <summary>
	/// Gets or Sets Overlapping
	/// </summary>
	[DataMember(Name = "overlapping", EmitDefaultValue = false)]
	public string? Overlapping { get; set; }

	/// <summary>
	/// Gets or Sets ConfigureExternalDhcp
	/// </summary>
	[DataMember(Name = "configureExternalDhcp", EmitDefaultValue = false)]
	public string? ConfigureExternalDhcp { get; set; }

	/// <summary>
	/// Gets or Sets UsedPercentage
	/// </summary>
	[DataMember(Name = "usedPercentage", EmitDefaultValue = false)]
	public string? UsedPercentage { get; set; }

	/// <summary>
	/// Gets or Sets ClientOptions
	/// </summary>
	[DataMember(Name = "clientOptions", EmitDefaultValue = false)]
	public Object ClientOptions { get; set; }

	/// <summary>
	/// Gets or Sets DnsServerIps
	/// </summary>
	[DataMember(Name = "dnsServerIps", EmitDefaultValue = false)]
	public List<string> DnsServerIps { get; set; }

	/// <summary>
	/// Gets or Sets Context
	/// </summary>
	[DataMember(Name = "context", EmitDefaultValue = false)]
	public List<GetGlobalPoolResponseContext> Context { get; set; }

	/// <summary>
	/// Gets or Sets Ipv6
	/// </summary>
	[DataMember(Name = "ipv6", EmitDefaultValue = false)]
	public string? Ipv6 { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets IpPoolCidr
	/// </summary>
	[DataMember(Name = "ipPoolCidr", EmitDefaultValue = false)]
	public string? IpPoolCidr { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetGlobalPoolResponseResponse {\n");
		sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
		sb.Append("  DhcpServerIps: ").Append(DhcpServerIps).Append("\n");
		sb.Append("  Gateways: ").Append(Gateways).Append("\n");
		sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
		sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
		sb.Append("  TotalIpAddressCount: ").Append(TotalIpAddressCount).Append("\n");
		sb.Append("  UsedIpAddressCount: ").Append(UsedIpAddressCount).Append("\n");
		sb.Append("  ParentUuid: ").Append(ParentUuid).Append("\n");
		sb.Append("  Owner: ").Append(Owner).Append("\n");
		sb.Append("  Shared: ").Append(Shared).Append("\n");
		sb.Append("  Overlapping: ").Append(Overlapping).Append("\n");
		sb.Append("  ConfigureExternalDhcp: ").Append(ConfigureExternalDhcp).Append("\n");
		sb.Append("  UsedPercentage: ").Append(UsedPercentage).Append("\n");
		sb.Append("  ClientOptions: ").Append(ClientOptions).Append("\n");
		sb.Append("  DnsServerIps: ").Append(DnsServerIps).Append("\n");
		sb.Append("  Context: ").Append(Context).Append("\n");
		sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  IpPoolCidr: ").Append(IpPoolCidr).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
