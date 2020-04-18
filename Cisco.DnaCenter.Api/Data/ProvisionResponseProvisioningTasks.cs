using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionResponseProvisioningTasks
	/// </summary>
	[DataContract]
	public class ProvisionResponseProvisioningTasks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionResponseProvisioningTasks" /> class.
		/// </summary>
		/// <param name="Success">Success.</param>
		/// <param name="Failed">Failed.</param>
		public ProvisionResponseProvisioningTasks(List<string> Success = default, List<string> Failed = default)
		{
			this.Success = Success;
			this.Failed = Failed;
		}

		/// <summary>
		/// Gets or Sets Success
		/// </summary>
		[DataMember(Name = "success", EmitDefaultValue = false)]
		public List<string> Success { get; set; }
		/// <summary>
		/// Gets or Sets Failed
		/// </summary>
		[DataMember(Name = "failed", EmitDefaultValue = false)]
		public List<string> Failed { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionResponseProvisioningTasks {\n");
			sb.Append("  Success: ").Append(Success).Append("\n");
			sb.Append("  Failed: ").Append(Failed).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
