using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetPortAssignmentForAccessPointInSdaFabricRequest
	/// </summary>
	[DataContract]
	public partial class GetPortAssignmentForAccessPointInSdaFabricRequest : List<DeletePortAssignmentForAccessPointInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetPortAssignmentForAccessPointInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetPortAssignmentForAccessPointInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetPortAssignmentForAccessPointInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
