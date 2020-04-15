using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteResponse
	/// </summary>
	[DataContract]
	public partial class UpdateSiteResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSiteResponse" /> class.
		/// </summary>
		/// <param name="Result">Result.</param>
		/// <param name="Response">Response.</param>
		/// <param name="Status">Status.</param>
		public UpdateSiteResponse(string? Result = default, UpdateSiteResponseResponse Response = default, string? Status = default)
		{
			this.Result = Result;
			this.Response = Response;
			this.Status = Status;
		}

		/// <summary>
		/// Gets or Sets Result
		/// </summary>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		public string? Result { get; set; }
		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public UpdateSiteResponseResponse Response { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSiteResponse {\n");
			sb.Append("  Result: ").Append(Result).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
