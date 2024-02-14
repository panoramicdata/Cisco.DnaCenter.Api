using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SiteProvisionRequestImageInfo
/// </summary>
[DataContract]
public class SiteProvisionRequestImageInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SiteProvisionRequestImageInfo" /> class.
	/// </summary>
	/// <param name="ImageId">ImageId.</param>
	/// <param name="Skip">Skip.</param>
	public SiteProvisionRequestImageInfo(
		string? ImageId = default,
		bool? Skip = default
		)
	{
		this.ImageId = ImageId;
		this.Skip = Skip;
	}

	/// <summary>
	/// Gets or Sets ImageId
	/// </summary>
	[DataMember(Name = "imageId", EmitDefaultValue = false)]
	public string? ImageId { get; set; }

	/// <summary>
	/// Gets or Sets Skip
	/// </summary>
	[DataMember(Name = "skip", EmitDefaultValue = false)]
	public bool? Skip { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SiteProvisionRequestImageInfo {\n");
		sb.Append("  ImageId: ").Append(ImageId).Append("\n");
		sb.Append("  Skip: ").Append(Skip).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}