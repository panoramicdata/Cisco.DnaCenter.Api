using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes
	/// </summary>
	[DataContract]
	public partial class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes" /> class.
		/// </summary>
		/// <param name="Role">Role.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DeviceType">DeviceType.</param>
		/// <param name="PlatformId">PlatformId.</param>
		/// <param name="Family">Family.</param>
		/// <param name="Ip">Ip.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="NodeType">NodeType.</param>
		/// <param name="RadioFrequency">RadioFrequency.</param>
		/// <param name="Clients">Clients.</param>
		/// <param name="Count">Count.</param>
		/// <param name="HealthScore">HealthScore.</param>
		/// <param name="Level">Level.</param>
		/// <param name="FabricGroup">FabricGroup.</param>
		/// <param name="ConnectedDevice">ConnectedDevice.</param>
		public GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes(string? Role = default, string? Name = default, string? Id = default, string? Description = default, string? DeviceType = default, string? PlatformId = default, string? Family = default, string? Ip = default, string? SoftwareVersion = default, Object UserId = default, string? NodeType = default, Object RadioFrequency = default, Object Clients = default, Object Count = default, int? HealthScore = default, decimal? Level = default, Object FabricGroup = default, Object ConnectedDevice = default)
		{
			this.Role = Role;
			this.Name = Name;
			this.Id = Id;
			this.Description = Description;
			this.DeviceType = DeviceType;
			this.PlatformId = PlatformId;
			this.Family = Family;
			this.Ip = Ip;
			this.SoftwareVersion = SoftwareVersion;
			this.UserId = UserId;
			this.NodeType = NodeType;
			this.RadioFrequency = RadioFrequency;
			this.Clients = Clients;
			this.Count = Count;
			this.HealthScore = HealthScore;
			this.Level = Level;
			this.FabricGroup = FabricGroup;
			this.ConnectedDevice = ConnectedDevice;
		}

		/// <summary>
		/// Gets or Sets Role
		/// </summary>
		[DataMember(Name = "role", EmitDefaultValue = false)]
		public string? Role { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets DeviceType
		/// </summary>
		[DataMember(Name = "deviceType", EmitDefaultValue = false)]
		public string? DeviceType { get; set; }
		/// <summary>
		/// Gets or Sets PlatformId
		/// </summary>
		[DataMember(Name = "platformId", EmitDefaultValue = false)]
		public string? PlatformId { get; set; }
		/// <summary>
		/// Gets or Sets Family
		/// </summary>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public string? Family { get; set; }
		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string? Ip { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string? SoftwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public Object UserId { get; set; }
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "nodeType", EmitDefaultValue = false)]
		public string? NodeType { get; set; }
		/// <summary>
		/// Gets or Sets RadioFrequency
		/// </summary>
		[DataMember(Name = "radioFrequency", EmitDefaultValue = false)]
		public Object RadioFrequency { get; set; }
		/// <summary>
		/// Gets or Sets Clients
		/// </summary>
		[DataMember(Name = "clients", EmitDefaultValue = false)]
		public Object Clients { get; set; }
		/// <summary>
		/// Gets or Sets Count
		/// </summary>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public Object Count { get; set; }
		/// <summary>
		/// Gets or Sets HealthScore
		/// </summary>
		[DataMember(Name = "healthScore", EmitDefaultValue = false)]
		public int? HealthScore { get; set; }
		/// <summary>
		/// Gets or Sets Level
		/// </summary>
		[DataMember(Name = "level", EmitDefaultValue = false)]
		public decimal? Level { get; set; }
		/// <summary>
		/// Gets or Sets FabricGroup
		/// </summary>
		[DataMember(Name = "fabricGroup", EmitDefaultValue = false)]
		public Object FabricGroup { get; set; }
		/// <summary>
		/// Gets or Sets ConnectedDevice
		/// </summary>
		[DataMember(Name = "connectedDevice", EmitDefaultValue = false)]
		public Object ConnectedDevice { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsNodes {\n");
			sb.Append("  Role: ").Append(Role).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
			sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
			sb.Append("  Family: ").Append(Family).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  NodeType: ").Append(NodeType).Append("\n");
			sb.Append("  RadioFrequency: ").Append(RadioFrequency).Append("\n");
			sb.Append("  Clients: ").Append(Clients).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  HealthScore: ").Append(HealthScore).Append("\n");
			sb.Append("  Level: ").Append(Level).Append("\n");
			sb.Append("  FabricGroup: ").Append(FabricGroup).Append("\n");
			sb.Append("  ConnectedDevice: ").Append(ConnectedDevice).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
