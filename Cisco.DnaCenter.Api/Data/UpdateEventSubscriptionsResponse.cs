using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateEventSubscriptionsResponse
	/// </summary>
	[DataContract]
	public partial class UpdateEventSubscriptionsResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateEventSubscriptionsResponse" /> class.
		/// </summary>
		/// <param name="StatusUri">StatusUri.</param>
		public UpdateEventSubscriptionsResponse(string? StatusUri = default)
		{
			this.StatusUri = StatusUri;
		}

		/// <summary>
		/// Gets or Sets StatusUri
		/// </summary>
		[DataMember(Name = "statusUri", EmitDefaultValue = false)]
		public string? StatusUri { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateEventSubscriptionsResponse {\n");
			sb.Append("  StatusUri: ").Append(StatusUri).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
