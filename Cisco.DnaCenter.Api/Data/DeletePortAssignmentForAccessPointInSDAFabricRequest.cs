using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeletePortAssignmentForAccessPointInSdaFabricRequest
	/// </summary>
	[DataContract]
	public class DeletePortAssignmentForAccessPointInSdaFabricRequest : List<DeletePortAssignmentForAccessPointInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeletePortAssignmentForAccessPointInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeletePortAssignmentForAccessPointInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeletePortAssignmentForAccessPointInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
