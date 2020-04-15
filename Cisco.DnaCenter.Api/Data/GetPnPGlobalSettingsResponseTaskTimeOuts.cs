using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetPnPGlobalSettingsResponseTaskTimeOuts
	/// </summary>
	[DataContract]
	public partial class GetPnPGlobalSettingsResponseTaskTimeOuts
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetPnPGlobalSettingsResponseTaskTimeOuts" /> class.
		/// </summary>
		/// <param name="ImageDownloadTimeOut">ImageDownloadTimeOut.</param>
		/// <param name="ConfigTimeOut">ConfigTimeOut.</param>
		/// <param name="GeneralTimeOut">GeneralTimeOut.</param>
		public GetPnPGlobalSettingsResponseTaskTimeOuts(decimal? ImageDownloadTimeOut = default, decimal? ConfigTimeOut = default, decimal? GeneralTimeOut = default)
		{
			this.ImageDownloadTimeOut = ImageDownloadTimeOut;
			this.ConfigTimeOut = ConfigTimeOut;
			this.GeneralTimeOut = GeneralTimeOut;
		}

		/// <summary>
		/// Gets or Sets ImageDownloadTimeOut
		/// </summary>
		[DataMember(Name = "imageDownloadTimeOut", EmitDefaultValue = false)]
		public decimal? ImageDownloadTimeOut { get; set; }
		/// <summary>
		/// Gets or Sets ConfigTimeOut
		/// </summary>
		[DataMember(Name = "configTimeOut", EmitDefaultValue = false)]
		public decimal? ConfigTimeOut { get; set; }
		/// <summary>
		/// Gets or Sets GeneralTimeOut
		/// </summary>
		[DataMember(Name = "generalTimeOut", EmitDefaultValue = false)]
		public decimal? GeneralTimeOut { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetPnPGlobalSettingsResponseTaskTimeOuts {\n");
			sb.Append("  ImageDownloadTimeOut: ").Append(ImageDownloadTimeOut).Append("\n");
			sb.Append("  ConfigTimeOut: ").Append(ConfigTimeOut).Append("\n");
			sb.Append("  GeneralTimeOut: ").Append(GeneralTimeOut).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
