using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDayZeroConfig
	/// </summary>
	[DataContract]
	public class DeviceDayZeroConfig
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDayZeroConfig" /> class.
		/// </summary>
		/// <param name="Config">Config.</param>
		public DeviceDayZeroConfig(string? Config = default)
		{
			this.Config = Config;
		}

		/// <summary>
		/// Gets or Sets Config
		/// </summary>
		[DataMember(Name = "config", EmitDefaultValue = false)]
		public string? Config { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDayZeroConfig {\n");
			sb.Append("  Config: ").Append(Config).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
