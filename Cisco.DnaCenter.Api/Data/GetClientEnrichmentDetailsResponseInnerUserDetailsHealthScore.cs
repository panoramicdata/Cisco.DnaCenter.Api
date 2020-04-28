using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore
	/// </summary>
	[DataContract]
	public class GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore" /> class.
		/// </summary>
		/// <param name="HealthType">HealthType.</param>
		/// <param name="Reason">Reason.</param>
		/// <param name="Score">Score.</param>
		public GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore(string? HealthType = default, string? Reason = default, int? Score = default)
		{
			this.HealthType = HealthType;
			this.Reason = Reason;
			this.Score = Score;
		}

		/// <summary>
		/// Gets or Sets HealthType
		/// </summary>
		[DataMember(Name = "healthType", EmitDefaultValue = false)]
		public string? HealthType { get; set; }

		/// <summary>
		/// Gets or Sets Reason
		/// </summary>
		[DataMember(Name = "reason", EmitDefaultValue = false)]
		public string? Reason { get; set; }

		/// <summary>
		/// Gets or Sets Score
		/// </summary>
		[DataMember(Name = "score", EmitDefaultValue = false)]
		public int? Score { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerUserDetailsHealthScore {\n");
			sb.Append("  HealthType: ").Append(HealthType).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
			sb.Append("  Score: ").Append(Score).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
