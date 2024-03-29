namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SitesInfoDto
/// </summary>
[DataContract]
public class SitesInfoDto
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SitesInfoDto" /> class.
	/// </summary>
	public SitesInfoDto() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="SitesInfoDto" /> class.
	/// </summary>
	/// <param name="SiteUuids">SiteUuids.</param>
	public SitesInfoDto(List<string> SiteUuids)
	{
		this.SiteUuids = SiteUuids;
	}

	/// <summary>
	/// Gets or Sets SiteUuids
	/// </summary>
	[DataMember(Name = "siteUuids", EmitDefaultValue = false)]
	public List<string> SiteUuids { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SitesInfoDto {\n");
		sb.Append("  SiteUuids: ").Append(SiteUuids).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
