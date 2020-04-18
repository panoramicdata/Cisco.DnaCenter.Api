using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallClientHealthResponseResponse
	/// </summary>
	[DataContract]
	public class GetOverallClientHealthResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallClientHealthResponseResponse" /> class.
		/// </summary>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="ScoreDetail">ScoreDetail.</param>
		public GetOverallClientHealthResponseResponse(string? SiteId = default, List<GetOverallClientHealthResponseScoreDetail> ScoreDetail = default)
		{
			this.SiteId = SiteId;
			this.ScoreDetail = ScoreDetail;
		}

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }
		/// <summary>
		/// Gets or Sets ScoreDetail
		/// </summary>
		[DataMember(Name = "scoreDetail", EmitDefaultValue = false)]
		public List<GetOverallClientHealthResponseScoreDetail> ScoreDetail { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallClientHealthResponseResponse {\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  ScoreDetail: ").Append(ScoreDetail).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
