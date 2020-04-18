using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddIPPoolInSDAVirtualNetworkRequestInner
	/// </summary>
	[DataContract]
	public class AddIpPoolInSdaVirtualNetworkRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddIpPoolInSdaVirtualNetworkRequestInner" /> class.
		/// </summary>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		/// <param name="IpPoolName">IpPoolName.</param>
		/// <param name="TrafficType">TrafficType.</param>
		/// <param name="AuthenticationPolicyName">AuthenticationPolicyName.</param>
		/// <param name="ScalableGroupName">ScalableGroupName.</param>
		/// <param name="IsL2FloodingEnabled">IsL2FloodingEnabled.</param>
		/// <param name="IsThisCriticalPool">IsThisCriticalPool.</param>
		/// <param name="PoolType">PoolType.</param>
		public AddIpPoolInSdaVirtualNetworkRequestInner(string? VirtualNetworkName = default, string? IpPoolName = default, string? TrafficType = default, string? AuthenticationPolicyName = default, string? ScalableGroupName = default, bool? IsL2FloodingEnabled = default, bool? IsThisCriticalPool = default, string? PoolType = default)
		{
			this.VirtualNetworkName = VirtualNetworkName;
			this.IpPoolName = IpPoolName;
			this.TrafficType = TrafficType;
			this.AuthenticationPolicyName = AuthenticationPolicyName;
			this.ScalableGroupName = ScalableGroupName;
			this.IsL2FloodingEnabled = IsL2FloodingEnabled;
			this.IsThisCriticalPool = IsThisCriticalPool;
			this.PoolType = PoolType;
		}

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
		/// Gets or Sets TrafficType
		/// </summary>
		[DataMember(Name = "trafficType", EmitDefaultValue = false)]
		public string? TrafficType { get; set; }
		/// <summary>
		/// Gets or Sets AuthenticationPolicyName
		/// </summary>
		[DataMember(Name = "authenticationPolicyName", EmitDefaultValue = false)]
		public string? AuthenticationPolicyName { get; set; }
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
		/// Gets or Sets IsThisCriticalPool
		/// </summary>
		[DataMember(Name = "isThisCriticalPool", EmitDefaultValue = false)]
		public bool? IsThisCriticalPool { get; set; }
		/// <summary>
		/// Gets or Sets PoolType
		/// </summary>
		[DataMember(Name = "poolType", EmitDefaultValue = false)]
		public string? PoolType { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddIPPoolInSDAVirtualNetworkRequestInner {\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
			sb.Append("  TrafficType: ").Append(TrafficType).Append("\n");
			sb.Append("  AuthenticationPolicyName: ").Append(AuthenticationPolicyName).Append("\n");
			sb.Append("  ScalableGroupName: ").Append(ScalableGroupName).Append("\n");
			sb.Append("  IsL2FloodingEnabled: ").Append(IsL2FloodingEnabled).Append("\n");
			sb.Append("  IsThisCriticalPool: ").Append(IsThisCriticalPool).Append("\n");
			sb.Append("  PoolType: ").Append(PoolType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
