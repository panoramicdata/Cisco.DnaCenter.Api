using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest
	/// </summary>
	[DataContract]
	public partial class UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest : List<UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDefaultAuthenticationProfileTemplateInSdaFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
