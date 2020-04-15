using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSDAFabricRequestInnerL3Handoff
	/// </summary>
	[DataContract]
	public partial class GetDefaultAuthenticationProfileFromSDAFabricRequestInnerL3Handoff
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSDAFabricRequestInnerL3Handoff" /> class.
		/// </summary>
		/// <param name="VirtualNetwork">VirtualNetwork.</param>
		public GetDefaultAuthenticationProfileFromSDAFabricRequestInnerL3Handoff(GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork VirtualNetwork = default)
		{
			this.VirtualNetwork = VirtualNetwork;
		}

		/// <summary>
		/// Gets or Sets VirtualNetwork
		/// </summary>
		[DataMember(Name = "virtualNetwork", EmitDefaultValue = false)]
		public GetDefaultAuthenticationProfileFromSDAFabricRequestInnerVirtualNetwork VirtualNetwork { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSDAFabricRequestInnerL3Handoff {\n");
			sb.Append("  VirtualNetwork: ").Append(VirtualNetwork).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
