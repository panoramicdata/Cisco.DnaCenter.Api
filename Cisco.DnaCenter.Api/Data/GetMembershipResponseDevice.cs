using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetMembershipResponseDevice
	/// </summary>
	[DataContract]
	public partial class GetMembershipResponseDevice
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetMembershipResponseDevice" /> class.
		/// </summary>
		/// <param name="Response">Response.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="SiteId">SiteId.</param>
		public GetMembershipResponseDevice(List<Object> Response = default, string? _Version = default, string? SiteId = default)
		{
			this.Response = Response;
			this._Version = _Version;
			this.SiteId = SiteId;
		}

		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<Object> Response { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetMembershipResponseDevice {\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
