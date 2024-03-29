using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetPortAssignmentForUserDeviceInSdaFabricRequest
/// </summary>
[DataContract]
public class GetPortAssignmentForUserDeviceInSdaFabricRequest : List<DeletePortAssignmentForAccessPointInSdaFabricRequestInner>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetPortAssignmentForUserDeviceInSdaFabricRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public GetPortAssignmentForUserDeviceInSdaFabricRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetPortAssignmentForUserDeviceInSdaFabricRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
