using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateEventSubscriptionsRequest
	/// </summary>
	[DataContract]
	public partial class CreateEventSubscriptionsRequest : List<CreateEventSubscriptionsRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public CreateEventSubscriptionsRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateEventSubscriptionsRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
