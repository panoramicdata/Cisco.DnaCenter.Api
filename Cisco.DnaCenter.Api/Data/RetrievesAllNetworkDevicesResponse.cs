using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// RetrievesAllNetworkDevicesResponse
	/// </summary>
	[DataContract]
	public partial class RetrievesAllNetworkDevicesResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RetrievesAllNetworkDevicesResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public RetrievesAllNetworkDevicesResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RetrievesAllNetworkDevicesResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
