using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo
/// </summary>
[DataContract]
public class PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo" /> class.
	/// </summary>
	/// <param name="Dscp">Dscp.</param>
	/// <param name="Vnid">Vnid.</param>
	public PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo(string? Dscp = default, string? Vnid = default)
	{
		this.Dscp = Dscp;
		this.Vnid = Vnid;
	}

	/// <summary>
	/// Gets or Sets Dscp
	/// </summary>
	[DataMember(Name = "dscp", EmitDefaultValue = false)]
	public string? Dscp { get; set; }

	/// <summary>
	/// Gets or Sets Vnid
	/// </summary>
	[DataMember(Name = "vnid", EmitDefaultValue = false)]
	public string? Vnid { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class PathResponseResultResponseEgressPhysicalInterfaceVxlanInfo {\n");
		sb.Append("  Dscp: ").Append(Dscp).Append("\n");
		sb.Append("  Vnid: ").Append(Vnid).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
