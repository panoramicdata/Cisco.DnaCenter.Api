using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDtoContainingTemplates
	/// </summary>
	[DataContract]
	public class TemplateDtoContainingTemplates
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDtoContainingTemplates" /> class.
		/// </summary>
		/// <param name="Composite">Composite.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="_Version">_Version.</param>
		public TemplateDtoContainingTemplates(bool? Composite = default, string? Id = default, string? Name = default, string? _Version = default)
		{
			this.Composite = Composite;
			this.Id = Id;
			this.Name = Name;
			this._Version = _Version;
		}

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
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDtoContainingTemplates {\n");
			sb.Append("  Composite: ").Append(Composite).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
