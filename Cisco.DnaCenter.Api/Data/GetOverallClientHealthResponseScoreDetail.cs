using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallClientHealthResponseScoreDetail
	/// </summary>
	[DataContract]
	public class GetOverallClientHealthResponseScoreDetail
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallClientHealthResponseScoreDetail" /> class.
		/// </summary>
		/// <param name="ScoreCategory">ScoreCategory.</param>
		/// <param name="ScoreValue">ScoreValue.</param>
		/// <param name="ClientCount">ClientCount.</param>
		/// <param name="ClientUniqueCount">ClientUniqueCount.</param>
		/// <param name="Starttime">Starttime.</param>
		/// <param name="Endtime">Endtime.</param>
		/// <param name="ScoreList">ScoreList.</param>
		public GetOverallClientHealthResponseScoreDetail(
			GetOverallClientHealthResponseScoreCategory ScoreCategory = default,
			int? ScoreValue = default,
			int? ClientCount = default,
			int? ClientUniqueCount = default,
			long? Starttime = default,
			long? Endtime = default,
			List<GetOverallClientHealthResponseScoreList1> ScoreList = default)
		{
			this.ScoreCategory = ScoreCategory;
			this.ScoreValue = ScoreValue;
			this.ClientCount = ClientCount;
			this.ClientUniqueCount = ClientUniqueCount;
			this.Starttime = Starttime;
			this.Endtime = Endtime;
			this.ScoreList = ScoreList;
		}

		/// <summary>
		/// Gets or Sets ScoreCategory
		/// </summary>
		[DataMember(Name = "scoreCategory", EmitDefaultValue = false)]
		public GetOverallClientHealthResponseScoreCategory ScoreCategory { get; set; }

		/// <summary>
		/// Gets or Sets ScoreValue
		/// </summary>
		[DataMember(Name = "scoreValue", EmitDefaultValue = false)]
		public int? ScoreValue { get; set; }

		/// <summary>
		/// Gets or Sets ClientCount
		/// </summary>
		[DataMember(Name = "clientCount", EmitDefaultValue = false)]
		public int? ClientCount { get; set; }

		/// <summary>
		/// Gets or Sets ClientUniqueCount
		/// </summary>
		[DataMember(Name = "clientUniqueCount", EmitDefaultValue = false)]
		public int? ClientUniqueCount { get; set; }

		/// <summary>
		/// Gets or Sets Starttime
		/// </summary>
		[DataMember(Name = "starttime", EmitDefaultValue = false)]
		public long? Starttime { get; set; }

		/// <summary>
		/// Gets or Sets Endtime
		/// </summary>
		[DataMember(Name = "endtime", EmitDefaultValue = false)]
		public long? Endtime { get; set; }

		/// <summary>
		/// Gets or Sets ScoreList
		/// </summary>
		[DataMember(Name = "scoreList", EmitDefaultValue = false)]
		public List<GetOverallClientHealthResponseScoreList1> ScoreList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallClientHealthResponseScoreDetail {\n");
			sb.Append("  ScoreCategory: ").Append(ScoreCategory).Append("\n");
			sb.Append("  ScoreValue: ").Append(ScoreValue).Append("\n");
			sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
			sb.Append("  ClientUniqueCount: ").Append(ClientUniqueCount).Append("\n");
			sb.Append("  Starttime: ").Append(Starttime).Append("\n");
			sb.Append("  Endtime: ").Append(Endtime).Append("\n");
			sb.Append("  ScoreList: ").Append(ScoreList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
