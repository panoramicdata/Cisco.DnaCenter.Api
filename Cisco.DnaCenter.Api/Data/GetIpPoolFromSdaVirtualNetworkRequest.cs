using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetIPPoolFromSDAVirtualNetworkRequest
	/// </summary>
	[DataContract]
	public class GetIpPoolFromSdaVirtualNetworkRequest : List<DeleteIpPoolFromSdaVirtualNetworkRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetIpPoolFromSdaVirtualNetworkRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetIpPoolFromSdaVirtualNetworkRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetIPPoolFromSDAVirtualNetworkRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
