using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddEdgeDeviceInSdaFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddEdgeDeviceInSdaFabricRequest : List<GetSdaFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddEdgeDeviceInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddEdgeDeviceInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddEdgeDeviceInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
