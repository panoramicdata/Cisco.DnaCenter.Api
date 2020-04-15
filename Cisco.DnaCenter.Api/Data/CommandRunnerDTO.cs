using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CommandRunnerDto
	/// </summary>
	[DataContract]
	public partial class CommandRunnerDto
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommandRunnerDto" /> class.
		/// </summary>
		/// <param name="Commands">Commands.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DeviceUuids">DeviceUuids.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Timeout">Timeout.</param>
		public CommandRunnerDto(List<string> Commands = default, string? Description = default, List<string> DeviceUuids = default, string? Name = default, int? Timeout = default)
		{
			this.Commands = Commands;
			this.Description = Description;
			this.DeviceUuids = DeviceUuids;
			this.Name = Name;
			this.Timeout = Timeout;
		}

		/// <summary>
		/// Gets or Sets Commands
		/// </summary>
		[DataMember(Name = "commands", EmitDefaultValue = false)]
		public List<string> Commands { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets DeviceUuids
		/// </summary>
		[DataMember(Name = "deviceUuids", EmitDefaultValue = false)]
		public List<string> DeviceUuids { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Timeout
		/// </summary>
		[DataMember(Name = "timeout", EmitDefaultValue = false)]
		public int? Timeout { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CommandRunnerDto {\n");
			sb.Append("  Commands: ").Append(Commands).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DeviceUuids: ").Append(DeviceUuids).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Timeout: ").Append(Timeout).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
