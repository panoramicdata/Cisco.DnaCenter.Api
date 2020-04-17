using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// NetworkDeviceBriefNio
	/// </summary>
	[DataContract]
	public partial class NetworkDeviceBriefNio
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NetworkDeviceBriefNio" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Role">Role.</param>
		/// <param name="RoleSource">RoleSource.</param>
		public NetworkDeviceBriefNio(string? Id = default, string? Role = default, string? RoleSource = default)
		{
			this.Id = Id;
			this.Role = Role;
			this.RoleSource = RoleSource;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Role
		/// </summary>
		[DataMember(Name = "role", EmitDefaultValue = false)]
		public string? Role { get; set; }
		/// <summary>
		/// Gets or Sets RoleSource
		/// </summary>
		[DataMember(Name = "roleSource", EmitDefaultValue = false)]
		public string? RoleSource { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkDeviceBriefNio {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Role: ").Append(Role).Append("\n");
			sb.Append("  RoleSource: ").Append(RoleSource).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
