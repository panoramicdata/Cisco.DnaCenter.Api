using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestServiceProviders
/// </summary>
[DataContract]
public class ProvisionNfvRequestServiceProviders
{
	/// <summary>
	/// Gets or Sets LinkType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LinkTypeEnum
	{

		/// <summary>
		/// Enum GigabitEthernet for "GigabitEthernet"
		/// </summary>
		[EnumMember(Value = "GigabitEthernet")]
		GigabitEthernet
	}

	/// <summary>
	/// Gets or Sets LinkType
	/// </summary>
	[DataMember(Name = "linkType", EmitDefaultValue = false)]
	public LinkTypeEnum? LinkType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestServiceProviders" /> class.
	/// </summary>
	/// <param name="ServiceProvider">ServiceProvider.</param>
	/// <param name="LinkType">LinkType.</param>
	/// <param name="Connect">Connect.</param>
	/// <param name="DefaultGateway">DefaultGateway.</param>
	public ProvisionNfvRequestServiceProviders(string? ServiceProvider = default, LinkTypeEnum? LinkType = default, bool? Connect = default, bool? DefaultGateway = default)
	{
		this.ServiceProvider = ServiceProvider;
		this.LinkType = LinkType;
		this.Connect = Connect;
		this.DefaultGateway = DefaultGateway;
	}

	/// <summary>
	/// Gets or Sets ServiceProvider
	/// </summary>
	[DataMember(Name = "serviceProvider", EmitDefaultValue = false)]
	public string? ServiceProvider { get; set; }

	/// <summary>
	/// Gets or Sets Connect
	/// </summary>
	[DataMember(Name = "connect", EmitDefaultValue = false)]
	public bool? Connect { get; set; }

	/// <summary>
	/// Gets or Sets DefaultGateway
	/// </summary>
	[DataMember(Name = "defaultGateway", EmitDefaultValue = false)]
	public bool? DefaultGateway { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestServiceProviders {\n");
		sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
		sb.Append("  LinkType: ").Append(LinkType).Append("\n");
		sb.Append("  Connect: ").Append(Connect).Append("\n");
		sb.Append("  DefaultGateway: ").Append(DefaultGateway).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
