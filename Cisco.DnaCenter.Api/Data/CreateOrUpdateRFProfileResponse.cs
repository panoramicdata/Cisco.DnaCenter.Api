using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateOrUpdateRFProfileResponse
	/// </summary>
	[DataContract]
	public partial class CreateOrUpdateRFProfileResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateOrUpdateRFProfileResponse" /> class.
		/// </summary>
		/// <param name="ExecutionId">ExecutionId.</param>
		/// <param name="ExecutionUrl">ExecutionUrl.</param>
		/// <param name="Message">Message.</param>
		public CreateOrUpdateRFProfileResponse(string? ExecutionId = default, string? ExecutionUrl = default, string? Message = default)
		{
			this.ExecutionId = ExecutionId;
			this.ExecutionUrl = ExecutionUrl;
			this.Message = Message;
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
		/// Gets or Sets Message
		/// </summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string? Message { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateOrUpdateRFProfileResponse {\n");
			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  ExecutionUrl: ").Append(ExecutionUrl).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
