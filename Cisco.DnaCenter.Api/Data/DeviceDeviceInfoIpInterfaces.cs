using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoIpInterfaces
	/// </summary>
	[DataContract]
	public class DeviceDeviceInfoIpInterfaces
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoIpInterfaces" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="Ipv4Address">Ipv4Address.</param>
		/// <param name="Ipv6AddressList">Ipv6AddressList.</param>
		/// <param name="Name">Name.</param>
		public DeviceDeviceInfoIpInterfaces(string? Status = default, string? MacAddress = default, Object Ipv4Address = default, List<Object> Ipv6AddressList = default, string? Name = default)
		{
			this.Status = Status;
			this.MacAddress = MacAddress;
			this.Ipv4Address = Ipv4Address;
			this.Ipv6AddressList = Ipv6AddressList;
			this.Name = Name;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }
		/// <summary>
		/// Gets or Sets Ipv4Address
		/// </summary>
		[DataMember(Name = "ipv4Address", EmitDefaultValue = false)]
		public Object Ipv4Address { get; set; }
		/// <summary>
		/// Gets or Sets Ipv6AddressList
		/// </summary>
		[DataMember(Name = "ipv6AddressList", EmitDefaultValue = false)]
		public List<Object> Ipv6AddressList { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoIpInterfaces {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
			sb.Append("  Ipv6AddressList: ").Append(Ipv6AddressList).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
