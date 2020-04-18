using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionResponse
	/// </summary>
	[DataContract]
	public class ApProvisionResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApProvisionResponse" /> class.
		/// </summary>
		/// <param name="ExecutionId">ExecutionId.</param>
		/// <param name="ExecutionUrl">ExecutionUrl.</param>
		/// <param name="ProvisionTasks">ProvisionTasks.</param>
		public ApProvisionResponse(string? ExecutionId = default, string? ExecutionUrl = default, ApProvisionResponseProvisionTasks ProvisionTasks = default)
		{
			this.ExecutionId = ExecutionId;
			this.ExecutionUrl = ExecutionUrl;
			this.ProvisionTasks = ProvisionTasks;
		}

		/// <summary>
		/// Gets or Sets ExecutionId
		/// </summary>
		[DataMember(Name = "executionId", EmitDefaultValue = false)]
		public string? ExecutionId { get; set; }
		/// <summary>
		/// Gets or Sets ExecutionUrl
		/// </summary>
		[DataMember(Name = "executionUrl", EmitDefaultValue = false)]
		public string? ExecutionUrl { get; set; }
		/// <summary>
		/// Gets or Sets ProvisionTasks
		/// </summary>
		[DataMember(Name = "provisionTasks", EmitDefaultValue = false)]
		public ApProvisionResponseProvisionTasks ProvisionTasks { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionResponse {\n");
			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  ExecutionUrl: ").Append(ExecutionUrl).Append("\n");
			sb.Append("  ProvisionTasks: ").Append(ProvisionTasks).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
