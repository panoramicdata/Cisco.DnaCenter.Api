using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateGlobalPoolRequest
	/// </summary>
	[DataContract]
	public partial class UpdateGlobalPoolRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateGlobalPoolRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public UpdateGlobalPoolRequest(UpdateGlobalPoolRequestSettings Settings = default)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public UpdateGlobalPoolRequestSettings Settings { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateGlobalPoolRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
