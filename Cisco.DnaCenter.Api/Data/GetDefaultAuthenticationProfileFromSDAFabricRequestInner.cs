using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSDAFabricRequestInner
	/// </summary>
	[DataContract]
	public partial class GetDefaultAuthenticationProfileFromSDAFabricRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSDAFabricRequestInner" /> class.
		/// </summary>
		/// <param name="DeviceManagementIpAddress">DeviceManagementIpAddress.</param>
		/// <param name="SiteHierarchy">SiteHierarchy.</param>
		/// <param name="ExternalDomainRoutingProtocolName">ExternalDomainRoutingProtocolName.</param>
		/// <param name="ExternalConnectivityIpPoolName">ExternalConnectivityIpPoolName.</param>
		/// <param name="InternalAutonomouSystemNumber">InternalAutonomouSystemNumber.</param>
		/// <param name="BorderSessionType">BorderSessionType.</param>
		/// <param name="ConnectedToInternet">ConnectedToInternet.</param>
		/// <param name="ExternalConnectivitySettings">ExternalConnectivitySettings.</param>
		public GetDefaultAuthenticationProfileFromSDAFabricRequestInner(string? DeviceManagementIpAddress = default, string? SiteHierarchy = default, string? ExternalDomainRoutingProtocolName = default, string? ExternalConnectivityIpPoolName = default, string? InternalAutonomouSystemNumber = default, string? BorderSessionType = default, bool? ConnectedToInternet = default, List<GetDefaultAuthenticationProfileFromSDAFabricRequestInnerExternalConnectivitySettings> ExternalConnectivitySettings = default)
		{
			this.DeviceManagementIpAddress = DeviceManagementIpAddress;
			this.SiteHierarchy = SiteHierarchy;
			this.ExternalDomainRoutingProtocolName = ExternalDomainRoutingProtocolName;
			this.ExternalConnectivityIpPoolName = ExternalConnectivityIpPoolName;
			this.InternalAutonomouSystemNumber = InternalAutonomouSystemNumber;
			this.BorderSessionType = BorderSessionType;
			this.ConnectedToInternet = ConnectedToInternet;
			this.ExternalConnectivitySettings = ExternalConnectivitySettings;
		}

		/// <summary>
		/// Gets or Sets DeviceManagementIpAddress
		/// </summary>
		[DataMember(Name = "deviceManagementIpAddress", EmitDefaultValue = false)]
		public string? DeviceManagementIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets SiteHierarchy
		/// </summary>
		[DataMember(Name = "siteHierarchy", EmitDefaultValue = false)]
		public string? SiteHierarchy { get; set; }
		/// <summary>
		/// Gets or Sets ExternalDomainRoutingProtocolName
		/// </summary>
		[DataMember(Name = "externalDomainRoutingProtocolName", EmitDefaultValue = false)]
		public string? ExternalDomainRoutingProtocolName { get; set; }
		/// <summary>
		/// Gets or Sets ExternalConnectivityIpPoolName
		/// </summary>
		[DataMember(Name = "externalConnectivityIpPoolName", EmitDefaultValue = false)]
		public string? ExternalConnectivityIpPoolName { get; set; }
		/// <summary>
		/// Gets or Sets InternalAutonomouSystemNumber
		/// </summary>
		[DataMember(Name = "internalAutonomouSystemNumber", EmitDefaultValue = false)]
		public string? InternalAutonomouSystemNumber { get; set; }
		/// <summary>
		/// Gets or Sets BorderSessionType
		/// </summary>
		[DataMember(Name = "borderSessionType", EmitDefaultValue = false)]
		public string? BorderSessionType { get; set; }
		/// <summary>
		/// Gets or Sets ConnectedToInternet
		/// </summary>
		[DataMember(Name = "connectedToInternet", EmitDefaultValue = false)]
		public bool? ConnectedToInternet { get; set; }
		/// <summary>
		/// Gets or Sets ExternalConnectivitySettings
		/// </summary>
		[DataMember(Name = "externalConnectivitySettings", EmitDefaultValue = false)]
		public List<GetDefaultAuthenticationProfileFromSDAFabricRequestInnerExternalConnectivitySettings> ExternalConnectivitySettings { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSDAFabricRequestInner {\n");
			sb.Append("  DeviceManagementIpAddress: ").Append(DeviceManagementIpAddress).Append("\n");
			sb.Append("  SiteHierarchy: ").Append(SiteHierarchy).Append("\n");
			sb.Append("  ExternalDomainRoutingProtocolName: ").Append(ExternalDomainRoutingProtocolName).Append("\n");
			sb.Append("  ExternalConnectivityIpPoolName: ").Append(ExternalConnectivityIpPoolName).Append("\n");
			sb.Append("  InternalAutonomouSystemNumber: ").Append(InternalAutonomouSystemNumber).Append("\n");
			sb.Append("  BorderSessionType: ").Append(BorderSessionType).Append("\n");
			sb.Append("  ConnectedToInternet: ").Append(ConnectedToInternet).Append("\n");
			sb.Append("  ExternalConnectivitySettings: ").Append(ExternalConnectivitySettings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
