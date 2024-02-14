using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetDeviceHistoryResponse
/// </summary>
[DataContract]
public class GetDeviceHistoryResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetDeviceHistoryResponse" /> class.
	/// </summary>
	/// <param name="Response">Response.</param>
	/// <param name="StatusCode">StatusCode.</param>
	public GetDeviceHistoryResponse(List<GetDeviceHistoryResponseResponse> Response = default, decimal? StatusCode = default)
	{
		this.Response = Response;
		this.StatusCode = StatusCode;
	}

	/// <summary>
	/// Gets or Sets Response
	/// </summary>
	[DataMember(Name = "response", EmitDefaultValue = false)]
	public List<GetDeviceHistoryResponseResponse> Response { get; set; }

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
		sb.Append("class GetDeviceHistoryResponse {\n");
		sb.Append("  Response: ").Append(Response).Append("\n");
		sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
