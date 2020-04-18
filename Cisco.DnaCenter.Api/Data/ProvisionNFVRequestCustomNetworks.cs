using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestCustomNetworks
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestCustomNetworks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestCustomNetworks" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ServicesToConnect">ServicesToConnect.</param>
		/// <param name="ConnectionType">ConnectionType.</param>
		/// <param name="NetworkMode">NetworkMode.</param>
		/// <param name="Vlan">Vlan.</param>
		public ProvisionNfvRequestCustomNetworks(string? Name = default, List<ProvisionNfvRequestServicesToConnect> ServicesToConnect = default, string? ConnectionType = default, string? NetworkMode = default, string? Vlan = default)
		{
			this.Name = Name;
			this.ServicesToConnect = ServicesToConnect;
			this.ConnectionType = ConnectionType;
			this.NetworkMode = NetworkMode;
			this.Vlan = Vlan;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets ServicesToConnect
		/// </summary>
		[DataMember(Name = "servicesToConnect", EmitDefaultValue = false)]
		public List<ProvisionNfvRequestServicesToConnect> ServicesToConnect { get; set; }
		/// <summary>
		/// Gets or Sets ConnectionType
		/// </summary>
		[DataMember(Name = "connectionType", EmitDefaultValue = false)]
		public string? ConnectionType { get; set; }
		/// <summary>
		/// Gets or Sets NetworkMode
		/// </summary>
		[DataMember(Name = "networkMode", EmitDefaultValue = false)]
		public string? NetworkMode { get; set; }
		/// <summary>
		/// Gets or Sets Vlan
		/// </summary>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public string? Vlan { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestCustomNetworks {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ServicesToConnect: ").Append(ServicesToConnect).Append("\n");
			sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
			sb.Append("  NetworkMode: ").Append(NetworkMode).Append("\n");
			sb.Append("  Vlan: ").Append(Vlan).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
