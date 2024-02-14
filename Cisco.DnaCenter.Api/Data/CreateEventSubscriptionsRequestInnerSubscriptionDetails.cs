using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CreateEventSubscriptionsRequestInnerSubscriptionDetails
/// </summary>
[DataContract]
public class CreateEventSubscriptionsRequestInnerSubscriptionDetails
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CreateEventSubscriptionsRequestInnerSubscriptionDetails" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="Url">Url.</param>
	/// <param name="Method">Method.</param>
	/// <param name="ConnectorType">ConnectorType.</param>
	public CreateEventSubscriptionsRequestInnerSubscriptionDetails(string? Name = default, string? Url = default, string? Method = default, string? ConnectorType = default)
	{
		this.Name = Name;
		this.Url = Url;
		this.Method = Method;
		this.ConnectorType = ConnectorType;
	}

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string? Url { get; set; }

	/// <summary>
	/// Gets or Sets Method
	/// </summary>
	[DataMember(Name = "method", EmitDefaultValue = false)]
	public string? Method { get; set; }

	/// <summary>
	/// Gets or Sets ConnectorType
	/// </summary>
	[DataMember(Name = "connectorType", EmitDefaultValue = false)]
	public string? ConnectorType { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CreateEventSubscriptionsRequestInnerSubscriptionDetails {\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  Url: ").Append(Url).Append("\n");
		sb.Append("  Method: ").Append(Method).Append("\n");
		sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
