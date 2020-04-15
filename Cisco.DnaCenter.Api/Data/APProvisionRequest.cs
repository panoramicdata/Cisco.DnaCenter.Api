using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionRequest
	/// </summary>
	[DataContract]
	public partial class APProvisionRequest : List<APProvisionRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="APProvisionRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public APProvisionRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
