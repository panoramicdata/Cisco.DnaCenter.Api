using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteSiteFromSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class DeleteSiteFromSDAFabricRequest : List<GetSDAFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteSiteFromSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeleteSiteFromSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeleteSiteFromSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
