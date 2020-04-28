using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CollectionTemplateInfoInnerVersionsInfo
	/// </summary>
	[DataContract]
	public class CollectionTemplateInfoInnerVersionsInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionTemplateInfoInnerVersionsInfo" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="VersionTime">VersionTime.</param>
		public CollectionTemplateInfoInnerVersionsInfo(string? Id = default, string? Description = default, decimal? VersionTime = default)
		{
			this.Id = Id;
			this.Description = Description;
			this.VersionTime = VersionTime;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or Sets VersionTime
		/// </summary>
		[DataMember(Name = "versionTime", EmitDefaultValue = false)]
		public decimal? VersionTime { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CollectionTemplateInfoInnerVersionsInfo {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  VersionTime: ").Append(VersionTime).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
