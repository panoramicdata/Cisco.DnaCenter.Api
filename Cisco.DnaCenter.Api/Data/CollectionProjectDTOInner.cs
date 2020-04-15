using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CollectionProjectDtoInner
	/// </summary>
	[DataContract]
	public partial class CollectionProjectDtoInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionProjectDtoInner" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Templates">Templates.</param>
		public CollectionProjectDtoInner(string? Name = default, string? Id = default, List<CollectionProjectDtoInnerTemplates> Templates = default)
		{
			this.Name = Name;
			this.Id = Id;
			this.Templates = Templates;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Templates
		/// </summary>
		[DataMember(Name = "templates", EmitDefaultValue = false)]
		public List<CollectionProjectDtoInnerTemplates> Templates { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CollectionProjectDtoInner {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Templates: ").Append(Templates).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
