using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestDevice1
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestDevice1
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestDevice1" /> class.
		/// </summary>
		/// <param name="Ip">Ip.</param>
		/// <param name="DeviceSerialNumber">DeviceSerialNumber.</param>
		/// <param name="TagName">TagName.</param>
		/// <param name="ServiceProviders">ServiceProviders.</param>
		/// <param name="Services">Services.</param>
		/// <param name="Vlan">Vlan.</param>
		/// <param name="SubPools">SubPools.</param>
		/// <param name="CustomNetworks">CustomNetworks.</param>
		/// <param name="TemplateParam">TemplateParam.</param>
		public ProvisionNfvRequestDevice1(string? Ip = default, string? DeviceSerialNumber = default, string? TagName = default, List<ProvisionNfvRequestServiceProviders1> ServiceProviders = default, List<ProvisionNfvRequestServices1> Services = default, List<ProvisionNfvRequestVlan1> Vlan = default, List<ProvisionNFVRequestSubPools> SubPools = default, List<ProvisionNfvRequestCustomNetworks1> CustomNetworks = default, ProvisionNfvRequestTemplateParam TemplateParam = default)
		{
			this.Ip = Ip;
			this.DeviceSerialNumber = DeviceSerialNumber;
			this.TagName = TagName;
			this.ServiceProviders = ServiceProviders;
			this.Services = Services;
			this.Vlan = Vlan;
			this.SubPools = SubPools;
			this.CustomNetworks = CustomNetworks;
			this.TemplateParam = TemplateParam;
		}

		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string? Ip { get; set; }
		/// <summary>
		/// Gets or Sets DeviceSerialNumber
		/// </summary>
		[DataMember(Name = "deviceSerialNumber", EmitDefaultValue = false)]
		public string? DeviceSerialNumber { get; set; }
		/// <summary>
		/// Gets or Sets TagName
		/// </summary>
		[DataMember(Name = "tagName", EmitDefaultValue = false)]
		public string? TagName { get; set; }
		/// <summary>
		/// Gets or Sets ServiceProviders
		/// </summary>
		[DataMember(Name = "serviceProviders", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestServiceProviders1> ServiceProviders { get; set; }
		/// <summary>
		/// Gets or Sets Services
		/// </summary>
		[DataMember(Name = "services", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestServices1> Services { get; set; }
		/// <summary>
		/// Gets or Sets Vlan
		/// </summary>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestVlan1> Vlan { get; set; }
		/// <summary>
		/// Gets or Sets SubPools
		/// </summary>
		[DataMember(Name = "subPools", EmitDefaultValue = false)]
		public List<ProvisionNFVRequestSubPools> SubPools { get; set; }
		/// <summary>
		/// Gets or Sets CustomNetworks
		/// </summary>
		[DataMember(Name = "customNetworks", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestCustomNetworks1> CustomNetworks { get; set; }
		/// <summary>
		/// Gets or Sets TemplateParam
		/// </summary>
		[DataMember(Name = "templateParam", EmitDefaultValue = false)]
		public ProvisionNfvRequestTemplateParam TemplateParam { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestDevice1 {\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("  DeviceSerialNumber: ").Append(DeviceSerialNumber).Append("\n");
			sb.Append("  TagName: ").Append(TagName).Append("\n");
			sb.Append("  ServiceProviders: ").Append(ServiceProviders).Append("\n");
			sb.Append("  Services: ").Append(Services).Append("\n");
			sb.Append("  Vlan: ").Append(Vlan).Append("\n");
			sb.Append("  SubPools: ").Append(SubPools).Append("\n");
			sb.Append("  CustomNetworks: ").Append(CustomNetworks).Append("\n");
			sb.Append("  TemplateParam: ").Append(TemplateParam).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
