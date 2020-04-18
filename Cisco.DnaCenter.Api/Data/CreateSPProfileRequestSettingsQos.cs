using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSPProfileRequestSettingsQos
	/// </summary>
	[DataContract]
	public class CreateSpProfileRequestSettingsQos
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSpProfileRequestSettingsQos" /> class.
		/// </summary>
		/// <param name="ProfileName">ProfileName.</param>
		/// <param name="Model">Model.</param>
		/// <param name="WanProvider">WanProvider.</param>
		public CreateSpProfileRequestSettingsQos(string? ProfileName = default, string? Model = default, string? WanProvider = default)
		{
			this.ProfileName = ProfileName;
			this.Model = Model;
			this.WanProvider = WanProvider;
		}

		/// <summary>
		/// Gets or Sets ProfileName
		/// </summary>
		[DataMember(Name = "profileName", EmitDefaultValue = false)]
		public string? ProfileName { get; set; }
		/// <summary>
		/// Gets or Sets Model
		/// </summary>
		[DataMember(Name = "model", EmitDefaultValue = false)]
		public string? Model { get; set; }
		/// <summary>
		/// Gets or Sets WanProvider
		/// </summary>
		[DataMember(Name = "wanProvider", EmitDefaultValue = false)]
		public string? WanProvider { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSPProfileRequestSettingsQos {\n");
			sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
			sb.Append("  Model: ").Append(Model).Append("\n");
			sb.Append("  WanProvider: ").Append(WanProvider).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
