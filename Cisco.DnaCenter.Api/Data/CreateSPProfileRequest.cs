using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSPProfileRequest
	/// </summary>
	[DataContract]
	public partial class CreateSpProfileRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSpProfileRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public CreateSpProfileRequest(CreateSpProfileRequestSettings Settings = default)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public CreateSpProfileRequestSettings Settings { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSPProfileRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
