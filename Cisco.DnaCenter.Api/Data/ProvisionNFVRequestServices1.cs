using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestServices1
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestServices1
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestServices1" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Mode">Mode.</param>
		/// <param name="SystemIp">SystemIp.</param>
		/// <param name="CentralManagerIp">CentralManagerIP.</param>
		/// <param name="CentralRegistrationKey">CentralRegistrationKey.</param>
		/// <param name="CommonKey">CommonKey.</param>
		/// <param name="AdminPasswordHash">AdminPasswordHash.</param>
		/// <param name="Disk">Disk.</param>
		public ProvisionNfvRequestServices1(string? Type = default, string? Mode = default, string? SystemIp = default, string? CentralManagerIp = default, string? CentralRegistrationKey = default, string? CommonKey = default, string? AdminPasswordHash = default, string? Disk = default)
		{
			this.Type = Type;
			this.Mode = Mode;
			this.SystemIp = SystemIp;
			this.CentralManagerIp = CentralManagerIp;
			this.CentralRegistrationKey = CentralRegistrationKey;
			this.CommonKey = CommonKey;
			this.AdminPasswordHash = AdminPasswordHash;
			this.Disk = Disk;
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public string? Mode { get; set; }

		/// <summary>
		/// Gets or Sets SystemIp
		/// </summary>
		[DataMember(Name = "systemIp", EmitDefaultValue = false)]
		public string? SystemIp { get; set; }

		/// <summary>
		/// Gets or Sets CentralManagerIP
		/// </summary>
		[DataMember(Name = "centralManagerIP", EmitDefaultValue = false)]
		public string? CentralManagerIp { get; set; }

		/// <summary>
		/// Gets or Sets CentralRegistrationKey
		/// </summary>
		[DataMember(Name = "centralRegistrationKey", EmitDefaultValue = false)]
		public string? CentralRegistrationKey { get; set; }

		/// <summary>
		/// Gets or Sets CommonKey
		/// </summary>
		[DataMember(Name = "commonKey", EmitDefaultValue = false)]
		public string? CommonKey { get; set; }

		/// <summary>
		/// Gets or Sets AdminPasswordHash
		/// </summary>
		[DataMember(Name = "adminPasswordHash", EmitDefaultValue = false)]
		public string? AdminPasswordHash { get; set; }

		/// <summary>
		/// Gets or Sets Disk
		/// </summary>
		[DataMember(Name = "disk", EmitDefaultValue = false)]
		public string? Disk { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestServices1 {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Mode: ").Append(Mode).Append("\n");
			sb.Append("  SystemIp: ").Append(SystemIp).Append("\n");
			sb.Append("  CentralManagerIP: ").Append(CentralManagerIp).Append("\n");
			sb.Append("  CentralRegistrationKey: ").Append(CentralRegistrationKey).Append("\n");
			sb.Append("  CommonKey: ").Append(CommonKey).Append("\n");
			sb.Append("  AdminPasswordHash: ").Append(AdminPasswordHash).Append("\n");
			sb.Append("  Disk: ").Append(Disk).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
