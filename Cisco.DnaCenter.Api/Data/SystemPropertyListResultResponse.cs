using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SystemPropertyListResultResponse
/// </summary>
[DataContract]
public class SystemPropertyListResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SystemPropertyListResultResponse" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="InstanceTenantId">InstanceTenantId.</param>
	/// <param name="InstanceUuid">InstanceUuid.</param>
	/// <param name="IntValue">IntValue.</param>
	/// <param name="SystemPropertyName">SystemPropertyName.</param>
	public SystemPropertyListResultResponse(string? Id = default, string? InstanceTenantId = default, string? InstanceUuid = default, int? IntValue = default, string? SystemPropertyName = default)
	{
		this.Id = Id;
		this.InstanceTenantId = InstanceTenantId;
		this.InstanceUuid = InstanceUuid;
		this.IntValue = IntValue;
		this.SystemPropertyName = SystemPropertyName;
	}

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
	/// Gets or Sets IntValue
	/// </summary>
	[DataMember(Name = "intValue", EmitDefaultValue = false)]
	public int? IntValue { get; set; }

	/// <summary>
	/// Gets or Sets SystemPropertyName
	/// </summary>
	[DataMember(Name = "systemPropertyName", EmitDefaultValue = false)]
	public string? SystemPropertyName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SystemPropertyListResultResponse {\n");
		sb.Append("  Id: ").Append(Id).Append("\n");
		sb.Append("  InstanceTenantId: ").Append(InstanceTenantId).Append("\n");
		sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
		sb.Append("  IntValue: ").Append(IntValue).Append("\n");
		sb.Append("  SystemPropertyName: ").Append(SystemPropertyName).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
