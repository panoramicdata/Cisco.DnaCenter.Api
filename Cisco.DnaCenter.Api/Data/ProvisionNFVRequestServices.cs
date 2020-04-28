using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestServices
	/// </summary>
	[DataContract]
	public class ProvisionNfvRequestServices
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Isr for "isr"
			/// </summary>
			[EnumMember(Value = "isr")]
			Isr,

			/// <summary>
			/// Enum Vedge for "vedge"
			/// </summary>
			[EnumMember(Value = "vedge")]
			Vedge,

			/// <summary>
			/// Enum Waas for "waas"
			/// </summary>
			[EnumMember(Value = "waas")]
			Waas,

			/// <summary>
			/// Enum Asa for "asa"
			/// </summary>
			[EnumMember(Value = "asa")]
			Asa,

			/// <summary>
			/// Enum Ngfw for "ngfw"
			/// </summary>
			[EnumMember(Value = "ngfw")]
			Ngfw,

			/// <summary>
			/// Enum Paloalto for "paloalto"
			/// </summary>
			[EnumMember(Value = "paloalto")]
			Paloalto,

			/// <summary>
			/// Enum Fortinet for "fortinet"
			/// </summary>
			[EnumMember(Value = "fortinet")]
			Fortinet,

			/// <summary>
			/// Enum Checkpoint for "checkpoint"
			/// </summary>
			[EnumMember(Value = "checkpoint")]
			Checkpoint,

			/// <summary>
			/// Enum Riverbed for "riverbed"
			/// </summary>
			[EnumMember(Value = "riverbed")]
			Riverbed,

			/// <summary>
			/// Enum Silverpeak for "silverpeak"
			/// </summary>
			[EnumMember(Value = "silverpeak")]
			Silverpeak
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNfvRequestServices" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Profile">Profile.</param>
		/// <param name="Mode">Mode.</param>
		/// <param name="Name">Name.</param>
		/// <param name="ImageName">ImageName.</param>
		/// <param name="Topology">Topology.</param>
		public ProvisionNfvRequestServices(TypeEnum? Type = default, string? Profile = default, string? Mode = default, string? Name = default, string? ImageName = default, ProvisionNfvRequestTopology Topology = default)
		{
			this.Type = Type;
			this.Profile = Profile;
			this.Mode = Mode;
			this.Name = Name;
			this.ImageName = ImageName;
			this.Topology = Topology;
		}

		/// <summary>
		/// Gets or Sets Profile
		/// </summary>
		[DataMember(Name = "profile", EmitDefaultValue = false)]
		public string? Profile { get; set; }

		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public string? Mode { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets ImageName
		/// </summary>
		[DataMember(Name = "imageName", EmitDefaultValue = false)]
		public string? ImageName { get; set; }

		/// <summary>
		/// Gets or Sets Topology
		/// </summary>
		[DataMember(Name = "topology", EmitDefaultValue = false)]
		public ProvisionNfvRequestTopology Topology { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestServices {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Profile: ").Append(Profile).Append("\n");
			sb.Append("  Mode: ").Append(Mode).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ImageName: ").Append(ImageName).Append("\n");
			sb.Append("  Topology: ").Append(Topology).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
