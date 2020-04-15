using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// NetworkDeviceBriefNIOResult
	/// </summary>
	[DataContract]
	public partial class NetworkDeviceBriefNIOResult
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NetworkDeviceBriefNIOResult" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		/// <param name="_Version">_Version.</param>
		public NetworkDeviceBriefNIOResult(NetworkDeviceBriefNIOResultResponse Response = default, string? _Version = default)
		{
			this.Response = Response;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public NetworkDeviceBriefNIOResultResponse Response { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkDeviceBriefNIOResult {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
