using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetIPPoolFromSDAVirtualNetworkResponse
	/// </summary>
	[DataContract]
	public partial class GetIPPoolFromSDAVirtualNetworkResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetIPPoolFromSDAVirtualNetworkResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Description">Description.</param>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		/// <param name="IpPoolName">IpPoolName.</param>
		/// <param name="AuthenticationPolicyName">AuthenticationPolicyName.</param>
		/// <param name="TrafficType">TrafficType.</param>
		/// <param name="ScalableGroupName">ScalableGroupName.</param>
		/// <param name="IsL2FloodingEnabled">IsL2FloodingEnabled.</param>
		/// <param name="IsThisCriticalPool">IsThisCriticalPool.</param>
		public GetIPPoolFromSDAVirtualNetworkResponse(string? Status = default, string? Description = default, string? VirtualNetworkName = default, string? IpPoolName = default, string? AuthenticationPolicyName = default, string? TrafficType = default, string? ScalableGroupName = default, bool? IsL2FloodingEnabled = default, bool? IsThisCriticalPool = default)
		{
			this.Status = Status;
			this.Description = Description;
			this.VirtualNetworkName = VirtualNetworkName;
			this.IpPoolName = IpPoolName;
			this.AuthenticationPolicyName = AuthenticationPolicyName;
			this.TrafficType = TrafficType;
			this.ScalableGroupName = ScalableGroupName;
			this.IsL2FloodingEnabled = IsL2FloodingEnabled;
			this.IsThisCriticalPool = IsThisCriticalPool;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
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
		/// Gets or Sets IsThisCriticalPool
		/// </summary>
		[DataMember(Name = "isThisCriticalPool", EmitDefaultValue = false)]
		public bool? IsThisCriticalPool { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetIPPoolFromSDAVirtualNetworkResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("  IpPoolName: ").Append(IpPoolName).Append("\n");
			sb.Append("  AuthenticationPolicyName: ").Append(AuthenticationPolicyName).Append("\n");
			sb.Append("  TrafficType: ").Append(TrafficType).Append("\n");
			sb.Append("  ScalableGroupName: ").Append(ScalableGroupName).Append("\n");
			sb.Append("  IsL2FloodingEnabled: ").Append(IsL2FloodingEnabled).Append("\n");
			sb.Append("  IsThisCriticalPool: ").Append(IsThisCriticalPool).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
