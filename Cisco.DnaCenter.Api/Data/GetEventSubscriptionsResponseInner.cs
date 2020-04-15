using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEventSubscriptionsResponseInner
	/// </summary>
	[DataContract]
	public partial class GetEventSubscriptionsResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEventSubscriptionsResponseInner" /> class.
		/// </summary>
		/// <param name="_Version">_Version.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="SubscriptionEndpoints">SubscriptionEndpoints.</param>
		/// <param name="Filter">Filter.</param>
		public GetEventSubscriptionsResponseInner(string? _Version = default, string? Name = default, string? Description = default, List<GetEventSubscriptionsResponseInnerSubscriptionEndpoints> SubscriptionEndpoints = default, CreateEventSubscriptionsRequestInnerFilter Filter = default)
		{
			this._Version = _Version;
			this.Name = Name;
			this.Description = Description;
			this.SubscriptionEndpoints = SubscriptionEndpoints;
			this.Filter = Filter;
		}

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
		public List<GetEventSubscriptionsResponseInnerSubscriptionEndpoints> SubscriptionEndpoints { get; set; }
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
			sb.Append("class GetEventSubscriptionsResponseInner {\n");
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
