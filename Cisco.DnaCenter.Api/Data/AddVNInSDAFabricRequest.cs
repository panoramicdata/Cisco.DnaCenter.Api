using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddVNInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddVNInSDAFabricRequest : List<AddVNInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddVNInSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddVNInSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddVNInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
