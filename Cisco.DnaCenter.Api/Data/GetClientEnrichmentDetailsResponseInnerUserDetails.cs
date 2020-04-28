using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerUserDetails
	/// </summary>
	[DataContract]
	public class GetClientEnrichmentDetailsResponseInnerUserDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerUserDetails" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ConnectionStatus">ConnectionStatus.</param>
		/// <param name="HostType">HostType.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="HostName">HostName.</param>
		/// <param name="HostOs">HostOs.</param>
		/// <param name="HostVersion">HostVersion.</param>
		/// <param name="SubType">SubType.</param>
		/// <param name="LastUpdated">LastUpdated.</param>
		/// <param name="HealthScore">HealthScore.</param>
		/// <param name="HostMac">HostMac.</param>
		/// <param name="HostIpV4">HostIpV4.</param>
		/// <param name="HostIpV6">HostIpV6.</param>
		/// <param name="AuthType">AuthType.</param>
		/// <param name="VlanId">VlanId.</param>
		/// <param name="Ssid">Ssid.</param>
		/// <param name="Location">Location.</param>
		/// <param name="ClientConnection">ClientConnection.</param>
		/// <param name="ConnectedDevice">ConnectedDevice.</param>
		/// <param name="IssueCount">IssueCount.</param>
		/// <param name="Rssi">Rssi.</param>
		/// <param name="Snr">Snr.</param>
		/// <param name="DataRate">DataRate.</param>
		/// <param name="Port">Port.</param>
		public GetClientEnrichmentDetailsResponseInnerUserDetails(string? Id = default, string? ConnectionStatus = default, string? HostType = default, string? UserId = default, Object HostName = default, Object HostOs = default, Object HostVersion = default, Object SubType = default, int? LastUpdated = default, List<GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore> HealthScore = default, string? HostMac = default, string? HostIpV4 = default, List<Object> HostIpV6 = default, Object AuthType = default, string? VlanId = default, Object Ssid = default, Object Location = default, string? ClientConnection = default, List<Object> ConnectedDevice = default, decimal? IssueCount = default, Object Rssi = default, Object Snr = default, Object DataRate = default, Object Port = default)
		{
			this.Id = Id;
			this.ConnectionStatus = ConnectionStatus;
			this.HostType = HostType;
			this.UserId = UserId;
			this.HostName = HostName;
			this.HostOs = HostOs;
			this.HostVersion = HostVersion;
			this.SubType = SubType;
			this.LastUpdated = LastUpdated;
			this.HealthScore = HealthScore;
			this.HostMac = HostMac;
			this.HostIpV4 = HostIpV4;
			this.HostIpV6 = HostIpV6;
			this.AuthType = AuthType;
			this.VlanId = VlanId;
			this.Ssid = Ssid;
			this.Location = Location;
			this.ClientConnection = ClientConnection;
			this.ConnectedDevice = ConnectedDevice;
			this.IssueCount = IssueCount;
			this.Rssi = Rssi;
			this.Snr = Snr;
			this.DataRate = DataRate;
			this.Port = Port;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets ConnectionStatus
		/// </summary>
		[DataMember(Name = "connectionStatus", EmitDefaultValue = false)]
		public string? ConnectionStatus { get; set; }

		/// <summary>
		/// Gets or Sets HostType
		/// </summary>
		[DataMember(Name = "hostType", EmitDefaultValue = false)]
		public string? HostType { get; set; }

		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string? UserId { get; set; }

		/// <summary>
		/// Gets or Sets HostName
		/// </summary>
		[DataMember(Name = "hostName", EmitDefaultValue = false)]
		public Object HostName { get; set; }

		/// <summary>
		/// Gets or Sets HostOs
		/// </summary>
		[DataMember(Name = "hostOs", EmitDefaultValue = false)]
		public Object HostOs { get; set; }

		/// <summary>
		/// Gets or Sets HostVersion
		/// </summary>
		[DataMember(Name = "hostVersion", EmitDefaultValue = false)]
		public Object HostVersion { get; set; }

		/// <summary>
		/// Gets or Sets SubType
		/// </summary>
		[DataMember(Name = "subType", EmitDefaultValue = false)]
		public Object SubType { get; set; }

		/// <summary>
		/// Gets or Sets LastUpdated
		/// </summary>
		[DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
		public int? LastUpdated { get; set; }

		/// <summary>
		/// Gets or Sets HealthScore
		/// </summary>
		[DataMember(Name = "healthScore", EmitDefaultValue = false)]
		public List<GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore> HealthScore { get; set; }

		/// <summary>
		/// Gets or Sets HostMac
		/// </summary>
		[DataMember(Name = "hostMac", EmitDefaultValue = false)]
		public string? HostMac { get; set; }

		/// <summary>
		/// Gets or Sets HostIpV4
		/// </summary>
		[DataMember(Name = "hostIpV4", EmitDefaultValue = false)]
		public string? HostIpV4 { get; set; }

		/// <summary>
		/// Gets or Sets HostIpV6
		/// </summary>
		[DataMember(Name = "hostIpV6", EmitDefaultValue = false)]
		public List<Object> HostIpV6 { get; set; }

		/// <summary>
		/// Gets or Sets AuthType
		/// </summary>
		[DataMember(Name = "authType", EmitDefaultValue = false)]
		public Object AuthType { get; set; }

		/// <summary>
		/// Gets or Sets VlanId
		/// </summary>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public string? VlanId { get; set; }

		/// <summary>
		/// Gets or Sets Ssid
		/// </summary>
		[DataMember(Name = "ssid", EmitDefaultValue = false)]
		public Object Ssid { get; set; }

		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public Object Location { get; set; }

		/// <summary>
		/// Gets or Sets ClientConnection
		/// </summary>
		[DataMember(Name = "clientConnection", EmitDefaultValue = false)]
		public string? ClientConnection { get; set; }

		/// <summary>
		/// Gets or Sets ConnectedDevice
		/// </summary>
		[DataMember(Name = "connectedDevice", EmitDefaultValue = false)]
		public List<Object> ConnectedDevice { get; set; }

		/// <summary>
		/// Gets or Sets IssueCount
		/// </summary>
		[DataMember(Name = "issueCount", EmitDefaultValue = false)]
		public decimal? IssueCount { get; set; }

		/// <summary>
		/// Gets or Sets Rssi
		/// </summary>
		[DataMember(Name = "rssi", EmitDefaultValue = false)]
		public Object Rssi { get; set; }

		/// <summary>
		/// Gets or Sets Snr
		/// </summary>
		[DataMember(Name = "snr", EmitDefaultValue = false)]
		public Object Snr { get; set; }

		/// <summary>
		/// Gets or Sets DataRate
		/// </summary>
		[DataMember(Name = "dataRate", EmitDefaultValue = false)]
		public Object DataRate { get; set; }

		/// <summary>
		/// Gets or Sets Port
		/// </summary>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public Object Port { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerUserDetails {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
			sb.Append("  HostType: ").Append(HostType).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  HostName: ").Append(HostName).Append("\n");
			sb.Append("  HostOs: ").Append(HostOs).Append("\n");
			sb.Append("  HostVersion: ").Append(HostVersion).Append("\n");
			sb.Append("  SubType: ").Append(SubType).Append("\n");
			sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
			sb.Append("  HealthScore: ").Append(HealthScore).Append("\n");
			sb.Append("  HostMac: ").Append(HostMac).Append("\n");
			sb.Append("  HostIpV4: ").Append(HostIpV4).Append("\n");
			sb.Append("  HostIpV6: ").Append(HostIpV6).Append("\n");
			sb.Append("  AuthType: ").Append(AuthType).Append("\n");
			sb.Append("  VlanId: ").Append(VlanId).Append("\n");
			sb.Append("  Ssid: ").Append(Ssid).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  ClientConnection: ").Append(ClientConnection).Append("\n");
			sb.Append("  ConnectedDevice: ").Append(ConnectedDevice).Append("\n");
			sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
			sb.Append("  Rssi: ").Append(Rssi).Append("\n");
			sb.Append("  Snr: ").Append(Snr).Append("\n");
			sb.Append("  DataRate: ").Append(DataRate).Append("\n");
			sb.Append("  Port: ").Append(Port).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
