using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoAaaCredentials
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoAaaCredentials
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoAaaCredentials" /> class.
		/// </summary>
		/// <param name="Password">Password.</param>
		/// <param name="Username">Username.</param>
		public DeviceDeviceInfoAaaCredentials(string? Password = default, string? Username = default)
		{
			this.Password = Password;
			this.Username = Username;
		}

		/// <summary>
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "password", EmitDefaultValue = false)]
		public string? Password { get; set; }
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
			sb.Append("class DeviceDeviceInfoAaaCredentials {\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
