using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestTemplateParam
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequestTemplateParam
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestTemplateParam" /> class.
		/// </summary>
		/// <param name="Nfvis">Nfvis.</param>
		/// <param name="Asav">Asav.</param>
		public ProvisionNFVRequestTemplateParam(ProvisionNFVRequestTemplateParamNfvis Nfvis = default, ProvisionNFVRequestTemplateParamNfvis Asav = default)
		{
			this.Nfvis = Nfvis;
			this.Asav = Asav;
		}

		/// <summary>
		/// Gets or Sets Nfvis
		/// </summary>
		[DataMember(Name = "nfvis", EmitDefaultValue = false)]
		public ProvisionNFVRequestTemplateParamNfvis Nfvis { get; set; }
		/// <summary>
		/// Gets or Sets Asav
		/// </summary>
		[DataMember(Name = "asav", EmitDefaultValue = false)]
		public ProvisionNFVRequestTemplateParamNfvis Asav { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestTemplateParam {\n");
			sb.Append("  Nfvis: ").Append(Nfvis).Append("\n");
			sb.Append("  Asav: ").Append(Asav).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
