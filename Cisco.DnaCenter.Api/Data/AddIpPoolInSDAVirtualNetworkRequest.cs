using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddIPPoolInSDAVirtualNetworkRequest
	/// </summary>
	[DataContract]
	public partial class AddIpPoolInSDAVirtualNetworkRequest : List<AddIpPoolInSdaVirtualNetworkRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddIpPoolInSDAVirtualNetworkRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddIpPoolInSDAVirtualNetworkRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddIPPoolInSDAVirtualNetworkRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
