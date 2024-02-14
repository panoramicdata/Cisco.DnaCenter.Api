using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CollectionProjectDtoInnerTemplates
/// </summary>
[DataContract]
public class CollectionProjectDtoInnerTemplates
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionProjectDtoInnerTemplates" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="Composite">Composite.</param>
	/// <param name="Id">Id.</param>
	public CollectionProjectDtoInnerTemplates(string? Name = default, bool? Composite = default, string? Id = default)
	{
		this.Name = Name;
		this.Composite = Composite;
		this.Id = Id;
	}

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets Composite
	/// </summary>
	[DataMember(Name = "composite", EmitDefaultValue = false)]
	public bool? Composite { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CollectionProjectDtoInnerTemplates {\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  Composite: ").Append(Composite).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
