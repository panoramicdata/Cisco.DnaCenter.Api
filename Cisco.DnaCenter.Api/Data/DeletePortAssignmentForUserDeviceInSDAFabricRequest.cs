using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeletePortAssignmentForUserDeviceInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class DeletePortAssignmentForUserDeviceInSDAFabricRequest : List<DeletePortAssignmentForAccessPointInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeletePortAssignmentForUserDeviceInSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeletePortAssignmentForUserDeviceInSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeletePortAssignmentForUserDeviceInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
