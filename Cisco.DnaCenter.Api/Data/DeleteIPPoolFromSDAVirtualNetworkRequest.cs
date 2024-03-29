using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeleteIPPoolFromSDAVirtualNetworkRequest
/// </summary>
[DataContract]
public class DeleteIpPoolFromSdaVirtualNetworkRequest : List<DeleteIpPoolFromSdaVirtualNetworkRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeleteIpPoolFromSdaVirtualNetworkRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public DeleteIpPoolFromSdaVirtualNetworkRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeleteIPPoolFromSDAVirtualNetworkRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
