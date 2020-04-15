using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallClientHealthResponseScoreList1
	/// </summary>
	[DataContract]
	public partial class GetOverallClientHealthResponseScoreList1
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallClientHealthResponseScoreList1" /> class.
		/// </summary>
		/// <param name="ScoreCategory">ScoreCategory.</param>
		/// <param name="ScoreValue">ScoreValue.</param>
		/// <param name="ClientCount">ClientCount.</param>
		/// <param name="ClientUniqueCount">ClientUniqueCount.</param>
		/// <param name="Starttime">Starttime.</param>
		/// <param name="Endtime">Endtime.</param>
		/// <param name="ScoreList">ScoreList.</param>
		public GetOverallClientHealthResponseScoreList1(GetOverallClientHealthResponseScoreCategory ScoreCategory = default, int? ScoreValue = default, int? ClientCount = default, decimal? ClientUniqueCount = default, int? Starttime = default, int? Endtime = default, List<GetOverallClientHealthResponseScoreList> ScoreList = default)
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
		public decimal? ClientUniqueCount { get; set; }
		/// <summary>
		/// Gets or Sets Starttime
		/// </summary>
		[DataMember(Name = "starttime", EmitDefaultValue = false)]
		public int? Starttime { get; set; }
		/// <summary>
		/// Gets or Sets Endtime
		/// </summary>
		[DataMember(Name = "endtime", EmitDefaultValue = false)]
		public int? Endtime { get; set; }
		/// <summary>
		/// Gets or Sets ScoreList
		/// </summary>
		[DataMember(Name = "scoreList", EmitDefaultValue = false)]
		public List<GetOverallClientHealthResponseScoreList> ScoreList { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallClientHealthResponseScoreList1 {\n");
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
