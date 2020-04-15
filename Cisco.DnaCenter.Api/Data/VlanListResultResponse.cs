using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// VlanListResultResponse
	/// </summary>
	[DataContract]
	public partial class VlanListResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VlanListResultResponse" /> class.
		/// </summary>
		/// <param name="InterfaceName">InterfaceName.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="Mask">Mask.</param>
		/// <param name="NetworkAddress">NetworkAddress.</param>
		/// <param name="NumberOfIPs">NumberOfIPs.</param>
		/// <param name="Prefix">Prefix.</param>
		/// <param name="VlanNumber">VlanNumber.</param>
		/// <param name="VlanType">VlanType.</param>
		public VlanListResultResponse(string? InterfaceName = default, string? IpAddress = default, int? Mask = default, string? NetworkAddress = default, int? NumberOfIPs = default, string? Prefix = default, int? VlanNumber = default, string? VlanType = default)
		{
			this.InterfaceName = InterfaceName;
			this.IpAddress = IpAddress;
			this.Mask = Mask;
			this.NetworkAddress = NetworkAddress;
			this.NumberOfIPs = NumberOfIPs;
			this.Prefix = Prefix;
			this.VlanNumber = VlanNumber;
			this.VlanType = VlanType;
		}

		/// <summary>
		/// Gets or Sets InterfaceName
		/// </summary>
		[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
		public string? InterfaceName { get; set; }
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string? IpAddress { get; set; }
		/// <summary>
		/// Gets or Sets Mask
		/// </summary>
		[DataMember(Name = "mask", EmitDefaultValue = false)]
		public int? Mask { get; set; }
		/// <summary>
		/// Gets or Sets NetworkAddress
		/// </summary>
		[DataMember(Name = "networkAddress", EmitDefaultValue = false)]
		public string? NetworkAddress { get; set; }
		/// <summary>
		/// Gets or Sets NumberOfIPs
		/// </summary>
		[DataMember(Name = "numberOfIPs", EmitDefaultValue = false)]
		public int? NumberOfIPs { get; set; }
		/// <summary>
		/// Gets or Sets Prefix
		/// </summary>
		[DataMember(Name = "prefix", EmitDefaultValue = false)]
		public string? Prefix { get; set; }
		/// <summary>
		/// Gets or Sets VlanNumber
		/// </summary>
		[DataMember(Name = "vlanNumber", EmitDefaultValue = false)]
		public int? VlanNumber { get; set; }
		/// <summary>
		/// Gets or Sets VlanType
		/// </summary>
		[DataMember(Name = "vlanType", EmitDefaultValue = false)]
		public string? VlanType { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class VlanListResultResponse {\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  Mask: ").Append(Mask).Append("\n");
			sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
			sb.Append("  NumberOfIPs: ").Append(NumberOfIPs).Append("\n");
			sb.Append("  Prefix: ").Append(Prefix).Append("\n");
			sb.Append("  VlanNumber: ").Append(VlanNumber).Append("\n");
			sb.Append("  VlanType: ").Append(VlanType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
