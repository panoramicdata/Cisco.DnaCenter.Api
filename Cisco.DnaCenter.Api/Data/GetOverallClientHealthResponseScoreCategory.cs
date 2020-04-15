using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallClientHealthResponseScoreCategory
	/// </summary>
	[DataContract]
	public partial class GetOverallClientHealthResponseScoreCategory
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallClientHealthResponseScoreCategory" /> class.
		/// </summary>
		/// <param name="ScoreCategory">ScoreCategory.</param>
		/// <param name="Value">Value.</param>
		public GetOverallClientHealthResponseScoreCategory(string? ScoreCategory = default, string? Value = default)
		{
			this.ScoreCategory = ScoreCategory;
			this.Value = Value;
		}

		/// <summary>
		/// Gets or Sets ScoreCategory
		/// </summary>
		[DataMember(Name = "scoreCategory", EmitDefaultValue = false)]
		public string? ScoreCategory { get; set; }
		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string? Value { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallClientHealthResponseScoreCategory {\n");
			sb.Append("  ScoreCategory: ").Append(ScoreCategory).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
