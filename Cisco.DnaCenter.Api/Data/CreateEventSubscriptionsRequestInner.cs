using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateEventSubscriptionsRequestInner
	/// </summary>
	[DataContract]
	public partial class CreateEventSubscriptionsRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventSubscriptionsRequestInner" /> class.
		/// </summary>
		/// <param name="SubscriptionId">SubscriptionId.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="SubscriptionEndpoints">SubscriptionEndpoints.</param>
		/// <param name="Filter">Filter.</param>
		public CreateEventSubscriptionsRequestInner(string? SubscriptionId = default, string? _Version = default, string? Name = default, string? Description = default, List<CreateEventSubscriptionsRequestInnerSubscriptionEndpoints> SubscriptionEndpoints = default, CreateEventSubscriptionsRequestInnerFilter Filter = default)
		{
			this.SubscriptionId = SubscriptionId;
			this._Version = _Version;
			this.Name = Name;
			this.Description = Description;
			this.SubscriptionEndpoints = SubscriptionEndpoints;
			this.Filter = Filter;
		}

		/// <summary>
		/// Gets or Sets SubscriptionId
		/// </summary>
		[DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
		public string? SubscriptionId { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets SubscriptionEndpoints
		/// </summary>
		[DataMember(Name = "subscriptionEndpoints", EmitDefaultValue = false)]
		public List<CreateEventSubscriptionsRequestInnerSubscriptionEndpoints> SubscriptionEndpoints { get; set; }
		/// <summary>
		/// Gets or Sets Filter
		/// </summary>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public CreateEventSubscriptionsRequestInnerFilter Filter { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateEventSubscriptionsRequestInner {\n");
			sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  SubscriptionEndpoints: ").Append(SubscriptionEndpoints).Append("\n");
			sb.Append("  Filter: ").Append(Filter).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
