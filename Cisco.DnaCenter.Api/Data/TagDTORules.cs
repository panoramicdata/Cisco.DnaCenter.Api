using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// TagDtoRules
/// </summary>
[DataContract]
public class TagDtoRules
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TagDtoRules" /> class.
	/// </summary>
	/// <param name="Values">Values.</param>
	/// <param name="Items">Items.</param>
	/// <param name="Operation">Operation.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Value">Value.</param>
	public TagDtoRules(List<string> Values = default, List<string> Items = default, string? Operation = default, string? Name = default, string? Value = default)
	{
		this.Values = Values;
		this.Items = Items;
		this.Operation = Operation;
		this.Name = Name;
		this.Value = Value;
	}

	/// <summary>
	/// Gets or Sets Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string> Values { get; set; }

	/// <summary>
	/// Gets or Sets Items
	/// </summary>
	[DataMember(Name = "items", EmitDefaultValue = false)]
	public List<string> Items { get; set; }

	/// <summary>
	/// Gets or Sets Operation
	/// </summary>
	[DataMember(Name = "operation", EmitDefaultValue = false)]
	public string? Operation { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string? Value { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TagDtoRules {\n");
		sb.Append("  Values: ").Append(Values).Append("\n");
		sb.Append("  Items: ").Append(Items).Append("\n");
		sb.Append("  Operation: ").Append(Operation).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  Value: ").Append(Value).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
