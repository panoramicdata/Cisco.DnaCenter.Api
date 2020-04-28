using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceHistoryResponseResponse
	/// </summary>
	[DataContract]
	public class GetDeviceHistoryResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceHistoryResponseResponse" /> class.
		/// </summary>
		/// <param name="Timestamp">Timestamp.</param>
		/// <param name="Details">Details.</param>
		/// <param name="HistoryTaskInfo">HistoryTaskInfo.</param>
		/// <param name="ErrorFlag">ErrorFlag.</param>
		public GetDeviceHistoryResponseResponse(decimal? Timestamp = default, string? Details = default, GetDeviceHistoryResponseHistoryTaskInfo HistoryTaskInfo = default, bool? ErrorFlag = default)
		{
			this.Timestamp = Timestamp;
			this.Details = Details;
			this.HistoryTaskInfo = HistoryTaskInfo;
			this.ErrorFlag = ErrorFlag;
		}

		/// <summary>
		/// Gets or Sets Timestamp
		/// </summary>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public decimal? Timestamp { get; set; }

		/// <summary>
		/// Gets or Sets Details
		/// </summary>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public string? Details { get; set; }

		/// <summary>
		/// Gets or Sets HistoryTaskInfo
		/// </summary>
		[DataMember(Name = "historyTaskInfo", EmitDefaultValue = false)]
		public GetDeviceHistoryResponseHistoryTaskInfo HistoryTaskInfo { get; set; }

		/// <summary>
		/// Gets or Sets ErrorFlag
		/// </summary>
		[DataMember(Name = "errorFlag", EmitDefaultValue = false)]
		public bool? ErrorFlag { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceHistoryResponseResponse {\n");
			sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
			sb.Append("  HistoryTaskInfo: ").Append(HistoryTaskInfo).Append("\n");
			sb.Append("  ErrorFlag: ").Append(ErrorFlag).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
