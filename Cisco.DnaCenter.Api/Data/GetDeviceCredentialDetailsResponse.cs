using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceCredentialDetailsResponse
	/// </summary>
	[DataContract]
	public class GetDeviceCredentialDetailsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceCredentialDetailsResponse" /> class.
		/// </summary>
		/// <param name="SnmpV3">SnmpV3.</param>
		/// <param name="HttpRead">HttpRead.</param>
		/// <param name="HttpWrite">HttpWrite.</param>
		/// <param name="SnmpV2Write">SnmpV2Write.</param>
		/// <param name="SnmpV2Read">SnmpV2Read.</param>
		/// <param name="Cli">Cli.</param>
		public GetDeviceCredentialDetailsResponse(List<GetDeviceCredentialDetailsResponseSnmpV3> SnmpV3 = default, List<GetDeviceCredentialDetailsResponseHttpRead> HttpRead = default, List<GetDeviceCredentialDetailsResponseHttpRead> HttpWrite = default, List<GetDeviceCredentialDetailsResponseSnmpV2Write> SnmpV2Write = default, List<GetDeviceCredentialDetailsResponseSnmpV2Read> SnmpV2Read = default, List<GetDeviceCredentialDetailsResponseCli> Cli = default)
		{
			this.SnmpV3 = SnmpV3;
			this.HttpRead = HttpRead;
			this.HttpWrite = HttpWrite;
			this.SnmpV2Write = SnmpV2Write;
			this.SnmpV2Read = SnmpV2Read;
			this.Cli = Cli;
		}

		/// <summary>
		/// Gets or Sets SnmpV3
		/// </summary>
		[DataMember(Name = "snmp_v3", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseSnmpV3> SnmpV3 { get; set; }

		/// <summary>
		/// Gets or Sets HttpRead
		/// </summary>
		[DataMember(Name = "http_read", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseHttpRead> HttpRead { get; set; }

		/// <summary>
		/// Gets or Sets HttpWrite
		/// </summary>
		[DataMember(Name = "http_write", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseHttpRead> HttpWrite { get; set; }

		/// <summary>
		/// Gets or Sets SnmpV2Write
		/// </summary>
		[DataMember(Name = "snmp_v2_write", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseSnmpV2Write> SnmpV2Write { get; set; }

		/// <summary>
		/// Gets or Sets SnmpV2Read
		/// </summary>
		[DataMember(Name = "snmp_v2_read", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseSnmpV2Read> SnmpV2Read { get; set; }

		/// <summary>
		/// Gets or Sets Cli
		/// </summary>
		[DataMember(Name = "cli", EmitDefaultValue = false)]
		public List<GetDeviceCredentialDetailsResponseCli> Cli { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceCredentialDetailsResponse {\n");
			sb.Append("  SnmpV3: ").Append(SnmpV3).Append("\n");
			sb.Append("  HttpRead: ").Append(HttpRead).Append("\n");
			sb.Append("  HttpWrite: ").Append(HttpWrite).Append("\n");
			sb.Append("  SnmpV2Write: ").Append(SnmpV2Write).Append("\n");
			sb.Append("  SnmpV2Read: ").Append(SnmpV2Read).Append("\n");
			sb.Append("  Cli: ").Append(Cli).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
