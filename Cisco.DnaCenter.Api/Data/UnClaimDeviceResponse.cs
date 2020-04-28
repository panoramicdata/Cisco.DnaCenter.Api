using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UnClaimDeviceResponse
	/// </summary>
	[DataContract]
	public class UnClaimDeviceResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnClaimDeviceResponse" /> class.
		/// </summary>
		/// <param name="JsonArrayResponse">JsonArrayResponse.</param>
		/// <param name="JsonResponse">JsonResponse.</param>
		/// <param name="Message">Message.</param>
		/// <param name="StatusCode">StatusCode.</param>
		public UnClaimDeviceResponse(List<Object> JsonArrayResponse = default, Object JsonResponse = default, string? Message = default, decimal? StatusCode = default)
		{
			this.JsonArrayResponse = JsonArrayResponse;
			this.JsonResponse = JsonResponse;
			this.Message = Message;
			this.StatusCode = StatusCode;
		}

		/// <summary>
		/// Gets or Sets JsonArrayResponse
		/// </summary>
		[DataMember(Name = "jsonArrayResponse", EmitDefaultValue = false)]
		public List<Object> JsonArrayResponse { get; set; }

		/// <summary>
		/// Gets or Sets JsonResponse
		/// </summary>
		[DataMember(Name = "jsonResponse", EmitDefaultValue = false)]
		public Object JsonResponse { get; set; }

		/// <summary>
		/// Gets or Sets Message
		/// </summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string? Message { get; set; }

		/// <summary>
		/// Gets or Sets StatusCode
		/// </summary>
		[DataMember(Name = "statusCode", EmitDefaultValue = false)]
		public decimal? StatusCode { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UnClaimDeviceResponse {\n");
			sb.Append("  JsonArrayResponse: ").Append(JsonArrayResponse).Append("\n");
			sb.Append("  JsonResponse: ").Append(JsonResponse).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
