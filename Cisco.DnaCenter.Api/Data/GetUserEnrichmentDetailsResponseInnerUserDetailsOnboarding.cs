using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetUserEnrichmentDetailsResponseInnerUserDetailsOnboarding
/// </summary>
[DataContract]
public class GetUserEnrichmentDetailsResponseInnerUserDetailsOnboarding
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetUserEnrichmentDetailsResponseInnerUserDetailsOnboarding" /> class.
	/// </summary>
	/// <param name="AverageRunDuration">AverageRunDuration.</param>
	/// <param name="MaxRunDuration">MaxRunDuration.</param>
	/// <param name="AverageAssocDuration">AverageAssocDuration.</param>
	/// <param name="MaxAssocDuration">MaxAssocDuration.</param>
	/// <param name="AverageAuthDuration">AverageAuthDuration.</param>
	/// <param name="MaxAuthDuration">MaxAuthDuration.</param>
	/// <param name="AverageDhcpDuration">AverageDhcpDuration.</param>
	/// <param name="MaxDhcpDuration">MaxDhcpDuration.</param>
	/// <param name="AaaServerIp">AaaServerIp.</param>
	/// <param name="DhcpServerIp">DhcpServerIp.</param>
	public GetUserEnrichmentDetailsResponseInnerUserDetailsOnboarding(Object AverageRunDuration = default, Object MaxRunDuration = default, Object AverageAssocDuration = default, Object MaxAssocDuration = default, Object AverageAuthDuration = default, Object MaxAuthDuration = default, Object AverageDhcpDuration = default, Object MaxDhcpDuration = default, Object AaaServerIp = default, Object DhcpServerIp = default)
	{
		this.AverageRunDuration = AverageRunDuration;
		this.MaxRunDuration = MaxRunDuration;
		this.AverageAssocDuration = AverageAssocDuration;
		this.MaxAssocDuration = MaxAssocDuration;
		this.AverageAuthDuration = AverageAuthDuration;
		this.MaxAuthDuration = MaxAuthDuration;
		this.AverageDhcpDuration = AverageDhcpDuration;
		this.MaxDhcpDuration = MaxDhcpDuration;
		this.AaaServerIp = AaaServerIp;
		this.DhcpServerIp = DhcpServerIp;
	}

	/// <summary>
	/// Gets or Sets AverageRunDuration
	/// </summary>
	[DataMember(Name = "averageRunDuration", EmitDefaultValue = false)]
	public Object AverageRunDuration { get; set; }

	/// <summary>
	/// Gets or Sets MaxRunDuration
	/// </summary>
	[DataMember(Name = "maxRunDuration", EmitDefaultValue = false)]
	public Object MaxRunDuration { get; set; }

	/// <summary>
	/// Gets or Sets AverageAssocDuration
	/// </summary>
	[DataMember(Name = "averageAssocDuration", EmitDefaultValue = false)]
	public Object AverageAssocDuration { get; set; }

	/// <summary>
	/// Gets or Sets MaxAssocDuration
	/// </summary>
	[DataMember(Name = "maxAssocDuration", EmitDefaultValue = false)]
	public Object MaxAssocDuration { get; set; }

	/// <summary>
	/// Gets or Sets AverageAuthDuration
	/// </summary>
	[DataMember(Name = "averageAuthDuration", EmitDefaultValue = false)]
	public Object AverageAuthDuration { get; set; }

	/// <summary>
	/// Gets or Sets MaxAuthDuration
	/// </summary>
	[DataMember(Name = "maxAuthDuration", EmitDefaultValue = false)]
	public Object MaxAuthDuration { get; set; }

	/// <summary>
	/// Gets or Sets AverageDhcpDuration
	/// </summary>
	[DataMember(Name = "averageDhcpDuration", EmitDefaultValue = false)]
	public Object AverageDhcpDuration { get; set; }

	/// <summary>
	/// Gets or Sets MaxDhcpDuration
	/// </summary>
	[DataMember(Name = "maxDhcpDuration", EmitDefaultValue = false)]
	public Object MaxDhcpDuration { get; set; }

	/// <summary>
	/// Gets or Sets AaaServerIp
	/// </summary>
	[DataMember(Name = "aaaServerIp", EmitDefaultValue = false)]
	public Object AaaServerIp { get; set; }

	/// <summary>
	/// Gets or Sets DhcpServerIp
	/// </summary>
	[DataMember(Name = "dhcpServerIp", EmitDefaultValue = false)]
	public Object DhcpServerIp { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetUserEnrichmentDetailsResponseInnerUserDetailsOnboarding {\n");
		sb.Append("  AverageRunDuration: ").Append(AverageRunDuration).Append("\n");
		sb.Append("  MaxRunDuration: ").Append(MaxRunDuration).Append("\n");
		sb.Append("  AverageAssocDuration: ").Append(AverageAssocDuration).Append("\n");
		sb.Append("  MaxAssocDuration: ").Append(MaxAssocDuration).Append("\n");
		sb.Append("  AverageAuthDuration: ").Append(AverageAuthDuration).Append("\n");
		sb.Append("  MaxAuthDuration: ").Append(MaxAuthDuration).Append("\n");
		sb.Append("  AverageDhcpDuration: ").Append(AverageDhcpDuration).Append("\n");
		sb.Append("  MaxDhcpDuration: ").Append(MaxDhcpDuration).Append("\n");
		sb.Append("  AaaServerIp: ").Append(AaaServerIp).Append("\n");
		sb.Append("  DhcpServerIp: ").Append(DhcpServerIp).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
