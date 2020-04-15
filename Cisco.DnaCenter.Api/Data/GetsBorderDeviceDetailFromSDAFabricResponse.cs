using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetsBorderDeviceDetailFromSDAFabricResponse
	/// </summary>
	[DataContract]
	public partial class GetsBorderDeviceDetailFromSDAFabricResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetsBorderDeviceDetailFromSDAFabricResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Payload">Payload.</param>
		public GetsBorderDeviceDetailFromSDAFabricResponse(string? Status = default, string? Description = default, GetsBorderDeviceDetailFromSDAFabricResponsePayload Payload = default)
		{
			this.Status = Status;
			this.Description = Description;
			this.Payload = Payload;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets Payload
		/// </summary>
		[DataMember(Name = "payload", EmitDefaultValue = false)]
		public GetsBorderDeviceDetailFromSDAFabricResponsePayload Payload { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetsBorderDeviceDetailFromSDAFabricResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Payload: ").Append(Payload).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
