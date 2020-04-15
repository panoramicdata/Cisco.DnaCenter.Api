using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SNMPvCredentialDto
	/// </summary>
	[DataContract]
	public partial class SNMPvCredentialDto : List<SNMPvCredentialDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SNMPvCredentialDto" /> class.
		/// </summary>
		[JsonConstructor]
		public SNMPvCredentialDto()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SNMPvCredentialDto {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
