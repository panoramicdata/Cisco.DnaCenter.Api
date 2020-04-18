using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestVlan
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestVlan
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestVlan" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Id">Id.</param>
		public ProvisionNfvRequestVlan(string? Type = default, string? Id = default)
		{
			this.Type = Type;
			this.Id = Id;
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
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestVlan {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
