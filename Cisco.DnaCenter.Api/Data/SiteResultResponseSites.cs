using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SiteResultResponseSites
/// </summary>
[DataContract]
public class SiteResultResponseSites
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SiteResultResponseSites" /> class.
	/// </summary>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="GroupNameHierarchy">GroupNameHierarchy.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Latitude">Latitude.</param>
	/// <param name="LocationAddress">LocationAddress.</param>
	/// <param name="LocationCountry">LocationCountry.</param>
	/// <param name="LocationType">LocationType.</param>
	/// <param name="Longitude">Longitude.</param>
	/// <param name="Name">Name.</param>
	/// <param name="ParentId">ParentId.</param>
	public SiteResultResponseSites(string? DisplayName = default, string? GroupNameHierarchy = default, string? Id = default, string? Latitude = default, string? LocationAddress = default, string? LocationCountry = default, string? LocationType = default, string? Longitude = default, string? Name = default, string? ParentId = default)
	{
		this.DisplayName = DisplayName;
		this.GroupNameHierarchy = GroupNameHierarchy;
		this.Id = Id;
		this.Latitude = Latitude;
		this.LocationAddress = LocationAddress;
		this.LocationCountry = LocationCountry;
		this.LocationType = LocationType;
		this.Longitude = Longitude;
		this.Name = Name;
		this.ParentId = ParentId;
	}

	/// <summary>
	/// Gets or Sets DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string? DisplayName { get; set; }

	/// <summary>
	/// Gets or Sets GroupNameHierarchy
	/// </summary>
	[DataMember(Name = "groupNameHierarchy", EmitDefaultValue = false)]
	public string? GroupNameHierarchy { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Gets or Sets Latitude
	/// </summary>
	[DataMember(Name = "latitude", EmitDefaultValue = false)]
	public string? Latitude { get; set; }

	/// <summary>
	/// Gets or Sets LocationAddress
	/// </summary>
	[DataMember(Name = "locationAddress", EmitDefaultValue = false)]
	public string? LocationAddress { get; set; }

	/// <summary>
	/// Gets or Sets LocationCountry
	/// </summary>
	[DataMember(Name = "locationCountry", EmitDefaultValue = false)]
	public string? LocationCountry { get; set; }

	/// <summary>
	/// Gets or Sets LocationType
	/// </summary>
	[DataMember(Name = "locationType", EmitDefaultValue = false)]
	public string? LocationType { get; set; }

	/// <summary>
	/// Gets or Sets Longitude
	/// </summary>
	[DataMember(Name = "longitude", EmitDefaultValue = false)]
	public string? Longitude { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets ParentId
	/// </summary>
	[DataMember(Name = "parentId", EmitDefaultValue = false)]
	public string? ParentId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SiteResultResponseSites {\n");
		sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
		sb.Append("  GroupNameHierarchy: ").Append(GroupNameHierarchy).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  Latitude: ").Append(Latitude).Append("\n");
		sb.Append("  LocationAddress: ").Append(LocationAddress).Append("\n");
		sb.Append("  LocationCountry: ").Append(LocationCountry).Append("\n");
		sb.Append("  LocationType: ").Append(LocationType).Append("\n");
		sb.Append("  Longitude: ").Append(Longitude).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  ParentId: ").Append(ParentId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
