using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSPProfileRequestSettings
	/// </summary>
	[DataContract]
	public partial class CreateSPProfileRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSPProfileRequestSettings" /> class.
		/// </summary>
		/// <param name="Qos">Qos.</param>
		public CreateSPProfileRequestSettings(List<CreateSPProfileRequestSettingsQos> Qos = default)
		{
			this.Qos = Qos;
		}

		/// <summary>
		/// Gets or Sets Qos
		/// </summary>
		[DataMember(Name = "qos", EmitDefaultValue = false)]
		public List<CreateSPProfileRequestSettingsQos> Qos { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSPProfileRequestSettings {\n");
			sb.Append("  Qos: ").Append(Qos).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
