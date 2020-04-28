using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff
	/// </summary>
	[DataContract]
	public class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff" /> class.
		/// </summary>
		/// <param name="VirtualNetwork">VirtualNetwork.</param>
		public GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff(GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork VirtualNetwork = default)
		{
			this.VirtualNetwork = VirtualNetwork;
		}

		/// <summary>
		/// Gets or Sets VirtualNetwork
		/// </summary>
		[DataMember(Name = "virtualNetwork", EmitDefaultValue = false)]
		public GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork VirtualNetwork { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff {\n");
			sb.Append("  VirtualNetwork: ").Append(VirtualNetwork).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
