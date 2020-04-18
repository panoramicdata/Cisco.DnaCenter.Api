using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddFabricRequest
	/// </summary>
	[DataContract]
	public class AddFabricRequest : List<AddFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
