using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DownloadAFileByFileIdResponse
	/// </summary>
	[DataContract]
	public partial class DownloadAFileByFileIdResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadAFileByFileIdResponse" /> class.
		/// </summary>
		[JsonConstructor]
		public DownloadAFileByFileIdResponse()
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
