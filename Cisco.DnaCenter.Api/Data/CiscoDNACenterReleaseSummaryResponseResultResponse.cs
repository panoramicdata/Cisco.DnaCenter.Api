using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CiscoDNACenterReleaseSummaryResponseResultResponse
/// </summary>
[DataContract]
public class CiscoDNACenterReleaseSummaryResponseResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CiscoDNACenterReleaseSummaryResponseResultResponse" /> class.
	/// </summary>
	/// <param name="InstalledVersion">InstalledVersion.</param>
	/// <param name="Name">Name.</param>
	/// <param name="SystemVersion">SystemVersion.</param>
	/// <param name="TenantId">TenantId.</param>
	/// <param name="CorePackages">CorePackages.</param>
	/// <param name="Packages">Packages.</param>
	/// <param name="SupportedDirectUpdates">SupportedDirectUpdates.</param>
	public CiscoDNACenterReleaseSummaryResponseResultResponse(
		string? InstalledVersion = default,
		string? Name = default,
		string? SystemVersion = default,
		string ? TenantId = default,
		List<string> CorePackages = default,
		List<string> Packages = default,
		List<string> SupportedDirectUpdates = default)
	{
		this.InstalledVersion = InstalledVersion;
		this.Name = Name;
		this.SystemVersion = SystemVersion;
		this.TenantId = TenantId;
		this.CorePackages = CorePackages;
		this.Packages = Packages;
		this.SupportedDirectUpdates = SupportedDirectUpdates;

		// Undocumented in response:
		// DisplayName
		// DisplayVersion
		// Modified
		// SystemPackages
	}

	/// <summary>
	/// Gets or Sets InstalledVersion
	/// </summary>
	[DataMember(Name = "installedVersion", EmitDefaultValue = false)]
	public string? InstalledVersion { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets SystemVersion
	/// </summary>
	[DataMember(Name = "systemVersion", EmitDefaultValue = false)]
	public string? SystemVersion { get; set; }

	/// <summary>
	/// Gets or Sets TenantId
	/// </summary>
	[DataMember(Name = "tenantId", EmitDefaultValue = false)]
	public string? TenantId { get; set; }

	/// <summary>
	/// Gets or Sets CorePackages
	/// </summary>
	[DataMember(Name = "corePackages", EmitDefaultValue = false)]
	public List<string> CorePackages { get; set; }

	/// <summary>
	/// Gets or Sets Packages
	/// </summary>
	[DataMember(Name = "packages", EmitDefaultValue = false)]
	public List<string> Packages { get; set; }

	/// <summary>
	/// Gets or Sets SupportedDirectUpdates
	/// </summary>
	[DataMember(Name = "supportedDirectUpdates", EmitDefaultValue = false)]
	public List<string> SupportedDirectUpdates { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CiscoDNACenterReleaseSummaryResponseResult {\n");
		sb.Append("  InstalledVersion: ").Append(InstalledVersion).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  SystemVersion: ").Append(SystemVersion).Append("\n");
		sb.Append("  TenantId: ").Append(TenantId).Append("\n");
		sb.Append("  CorePackages: ").Append(CorePackages).Append("\n");
		sb.Append("  Packages: ").Append(Packages).Append("\n");
		sb.Append("  SupportedDirectUpdates: ").Append(SupportedDirectUpdates).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
