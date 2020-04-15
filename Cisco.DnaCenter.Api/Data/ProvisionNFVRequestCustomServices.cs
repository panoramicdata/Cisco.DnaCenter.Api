using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestCustomServices
	/// </summary>
	[DataContract]
	public partial class ProvisionNFVRequestCustomServices
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestCustomServices" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ApplicationType">ApplicationType.</param>
		/// <param name="Profile">Profile.</param>
		/// <param name="Topology">Topology.</param>
		/// <param name="ImageName">ImageName.</param>
		public ProvisionNFVRequestCustomServices(string? Name = default, string? ApplicationType = default, string? Profile = default, ProvisionNFVRequestTopology Topology = default, string? ImageName = default)
		{
			this.Name = Name;
			this.ApplicationType = ApplicationType;
			this.Profile = Profile;
			this.Topology = Topology;
			this.ImageName = ImageName;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets ApplicationType
		/// </summary>
		[DataMember(Name = "applicationType", EmitDefaultValue = false)]
		public string? ApplicationType { get; set; }
		/// <summary>
		/// Gets or Sets Profile
		/// </summary>
		[DataMember(Name = "profile", EmitDefaultValue = false)]
		public string? Profile { get; set; }
		/// <summary>
		/// Gets or Sets Topology
		/// </summary>
		[DataMember(Name = "topology", EmitDefaultValue = false)]
		public ProvisionNFVRequestTopology Topology { get; set; }
		/// <summary>
		/// Gets or Sets ImageName
		/// </summary>
		[DataMember(Name = "imageName", EmitDefaultValue = false)]
		public string? ImageName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestCustomServices {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
			sb.Append("  Profile: ").Append(Profile).Append("\n");
			sb.Append("  Topology: ").Append(Topology).Append("\n");
			sb.Append("  ImageName: ").Append(ImageName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
