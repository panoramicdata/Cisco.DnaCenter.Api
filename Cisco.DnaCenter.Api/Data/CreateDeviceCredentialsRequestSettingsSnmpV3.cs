using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// CreateDeviceCredentialsRequestSettingsSnmpV3
/// </summary>
[DataContract]
public class CreateDeviceCredentialsRequestSettingsSnmpV3
{
	/// <summary>
	/// Gets or Sets PrivacyType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrivacyTypeEnum
	{

		/// <summary>
		/// Enum AES128 for "AES128"
		/// </summary>
		[EnumMember(Value = "AES128")]
		AES128,

		/// <summary>
		/// Enum DES for "DES"
		/// </summary>
		[EnumMember(Value = "DES")]
		DES
	}

	/// <summary>
	/// Gets or Sets AuthType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AuthTypeEnum
	{

		/// <summary>
		/// Enum SHA for "SHA"
		/// </summary>
		[EnumMember(Value = "SHA")]
		SHA,

		/// <summary>
		/// Enum MD5 for "MD5"
		/// </summary>
		[EnumMember(Value = "MD5")]
		MD5
	}

	/// <summary>
	/// Gets or Sets SnmpMode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SnmpModeEnum
	{

		/// <summary>
		/// Enum AUTHPRIV for "AUTHPRIV"
		/// </summary>
		[EnumMember(Value = "AUTHPRIV")]
		AUTHPRIV,

		/// <summary>
		/// Enum AUTHNOPRIV for "AUTHNOPRIV"
		/// </summary>
		[EnumMember(Value = "AUTHNOPRIV")]
		AUTHNOPRIV,

		/// <summary>
		/// Enum NOAUTHNOPRIV for "NOAUTHNOPRIV"
		/// </summary>
		[EnumMember(Value = "NOAUTHNOPRIV")]
		NOAUTHNOPRIV
	}

	/// <summary>
	/// Gets or Sets PrivacyType
	/// </summary>
	[DataMember(Name = "privacyType", EmitDefaultValue = false)]
	public PrivacyTypeEnum? PrivacyType { get; set; }

	/// <summary>
	/// Gets or Sets AuthType
	/// </summary>
	[DataMember(Name = "authType", EmitDefaultValue = false)]
	public AuthTypeEnum? AuthType { get; set; }

	/// <summary>
	/// Gets or Sets SnmpMode
	/// </summary>
	[DataMember(Name = "snmpMode", EmitDefaultValue = false)]
	public SnmpModeEnum? SnmpMode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="CreateDeviceCredentialsRequestSettingsSnmpV3" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="Username">Username.</param>
	/// <param name="PrivacyType">PrivacyType.</param>
	/// <param name="PrivacyPassword">PrivacyPassword.</param>
	/// <param name="AuthType">AuthType.</param>
	/// <param name="AuthPassword">AuthPassword.</param>
	/// <param name="SnmpMode">SnmpMode.</param>
	public CreateDeviceCredentialsRequestSettingsSnmpV3(string? Description = default, string? Username = default, PrivacyTypeEnum? PrivacyType = default, string? PrivacyPassword = default, AuthTypeEnum? AuthType = default, string? AuthPassword = default, SnmpModeEnum? SnmpMode = default)
	{
		this.Description = Description;
		this.Username = Username;
		this.PrivacyType = PrivacyType;
		this.PrivacyPassword = PrivacyPassword;
		this.AuthType = AuthType;
		this.AuthPassword = AuthPassword;
		this.SnmpMode = SnmpMode;
	}

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or Sets Username
	/// </summary>
	[DataMember(Name = "username", EmitDefaultValue = false)]
	public string? Username { get; set; }

	/// <summary>
	/// Gets or Sets PrivacyPassword
	/// </summary>
	[DataMember(Name = "privacyPassword", EmitDefaultValue = false)]
	public string? PrivacyPassword { get; set; }

	/// <summary>
	/// Gets or Sets AuthPassword
	/// </summary>
	[DataMember(Name = "authPassword", EmitDefaultValue = false)]
	public string? AuthPassword { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CreateDeviceCredentialsRequestSettingsSnmpV3 {\n");
		sb.Append("  Description: ").Append(Description).Append("\n");
		sb.Append("  Username: ").Append(Username).Append("\n");
		sb.Append("  PrivacyType: ").Append(PrivacyType).Append("\n");
		sb.Append("  PrivacyPassword: ").Append(PrivacyPassword).Append("\n");
		sb.Append("  AuthType: ").Append(AuthType).Append("\n");
		sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
		sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
