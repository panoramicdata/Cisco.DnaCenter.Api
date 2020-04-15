using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateDeviceCredentialsRequestSettingsHttpsRead
	/// </summary>
	[DataContract]
	public partial class CreateDeviceCredentialsRequestSettingsHttpsRead
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateDeviceCredentialsRequestSettingsHttpsRead" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Password">Password.</param>
		/// <param name="Port">Port.</param>
		public CreateDeviceCredentialsRequestSettingsHttpsRead(string? Name = default, string? Username = default, string? Password = default, decimal? Port = default)
		{
			this.Name = Name;
			this.Username = Username;
			this.Password = Password;
			this.Port = Port;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
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
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public decimal? Port { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateDeviceCredentialsRequestSettingsHttpsRead {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
