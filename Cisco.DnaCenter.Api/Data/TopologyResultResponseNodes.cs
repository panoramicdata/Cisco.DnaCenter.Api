using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TopologyResultResponseNodes
	/// </summary>
	[DataContract]
	public class TopologyResultResponseNodes
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TopologyResultResponseNodes" /> class.
		/// </summary>
		/// <param name="AclApplied">AclApplied.</param>
		/// <param name="AdditionalInfo">AdditionalInfo.</param>
		/// <param name="CustomParam">CustomParam.</param>
		/// <param name="DataPathId">DataPathId.</param>
		/// <param name="DeviceType">DeviceType.</param>
		/// <param name="Family">Family.</param>
		/// <param name="_Fixed">_Fixed.</param>
		/// <param name="GreyOut">GreyOut.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Ip">Ip.</param>
		/// <param name="Label">Label.</param>
		/// <param name="NetworkType">NetworkType.</param>
		/// <param name="NodeType">NodeType.</param>
		/// <param name="Order">Order.</param>
		/// <param name="OsType">OsType.</param>
		/// <param name="PlatformId">PlatformId.</param>
		/// <param name="Role">Role.</param>
		/// <param name="RoleSource">RoleSource.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="Tags">Tags.</param>
		/// <param name="UpperNode">UpperNode.</param>
		/// <param name="UserId">UserId.</param>
		/// <param name="VlanId">VlanId.</param>
		/// <param name="X">X.</param>
		/// <param name="Y">Y.</param>
		public TopologyResultResponseNodes(bool? AclApplied = default, Object AdditionalInfo = default, TopologyResultResponseCustomParam CustomParam = default, string? DataPathId = default, string? DeviceType = default, string? Family = default, bool? _Fixed = default, bool? GreyOut = default, string? Id = default, string? Ip = default, string? Label = default, string? NetworkType = default, string? NodeType = default, int? Order = default, string? OsType = default, string? PlatformId = default, string? Role = default, string? RoleSource = default, string? SoftwareVersion = default, List<string> Tags = default, string? UpperNode = default, string? UserId = default, string? VlanId = default, int? X = default, int? Y = default)
		{
			this.AclApplied = AclApplied;
			this.AdditionalInfo = AdditionalInfo;
			this.CustomParam = CustomParam;
			this.DataPathId = DataPathId;
			this.DeviceType = DeviceType;
			this.Family = Family;
			this._Fixed = _Fixed;
			this.GreyOut = GreyOut;
			this.Id = Id;
			this.Ip = Ip;
			this.Label = Label;
			this.NetworkType = NetworkType;
			this.NodeType = NodeType;
			this.Order = Order;
			this.OsType = OsType;
			this.PlatformId = PlatformId;
			this.Role = Role;
			this.RoleSource = RoleSource;
			this.SoftwareVersion = SoftwareVersion;
			this.Tags = Tags;
			this.UpperNode = UpperNode;
			this.UserId = UserId;
			this.VlanId = VlanId;
			this.X = X;
			this.Y = Y;
		}

		/// <summary>
		/// Gets or Sets AclApplied
		/// </summary>
		[DataMember(Name = "aclApplied", EmitDefaultValue = false)]
		public bool? AclApplied { get; set; }
		/// <summary>
		/// Gets or Sets AdditionalInfo
		/// </summary>
		[DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
		public Object AdditionalInfo { get; set; }
		/// <summary>
		/// Gets or Sets CustomParam
		/// </summary>
		[DataMember(Name = "customParam", EmitDefaultValue = false)]
		public TopologyResultResponseCustomParam CustomParam { get; set; }
		/// <summary>
		/// Gets or Sets DataPathId
		/// </summary>
		[DataMember(Name = "dataPathId", EmitDefaultValue = false)]
		public string? DataPathId { get; set; }
		/// <summary>
		/// Gets or Sets DeviceType
		/// </summary>
		[DataMember(Name = "deviceType", EmitDefaultValue = false)]
		public string? DeviceType { get; set; }
		/// <summary>
		/// Gets or Sets Family
		/// </summary>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public string? Family { get; set; }
		/// <summary>
		/// Gets or Sets _Fixed
		/// </summary>
		[DataMember(Name = "fixed", EmitDefaultValue = false)]
		public bool? _Fixed { get; set; }
		/// <summary>
		/// Gets or Sets GreyOut
		/// </summary>
		[DataMember(Name = "greyOut", EmitDefaultValue = false)]
		public bool? GreyOut { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string? Ip { get; set; }
		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public string? Label { get; set; }
		/// <summary>
		/// Gets or Sets NetworkType
		/// </summary>
		[DataMember(Name = "networkType", EmitDefaultValue = false)]
		public string? NetworkType { get; set; }
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "nodeType", EmitDefaultValue = false)]
		public string? NodeType { get; set; }
		/// <summary>
		/// Gets or Sets Order
		/// </summary>
		[DataMember(Name = "order", EmitDefaultValue = false)]
		public int? Order { get; set; }
		/// <summary>
		/// Gets or Sets OsType
		/// </summary>
		[DataMember(Name = "osType", EmitDefaultValue = false)]
		public string? OsType { get; set; }
		/// <summary>
		/// Gets or Sets PlatformId
		/// </summary>
		[DataMember(Name = "platformId", EmitDefaultValue = false)]
		public string? PlatformId { get; set; }
		/// <summary>
		/// Gets or Sets Role
		/// </summary>
		[DataMember(Name = "role", EmitDefaultValue = false)]
		public string? Role { get; set; }
		/// <summary>
		/// Gets or Sets RoleSource
		/// </summary>
		[DataMember(Name = "roleSource", EmitDefaultValue = false)]
		public string? RoleSource { get; set; }
		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string? SoftwareVersion { get; set; }
		/// <summary>
		/// Gets or Sets Tags
		/// </summary>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; }
		/// <summary>
		/// Gets or Sets UpperNode
		/// </summary>
		[DataMember(Name = "upperNode", EmitDefaultValue = false)]
		public string? UpperNode { get; set; }
		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string? UserId { get; set; }
		/// <summary>
		/// Gets or Sets VlanId
		/// </summary>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public string? VlanId { get; set; }
		/// <summary>
		/// Gets or Sets X
		/// </summary>
		[DataMember(Name = "x", EmitDefaultValue = false)]
		public int? X { get; set; }
		/// <summary>
		/// Gets or Sets Y
		/// </summary>
		[DataMember(Name = "y", EmitDefaultValue = false)]
		public int? Y { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TopologyResultResponseNodes {\n");
			sb.Append("  AclApplied: ").Append(AclApplied).Append("\n");
			sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
			sb.Append("  CustomParam: ").Append(CustomParam).Append("\n");
			sb.Append("  DataPathId: ").Append(DataPathId).Append("\n");
			sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
			sb.Append("  Family: ").Append(Family).Append("\n");
			sb.Append("  _Fixed: ").Append(_Fixed).Append("\n");
			sb.Append("  GreyOut: ").Append(GreyOut).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
			sb.Append("  NodeType: ").Append(NodeType).Append("\n");
			sb.Append("  Order: ").Append(Order).Append("\n");
			sb.Append("  OsType: ").Append(OsType).Append("\n");
			sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
			sb.Append("  Role: ").Append(Role).Append("\n");
			sb.Append("  RoleSource: ").Append(RoleSource).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
			sb.Append("  UpperNode: ").Append(UpperNode).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  VlanId: ").Append(VlanId).Append("\n");
			sb.Append("  X: ").Append(X).Append("\n");
			sb.Append("  Y: ").Append(Y).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
