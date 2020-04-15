using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TagListResult
	/// </summary>
	[DataContract]
	public partial class TagListResult
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TagListResult" /> class.
		/// </summary>
		/// <param name="_Version">_Version.</param>
		/// <param name="Response">Response.</param>
		public TagListResult(string? _Version = default, List<TagResultResponse> Response = default)
		{
			this._Version = _Version;
			this.Response = Response;
		}

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<TagResultResponse> Response { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TagListResult {\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
