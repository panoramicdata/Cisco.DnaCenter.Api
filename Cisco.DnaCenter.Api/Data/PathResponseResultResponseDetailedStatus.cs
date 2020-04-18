using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponseDetailedStatus
	/// </summary>
	[DataContract]
	public class PathResponseResultResponseDetailedStatus
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponseDetailedStatus" /> class.
		/// </summary>
		/// <param name="AclTraceCalculation">AclTraceCalculation.</param>
		/// <param name="AclTraceCalculationFailureReason">AclTraceCalculationFailureReason.</param>
		public PathResponseResultResponseDetailedStatus(string? AclTraceCalculation = default, string? AclTraceCalculationFailureReason = default)
		{
			this.AclTraceCalculation = AclTraceCalculation;
			this.AclTraceCalculationFailureReason = AclTraceCalculationFailureReason;
		}

		/// <summary>
		/// Gets or Sets AclTraceCalculation
		/// </summary>
		[DataMember(Name = "aclTraceCalculation", EmitDefaultValue = false)]
		public string? AclTraceCalculation { get; set; }
		/// <summary>
		/// Gets or Sets AclTraceCalculationFailureReason
		/// </summary>
		[DataMember(Name = "aclTraceCalculationFailureReason", EmitDefaultValue = false)]
		public string? AclTraceCalculationFailureReason { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponseDetailedStatus {\n");
			sb.Append("  AclTraceCalculation: ").Append(AclTraceCalculation).Append("\n");
			sb.Append("  AclTraceCalculationFailureReason: ").Append(AclTraceCalculationFailureReason).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
