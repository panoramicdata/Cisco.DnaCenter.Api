using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetOverallNetworkHealthResponseHealthDistirubution
/// </summary>
[DataContract]
public class GetOverallNetworkHealthResponseHealthDistirubution
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetOverallNetworkHealthResponseHealthDistirubution" /> class.
	/// </summary>
	/// <param name="Category">Category.</param>
	/// <param name="TotalCount">TotalCount.</param>
	/// <param name="HealthScore">HealthScore.</param>
	/// <param name="GoodPercentage">GoodPercentage.</param>
	/// <param name="BadPercentage">BadPercentage.</param>
	/// <param name="FairPercentage">FairPercentage.</param>
	/// <param name="UnmonPercentage">UnmonPercentage.</param>
	/// <param name="GoodCount">GoodCount.</param>
	/// <param name="BadCount">BadCount.</param>
	/// <param name="FairCount">FairCount.</param>
	/// <param name="UnmonCount">UnmonCount.</param>
	/// <param name="KpiMetrics">KpiMetrics.</param>
	public GetOverallNetworkHealthResponseHealthDistirubution(string? Category = default, int? TotalCount = default, int? HealthScore = default, int? GoodPercentage = default, decimal? BadPercentage = default, decimal? FairPercentage = default, decimal? UnmonPercentage = default, int? GoodCount = default, decimal? BadCount = default, decimal? FairCount = default, decimal? UnmonCount = default, List<Object> KpiMetrics = default)
	{
		this.Category = Category;
		this.TotalCount = TotalCount;
		this.HealthScore = HealthScore;
		this.GoodPercentage = GoodPercentage;
		this.BadPercentage = BadPercentage;
		this.FairPercentage = FairPercentage;
		this.UnmonPercentage = UnmonPercentage;
		this.GoodCount = GoodCount;
		this.BadCount = BadCount;
		this.FairCount = FairCount;
		this.UnmonCount = UnmonCount;
		this.KpiMetrics = KpiMetrics;
	}

	/// <summary>
	/// Gets or Sets Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string? Category { get; set; }

	/// <summary>
	/// Gets or Sets TotalCount
	/// </summary>
	[DataMember(Name = "totalCount", EmitDefaultValue = false)]
	public int? TotalCount { get; set; }

	/// <summary>
	/// Gets or Sets HealthScore
	/// </summary>
	[DataMember(Name = "healthScore", EmitDefaultValue = false)]
	public int? HealthScore { get; set; }

	/// <summary>
	/// Gets or Sets GoodPercentage
	/// </summary>
	[DataMember(Name = "goodPercentage", EmitDefaultValue = false)]
	public int? GoodPercentage { get; set; }

	/// <summary>
	/// Gets or Sets BadPercentage
	/// </summary>
	[DataMember(Name = "badPercentage", EmitDefaultValue = false)]
	public decimal? BadPercentage { get; set; }

	/// <summary>
	/// Gets or Sets FairPercentage
	/// </summary>
	[DataMember(Name = "fairPercentage", EmitDefaultValue = false)]
	public decimal? FairPercentage { get; set; }

	/// <summary>
	/// Gets or Sets UnmonPercentage
	/// </summary>
	[DataMember(Name = "unmonPercentage", EmitDefaultValue = false)]
	public decimal? UnmonPercentage { get; set; }

	/// <summary>
	/// Gets or Sets GoodCount
	/// </summary>
	[DataMember(Name = "goodCount", EmitDefaultValue = false)]
	public int? GoodCount { get; set; }

	/// <summary>
	/// Gets or Sets BadCount
	/// </summary>
	[DataMember(Name = "badCount", EmitDefaultValue = false)]
	public decimal? BadCount { get; set; }

	/// <summary>
	/// Gets or Sets FairCount
	/// </summary>
	[DataMember(Name = "fairCount", EmitDefaultValue = false)]
	public decimal? FairCount { get; set; }

	/// <summary>
	/// Gets or Sets UnmonCount
	/// </summary>
	[DataMember(Name = "unmonCount", EmitDefaultValue = false)]
	public decimal? UnmonCount { get; set; }

	/// <summary>
	/// Gets or Sets KpiMetrics
	/// </summary>
	[DataMember(Name = "kpiMetrics", EmitDefaultValue = false)]
	public List<Object> KpiMetrics { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetOverallNetworkHealthResponseHealthDistirubution {\n");
		sb.Append("  Category: ").Append(Category).Append("\n");
		sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
		sb.Append("  HealthScore: ").Append(HealthScore).Append("\n");
		sb.Append("  GoodPercentage: ").Append(GoodPercentage).Append("\n");
		sb.Append("  BadPercentage: ").Append(BadPercentage).Append("\n");
		sb.Append("  FairPercentage: ").Append(FairPercentage).Append("\n");
		sb.Append("  UnmonPercentage: ").Append(UnmonPercentage).Append("\n");
		sb.Append("  GoodCount: ").Append(GoodCount).Append("\n");
		sb.Append("  BadCount: ").Append(BadCount).Append("\n");
		sb.Append("  FairCount: ").Append(FairCount).Append("\n");
		sb.Append("  UnmonCount: ").Append(UnmonCount).Append("\n");
		sb.Append("  KpiMetrics: ").Append(KpiMetrics).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
