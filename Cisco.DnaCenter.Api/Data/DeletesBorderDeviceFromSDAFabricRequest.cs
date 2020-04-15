using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeletesBorderDeviceFromSDAFabricRequest
	/// </summary>
	[DataContract]
	public partial class DeletesBorderDeviceFromSDAFabricRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeletesBorderDeviceFromSDAFabricRequest" /> class.
		/// </summary>
		[JsonConstructor]
		public DeletesBorderDeviceFromSDAFabricRequest()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeletesBorderDeviceFromSDAFabricRequest {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
