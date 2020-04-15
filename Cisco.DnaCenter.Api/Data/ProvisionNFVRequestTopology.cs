using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestTopology
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequestTopology
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestTopology" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Name">Name.</param>
		/// <param name="AssignIp">AssignIp.</param>
		public ProvisionNFVRequestTopology(string? Type = default, string? Name = default, string? AssignIp = default)
		{
			this.Type = Type;
			this.Name = Name;
			this.AssignIp = AssignIp;
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets AssignIp
		/// </summary>
		[DataMember(Name = "assignIp", EmitDefaultValue = false)]
		public string? AssignIp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestTopology {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  AssignIp: ").Append(AssignIp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
