using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetUserEnrichmentDetailsResponse
	/// </summary>
	[DataContract]
	public class GetUserEnrichmentDetailsResponse : List<GetUserEnrichmentDetailsResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetUserEnrichmentDetailsResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetUserEnrichmentDetailsResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetUserEnrichmentDetailsResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
