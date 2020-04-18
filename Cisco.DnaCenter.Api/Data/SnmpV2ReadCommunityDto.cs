using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SNMPvReadCommunityDto
	/// </summary>
	[DataContract]
	public class SnmpV2ReadCommunityDto
	{
		/// <summary>
		/// Gets or Sets CredentialType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CredentialTypeEnum
		{

			/// <summary>
			/// Enum GLOBAL for "GLOBAL"
			/// </summary>
			[EnumMember(Value = "GLOBAL")]
			GLOBAL,

			/// <summary>
			/// Enum APP for "APP"
			/// </summary>
			[EnumMember(Value = "APP")]
			APP
		}

		/// <summary>
		/// Gets or Sets CredentialType
		/// </summary>
		[DataMember(Name = "credentialType", EmitDefaultValue = false)]
		public CredentialTypeEnum? CredentialType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SnmpV2ReadCommunityDto" /> class.
		/// </summary>
		/// <param name="Comments">Comments.</param>
		/// <param name="CredentialType">CredentialType.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InstanceTenantId">InstanceTenantId.</param>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		/// <param name="ReadCommunity">ReadCommunity.</param>
		public SnmpV2ReadCommunityDto(string? Comments = default, CredentialTypeEnum? CredentialType = default, string? Description = default, string? Id = default, string? InstanceTenantId = default, string? InstanceUuid = default, string? ReadCommunity = default)
		{
			this.Comments = Comments;
			this.CredentialType = CredentialType;
			this.Description = Description;
			this.Id = Id;
			this.InstanceTenantId = InstanceTenantId;
			this.InstanceUuid = InstanceUuid;
			this.ReadCommunity = ReadCommunity;
		}

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
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets InstanceTenantId
		/// </summary>
		[DataMember(Name = "instanceTenantId", EmitDefaultValue = false)]
		public string? InstanceTenantId { get; set; }
		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }
		/// <summary>
		/// Gets or Sets ReadCommunity
		/// </summary>
		[DataMember(Name = "readCommunity", EmitDefaultValue = false)]
		public string? ReadCommunity { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SNMPvReadCommunityDto {\n");
			sb.Append("  Comments: ").Append(Comments).Append("\n");
			sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("  ReadCommunity: ").Append(ReadCommunity).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
