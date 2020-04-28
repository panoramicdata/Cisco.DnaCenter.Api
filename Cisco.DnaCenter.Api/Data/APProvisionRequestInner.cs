using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// APProvisionRequestInner
	/// </summary>
	[DataContract]
	public class ApProvisionRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApProvisionRequestInner" /> class.
		/// </summary>
		/// <param name="RfProfile">RfProfile.</param>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="Type">Type.</param>
		/// <param name="DeviceName">DeviceName.</param>
		/// <param name="CustomFlexGroupName">CustomFlexGroupName.</param>
		/// <param name="CustomApGroupName">CustomApGroupName.</param>
		public ApProvisionRequestInner(string? RfProfile = default, string? SiteId = default, string? Type = default, string? DeviceName = default, List<string> CustomFlexGroupName = default, string? CustomApGroupName = default)
		{
			this.RfProfile = RfProfile;
			this.SiteId = SiteId;
			this.Type = Type;
			this.DeviceName = DeviceName;
			this.CustomFlexGroupName = CustomFlexGroupName;
			this.CustomApGroupName = CustomApGroupName;
		}

		/// <summary>
		/// Gets or Sets RfProfile
		/// </summary>
		[DataMember(Name = "RfProfile", EmitDefaultValue = false)]
		public string? RfProfile { get; set; }

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Gets or Sets DeviceName
		/// </summary>
		[DataMember(Name = "deviceName", EmitDefaultValue = false)]
		public string? DeviceName { get; set; }

		/// <summary>
		/// Gets or Sets CustomFlexGroupName
		/// </summary>
		[DataMember(Name = "customFlexGroupName", EmitDefaultValue = false)]
		public List<string> CustomFlexGroupName { get; set; }

		/// <summary>
		/// Gets or Sets CustomApGroupName
		/// </summary>
		[DataMember(Name = "customApGroupName", EmitDefaultValue = false)]
		public string? CustomApGroupName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class APProvisionRequestInner {\n");
			sb.Append("  RfProfile: ").Append(RfProfile).Append("\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  CustomFlexGroupName: ").Append(CustomFlexGroupName).Append("\n");
			sb.Append("  CustomApGroupName: ").Append(CustomApGroupName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
