using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEnterpriseSSIDResponse
	/// </summary>
	[DataContract]
	public partial class GetEnterpriseSSIDResponse : List<GetEnterpriseSSIDResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEnterpriseSSIDResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetEnterpriseSSIDResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEnterpriseSSIDResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
