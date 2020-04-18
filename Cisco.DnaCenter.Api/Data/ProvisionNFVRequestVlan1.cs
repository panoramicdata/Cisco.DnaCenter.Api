using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestVlan1
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestVlan1
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestVlan1" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Interfaces">Interfaces.</param>
		/// <param name="Network">Network.</param>
		public ProvisionNfvRequestVlan1(string? Type = default, string? Id = default, string? Interfaces = default, string? Network = default)
		{
			this.Type = Type;
			this.Id = Id;
			this.Interfaces = Interfaces;
			this.Network = Network;
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Interfaces
		/// </summary>
		[DataMember(Name = "interfaces", EmitDefaultValue = false)]
		public string? Interfaces { get; set; }
		/// <summary>
		/// Gets or Sets Network
		/// </summary>
		[DataMember(Name = "network", EmitDefaultValue = false)]
		public string? Network { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestVlan1 {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
			sb.Append("  Network: ").Append(Network).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
