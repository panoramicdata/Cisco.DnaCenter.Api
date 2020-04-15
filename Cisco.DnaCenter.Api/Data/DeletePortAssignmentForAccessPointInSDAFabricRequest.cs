using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeletePortAssignmentForAccessPointInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class DeletePortAssignmentForAccessPointInSDAFabricRequest : List<DeletePortAssignmentForAccessPointInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeletePortAssignmentForAccessPointInSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeletePortAssignmentForAccessPointInSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeletePortAssignmentForAccessPointInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
