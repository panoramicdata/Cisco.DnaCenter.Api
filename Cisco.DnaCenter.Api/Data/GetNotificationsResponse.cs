using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetNotificationsResponse
/// </summary>
[DataContract]
public class GetNotificationsResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetNotificationsResponse" /> class.
	/// </summary>
	/// <param name="InstanceId">InstanceId.</param>
	/// <param name="EventId">EventId.</param>
	/// <param name="Name">Name.</param>
	/// <param name="_Namespace">_Namespace.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Type">Type.</param>
	/// <param name="Category">Category.</param>
	/// <param name="Severity">Severity.</param>
	/// <param name="Timestamp">Timestamp.</param>
	/// <param name="Domain">Domain.</param>
	/// <param name="SubDomain">SubDomain.</param>
	/// <param name="Source">Source.</param>
	/// <param name="Context">Context.</param>
	/// <param name="Details">Details.</param>
	/// <param name="TenantId">TenantId.</param>
	public GetNotificationsResponse(string? InstanceId = default, string? EventId = default, string? Name = default, string? _Namespace = default, string? Description = default, string? Type = default, string? Category = default, decimal? Severity = default, decimal? Timestamp = default, string? Domain = default, string? SubDomain = default, string? Source = default, string? Context = default, Object Details = default, string? TenantId = default)
	{
		this.InstanceId = InstanceId;
		this.EventId = EventId;
		this.Name = Name;
		this._Namespace = _Namespace;
		this.Description = Description;
		this.Type = Type;
		this.Category = Category;
		this.Severity = Severity;
		this.Timestamp = Timestamp;
		this.Domain = Domain;
		this.SubDomain = SubDomain;
		this.Source = Source;
		this.Context = Context;
		this.Details = Details;
		this.TenantId = TenantId;
	}

	/// <summary>
	/// Gets or Sets InstanceId
	/// </summary>
	[DataMember(Name = "instanceId", EmitDefaultValue = false)]
	public string? InstanceId { get; set; }

	/// <summary>
	/// Gets or Sets EventId
	/// </summary>
	[DataMember(Name = "eventId", EmitDefaultValue = false)]
	public string? EventId { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets _Namespace
	/// </summary>
	[DataMember(Name = "namespace", EmitDefaultValue = false)]
	public string? _Namespace { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string? Type { get; set; }

	/// <summary>
	/// Gets or Sets Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string? Category { get; set; }

	/// <summary>
	/// Gets or Sets Severity
	/// </summary>
	[DataMember(Name = "severity", EmitDefaultValue = false)]
	public decimal? Severity { get; set; }

	/// <summary>
	/// Gets or Sets Timestamp
	/// </summary>
	[DataMember(Name = "timestamp", EmitDefaultValue = false)]
	public decimal? Timestamp { get; set; }

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
	/// Gets or Sets Source
	/// </summary>
	[DataMember(Name = "source", EmitDefaultValue = false)]
	public string? Source { get; set; }

	/// <summary>
	/// Gets or Sets Context
	/// </summary>
	[DataMember(Name = "context", EmitDefaultValue = false)]
	public string? Context { get; set; }

	/// <summary>
	/// Gets or Sets Details
	/// </summary>
	[DataMember(Name = "details", EmitDefaultValue = false)]
	public Object Details { get; set; }

	/// <summary>
	/// Gets or Sets TenantId
	/// </summary>
	[DataMember(Name = "tenantId", EmitDefaultValue = false)]
	public string? TenantId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetNotificationsResponse {\n");
		sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
		sb.Append("  EventId: ").Append(EventId).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
		sb.Append("  Description: ").Append(Description).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("  Category: ").Append(Category).Append("\n");
		sb.Append("  Severity: ").Append(Severity).Append("\n");
		sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
		sb.Append("  Domain: ").Append(Domain).Append("\n");
		sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
		sb.Append("  Source: ").Append(Source).Append("\n");
		sb.Append("  Context: ").Append(Context).Append("\n");
		sb.Append("  Details: ").Append(Details).Append("\n");
		sb.Append("  TenantId: ").Append(TenantId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
