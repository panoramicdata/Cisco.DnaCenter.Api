using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork
	/// </summary>
	[DataContract]
	public partial class GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork" /> class.
		/// </summary>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		public GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork(string? VirtualNetworkName = default)
		{
			this.VirtualNetworkName = VirtualNetworkName;
		}

		/// <summary>
		/// Gets or Sets VirtualNetworkName
		/// </summary>
		[DataMember(Name = "virtualNetworkName", EmitDefaultValue = false)]
		public string? VirtualNetworkName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork {\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
