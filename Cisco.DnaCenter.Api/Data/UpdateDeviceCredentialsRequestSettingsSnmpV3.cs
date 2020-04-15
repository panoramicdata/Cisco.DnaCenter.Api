using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequestSettingsSnmpV3
	/// </summary>
	[DataContract]
	public partial class UpdateDeviceCredentialsRequestSettingsSnmpV3
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequestSettingsSnmpV3" /> class.
		/// </summary>
		/// <param name="AuthPassword">AuthPassword.</param>
		/// <param name="AuthType">AuthType.</param>
		/// <param name="SnmpMode">SnmpMode.</param>
		/// <param name="PrivacyPassword">PrivacyPassword.</param>
		/// <param name="PrivacyType">PrivacyType.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Id">Id.</param>
		public UpdateDeviceCredentialsRequestSettingsSnmpV3(string? AuthPassword = default, string? AuthType = default, string? SnmpMode = default, string? PrivacyPassword = default, string? PrivacyType = default, string? Username = default, string? Description = default, string? Id = default)
		{
			this.AuthPassword = AuthPassword;
			this.AuthType = AuthType;
			this.SnmpMode = SnmpMode;
			this.PrivacyPassword = PrivacyPassword;
			this.PrivacyType = PrivacyType;
			this.Username = Username;
			this.Description = Description;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets AuthPassword
		/// </summary>
		[DataMember(Name = "authPassword", EmitDefaultValue = false)]
		public string? AuthPassword { get; set; }
		/// <summary>
		/// Gets or Sets AuthType
		/// </summary>
		[DataMember(Name = "authType", EmitDefaultValue = false)]
		public string? AuthType { get; set; }
		/// <summary>
		/// Gets or Sets SnmpMode
		/// </summary>
		[DataMember(Name = "snmpMode", EmitDefaultValue = false)]
		public string? SnmpMode { get; set; }
		/// <summary>
		/// Gets or Sets PrivacyPassword
		/// </summary>
		[DataMember(Name = "privacyPassword", EmitDefaultValue = false)]
		public string? PrivacyPassword { get; set; }
		/// <summary>
		/// Gets or Sets PrivacyType
		/// </summary>
		[DataMember(Name = "privacyType", EmitDefaultValue = false)]
		public string? PrivacyType { get; set; }
		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string? Username { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDeviceCredentialsRequestSettingsSnmpV3 {\n");
			sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
			sb.Append("  AuthType: ").Append(AuthType).Append("\n");
			sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
			sb.Append("  PrivacyPassword: ").Append(PrivacyPassword).Append("\n");
			sb.Append("  PrivacyType: ").Append(PrivacyType).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
