using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// EditApplicationRequest
	/// </summary>
	[DataContract]
	public partial class EditApplicationRequest : List<EditApplicationRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EditApplicationRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public EditApplicationRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EditApplicationRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
