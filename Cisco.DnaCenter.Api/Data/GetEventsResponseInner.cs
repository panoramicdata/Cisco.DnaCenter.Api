using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEventsResponseInner
	/// </summary>
	[DataContract]
	public class GetEventsResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEventsResponseInner" /> class.
		/// </summary>
		/// <param name="EventId">EventId.</param>
		/// <param name="_NameSpace">_NameSpace.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="Category">Category.</param>
		/// <param name="Domain">Domain.</param>
		/// <param name="SubDomain">SubDomain.</param>
		/// <param name="Type">Type.</param>
		/// <param name="Tags">Tags.</param>
		/// <param name="Severity">Severity.</param>
		/// <param name="Details">Details.</param>
		/// <param name="SubscriptionTypes">SubscriptionTypes.</param>
		public GetEventsResponseInner(
			string? EventId = default,
			string? _NameSpace = default,
			string? Name = default,
			string? Description = default,
			string? _Version = default,
			string? Category = default,
			string? Domain = default,
			string? SubDomain = default,
			string? Type = default,
			List<TagDto>? Tags = default,
			decimal? Severity = default,
			Object Details = default,
			List<string> SubscriptionTypes = default)
		{
			this.EventId = EventId;
			this._NameSpace = _NameSpace;
			this.Name = Name;
			this.Description = Description;
			this._Version = _Version;
			this.Category = Category;
			this.Domain = Domain;
			this.SubDomain = SubDomain;
			this.Type = Type;
			this.Tags = Tags ?? new List<TagDto>();
			this.Severity = Severity;
			this.Details = Details;
			this.SubscriptionTypes = SubscriptionTypes;
		}

		/// <summary>
		/// Gets or Sets EventId
		/// </summary>
		[DataMember(Name = "eventId", EmitDefaultValue = false)]
		public string? EventId { get; set; }

		/// <summary>
		/// Gets or Sets _NameSpace
		/// </summary>
		[DataMember(Name = "nameSpace", EmitDefaultValue = false)]
		public string? _NameSpace { get; set; }

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
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }

		/// <summary>
		/// Gets or Sets Category
		/// </summary>
		[DataMember(Name = "category", EmitDefaultValue = false)]
		public string? Category { get; set; }

		/// <summary>
		/// Gets or Sets Domain
		/// </summary>
		[DataMember(Name = "domain", EmitDefaultValue = false)]
		public string? Domain { get; set; }

		/// <summary>
		/// Gets or Sets SubDomain
		/// </summary>
		[DataMember(Name = "subDomain", EmitDefaultValue = false)]
		public string? SubDomain { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets Tags
		/// </summary>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<TagDto> Tags { get; set; }

		/// <summary>
		/// Gets or Sets Severity
		/// </summary>
		[DataMember(Name = "severity", EmitDefaultValue = false)]
		public decimal? Severity { get; set; }

		/// <summary>
		/// Gets or Sets Details
		/// </summary>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public Object Details { get; set; }

		/// <summary>
		/// Gets or Sets SubscriptionTypes
		/// </summary>
		[DataMember(Name = "subscriptionTypes", EmitDefaultValue = false)]
		public List<string> SubscriptionTypes { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEventsResponseInner {\n");
			sb.Append("  EventId: ").Append(EventId).Append("\n");
			sb.Append("  _NameSpace: ").Append(_NameSpace).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  Category: ").Append(Category).Append("\n");
			sb.Append("  Domain: ").Append(Domain).Append("\n");
			sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
			sb.Append("  Severity: ").Append(Severity).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
			sb.Append("  SubscriptionTypes: ").Append(SubscriptionTypes).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
