using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts
	/// </summary>
	[DataContract]
	public class GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts" /> class.
		/// </summary>
		/// <param name="HostType">HostType.</param>
		/// <param name="HostName">HostName.</param>
		/// <param name="HostOs">HostOs.</param>
		/// <param name="Ssid">Ssid.</param>
		/// <param name="ConnectedInterface">ConnectedInterface.</param>
		/// <param name="MacAddress">MacAddress.</param>
		/// <param name="FailedAttempts">FailedAttempts.</param>
		/// <param name="Location">Location.</param>
		/// <param name="Timestamp">Timestamp.</param>
		public GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts(string? HostType = default, string? HostName = default, string? HostOs = default, string? Ssid = default, string? ConnectedInterface = default, string? MacAddress = default, int? FailedAttempts = default, GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation Location = default, int? Timestamp = default)
		{
			this.HostType = HostType;
			this.HostName = HostName;
			this.HostOs = HostOs;
			this.Ssid = Ssid;
			this.ConnectedInterface = ConnectedInterface;
			this.MacAddress = MacAddress;
			this.FailedAttempts = FailedAttempts;
			this.Location = Location;
			this.Timestamp = Timestamp;
		}

		/// <summary>
		/// Gets or Sets HostType
		/// </summary>
		[DataMember(Name = "hostType", EmitDefaultValue = false)]
		public string? HostType { get; set; }
		/// <summary>
		/// Gets or Sets HostName
		/// </summary>
		[DataMember(Name = "hostName", EmitDefaultValue = false)]
		public string? HostName { get; set; }
		/// <summary>
		/// Gets or Sets HostOs
		/// </summary>
		[DataMember(Name = "hostOs", EmitDefaultValue = false)]
		public string? HostOs { get; set; }
		/// <summary>
		/// Gets or Sets Ssid
		/// </summary>
		[DataMember(Name = "ssid", EmitDefaultValue = false)]
		public string? Ssid { get; set; }
		/// <summary>
		/// Gets or Sets ConnectedInterface
		/// </summary>
		[DataMember(Name = "connectedInterface", EmitDefaultValue = false)]
		public string? ConnectedInterface { get; set; }
		/// <summary>
		/// Gets or Sets MacAddress
		/// </summary>
		[DataMember(Name = "macAddress", EmitDefaultValue = false)]
		public string? MacAddress { get; set; }
		/// <summary>
		/// Gets or Sets FailedAttempts
		/// </summary>
		[DataMember(Name = "failedAttempts", EmitDefaultValue = false)]
		public int? FailedAttempts { get; set; }
		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation Location { get; set; }
		/// <summary>
		/// Gets or Sets Timestamp
		/// </summary>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public int? Timestamp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerIssueDetailsImpactedHosts {\n");
			sb.Append("  HostType: ").Append(HostType).Append("\n");
			sb.Append("  HostName: ").Append(HostName).Append("\n");
			sb.Append("  HostOs: ").Append(HostOs).Append("\n");
			sb.Append("  Ssid: ").Append(Ssid).Append("\n");
			sb.Append("  ConnectedInterface: ").Append(ConnectedInterface).Append("\n");
			sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
			sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
