using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSPProfileRequestSettings
	/// </summary>
	[DataContract]
	public partial class UpdateSPProfileRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSPProfileRequestSettings" /> class.
		/// </summary>
		/// <param name="Qos">Qos.</param>
		public UpdateSPProfileRequestSettings(List<UpdateSPProfileRequestSettingsQos> Qos = default)
		{
			this.Qos = Qos;
		}

		/// <summary>
		/// Gets or Sets Qos
		/// </summary>
		[DataMember(Name = "qos", EmitDefaultValue = false)]
		public List<UpdateSPProfileRequestSettingsQos> Qos { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSPProfileRequestSettings {\n");
			sb.Append("  Qos: ").Append(Qos).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
