using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// GetServiceProviderDetailsResponseResponse
/// </summary>
[DataContract]
public class GetServiceProviderDetailsResponseResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetServiceProviderDetailsResponseResponse" /> class.
	/// </summary>
	/// <param name="InstanceType">InstanceType.</param>
	/// <param name="InstanceUuid">InstanceUuid.</param>
	/// <param name="_Namespace">_Namespace.</param>
	/// <param name="Type">Type.</param>
	/// <param name="Key">Key.</param>
	/// <param name="_Version">_Version.</param>
	/// <param name="Value">Value.</param>
	/// <param name="GroupUuid">GroupUuid.</param>
	/// <param name="InheritedGroupUuid">InheritedGroupUuid.</param>
	/// <param name="InheritedGroupName">InheritedGroupName.</param>
	public GetServiceProviderDetailsResponseResponse(string? InstanceType = default, string? InstanceUuid = default, string? _Namespace = default, string? Type = default, string? Key = default, string? _Version = default, List<GetServiceProviderDetailsResponseValue> Value = default, string? GroupUuid = default, string? InheritedGroupUuid = default, string? InheritedGroupName = default)
	{
		this.InstanceType = InstanceType;
		this.InstanceUuid = InstanceUuid;
		this._Namespace = _Namespace;
		this.Type = Type;
		this.Key = Key;
		this._Version = _Version;
		this.Value = Value;
		this.GroupUuid = GroupUuid;
		this.InheritedGroupUuid = InheritedGroupUuid;
		this.InheritedGroupName = InheritedGroupName;
	}

	/// <summary>
	/// Gets or Sets InstanceType
	/// </summary>
	[DataMember(Name = "instanceType", EmitDefaultValue = false)]
	public string? InstanceType { get; set; }

	/// <summary>
	/// Gets or Sets InstanceUuid
	/// </summary>
	[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
	public string? InstanceUuid { get; set; }

	/// <summary>
	/// Gets or Sets _Namespace
	/// </summary>
	[DataMember(Name = "namespace", EmitDefaultValue = false)]
	public string? _Namespace { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string? Type { get; set; }

	/// <summary>
	/// Gets or Sets Key
	/// </summary>
	[DataMember(Name = "key", EmitDefaultValue = false)]
	public string? Key { get; set; }

	/// <summary>
	/// Gets or Sets _Version
	/// </summary>
	[DataMember(Name = "version", EmitDefaultValue = false)]
	public string? _Version { get; set; }

	/// <summary>
	/// Gets or Sets Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public List<GetServiceProviderDetailsResponseValue> Value { get; set; }

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
		sb.Append("class GetServiceProviderDetailsResponseResponse {\n");
		sb.Append("  InstanceType: ").Append(InstanceType).Append("\n");
		sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
		sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
		sb.Append("  Type: ").Append(Type).Append("\n");
		sb.Append("  Key: ").Append(Key).Append("\n");
		sb.Append("  _Version: ").Append(_Version).Append("\n");
		sb.Append("  Value: ").Append(Value).Append("\n");
		sb.Append("  GroupUuid: ").Append(GroupUuid).Append("\n");
		sb.Append("  InheritedGroupUuid: ").Append(InheritedGroupUuid).Append("\n");
		sb.Append("  InheritedGroupName: ").Append(InheritedGroupName).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
