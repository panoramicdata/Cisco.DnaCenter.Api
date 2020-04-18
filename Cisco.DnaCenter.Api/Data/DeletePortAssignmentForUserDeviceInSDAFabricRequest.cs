using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeletePortAssignmentForUserDeviceInSdaFabricRequest
	/// </summary>
	[DataContract]
	public class DeletePortAssignmentForUserDeviceInSdaFabricRequest : List<DeletePortAssignmentForAccessPointInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeletePortAssignmentForUserDeviceInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeletePortAssignmentForUserDeviceInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeletePortAssignmentForUserDeviceInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
