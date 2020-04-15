using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSiteRequestSiteArea
	/// </summary>
	[DataContract]
	public partial class CreateSiteRequestSiteArea
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSiteRequestSiteArea" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ParentName">ParentName.</param>
		public CreateSiteRequestSiteArea(string? Name = default, string? ParentName = default)
		{
			this.Name = Name;
			this.ParentName = ParentName;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets ParentName
		/// </summary>
		[DataMember(Name = "parentName", EmitDefaultValue = false)]
		public string? ParentName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSiteRequestSiteArea {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ParentName: ").Append(ParentName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
