using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSPProfileRequest
	/// </summary>
	[DataContract]
	public partial class UpdateSpProfileRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSpProfileRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public UpdateSpProfileRequest(UpdateSpProfileRequestSettings Settings = default)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public UpdateSpProfileRequestSettings Settings { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSPProfileRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
