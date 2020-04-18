using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseAccuracyList
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseAccuracyList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseAccuracyList" /> class.
		/// </summary>
		/// <param name="Percent">Percent.</param>
		/// <param name="Reason">Reason.</param>
		public PathResponseResultResponseAccuracyList(int? Percent = default, string? Reason = default)
		{
			this.Percent = Percent;
			this.Reason = Reason;
		}

		/// <summary>
		/// Gets or Sets Percent
		/// </summary>
		[DataMember(Name = "percent", EmitDefaultValue = false)]
		public int? Percent { get; set; }
		/// <summary>
		/// Gets or Sets Reason
		/// </summary>
		[DataMember(Name = "reason", EmitDefaultValue = false)]
		public string? Reason { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseAccuracyList {\n");
			sb.Append("  Percent: ").Append(Percent).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
