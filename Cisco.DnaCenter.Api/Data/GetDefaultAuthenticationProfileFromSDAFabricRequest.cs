using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDefaultAuthenticationProfileFromSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class GetDefaultAuthenticationProfileFromSDAFabricRequest : List<GetDefaultAuthenticationProfileFromSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDefaultAuthenticationProfileFromSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public GetDefaultAuthenticationProfileFromSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDefaultAuthenticationProfileFromSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
