using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateDeviceCredentialsRequestSettingsCliCredential
	/// </summary>
	[DataContract]
	public class CreateDeviceCredentialsRequestSettingsCliCredential
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateDeviceCredentialsRequestSettingsCliCredential" /> class.
		/// </summary>
		/// <param name="Description">Description.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Password">Password.</param>
		/// <param name="EnablePassword">EnablePassword.</param>
		public CreateDeviceCredentialsRequestSettingsCliCredential(string? Description = default, string? Username = default, string? Password = default, string? EnablePassword = default)
		{
			this.Description = Description;
			this.Username = Username;
			this.Password = Password;
			this.EnablePassword = EnablePassword;
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
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "password", EmitDefaultValue = false)]
		public string? Password { get; set; }
		/// <summary>
		/// Gets or Sets EnablePassword
		/// </summary>
		[DataMember(Name = "enablePassword", EmitDefaultValue = false)]
		public string? EnablePassword { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateDeviceCredentialsRequestSettingsCliCredential {\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  EnablePassword: ").Append(EnablePassword).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
