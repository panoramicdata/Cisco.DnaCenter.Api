using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CountOfEventSubscriptionsResponse
	/// </summary>
	[DataContract]
	public class EventSubscriptionCountResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EventSubscriptionCountResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>

		public EventSubscriptionCountResponse() : this(default) { }

		public EventSubscriptionCountResponse(decimal? Response)
		{
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public decimal? Response { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CountOfEventSubscriptionsResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
