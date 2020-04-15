using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWorkflowsResponse
	/// </summary>
	[DataContract]
	public partial class GetWorkflowsResponse : List<DeviceSystemResetWorkflow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWorkflowsResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public GetWorkflowsResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWorkflowsResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
