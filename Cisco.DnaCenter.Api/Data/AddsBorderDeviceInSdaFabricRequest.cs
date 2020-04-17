using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddsBorderDeviceInSdaFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddsBorderDeviceInSdaFabricRequest : List<AddsBorderDeviceInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddsBorderDeviceInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddsBorderDeviceInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddsBorderDeviceInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
