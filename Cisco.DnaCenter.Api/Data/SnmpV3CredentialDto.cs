using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SNMPv3CredentialDto
	/// </summary>
	[DataContract]
	public class Snmpv3CredentialDto : List<SnmpV3CredentialDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Snmpv3CredentialDto" /> class.
		/// </summary>
		[JsonConstructor]
		public Snmpv3CredentialDto()
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
