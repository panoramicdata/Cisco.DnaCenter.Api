using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestDevice
/// </summary>
[DataContract]
public class ProvisionNfvRequestDevice
{
	/// <summary>
	/// Gets or Sets DeviceType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeviceTypeEnum
	{

		/// <summary>
		/// Enum ENCS5100 for "ENCS5100"
		/// </summary>
		[EnumMember(Value = "ENCS5100")]
		ENCS5100,

		/// <summary>
		/// Enum ENCS5400 for "ENCS5400"
		/// </summary>
		[EnumMember(Value = "ENCS5400")]
		ENCS5400
	}

	/// <summary>
	/// Gets or Sets DeviceType
	/// </summary>
	[DataMember(Name = "deviceType", EmitDefaultValue = false)]
	public DeviceTypeEnum? DeviceType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestDevice" /> class.
	/// </summary>
	/// <param name="DeviceType">DeviceType.</param>
	/// <param name="TagName">TagName.</param>
	/// <param name="ServiceProviders">ServiceProviders.</param>
	/// <param name="Dia">Dia.</param>
	/// <param name="Services">Services.</param>
	/// <param name="CustomServices">CustomServices.</param>
	/// <param name="CustomNetworks">CustomNetworks.</param>
	/// <param name="Vlan">Vlan.</param>
	/// <param name="CustomTemplate">CustomTemplate.</param>
	public ProvisionNfvRequestDevice(DeviceTypeEnum? DeviceType = default, string? TagName = default, List<ProvisionNfvRequestServiceProviders> ServiceProviders = default, bool? Dia = default, List<ProvisionNfvRequestServices> Services = default, List<ProvisionNfvRequestCustomServices> CustomServices = default, List<ProvisionNfvRequestCustomNetworks> CustomNetworks = default, List<ProvisionNfvRequestVlan> Vlan = default, List<ProvisionNfvRequestCustomTemplate> CustomTemplate = default)
	{
		this.DeviceType = DeviceType;
		this.TagName = TagName;
		this.ServiceProviders = ServiceProviders;
		this.Dia = Dia;
		this.Services = Services;
		this.CustomServices = CustomServices;
		this.CustomNetworks = CustomNetworks;
		this.Vlan = Vlan;
		this.CustomTemplate = CustomTemplate;
	}

	/// <summary>
	/// Gets or Sets TagName
	/// </summary>
	[DataMember(Name = "tagName", EmitDefaultValue = false)]
	public string? TagName { get; set; }

	/// <summary>
	/// Gets or Sets ServiceProviders
	/// </summary>
	[DataMember(Name = "serviceProviders", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestServiceProviders> ServiceProviders { get; set; }

	/// <summary>
	/// Gets or Sets Dia
	/// </summary>
	[DataMember(Name = "dia", EmitDefaultValue = false)]
	public bool? Dia { get; set; }

	/// <summary>
	/// Gets or Sets Services
	/// </summary>
	[DataMember(Name = "services", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestServices> Services { get; set; }

	/// <summary>
	/// Gets or Sets CustomServices
	/// </summary>
	[DataMember(Name = "customServices", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestCustomServices> CustomServices { get; set; }

	/// <summary>
	/// Gets or Sets CustomNetworks
	/// </summary>
	[DataMember(Name = "customNetworks", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestCustomNetworks> CustomNetworks { get; set; }

	/// <summary>
	/// Gets or Sets Vlan
	/// </summary>
	[DataMember(Name = "vlan", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestVlan> Vlan { get; set; }

	/// <summary>
	/// Gets or Sets CustomTemplate
	/// </summary>
	[DataMember(Name = "customTemplate", EmitDefaultValue = false)]
	public List<ProvisionNfvRequestCustomTemplate> CustomTemplate { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestDevice {\n");
		sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
		sb.Append("  TagName: ").Append(TagName).Append("\n");
		sb.Append("  ServiceProviders: ").Append(ServiceProviders).Append("\n");
		sb.Append("  Dia: ").Append(Dia).Append("\n");
		sb.Append("  Services: ").Append(Services).Append("\n");
		sb.Append("  CustomServices: ").Append(CustomServices).Append("\n");
		sb.Append("  CustomNetworks: ").Append(CustomNetworks).Append("\n");
		sb.Append("  Vlan: ").Append(Vlan).Append("\n");
		sb.Append("  CustomTemplate: ").Append(CustomTemplate).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
