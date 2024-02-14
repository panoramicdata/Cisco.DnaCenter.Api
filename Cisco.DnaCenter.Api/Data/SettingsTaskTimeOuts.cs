using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SettingsTaskTimeOuts
/// </summary>
[DataContract]
public class SettingsTaskTimeOuts
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SettingsTaskTimeOuts" /> class.
	/// </summary>
	/// <param name="ConfigTimeOut">ConfigTimeOut.</param>
	/// <param name="GeneralTimeOut">GeneralTimeOut.</param>
	/// <param name="ImageDownloadTimeOut">ImageDownloadTimeOut.</param>
	public SettingsTaskTimeOuts(int? ConfigTimeOut = default, int? GeneralTimeOut = default, int? ImageDownloadTimeOut = default)
	{
		this.ConfigTimeOut = ConfigTimeOut;
		this.GeneralTimeOut = GeneralTimeOut;
		this.ImageDownloadTimeOut = ImageDownloadTimeOut;
	}

	/// <summary>
	/// Gets or Sets ConfigTimeOut
	/// </summary>
	[DataMember(Name = "configTimeOut", EmitDefaultValue = false)]
	public int? ConfigTimeOut { get; set; }

	/// <summary>
	/// Gets or Sets GeneralTimeOut
	/// </summary>
	[DataMember(Name = "generalTimeOut", EmitDefaultValue = false)]
	public int? GeneralTimeOut { get; set; }

	/// <summary>
	/// Gets or Sets ImageDownloadTimeOut
	/// </summary>
	[DataMember(Name = "imageDownloadTimeOut", EmitDefaultValue = false)]
	public int? ImageDownloadTimeOut { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SettingsTaskTimeOuts {\n");
		sb.Append("  ConfigTimeOut: ").Append(ConfigTimeOut).Append("\n");
		sb.Append("  GeneralTimeOut: ").Append(GeneralTimeOut).Append("\n");
		sb.Append("  ImageDownloadTimeOut: ").Append(ImageDownloadTimeOut).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
