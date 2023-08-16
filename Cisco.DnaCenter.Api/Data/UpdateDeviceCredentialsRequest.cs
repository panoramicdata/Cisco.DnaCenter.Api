using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequest
	/// </summary>
	[DataContract]
	public class UpdateDeviceCredentialsRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>

		public UpdateDeviceCredentialsRequest(): this(default) { }

		public UpdateDeviceCredentialsRequest(UpdateDeviceCredentialsRequestSettings Settings)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettings Settings { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDeviceCredentialsRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
