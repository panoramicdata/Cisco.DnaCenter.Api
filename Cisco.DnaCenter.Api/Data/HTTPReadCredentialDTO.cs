using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// HTTPReadCredentialDto
	/// </summary>
	[DataContract]
	public partial class HTTPReadCredentialDto : List<InventoryRequestHttpReadCredential>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HTTPReadCredentialDto" /> class.
		/// </summary>
		[JsonConstructor]
		public HTTPReadCredentialDto()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class HTTPReadCredentialDto {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
