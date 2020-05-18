using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteResponse
	/// </summary>
	[DataContract]
	public class ExecutionStatusResponse
	{
		[DataMember(Name = "executionId")]
		public string ExecutionId { get; set; }

		[DataMember(Name = "executionStatusUrl")]
		public string ExecutionStatusUrl { get; set; }

		[DataMember(Name = "message")]
		public string Message { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSiteResponse {\n");
			sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
			sb.Append("  ExecutionStatusUrl: ").Append(ExecutionStatusUrl).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
