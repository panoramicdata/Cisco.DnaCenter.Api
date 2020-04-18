using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteIPPoolFromSDAVirtualNetworkRequestInner
	/// </summary>
	[DataContract]
	public class DeleteIpPoolFromSdaVirtualNetworkRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteIpPoolFromSdaVirtualNetworkRequestInner" /> class.
		/// </summary>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		/// <param name="IpPoolName">IpPoolName.</param>
		/// <param name="AuthenticationPolicyName">AuthenticationPolicyName.</param>
		/// <param name="TrafficType">TrafficType.</param>
		/// <param name="ScalableGroupName">ScalableGroupName.</param>
		/// <param name="IsL2FloodingEnabled">IsL2FloodingEnabled.</param>
		public DeleteIpPoolFromSdaVirtualNetworkRequestInner(string? SiteNameHierarchy = default, string? VirtualNetworkName = default, string? IpPoolName = default, string? AuthenticationPolicyName = default, string? TrafficType = default, string? ScalableGroupName = default, bool? IsL2FloodingEnabled = default)
		{
			this.SiteNameHierarchy = SiteNameHierarchy;
			this.VirtualNetworkName = VirtualNetworkName;
			this.IpPoolName = IpPoolName;
			this.AuthenticationPolicyName = AuthenticationPolicyName;
			this.TrafficType = TrafficType;
			this.ScalableGroupName = ScalableGroupName;
			this.IsL2FloodingEnabled = IsL2FloodingEnabled;
		}

		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }
		/// <summary>
		/// Gets or Sets VirtualNetworkName
		/// </summary>
		[DataMember(Name = "virtualNetworkName", EmitDefaultValue = false)]
		public string? VirtualNetworkName { get; set; }
		/// <summary>
		/// Gets or Sets IpPoolName
		/// </summary>
		[DataMember(Name = "ipPoolName", EmitDefaultValue = false)]
		public string? IpPoolName { get; set; }
		/// <summary>
		/// Gets or Sets AuthenticationPolicyName
		/// </summary>
		[DataMember(Name = "authenticationPolicyName", EmitDefaultValue = false)]
		public string? AuthenticationPolicyName { get; set; }
		/// <summary>
		/// Gets or Sets TrafficType
		/// </summary>
		[DataMember(Name = "trafficType", EmitDefaultValue = false)]
		public string? TrafficType { get; set; }
		/// <summary>
		/// Gets or Sets ScalableGroupName
		/// </summary>
		[DataMember(Name = "scalableGroupName", EmitDefaultValue = false)]
		public string? ScalableGroupName { get; set; }
		/// <summary>
		/// Gets or Sets IsL2FloodingEnabled
		/// </summary>
		[DataMember(Name = "isL2FloodingEnabled", EmitDefaultValue = false)]
		public bool? IsL2FloodingEnabled { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeleteIPPoolFromSDAVirtualNetworkRequestInner {\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
			sb.Append("  AuthenticationPolicyName: ").Append(AuthenticationPolicyName).Append("\n");
			sb.Append("  TrafficType: ").Append(TrafficType).Append("\n");
			sb.Append("  ScalableGroupName: ").Append(ScalableGroupName).Append("\n");
			sb.Append("  IsL2FloodingEnabled: ").Append(IsL2FloodingEnabled).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
