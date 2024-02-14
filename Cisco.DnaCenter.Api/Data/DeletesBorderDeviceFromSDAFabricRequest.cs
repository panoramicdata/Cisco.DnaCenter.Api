using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeletesBorderDeviceFromSdaFabricRequest
/// </summary>
[DataContract]
public class DeleteBorderDeviceFromSdaFabricRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeleteBorderDeviceFromSdaFabricRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public DeleteBorderDeviceFromSdaFabricRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeletesBorderDeviceFromSdaFabricRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
