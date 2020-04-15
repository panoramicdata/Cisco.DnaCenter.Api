using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequestSettingsNetflowcollector
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkRequestSettingsNetflowcollector
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettingsNetflowcollector" /> class.
		/// </summary>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="Port">Port.</param>
		public UpdateNetworkRequestSettingsNetflowcollector(string? IpAddress = default, decimal? Port = default)
		{
			this.IpAddress = IpAddress;
			this.Port = Port;
		}

		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string? IpAddress { get; set; }
		/// <summary>
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public decimal? Port { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequestSettingsNetflowcollector {\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
