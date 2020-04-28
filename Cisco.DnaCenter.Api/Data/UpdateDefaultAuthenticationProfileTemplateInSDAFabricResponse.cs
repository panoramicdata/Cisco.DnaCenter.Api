using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse
	/// </summary>
	[DataContract]
	public class UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ExecutionStatusUrl">ExecutionStatusUrl.</param>
		public UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse(string? Status = default, string? Description = default, string? ExecutionStatusUrl = default)
		{
			this.Status = Status;
			this.Description = Description;
			this.ExecutionStatusUrl = ExecutionStatusUrl;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or Sets ExecutionStatusUrl
		/// </summary>
		[DataMember(Name = "executionStatusUrl", EmitDefaultValue = false)]
		public string? ExecutionStatusUrl { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDefaultAuthenticationProfileTemplateInSdaFabricResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  ExecutionStatusUrl: ").Append(ExecutionStatusUrl).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
