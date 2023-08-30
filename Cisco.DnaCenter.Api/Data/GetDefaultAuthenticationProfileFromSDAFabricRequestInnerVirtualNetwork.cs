namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork
	/// </summary>
	[DataContract]
	public class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork" /> class.
		/// </summary>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		public GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork() : this(default) { }

		public GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork(string? VirtualNetworkName)
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
			sb.Append("class GetDefaultAuthenticationProfileFromSdaFabricRequestInnerVirtualNetwork {\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
