using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequestSettingsHttpsRead
	/// </summary>
	[DataContract]
	public partial class UpdateDeviceCredentialsRequestSettingsHttpsRead
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequestSettingsHttpsRead" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Password">Password.</param>
		/// <param name="Port">Port.</param>
		/// <param name="Id">Id.</param>
		public UpdateDeviceCredentialsRequestSettingsHttpsRead(string? Name = default, string? Username = default, string? Password = default, string? Port = default, string? Id = default)
		{
			this.Name = Name;
			this.Username = Username;
			this.Password = Password;
			this.Port = Port;
			this.Id = Id;
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
		public string? Port { get; set; }
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
			sb.Append("class UpdateDeviceCredentialsRequestSettingsHttpsRead {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
