using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSdaFabricRequestInnerExternalConnectivitySettings
	/// </summary>
	[DataContract]
	public partial class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerExternalConnectivitySettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSdaFabricRequestInnerExternalConnectivitySettings" /> class.
		/// </summary>
		/// <param name="InterfaceName">InterfaceName.</param>
		/// <param name="ExternalAutonomouSystemNumber">ExternalAutonomouSystemNumber.</param>
		/// <param name="L3Handoff">L3Handoff.</param>
		public GetDefaultAuthenticationProfileFromSdaFabricRequestInnerExternalConnectivitySettings(string? InterfaceName = default, string? ExternalAutonomouSystemNumber = default, List<GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff> L3Handoff = default)
		{
			this.InterfaceName = InterfaceName;
			this.ExternalAutonomouSystemNumber = ExternalAutonomouSystemNumber;
			this.L3Handoff = L3Handoff;
		}

		/// <summary>
		/// Gets or Sets InterfaceName
		/// </summary>
		[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
		public string? InterfaceName { get; set; }
		/// <summary>
		/// Gets or Sets ExternalAutonomouSystemNumber
		/// </summary>
		[DataMember(Name = "externalAutonomouSystemNumber", EmitDefaultValue = false)]
		public string? ExternalAutonomouSystemNumber { get; set; }
		/// <summary>
		/// Gets or Sets L3Handoff
		/// </summary>
		[DataMember(Name = "l3Handoff", EmitDefaultValue = false)]
		public List<GetDefaultAuthenticationProfileFromSdaFabricRequestInnerL3Handoff> L3Handoff { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerExternalConnectivitySettings {\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("  ExternalAutonomouSystemNumber: ").Append(ExternalAutonomouSystemNumber).Append("\n");
			sb.Append("  L3Handoff: ").Append(L3Handoff).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
