using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AssignCredentialToSiteRequest
	/// </summary>
	[DataContract]
	public class AssignCredentialToSiteRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssignCredentialToSiteRequest" /> class.
		/// </summary>
		/// <param name="CliId">CliId.</param>
		/// <param name="SnmpV2ReadId">SnmpV2ReadId.</param>
		/// <param name="SnmpV2WriteId">SnmpV2WriteId.</param>
		/// <param name="HttpRead">HttpRead.</param>
		/// <param name="HttpWrite">HttpWrite.</param>
		/// <param name="SnmpV3Id">SnmpV3Id.</param>
		public AssignCredentialToSiteRequest(string? CliId = default, string? SnmpV2ReadId = default, string? SnmpV2WriteId = default, string? HttpRead = default, string? HttpWrite = default, string? SnmpV3Id = default)
		{
			this.CliId = CliId;
			this.SnmpV2ReadId = SnmpV2ReadId;
			this.SnmpV2WriteId = SnmpV2WriteId;
			this.HttpRead = HttpRead;
			this.HttpWrite = HttpWrite;
			this.SnmpV3Id = SnmpV3Id;
		}

		/// <summary>
		/// Gets or Sets CliId
		/// </summary>
		[DataMember(Name = "cliId", EmitDefaultValue = false)]
		public string? CliId { get; set; }
		/// <summary>
		/// Gets or Sets SnmpV2ReadId
		/// </summary>
		[DataMember(Name = "snmpV2ReadId", EmitDefaultValue = false)]
		public string? SnmpV2ReadId { get; set; }
		/// <summary>
		/// Gets or Sets SnmpV2WriteId
		/// </summary>
		[DataMember(Name = "snmpV2WriteId", EmitDefaultValue = false)]
		public string? SnmpV2WriteId { get; set; }
		/// <summary>
		/// Gets or Sets HttpRead
		/// </summary>
		[DataMember(Name = "httpRead", EmitDefaultValue = false)]
		public string? HttpRead { get; set; }
		/// <summary>
		/// Gets or Sets HttpWrite
		/// </summary>
		[DataMember(Name = "httpWrite", EmitDefaultValue = false)]
		public string? HttpWrite { get; set; }
		/// <summary>
		/// Gets or Sets SnmpV3Id
		/// </summary>
		[DataMember(Name = "snmpV3Id", EmitDefaultValue = false)]
		public string? SnmpV3Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssignCredentialToSiteRequest {\n");
			sb.Append("  CliId: ").Append(CliId).Append("\n");
			sb.Append("  SnmpV2ReadId: ").Append(SnmpV2ReadId).Append("\n");
			sb.Append("  SnmpV2WriteId: ").Append(SnmpV2WriteId).Append("\n");
			sb.Append("  HttpRead: ").Append(HttpRead).Append("\n");
			sb.Append("  HttpWrite: ").Append(HttpWrite).Append("\n");
			sb.Append("  SnmpV3Id: ").Append(SnmpV3Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
