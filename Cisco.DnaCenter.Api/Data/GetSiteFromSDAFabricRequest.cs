using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSiteFromSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class GetSiteFromSDAFabricRequest : List<GetSDAFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSiteFromSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetSiteFromSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSiteFromSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
