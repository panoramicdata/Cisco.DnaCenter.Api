using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// AddSiteInSdaFabricRequestInner
/// </summary>
[DataContract]
public class AddSiteInSdaFabricRequestInner
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddSiteInSdaFabricRequestInner" /> class.
	/// </summary>
	/// <param name="FabricName">FabricName.</param>
	/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
	public AddSiteInSdaFabricRequestInner(string? FabricName = default, string? SiteNameHierarchy = default)
	{
		this.FabricName = FabricName;
		this.SiteNameHierarchy = SiteNameHierarchy;
	}

	/// <summary>
	/// Gets or Sets FabricName
	/// </summary>
	[DataMember(Name = "fabricName", EmitDefaultValue = false)]
	public string? FabricName { get; set; }

	/// <summary>
	/// Gets or Sets SiteNameHierarchy
	/// </summary>
	[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
	public string? SiteNameHierarchy { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AddSiteInSdaFabricRequestInner {\n");
		sb.Append("  FabricName: ").Append(FabricName).Append("\n");
		sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
