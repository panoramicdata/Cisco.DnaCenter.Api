using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequestSettings
	/// </summary>
	[DataContract]
	public class UpdateDeviceCredentialsRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequestSettings" /> class.
		/// </summary>
		/// <param name="CliCredential">CliCredential.</param>
		/// <param name="SnmpV2cRead">SnmpV2cRead.</param>
		/// <param name="SnmpV2cWrite">SnmpV2cWrite.</param>
		/// <param name="SnmpV3">SnmpV3.</param>
		/// <param name="HttpsRead">HttpsRead.</param>
		/// <param name="HttpsWrite">HttpsWrite.</param>
		public UpdateDeviceCredentialsRequestSettings(UpdateDeviceCredentialsRequestSettingsCliCredential CliCredential = default, UpdateDeviceCredentialsRequestSettingsSnmpV2cRead SnmpV2cRead = default, UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite SnmpV2cWrite = default, UpdateDeviceCredentialsRequestSettingsSnmpV3 SnmpV3 = default, UpdateDeviceCredentialsRequestSettingsHttpsRead HttpsRead = default, UpdateDeviceCredentialsRequestSettingsHttpsRead HttpsWrite = default)
		{
			this.CliCredential = CliCredential;
			this.SnmpV2cRead = SnmpV2cRead;
			this.SnmpV2cWrite = SnmpV2cWrite;
			this.SnmpV3 = SnmpV3;
			this.HttpsRead = HttpsRead;
			this.HttpsWrite = HttpsWrite;
		}

		/// <summary>
		/// Gets or Sets CliCredential
		/// </summary>
		[DataMember(Name = "cliCredential", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsCliCredential CliCredential { get; set; }

		/// <summary>
		/// Gets or Sets SnmpV2cRead
		/// </summary>
		[DataMember(Name = "snmpV2cRead", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsSnmpV2cRead SnmpV2cRead { get; set; }

		/// <summary>
		/// Gets or Sets SnmpV2cWrite
		/// </summary>
		[DataMember(Name = "snmpV2cWrite", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite SnmpV2cWrite { get; set; }

		/// <summary>
		/// Gets or Sets SnmpV3
		/// </summary>
		[DataMember(Name = "snmpV3", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsSnmpV3 SnmpV3 { get; set; }

		/// <summary>
		/// Gets or Sets HttpsRead
		/// </summary>
		[DataMember(Name = "httpsRead", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsHttpsRead HttpsRead { get; set; }

		/// <summary>
		/// Gets or Sets HttpsWrite
		/// </summary>
		[DataMember(Name = "httpsWrite", EmitDefaultValue = false)]
		public UpdateDeviceCredentialsRequestSettingsHttpsRead HttpsWrite { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDeviceCredentialsRequestSettings {\n");
			sb.Append("  CliCredential: ").Append(CliCredential).Append("\n");
			sb.Append("  SnmpV2cRead: ").Append(SnmpV2cRead).Append("\n");
			sb.Append("  SnmpV2cWrite: ").Append(SnmpV2cWrite).Append("\n");
			sb.Append("  SnmpV3: ").Append(SnmpV3).Append("\n");
			sb.Append("  HttpsRead: ").Append(HttpsRead).Append("\n");
			sb.Append("  HttpsWrite: ").Append(HttpsWrite).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
