using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequestSettingsSyslogServer
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkRequestSettingsSyslogServer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequestSettingsSyslogServer" /> class.
		/// </summary>
		/// <param name="IpAddresses">IpAddresses.</param>
		/// <param name="ConfigureDnacIp">ConfigureDnacIP.</param>
		public UpdateNetworkRequestSettingsSyslogServer(List<string> IpAddresses = default, bool? ConfigureDnacIp = default)
		{
			this.IpAddresses = IpAddresses;
			this.ConfigureDnacIp = ConfigureDnacIp;
		}

		/// <summary>
		/// Gets or Sets IpAddresses
		/// </summary>
		[DataMember(Name = "ipAddresses", EmitDefaultValue = false)]
		public List<string> IpAddresses { get; set; }
		/// <summary>
		/// Gets or Sets ConfigureDnacIP
		/// </summary>
		[DataMember(Name = "configureDnacIP", EmitDefaultValue = false)]
		public bool? ConfigureDnacIp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequestSettingsSyslogServer {\n");
			sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
			sb.Append("  ConfigureDnacIP: ").Append(ConfigureDnacIp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
