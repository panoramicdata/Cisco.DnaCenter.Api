using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddPortAssignmentForUserDeviceInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddPortAssignmentForUserDeviceInSdaFabricRequest : List<AddPortAssignmentForUserDeviceInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddPortAssignmentForUserDeviceInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddPortAssignmentForUserDeviceInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddPortAssignmentForUserDeviceInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
