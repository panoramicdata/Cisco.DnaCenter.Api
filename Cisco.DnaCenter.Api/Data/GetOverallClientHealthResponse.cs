using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallClientHealthResponse
	/// </summary>
	[DataContract]
	public class GetOverallClientHealthResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallClientHealthResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>

		public GetOverallClientHealthResponse() : this(default) { }

		public GetOverallClientHealthResponse(List<GetOverallClientHealthResponseResponse> Response)
		{
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<GetOverallClientHealthResponseResponse> Response { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallClientHealthResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
