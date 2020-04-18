using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SNMPv2WriteCommunityDto
	/// </summary>
	[DataContract]
	public class SnmpV2WriteCommunityDto : List<SnmpV2WriteCommunityDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SnmpV2WriteCommunityDto" /> class.
		/// </summary>
		[JsonConstructor]
		public SnmpV2WriteCommunityDto()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SNMPvWriteCommunityDto {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
