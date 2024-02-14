using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// PathResponseResultResponseEgressInterface
/// </summary>
[DataContract]
public class PathResponseResultResponseEgressInterface
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PathResponseResultResponseEgressInterface" /> class.
	/// </summary>
	/// <param name="PhysicalInterface">PhysicalInterface.</param>
	/// <param name="VirtualInterface">VirtualInterface.</param>
	public PathResponseResultResponseEgressInterface(PathResponseResultResponseEgressPhysicalInterface PhysicalInterface = default, List<PathResponseResultResponseEgressPhysicalInterface> VirtualInterface = default)
	{
		this.PhysicalInterface = PhysicalInterface;
		this.VirtualInterface = VirtualInterface;
	}

	/// <summary>
	/// Gets or Sets PhysicalInterface
	/// </summary>
	[DataMember(Name = "physicalInterface", EmitDefaultValue = false)]
	public PathResponseResultResponseEgressPhysicalInterface PhysicalInterface { get; set; }

	/// <summary>
	/// Gets or Sets VirtualInterface
	/// </summary>
	[DataMember(Name = "virtualInterface", EmitDefaultValue = false)]
	public List<PathResponseResultResponseEgressPhysicalInterface> VirtualInterface { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class PathResponseResultResponseEgressInterface {\n");
		sb.Append("  PhysicalInterface: ").Append(PhysicalInterface).Append("\n");
		sb.Append("  VirtualInterface: ").Append(VirtualInterface).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
