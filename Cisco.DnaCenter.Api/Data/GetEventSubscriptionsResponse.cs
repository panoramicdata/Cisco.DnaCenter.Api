using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEventSubscriptionsResponse
	/// </summary>
	[DataContract]
	public partial class GetEventSubscriptionsResponse : List<GetEventSubscriptionsResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEventSubscriptionsResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetEventSubscriptionsResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEventSubscriptionsResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
