using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ProvisionNFVRequestSite
/// </summary>
[DataContract]
public class ProvisionNfvRequestSite
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ProvisionNfvRequestSite" /> class.
	/// </summary>
	/// <param name="SiteProfileName">SiteProfileName.</param>
	/// <param name="Area">Area.</param>
	/// <param name="Building">Building.</param>
	/// <param name="Floor">Floor.</param>
	public ProvisionNfvRequestSite(string? SiteProfileName = default, CreateSiteRequestSiteArea Area = default, ProvisionNfvRequestSiteBuilding Building = default, ProvisionNfvRequestSiteFloor Floor = default)
	{
		this.SiteProfileName = SiteProfileName;
		this.Area = Area;
		this.Building = Building;
		this.Floor = Floor;
	}

	/// <summary>
	/// Gets or Sets SiteProfileName
	/// </summary>
	[DataMember(Name = "siteProfileName", EmitDefaultValue = false)]
	public string? SiteProfileName { get; set; }

	/// <summary>
	/// Gets or Sets Area
	/// </summary>
	[DataMember(Name = "area", EmitDefaultValue = false)]
	public CreateSiteRequestSiteArea Area { get; set; }

	/// <summary>
	/// Gets or Sets Building
	/// </summary>
	[DataMember(Name = "building", EmitDefaultValue = false)]
	public ProvisionNfvRequestSiteBuilding Building { get; set; }

	/// <summary>
	/// Gets or Sets Floor
	/// </summary>
	[DataMember(Name = "floor", EmitDefaultValue = false)]
	public ProvisionNfvRequestSiteFloor Floor { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ProvisionNFVRequestSite {\n");
		sb.Append("  SiteProfileName: ").Append(SiteProfileName).Append("\n");
		sb.Append("  Area: ").Append(Area).Append("\n");
		sb.Append("  Building: ").Append(Building).Append("\n");
		sb.Append("  Floor: ").Append(Floor).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
