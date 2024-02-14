using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// PathResponseResultResponseDeviceStatistics
/// </summary>
[DataContract]
public class PathResponseResultResponseDeviceStatistics
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PathResponseResultResponseDeviceStatistics" /> class.
	/// </summary>
	/// <param name="CpuStatistics">CpuStatistics.</param>
	/// <param name="MemoryStatistics">MemoryStatistics.</param>
	public PathResponseResultResponseDeviceStatistics(PathResponseResultResponseDeviceStatisticsCpuStatistics CpuStatistics = default, PathResponseResultResponseDeviceStatisticsMemoryStatistics MemoryStatistics = default)
	{
		this.CpuStatistics = CpuStatistics;
		this.MemoryStatistics = MemoryStatistics;
	}

	/// <summary>
	/// Gets or Sets CpuStatistics
	/// </summary>
	[DataMember(Name = "cpuStatistics", EmitDefaultValue = false)]
	public PathResponseResultResponseDeviceStatisticsCpuStatistics CpuStatistics { get; set; }

	/// <summary>
	/// Gets or Sets MemoryStatistics
	/// </summary>
	[DataMember(Name = "memoryStatistics", EmitDefaultValue = false)]
	public PathResponseResultResponseDeviceStatisticsMemoryStatistics MemoryStatistics { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class PathResponseResultResponseDeviceStatistics {\n");
		sb.Append("  CpuStatistics: ").Append(CpuStatistics).Append("\n");
		sb.Append("  MemoryStatistics: ").Append(MemoryStatistics).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
