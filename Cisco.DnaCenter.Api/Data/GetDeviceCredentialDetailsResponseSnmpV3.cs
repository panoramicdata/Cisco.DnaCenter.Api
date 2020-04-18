using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceCredentialDetailsResponseSnmpV3
	/// </summary>
	[DataContract]
	public class GetDeviceCredentialDetailsResponseSnmpV3
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceCredentialDetailsResponseSnmpV3" /> class.
		/// </summary>
		/// <param name="Username">Username.</param>
		/// <param name="AuthPassword">AuthPassword.</param>
		/// <param name="AuthType">AuthType.</param>
		/// <param name="PrivacyPassword">PrivacyPassword.</param>
		/// <param name="PrivacyType">PrivacyType.</param>
		/// <param name="SnmpMode">SnmpMode.</param>
		/// <param name="Comments">Comments.</param>
		/// <param name="Description">Description.</param>
		/// <param name="CredentialType">CredentialType.</param>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="Id">Id.</param>
		public GetDeviceCredentialDetailsResponseSnmpV3(string? Username = default, string? AuthPassword = default, string? AuthType = default, string? PrivacyPassword = default, string? PrivacyType = default, string? SnmpMode = default, string? Comments = default, string? Description = default, string? CredentialType = default, string? InstanceUuid = default, string? InstanceTenantId = default, string? Id = default)
		{
			this.Username = Username;
			this.AuthPassword = AuthPassword;
			this.AuthType = AuthType;
			this.PrivacyPassword = PrivacyPassword;
			this.PrivacyType = PrivacyType;
			this.SnmpMode = SnmpMode;
			this.Comments = Comments;
			this.Description = Description;
			this.CredentialType = CredentialType;
			this.InstanceUuid = InstanceUuid;
			this.InstanceTenantId = InstanceTenantId;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string? Username { get; set; }
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
		/// Gets or Sets SnmpMode
		/// </summary>
		[DataMember(Name = "snmpMode", EmitDefaultValue = false)]
		public string? SnmpMode { get; set; }
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
		/// Gets or Sets CredentialType
		/// </summary>
		[DataMember(Name = "credentialType", EmitDefaultValue = false)]
		public string? CredentialType { get; set; }
		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
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
			sb.Append("class GetDeviceCredentialDetailsResponseSnmpV3 {\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
			sb.Append("  AuthType: ").Append(AuthType).Append("\n");
			sb.Append("  PrivacyPassword: ").Append(PrivacyPassword).Append("\n");
			sb.Append("  PrivacyType: ").Append(PrivacyType).Append("\n");
			sb.Append("  SnmpMode: ").Append(SnmpMode).Append("\n");
			sb.Append("  Comments: ").Append(Comments).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
