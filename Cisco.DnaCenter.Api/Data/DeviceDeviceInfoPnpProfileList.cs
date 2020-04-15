using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoPnpProfileList
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoPnpProfileList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoPnpProfileList" /> class.
		/// </summary>
		/// <param name="ProfileName">ProfileName.</param>
		/// <param name="DiscoveryCreated">DiscoveryCreated.</param>
		/// <param name="CreatedBy">CreatedBy.</param>
		/// <param name="PrimaryEndpoint">PrimaryEndpoint.</param>
		/// <param name="SecondaryEndpoint">SecondaryEndpoint.</param>
		public DeviceDeviceInfoPnpProfileList(string? ProfileName = default, bool? DiscoveryCreated = default, string? CreatedBy = default, DeviceDeviceInfoPrimaryEndpoint PrimaryEndpoint = default, DeviceDeviceInfoPrimaryEndpoint SecondaryEndpoint = default)
		{
			this.ProfileName = ProfileName;
			this.DiscoveryCreated = DiscoveryCreated;
			this.CreatedBy = CreatedBy;
			this.PrimaryEndpoint = PrimaryEndpoint;
			this.SecondaryEndpoint = SecondaryEndpoint;
		}

		/// <summary>
		/// Gets or Sets ProfileName
		/// </summary>
		[DataMember(Name = "profileName", EmitDefaultValue = false)]
		public string? ProfileName { get; set; }
		/// <summary>
		/// Gets or Sets DiscoveryCreated
		/// </summary>
		[DataMember(Name = "discoveryCreated", EmitDefaultValue = false)]
		public bool? DiscoveryCreated { get; set; }
		/// <summary>
		/// Gets or Sets CreatedBy
		/// </summary>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public string? CreatedBy { get; set; }
		/// <summary>
		/// Gets or Sets PrimaryEndpoint
		/// </summary>
		[DataMember(Name = "primaryEndpoint", EmitDefaultValue = false)]
		public DeviceDeviceInfoPrimaryEndpoint PrimaryEndpoint { get; set; }
		/// <summary>
		/// Gets or Sets SecondaryEndpoint
		/// </summary>
		[DataMember(Name = "secondaryEndpoint", EmitDefaultValue = false)]
		public DeviceDeviceInfoPrimaryEndpoint SecondaryEndpoint { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoPnpProfileList {\n");
			sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
			sb.Append("  DiscoveryCreated: ").Append(DiscoveryCreated).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  PrimaryEndpoint: ").Append(PrimaryEndpoint).Append("\n");
			sb.Append("  SecondaryEndpoint: ").Append(SecondaryEndpoint).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
