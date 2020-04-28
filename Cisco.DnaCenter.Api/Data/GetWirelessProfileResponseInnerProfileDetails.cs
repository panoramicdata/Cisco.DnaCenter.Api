using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWirelessProfileResponseInnerProfileDetails
	/// </summary>
	[DataContract]
	public class GetWirelessProfileResponseInnerProfileDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWirelessProfileResponseInnerProfileDetails" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Sites">Sites.</param>
		/// <param name="SsidDetails">SsidDetails.</param>
		public GetWirelessProfileResponseInnerProfileDetails(string? Name = default, List<string> Sites = default, List<GetWirelessProfileResponseInnerProfileDetailsSsidDetails> SsidDetails = default)
		{
			this.Name = Name;
			this.Sites = Sites;
			this.SsidDetails = SsidDetails;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets Sites
		/// </summary>
		[DataMember(Name = "sites", EmitDefaultValue = false)]
		public List<string> Sites { get; set; }

		/// <summary>
		/// Gets or Sets SsidDetails
		/// </summary>
		[DataMember(Name = "ssidDetails", EmitDefaultValue = false)]
		public List<GetWirelessProfileResponseInnerProfileDetailsSsidDetails> SsidDetails { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWirelessProfileResponseInnerProfileDetails {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Sites: ").Append(Sites).Append("\n");
			sb.Append("  SsidDetails: ").Append(SsidDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
