using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateEventSubscriptionsRequestInnerSubscriptionEndpoints
	/// </summary>
	[DataContract]
	public partial class CreateEventSubscriptionsRequestInnerSubscriptionEndpoints
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsRequestInnerSubscriptionEndpoints" /> class.
		/// </summary>
		/// <param name="InstanceId">InstanceId.</param>
		/// <param name="SubscriptionDetails">SubscriptionDetails.</param>
		public CreateEventSubscriptionsRequestInnerSubscriptionEndpoints(string? InstanceId = default, CreateEventSubscriptionsRequestInnerSubscriptionDetails SubscriptionDetails = default)
		{
			this.InstanceId = InstanceId;
			this.SubscriptionDetails = SubscriptionDetails;
		}

		/// <summary>
		/// Gets or Sets InstanceId
		/// </summary>
		[DataMember(Name = "instanceId", EmitDefaultValue = false)]
		public string? InstanceId { get; set; }
		/// <summary>
		/// Gets or Sets SubscriptionDetails
		/// </summary>
		[DataMember(Name = "subscriptionDetails", EmitDefaultValue = false)]
		public CreateEventSubscriptionsRequestInnerSubscriptionDetails SubscriptionDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateEventSubscriptionsRequestInnerSubscriptionEndpoints {\n");
			sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
			sb.Append("  SubscriptionDetails: ").Append(SubscriptionDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
