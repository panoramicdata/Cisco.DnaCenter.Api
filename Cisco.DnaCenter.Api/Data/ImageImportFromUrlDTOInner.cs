using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ImageImportFromUrlDtoInner
/// </summary>
[DataContract]
public class ImageImportFromUrlDtoInner
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ImageImportFromUrlDtoInner" /> class.
	/// </summary>
	/// <param name="ApplicationType">ApplicationType.</param>
	/// <param name="ImageFamily">ImageFamily.</param>
	/// <param name="SourceURL">SourceURL.</param>
	/// <param name="ThirdParty">ThirdParty.</param>
	/// <param name="Vendor">Vendor.</param>
	public ImageImportFromUrlDtoInner(string? ApplicationType = default, string? ImageFamily = default, string? SourceURL = default, bool? ThirdParty = default, string? Vendor = default)
	{
		this.ApplicationType = ApplicationType;
		this.ImageFamily = ImageFamily;
		this.SourceURL = SourceURL;
		this.ThirdParty = ThirdParty;
		this.Vendor = Vendor;
	}

	/// <summary>
	/// Gets or Sets ApplicationType
	/// </summary>
	[DataMember(Name = "applicationType", EmitDefaultValue = false)]
	public string? ApplicationType { get; set; }

	/// <summary>
	/// Gets or Sets ImageFamily
	/// </summary>
	[DataMember(Name = "imageFamily", EmitDefaultValue = false)]
	public string? ImageFamily { get; set; }

	/// <summary>
	/// Gets or Sets SourceURL
	/// </summary>
	[DataMember(Name = "sourceURL", EmitDefaultValue = false)]
	public string? SourceURL { get; set; }

	/// <summary>
	/// Gets or Sets ThirdParty
	/// </summary>
	[DataMember(Name = "thirdParty", EmitDefaultValue = false)]
	public bool? ThirdParty { get; set; }

	/// <summary>
	/// Gets or Sets Vendor
	/// </summary>
	[DataMember(Name = "vendor", EmitDefaultValue = false)]
	public string? Vendor { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ImageImportFromUrlDtoInner {\n");
		sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
		sb.Append("  ImageFamily: ").Append(ImageFamily).Append("\n");
		sb.Append("  SourceURL: ").Append(SourceURL).Append("\n");
		sb.Append("  ThirdParty: ").Append(ThirdParty).Append("\n");
		sb.Append("  Vendor: ").Append(Vendor).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
