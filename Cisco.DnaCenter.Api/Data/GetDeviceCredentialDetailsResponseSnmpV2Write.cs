using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceCredentialDetailsResponseSnmpV2Write
	/// </summary>
	[DataContract]
	public class GetDeviceCredentialDetailsResponseSnmpV2Write
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceCredentialDetailsResponseSnmpV2Write" /> class.
		/// </summary>
		/// <param name="WriteCommunity">WriteCommunity.</param>
		/// <param name="Comments">Comments.</param>
		/// <param name="Description">Description.</param>
		/// <param name="CredentialType">CredentialType.</param>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="Id">Id.</param>
		public GetDeviceCredentialDetailsResponseSnmpV2Write(string? WriteCommunity = default, string? Comments = default, string? Description = default, string? CredentialType = default, string? InstanceUuid = default, string? InstanceTenantId = default, string? Id = default)
		{
			this.WriteCommunity = WriteCommunity;
			this.Comments = Comments;
			this.Description = Description;
			this.CredentialType = CredentialType;
			this.InstanceUuid = InstanceUuid;
			this.InstanceTenantId = InstanceTenantId;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets WriteCommunity
		/// </summary>
		[DataMember(Name = "writeCommunity", EmitDefaultValue = false)]
		public string? WriteCommunity { get; set; }
		/// <summary>
		/// Gets or Sets Comments
		/// </summary>
		[DataMember(Name = "comments", EmitDefaultValue = false)]
		public string? Comments { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets CredentialType
		/// </summary>
		[DataMember(Name = "credentialType", EmitDefaultValue = false)]
		public string? CredentialType { get; set; }
		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceCredentialDetailsResponseSnmpV2Write {\n");
			sb.Append("  WriteCommunity: ").Append(WriteCommunity).Append("\n");
			sb.Append("  Comments: ").Append(Comments).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
