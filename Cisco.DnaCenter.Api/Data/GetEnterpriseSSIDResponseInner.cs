using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetEnterpriseSSIDResponseInner
	/// </summary>
	[DataContract]
	public class GetEnterpriseSsidResponseInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetEnterpriseSsidResponseInner" /> class.
		/// </summary>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="_Version">_Version.</param>
		/// <param name="SsidDetails">SsidDetails.</param>
		/// <param name="GroupUuid">GroupUuid.</param>
		/// <param name="InheritedGroupUuid">InheritedGroupUuid.</param>
		/// <param name="InheritedGroupName">InheritedGroupName.</param>
		public GetEnterpriseSsidResponseInner(string? InstanceUuid = default, int? _Version = default, List<GetEnterpriseSsidResponseInnerSsidDetails> SsidDetails = default, string? GroupUuid = default, string? InheritedGroupUuid = default, string? InheritedGroupName = default)
		{
			this.InstanceUuid = InstanceUuid;
			this._Version = _Version;
			this.SsidDetails = SsidDetails;
			this.GroupUuid = GroupUuid;
			this.InheritedGroupUuid = InheritedGroupUuid;
			this.InheritedGroupName = InheritedGroupName;
		}

		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? _Version { get; set; }

		/// <summary>
		/// Gets or Sets SsidDetails
		/// </summary>
		[DataMember(Name = "ssidDetails", EmitDefaultValue = false)]
		public List<GetEnterpriseSsidResponseInnerSsidDetails> SsidDetails { get; set; }

		/// <summary>
		/// Gets or Sets GroupUuid
		/// </summary>
		[DataMember(Name = "groupUuid", EmitDefaultValue = false)]
		public string? GroupUuid { get; set; }

		/// <summary>
		/// Gets or Sets InheritedGroupUuid
		/// </summary>
		[DataMember(Name = "inheritedGroupUuid", EmitDefaultValue = false)]
		public string? InheritedGroupUuid { get; set; }

		/// <summary>
		/// Gets or Sets InheritedGroupName
		/// </summary>
		[DataMember(Name = "inheritedGroupName", EmitDefaultValue = false)]
		public string? InheritedGroupName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetEnterpriseSSIDResponseInner {\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  SsidDetails: ").Append(SsidDetails).Append("\n");
			sb.Append("  GroupUuid: ").Append(GroupUuid).Append("\n");
			sb.Append("  InheritedGroupUuid: ").Append(InheritedGroupUuid).Append("\n");
			sb.Append("  InheritedGroupName: ").Append(InheritedGroupName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
