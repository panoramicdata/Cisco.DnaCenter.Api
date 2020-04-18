using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSdaFabricRequest
	/// </summary>
	[DataContract]
	public class GetDefaultAuthenticationProfileFromSdaFabricRequest : List<GetDefaultAuthenticationProfileFromSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetDefaultAuthenticationProfileFromSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
