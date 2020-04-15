using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWirelessProfileResponse
	/// </summary>
	[DataContract]
	public partial class GetWirelessProfileResponse : List<GetWirelessProfileResponseInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWirelessProfileResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetWirelessProfileResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWirelessProfileResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
