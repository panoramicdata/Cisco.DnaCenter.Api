using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteSiteFromSdaFabricRequest
	/// </summary>
	[DataContract]
	public class DeleteSiteFromSdaFabricRequest : List<GetSdaFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteSiteFromSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeleteSiteFromSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeleteSiteFromSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
