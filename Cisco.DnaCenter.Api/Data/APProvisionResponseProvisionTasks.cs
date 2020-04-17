using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionResponseProvisionTasks
	/// </summary>
	[DataContract]
	public partial class ApProvisionResponseProvisionTasks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApProvisionResponseProvisionTasks" /> class.
		/// </summary>
		/// <param name="Success">Success.</param>
		/// <param name="Failure">Failure.</param>
		public ApProvisionResponseProvisionTasks(List<ApProvisionResponseProvisionTasksSuccess> Success = default, ApProvisionResponseProvisionTasksFailure Failure = default)
		{
			this.Success = Success;
			this.Failure = Failure;
		}

		/// <summary>
		/// Gets or Sets Success
		/// </summary>
		[DataMember(Name = "success", EmitDefaultValue = false)]
		public List<ApProvisionResponseProvisionTasksSuccess> Success { get; set; }
		/// <summary>
		/// Gets or Sets Failure
		/// </summary>
		[DataMember(Name = "failure", EmitDefaultValue = false)]
		public ApProvisionResponseProvisionTasksFailure Failure { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionResponseProvisionTasks {\n");
			sb.Append("  Success: ").Append(Success).Append("\n");
			sb.Append("  Failure: ").Append(Failure).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
