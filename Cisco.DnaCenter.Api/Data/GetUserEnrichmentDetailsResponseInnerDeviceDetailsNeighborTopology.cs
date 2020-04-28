using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetUserEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology
	/// </summary>
	[DataContract]
	public class GetUserEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetUserEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology" /> class.
		/// </summary>
		/// <param name="ErrorCode">ErrorCode.</param>
		/// <param name="Message">Message.</param>
		/// <param name="Detail">Detail.</param>
		public GetUserEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology(int? ErrorCode = default, string? Message = default, string? Detail = default)
		{
			this.ErrorCode = ErrorCode;
			this.Message = Message;
			this.Detail = Detail;
		}

		/// <summary>
		/// Gets or Sets ErrorCode
		/// </summary>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public int? ErrorCode { get; set; }

		/// <summary>
		/// Gets or Sets Message
		/// </summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string? Message { get; set; }

		/// <summary>
		/// Gets or Sets Detail
		/// </summary>
		[DataMember(Name = "detail", EmitDefaultValue = false)]
		public string? Detail { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetUserEnrichmentDetailsResponseInnerDeviceDetailsNeighborTopology {\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  Detail: ").Append(Detail).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
