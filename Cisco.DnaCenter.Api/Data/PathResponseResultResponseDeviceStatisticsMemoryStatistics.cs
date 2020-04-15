using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseDeviceStatisticsMemoryStatistics
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponseDeviceStatisticsMemoryStatistics
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseDeviceStatisticsMemoryStatistics" /> class.
		/// </summary>
		/// <param name="MemoryUsage">MemoryUsage.</param>
		/// <param name="RefreshedAt">RefreshedAt.</param>
		/// <param name="TotalMemory">TotalMemory.</param>
		public PathResponseResultResponseDeviceStatisticsMemoryStatistics(int? MemoryUsage = default, int? RefreshedAt = default, int? TotalMemory = default)
		{
			this.MemoryUsage = MemoryUsage;
			this.RefreshedAt = RefreshedAt;
			this.TotalMemory = TotalMemory;
		}

		/// <summary>
		/// Gets or Sets MemoryUsage
		/// </summary>
		[DataMember(Name = "memoryUsage", EmitDefaultValue = false)]
		public int? MemoryUsage { get; set; }
		/// <summary>
		/// Gets or Sets RefreshedAt
		/// </summary>
		[DataMember(Name = "refreshedAt", EmitDefaultValue = false)]
		public int? RefreshedAt { get; set; }
		/// <summary>
		/// Gets or Sets TotalMemory
		/// </summary>
		[DataMember(Name = "totalMemory", EmitDefaultValue = false)]
		public int? TotalMemory { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseDeviceStatisticsMemoryStatistics {\n");
			sb.Append("  MemoryUsage: ").Append(MemoryUsage).Append("\n");
			sb.Append("  RefreshedAt: ").Append(RefreshedAt).Append("\n");
			sb.Append("  TotalMemory: ").Append(TotalMemory).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
