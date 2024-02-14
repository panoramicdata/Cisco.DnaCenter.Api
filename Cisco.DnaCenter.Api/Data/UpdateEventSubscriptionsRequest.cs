using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// UpdateEventSubscriptionsRequest
/// </summary>
[DataContract]
public class UpdateEventSubscriptionsRequest : List<CreateEventSubscriptionsRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UpdateEventSubscriptionsRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public UpdateEventSubscriptionsRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UpdateEventSubscriptionsRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
