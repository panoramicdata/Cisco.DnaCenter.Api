using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetStatusAPIForEventsResponse
	/// </summary>
	[DataContract]
	public class GetEventStatusApisResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEventStatusApisResponse" /> class.
		/// </summary>
		/// <param name="ErrorMessage">ErrorMessage.</param>
		/// <param name="ApiStatus">ApiStatus.</param>
		/// <param name="StatusMessage">StatusMessage.</param>
		public GetEventStatusApisResponse(Object ErrorMessage = default, string? ApiStatus = default, string? StatusMessage = default)
		{
			this.ErrorMessage = ErrorMessage;
			this.ApiStatus = ApiStatus;
			this.StatusMessage = StatusMessage;
		}

		/// <summary>
		/// Gets or Sets ErrorMessage
		/// </summary>
		[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
		public Object ErrorMessage { get; set; }
		/// <summary>
		/// Gets or Sets ApiStatus
		/// </summary>
		[DataMember(Name = "apiStatus", EmitDefaultValue = false)]
		public string? ApiStatus { get; set; }
		/// <summary>
		/// Gets or Sets StatusMessage
		/// </summary>
		[DataMember(Name = "statusMessage", EmitDefaultValue = false)]
		public string? StatusMessage { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetStatusAPIForEventsResponse {\n");
			sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
			sb.Append("  ApiStatus: ").Append(ApiStatus).Append("\n");
			sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
