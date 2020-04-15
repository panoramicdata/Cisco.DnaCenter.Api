using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteDeviceCredentialResponse
	/// </summary>
	[DataContract]
	public partial class DeleteDeviceCredentialResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteDeviceCredentialResponse" /> class.
		/// </summary>
		/// <param name="ExecutionId">ExecutionId.</param>
		/// <param name="ExecutionStatusUrl">ExecutionStatusUrl.</param>
		/// <param name="Message">Message.</param>
		public DeleteDeviceCredentialResponse(string? ExecutionId = default, string? ExecutionStatusUrl = default, string? Message = default)
		{
			this.ExecutionId = ExecutionId;
			this.ExecutionStatusUrl = ExecutionStatusUrl;
			this.Message = Message;
		}

		/// <summary>
		/// Gets or Sets ExecutionId
		/// </summary>
		[DataMember(Name = "executionId", EmitDefaultValue = false)]
		public string? ExecutionId { get; set; }
		/// <summary>
		/// Gets or Sets ExecutionStatusUrl
		/// </summary>
		[DataMember(Name = "executionStatusUrl", EmitDefaultValue = false)]
		public string? ExecutionStatusUrl { get; set; }
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
			sb.Append("class DeleteDeviceCredentialResponse {\n");
			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  ExecutionStatusUrl: ").Append(ExecutionStatusUrl).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
