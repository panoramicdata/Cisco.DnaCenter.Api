using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteRequestSite
	/// </summary>
	[DataContract]
	public partial class UpdateSiteRequestSite
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSiteRequestSite" /> class.
		/// </summary>
		/// <param name="Area">Area.</param>
		/// <param name="Building">Building.</param>
		/// <param name="Floor">Floor.</param>
		public UpdateSiteRequestSite(CreateSiteRequestSiteArea Area = default, CreateSiteRequestSiteBuilding Building = default, UpdateSiteRequestSiteFloor Floor = default)
		{
			this.Area = Area;
			this.Building = Building;
			this.Floor = Floor;
		}

		/// <summary>
		/// Gets or Sets Area
		/// </summary>
		[DataMember(Name = "area", EmitDefaultValue = false)]
		public CreateSiteRequestSiteArea Area { get; set; }
		/// <summary>
		/// Gets or Sets Building
		/// </summary>
		[DataMember(Name = "building", EmitDefaultValue = false)]
		public CreateSiteRequestSiteBuilding Building { get; set; }
		/// <summary>
		/// Gets or Sets Floor
		/// </summary>
		[DataMember(Name = "floor", EmitDefaultValue = false)]
		public UpdateSiteRequestSiteFloor Floor { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSiteRequestSite {\n");
			sb.Append("  Area: ").Append(Area).Append("\n");
			sb.Append("  Building: ").Append(Building).Append("\n");
			sb.Append("  Floor: ").Append(Floor).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
