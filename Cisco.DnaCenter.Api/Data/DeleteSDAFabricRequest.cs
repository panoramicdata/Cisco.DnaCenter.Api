using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class DeleteSDAFabricRequest : List<GetSDAFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeleteSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeleteSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
