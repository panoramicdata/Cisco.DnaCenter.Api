using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddPortAssignmentForAccessPointInSdaFabricRequest
	/// </summary>
	[DataContract]
	public class AddPortAssignmentForAccessPointInSdaFabricRequest : List<AddPortAssignmentForUserDeviceInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddPortAssignmentForAccessPointInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddPortAssignmentForAccessPointInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddPortAssignmentForAccessPointInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
