using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateEventSubscriptionsRequestInnerFilter
	/// </summary>
	[DataContract]
	public class CreateEventSubscriptionsRequestInnerFilter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsRequestInnerFilter" /> class.
		/// </summary>
		/// <param name="EventIds">EventIds.</param>
		public CreateEventSubscriptionsRequestInnerFilter(List<string> EventIds = default)
		{
			this.EventIds = EventIds;
		}

		/// <summary>
		/// Gets or Sets EventIds
		/// </summary>
		[DataMember(Name = "eventIds", EmitDefaultValue = false)]
		public List<string> EventIds { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateEventSubscriptionsRequestInnerFilter {\n");
			sb.Append("  EventIds: ").Append(EventIds).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
