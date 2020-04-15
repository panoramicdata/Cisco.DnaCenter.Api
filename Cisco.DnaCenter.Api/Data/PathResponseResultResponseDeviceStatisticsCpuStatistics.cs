using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseDeviceStatisticsCpuStatistics
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponseDeviceStatisticsCpuStatistics
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseDeviceStatisticsCpuStatistics" /> class.
		/// </summary>
		/// <param name="FiveMinUsageInPercentage">FiveMinUsageInPercentage.</param>
		/// <param name="FiveSecsUsageInPercentage">FiveSecsUsageInPercentage.</param>
		/// <param name="OneMinUsageInPercentage">OneMinUsageInPercentage.</param>
		/// <param name="RefreshedAt">RefreshedAt.</param>
		public PathResponseResultResponseDeviceStatisticsCpuStatistics(decimal? FiveMinUsageInPercentage = default, decimal? FiveSecsUsageInPercentage = default, decimal? OneMinUsageInPercentage = default, int? RefreshedAt = default)
		{
			this.FiveMinUsageInPercentage = FiveMinUsageInPercentage;
			this.FiveSecsUsageInPercentage = FiveSecsUsageInPercentage;
			this.OneMinUsageInPercentage = OneMinUsageInPercentage;
			this.RefreshedAt = RefreshedAt;
		}

		/// <summary>
		/// Gets or Sets FiveMinUsageInPercentage
		/// </summary>
		[DataMember(Name = "fiveMinUsageInPercentage", EmitDefaultValue = false)]
		public decimal? FiveMinUsageInPercentage { get; set; }
		/// <summary>
		/// Gets or Sets FiveSecsUsageInPercentage
		/// </summary>
		[DataMember(Name = "fiveSecsUsageInPercentage", EmitDefaultValue = false)]
		public decimal? FiveSecsUsageInPercentage { get; set; }
		/// <summary>
		/// Gets or Sets OneMinUsageInPercentage
		/// </summary>
		[DataMember(Name = "oneMinUsageInPercentage", EmitDefaultValue = false)]
		public decimal? OneMinUsageInPercentage { get; set; }
		/// <summary>
		/// Gets or Sets RefreshedAt
		/// </summary>
		[DataMember(Name = "refreshedAt", EmitDefaultValue = false)]
		public int? RefreshedAt { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseDeviceStatisticsCpuStatistics {\n");
			sb.Append("  FiveMinUsageInPercentage: ").Append(FiveMinUsageInPercentage).Append("\n");
			sb.Append("  FiveSecsUsageInPercentage: ").Append(FiveSecsUsageInPercentage).Append("\n");
			sb.Append("  OneMinUsageInPercentage: ").Append(OneMinUsageInPercentage).Append("\n");
			sb.Append("  RefreshedAt: ").Append(RefreshedAt).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
