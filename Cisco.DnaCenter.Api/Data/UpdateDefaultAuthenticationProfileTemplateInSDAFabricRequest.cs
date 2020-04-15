using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest : List<UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequestInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDefaultAuthenticationProfileTemplateInSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
