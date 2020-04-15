using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetPortAssignmentForUserDeviceInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class GetPortAssignmentForUserDeviceInSDAFabricRequest : List<DeletePortAssignmentForAccessPointInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetPortAssignmentForUserDeviceInSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetPortAssignmentForUserDeviceInSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetPortAssignmentForUserDeviceInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
