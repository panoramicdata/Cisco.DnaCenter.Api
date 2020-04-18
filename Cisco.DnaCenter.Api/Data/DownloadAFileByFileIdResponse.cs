using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DownloadAFileByFileIdResponse
	/// </summary>
	[DataContract]
	public class DownloadFileByFileIdResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadFileByFileIdResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public DownloadFileByFileIdResponse()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DownloadAFileByFileIdResponse {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
