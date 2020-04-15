using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponse
	/// </summary>
	[DataContract]
	public partial class GetClientEnrichmentDetailsResponse : List<GetClientEnrichmentDetailsResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetClientEnrichmentDetailsResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
