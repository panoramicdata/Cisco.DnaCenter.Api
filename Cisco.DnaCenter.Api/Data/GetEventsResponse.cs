using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEventsResponse
	/// </summary>
	[DataContract]
	public class GetEventsResponse : List<GetEventsResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEventsResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetEventsResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEventsResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
