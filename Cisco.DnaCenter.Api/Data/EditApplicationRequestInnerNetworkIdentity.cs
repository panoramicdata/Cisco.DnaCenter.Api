using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// EditApplicationRequestInnerNetworkIdentity
	/// </summary>
	[DataContract]
	public partial class EditApplicationRequestInnerNetworkIdentity
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EditApplicationRequestInnerNetworkIdentity" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="LowerPort">LowerPort.</param>
		/// <param name="Ports">Ports.</param>
		/// <param name="Protocol">Protocol.</param>
		/// <param name="UpperPort">UpperPort.</param>
		public EditApplicationRequestInnerNetworkIdentity(string? Id = default, string? DisplayName = default, string? LowerPort = default, string? Ports = default, string? Protocol = default, string? UpperPort = default)
		{
			this.Id = Id;
			this.DisplayName = DisplayName;
			this.LowerPort = LowerPort;
			this.Ports = Ports;
			this.Protocol = Protocol;
			this.UpperPort = UpperPort;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string? DisplayName { get; set; }
		/// <summary>
		/// Gets or Sets LowerPort
		/// </summary>
		[DataMember(Name = "lowerPort", EmitDefaultValue = false)]
		public string? LowerPort { get; set; }
		/// <summary>
		/// Gets or Sets Ports
		/// </summary>
		[DataMember(Name = "ports", EmitDefaultValue = false)]
		public string? Ports { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public string? Protocol { get; set; }
		/// <summary>
		/// Gets or Sets UpperPort
		/// </summary>
		[DataMember(Name = "upperPort", EmitDefaultValue = false)]
		public string? UpperPort { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EditApplicationRequestInnerNetworkIdentity {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  LowerPort: ").Append(LowerPort).Append("\n");
			sb.Append("  Ports: ").Append(Ports).Append("\n");
			sb.Append("  Protocol: ").Append(Protocol).Append("\n");
			sb.Append("  UpperPort: ").Append(UpperPort).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
