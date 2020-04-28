using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceCredentialDetailsResponseCli
	/// </summary>
	[DataContract]
	public class GetDeviceCredentialDetailsResponseCli
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceCredentialDetailsResponseCli" /> class.
		/// </summary>
		/// <param name="Username">Username.</param>
		/// <param name="EnablePassword">EnablePassword.</param>
		/// <param name="Password">Password.</param>
		/// <param name="Comments">Comments.</param>
		/// <param name="Description">Description.</param>
		/// <param name="CredentialType">CredentialType.</param>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="Id">Id.</param>
		public GetDeviceCredentialDetailsResponseCli(string? Username = default, string? EnablePassword = default, string? Password = default, string? Comments = default, string? Description = default, string? CredentialType = default, string? InstanceUuid = default, string? InstanceTenantId = default, string? Id = default)
		{
			this.Username = Username;
			this.EnablePassword = EnablePassword;
			this.Password = Password;
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
		/// Gets or Sets EnablePassword
		/// </summary>
		[DataMember(Name = "enablePassword", EmitDefaultValue = false)]
		public string? EnablePassword { get; set; }

		/// <summary>
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "password", EmitDefaultValue = false)]
		public string? Password { get; set; }

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
			sb.Append("class GetDeviceCredentialDetailsResponseCli {\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  EnablePassword: ").Append(EnablePassword).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
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
