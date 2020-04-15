using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddDefaultAuthenticationProfileInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class AddDefaultAuthenticationProfileInSdaFabricRequest : List<UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddDefaultAuthenticationProfileInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public AddDefaultAuthenticationProfileInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddDefaultAuthenticationProfileInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
