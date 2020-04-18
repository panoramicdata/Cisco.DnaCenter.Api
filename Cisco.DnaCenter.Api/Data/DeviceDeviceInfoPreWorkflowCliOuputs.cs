using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoPreWorkflowCliOuputs
	/// </summary>
	[DataContract]
	public class DeviceDeviceInfoPreWorkflowCliOuputs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoPreWorkflowCliOuputs" /> class.
		/// </summary>
		/// <param name="Cli">Cli.</param>
		/// <param name="CliOutput">CliOutput.</param>
		public DeviceDeviceInfoPreWorkflowCliOuputs(string? Cli = default, string? CliOutput = default)
		{
			this.Cli = Cli;
			this.CliOutput = CliOutput;
		}

		/// <summary>
		/// Gets or Sets Cli
		/// </summary>
		[DataMember(Name = "cli", EmitDefaultValue = false)]
		public string? Cli { get; set; }
		/// <summary>
		/// Gets or Sets CliOutput
		/// </summary>
		[DataMember(Name = "cliOutput", EmitDefaultValue = false)]
		public string? CliOutput { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoPreWorkflowCliOuputs {\n");
			sb.Append("  Cli: ").Append(Cli).Append("\n");
			sb.Append("  CliOutput: ").Append(CliOutput).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
