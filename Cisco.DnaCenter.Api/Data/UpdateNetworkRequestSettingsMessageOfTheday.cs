using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// UpdateNetworkRequestSettingsMessageOfTheday
/// </summary>
[DataContract]
public class UpdateNetworkRequestSettingsMessageOfTheday
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettingsMessageOfTheday" /> class.
	/// </summary>
	/// <param name="BannerMessage">BannerMessage.</param>
	/// <param name="RetainExistingBanner">RetainExistingBanner.</param>
	public UpdateNetworkRequestSettingsMessageOfTheday(string? BannerMessage = default, bool? RetainExistingBanner = default)
	{
		this.BannerMessage = BannerMessage;
		this.RetainExistingBanner = RetainExistingBanner;
	}

	/// <summary>
	/// Gets or Sets BannerMessage
	/// </summary>
	[DataMember(Name = "bannerMessage", EmitDefaultValue = false)]
	public string? BannerMessage { get; set; }

	/// <summary>
	/// Gets or Sets RetainExistingBanner
	/// </summary>
	[DataMember(Name = "retainExistingBanner", EmitDefaultValue = false)]
	public bool? RetainExistingBanner { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UpdateNetworkRequestSettingsMessageOfTheday {\n");
		sb.Append("  BannerMessage: ").Append(BannerMessage).Append("\n");
		sb.Append("  RetainExistingBanner: ").Append(RetainExistingBanner).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
