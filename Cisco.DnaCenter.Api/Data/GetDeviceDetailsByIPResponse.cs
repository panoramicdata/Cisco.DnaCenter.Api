using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceDetailsByIPResponse
	/// </summary>
	[DataContract]
	public partial class GetDeviceDetailsByIPResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceDetailsByIPResponse" /> class.
		/// </summary>
		/// <param name="ProvisionDetails">ProvisionDetails.</param>
		public GetDeviceDetailsByIPResponse(GetDeviceDetailsByIPResponseProvisionDetails ProvisionDetails = default)
		{
			this.ProvisionDetails = ProvisionDetails;
		}

		/// <summary>
		/// Gets or Sets ProvisionDetails
		/// </summary>
		[DataMember(Name = "provisionDetails", EmitDefaultValue = false)]
		public GetDeviceDetailsByIPResponseProvisionDetails ProvisionDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceDetailsByIPResponse {\n");
			sb.Append("  ProvisionDetails: ").Append(ProvisionDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
