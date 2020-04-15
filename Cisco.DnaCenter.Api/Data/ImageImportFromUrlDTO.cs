using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ImageImportFromUrlDto
	/// </summary>
	[DataContract]
	public partial class ImageImportFromUrlDto : List<ImageImportFromUrlDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageImportFromUrlDto" /> class.
		/// </summary>
		[JsonConstructor]
		public ImageImportFromUrlDto()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImageImportFromUrlDto {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
