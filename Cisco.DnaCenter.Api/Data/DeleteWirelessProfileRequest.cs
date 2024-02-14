using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// DeleteWirelessProfileRequest
/// </summary>
[DataContract]
public class DeleteWirelessProfileRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="DeleteWirelessProfileRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public DeleteWirelessProfileRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DeleteWirelessProfileRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
