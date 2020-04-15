using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddControlPlaneDeviceInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddControlPlaneDeviceInSdaFabricRequest : List<GetSDAFabricInfoRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddControlPlaneDeviceInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddControlPlaneDeviceInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddControlPlaneDeviceInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
