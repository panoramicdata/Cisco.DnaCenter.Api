using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// RetrieveRFProfilesResponse
	/// </summary>
	[DataContract]
	public partial class RetrieveRFProfilesResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RetrieveRFProfilesResponse" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		public RetrieveRFProfilesResponse(List<RetrieveRFProfilesResponseResponse> Response = default)
		{
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<RetrieveRFProfilesResponseResponse> Response { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RetrieveRFProfilesResponse {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
