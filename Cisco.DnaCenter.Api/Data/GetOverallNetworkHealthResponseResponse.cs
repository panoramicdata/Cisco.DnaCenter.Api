using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallNetworkHealthResponseResponse
	/// </summary>
	[DataContract]
	public class GetOverallNetworkHealthResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallNetworkHealthResponseResponse" /> class.
		/// </summary>
		/// <param name="Time">Time.</param>
		/// <param name="HealthScore">HealthScore.</param>
		/// <param name="TotalCount">TotalCount.</param>
		/// <param name="GoodCount">GoodCount.</param>
		/// <param name="UnmonCount">UnmonCount.</param>
		/// <param name="FairCount">FairCount.</param>
		/// <param name="BadCount">BadCount.</param>
		/// <param name="Entity">Entity.</param>
		/// <param name="TimeinMillis">TimeinMillis.</param>
		public GetOverallNetworkHealthResponseResponse(string? Time = default, int? HealthScore = default, int? TotalCount = default, int? GoodCount = default, decimal? UnmonCount = default, int? FairCount = default, decimal? BadCount = default, Object Entity = default, int? TimeinMillis = default)
		{
			this.Time = Time;
			this.HealthScore = HealthScore;
			this.TotalCount = TotalCount;
			this.GoodCount = GoodCount;
			this.UnmonCount = UnmonCount;
			this.FairCount = FairCount;
			this.BadCount = BadCount;
			this.Entity = Entity;
			this.TimeinMillis = TimeinMillis;
		}

		/// <summary>
		/// Gets or Sets Time
		/// </summary>
		[DataMember(Name = "time", EmitDefaultValue = false)]
		public string? Time { get; set; }

		/// <summary>
		/// Gets or Sets HealthScore
		/// </summary>
		[DataMember(Name = "healthScore", EmitDefaultValue = false)]
		public int? HealthScore { get; set; }

		/// <summary>
		/// Gets or Sets TotalCount
		/// </summary>
		[DataMember(Name = "totalCount", EmitDefaultValue = false)]
		public int? TotalCount { get; set; }

		/// <summary>
		/// Gets or Sets GoodCount
		/// </summary>
		[DataMember(Name = "goodCount", EmitDefaultValue = false)]
		public int? GoodCount { get; set; }

		/// <summary>
		/// Gets or Sets UnmonCount
		/// </summary>
		[DataMember(Name = "unmonCount", EmitDefaultValue = false)]
		public decimal? UnmonCount { get; set; }

		/// <summary>
		/// Gets or Sets FairCount
		/// </summary>
		[DataMember(Name = "fairCount", EmitDefaultValue = false)]
		public int? FairCount { get; set; }

		/// <summary>
		/// Gets or Sets BadCount
		/// </summary>
		[DataMember(Name = "badCount", EmitDefaultValue = false)]
		public decimal? BadCount { get; set; }

		/// <summary>
		/// Gets or Sets Entity
		/// </summary>
		[DataMember(Name = "entity", EmitDefaultValue = false)]
		public Object Entity { get; set; }

		/// <summary>
		/// Gets or Sets TimeinMillis
		/// </summary>
		[DataMember(Name = "timeinMillis", EmitDefaultValue = false)]
		public int? TimeinMillis { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallNetworkHealthResponseResponse {\n");
			sb.Append("  Time: ").Append(Time).Append("\n");
			sb.Append("  HealthScore: ").Append(HealthScore).Append("\n");
			sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
			sb.Append("  GoodCount: ").Append(GoodCount).Append("\n");
			sb.Append("  UnmonCount: ").Append(UnmonCount).Append("\n");
			sb.Append("  FairCount: ").Append(FairCount).Append("\n");
			sb.Append("  BadCount: ").Append(BadCount).Append("\n");
			sb.Append("  Entity: ").Append(Entity).Append("\n");
			sb.Append("  TimeinMillis: ").Append(TimeinMillis).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
