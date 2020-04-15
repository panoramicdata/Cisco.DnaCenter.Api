using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeleteSiteResponse
	/// </summary>
	[DataContract]
	public partial class DeleteSiteResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteSiteResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Message">Message.</param>
		public DeleteSiteResponse(string? Status = default, string? Message = default)
		{
			this.Status = Status;
			this.Message = Message;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets Message
		/// </summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string? Message { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeleteSiteResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
