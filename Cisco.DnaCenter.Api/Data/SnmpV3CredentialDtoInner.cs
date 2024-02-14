using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SNMPvCredentialDtoInner
/// </summary>
[DataContract]
public class SnmpV3CredentialDtoInner
{
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
	/// Gets or Sets CredentialType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CredentialTypeEnum
	{

		/// <summary>
		/// Enum GLOBAL for "GLOBAL"
		/// </summary>
		[EnumMember(Value = "GLOBAL")]
		GLOBAL,

		/// <summary>
		/// Enum APP for "APP"
		/// </summary>
		[EnumMember(Value = "APP")]
		APP
	}

	/// <summary>
	/// Gets or Sets PrivacyType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrivacyTypeEnum
	{

		/// <summary>
		/// Enum DES for "DES"
		/// </summary>
		[EnumMember(Value = "DES")]
		DES,

		/// <summary>
		/// Enum AES128 for "AES128"
		/// </summary>
		[EnumMember(Value = "AES128")]
		AES128
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
	/// Gets or Sets AuthType
	/// </summary>
	[DataMember(Name = "authType", EmitDefaultValue = false)]
	public AuthTypeEnum? AuthType { get; set; }

	/// <summary>
	/// Gets or Sets CredentialType
	/// </summary>
	[DataMember(Name = "credentialType", EmitDefaultValue = false)]
	public CredentialTypeEnum? CredentialType { get; set; }

	/// <summary>
	/// Gets or Sets PrivacyType
	/// </summary>
	[DataMember(Name = "privacyType", EmitDefaultValue = false)]
	public PrivacyTypeEnum? PrivacyType { get; set; }

	/// <summary>
	/// Gets or Sets SnmpMode
	/// </summary>
	[DataMember(Name = "snmpMode", EmitDefaultValue = false)]
	public SnmpModeEnum? SnmpMode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SnmpV3CredentialDtoInner" /> class.
	/// </summary>
	/// <param name="AuthPassword">AuthPassword.</param>
	/// <param name="AuthType">AuthType.</param>
	/// <param name="Comments">Comments.</param>
	/// <param name="CredentialType">CredentialType.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Id">Id.</param>
	/// <param name="InstanceTenantId">InstanceTenantId.</param>
	/// <param name="InstanceUuid">InstanceUuid.</param>
	/// <param name="PrivacyPassword">PrivacyPassword.</param>
	/// <param name="PrivacyType">PrivacyType.</param>
	/// <param name="SnmpMode">SnmpMode.</param>
	/// <param name="Username">Username.</param>
	public SnmpV3CredentialDtoInner(string? AuthPassword = default, AuthTypeEnum? AuthType = default, string? Comments = default, CredentialTypeEnum? CredentialType = default, string? Description = default, string? Id = default, string? InstanceTenantId = default, string? InstanceUuid = default, string? PrivacyPassword = default, PrivacyTypeEnum? PrivacyType = default, SnmpModeEnum? SnmpMode = default, string? Username = default)
	{
		this.AuthPassword = AuthPassword;
		this.AuthType = AuthType;
		this.Comments = Comments;
		this.CredentialType = CredentialType;
		this.Description = Description;
		this.Id = Id;
		this.InstanceTenantId = InstanceTenantId;
		this.InstanceUuid = InstanceUuid;
		this.PrivacyPassword = PrivacyPassword;
		this.PrivacyType = PrivacyType;
		this.SnmpMode = SnmpMode;
		this.Username = Username;
	}

	/// <summary>
	/// Gets or Sets AuthPassword
	/// </summary>
	[DataMember(Name = "authPassword", EmitDefaultValue = false)]
	public string? AuthPassword { get; set; }

	/// <summary>
	/// Gets or Sets Comments
	/// </summary>
	[DataMember(Name = "comments", EmitDefaultValue = false)]
	public string? Comments { get; set; }

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
	/// Gets or Sets InstanceTenantId
	/// </summary>
	[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
	public string? InstanceTenantId { get; set; }

	/// <summary>
	/// Gets or Sets InstanceUuid
	/// </summary>
	[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
	public string? InstanceUuid { get; set; }

	/// <summary>
	/// Gets or Sets PrivacyPassword
	/// </summary>
	[DataMember(Name = "privacyPassword", EmitDefaultValue = false)]
	public string? PrivacyPassword { get; set; }

	/// <summary>
	/// Gets or Sets Username
	/// </summary>
	[DataMember(Name = "username", EmitDefaultValue = false)]
	public string? Username { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SNMPvCredentialDtoInner {\n");
		sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
		sb.Append("  AuthType: ").Append(AuthType).Append("\n");
		sb.Append("  Comments: ").Append(Comments).Append("\n");
		sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
		sb.Append("  Description: ").Append(Description).Append("\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
		sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
		sb.Append("  PrivacyPassword: ").Append(PrivacyPassword).Append("\n");
		sb.Append("  PrivacyType: ").Append(PrivacyType).Append("\n");
		sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
		sb.Append("  Username: ").Append(Username).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
