using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetVirtualAccountListResponse
	/// </summary>
	[DataContract]
	public partial class GetVirtualAccountListResponse : List<string>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetVirtualAccountListResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetVirtualAccountListResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetVirtualAccountListResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
