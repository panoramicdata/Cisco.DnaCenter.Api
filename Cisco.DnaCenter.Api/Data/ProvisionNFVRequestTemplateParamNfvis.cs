using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestTemplateParamNfvis
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestTemplateParamNfvis
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestTemplateParamNfvis" /> class.
		/// </summary>
		/// <param name="Var1">Var1.</param>

		public ProvisionNfvRequestTemplateParamNfvis() : this(default) { }

		public ProvisionNfvRequestTemplateParamNfvis(string? Var1)
		{
			this.Var1 = Var1;
		}

		/// <summary>
		/// Gets or Sets Var1
		/// </summary>
		[DataMember(Name = "var1", EmitDefaultValue = false)]
		public string? Var1 { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestTemplateParamNfvis {\n");
			sb.Append("  Var1: ").Append(Var1).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
