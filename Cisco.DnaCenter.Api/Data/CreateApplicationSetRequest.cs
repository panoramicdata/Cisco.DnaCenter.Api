using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateApplicationSetRequest
	/// </summary>
	[DataContract]
	public class CreateApplicationSetRequest : List<CreateApplicationSetRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateApplicationSetRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public CreateApplicationSetRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateApplicationSetRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
