using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SNMPvWriteCommunityDto
	/// </summary>
	[DataContract]
	public partial class SNMPvWriteCommunityDto : List<SNMPvWriteCommunityDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SNMPvWriteCommunityDto" /> class.
		/// </summary>
		[JsonConstructor]
		public SNMPvWriteCommunityDto()
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
