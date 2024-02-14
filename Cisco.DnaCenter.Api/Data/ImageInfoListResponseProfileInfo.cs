using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ImageInfoListResponseProfileInfo
/// </summary>
[DataContract]
public class ImageInfoListResponseProfileInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ImageInfoListResponseProfileInfo" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="ExtendedAttributes">ExtendedAttributes.</param>
	/// <param name="Memory">Memory.</param>
	/// <param name="ProductType">ProductType.</param>
	/// <param name="ProfileName">ProfileName.</param>
	/// <param name="Shares">Shares.</param>
	/// <param name="VCpu">VCpu.</param>
	public ImageInfoListResponseProfileInfo(string? Description = default, Object ExtendedAttributes = default, int? Memory = default, string? ProductType = default, string? ProfileName = default, int? Shares = default, int? VCpu = default)
	{
		this.Description = Description;
		this.ExtendedAttributes = ExtendedAttributes;
		this.Memory = Memory;
		this.ProductType = ProductType;
		this.ProfileName = ProfileName;
		this.Shares = Shares;
		this.VCpu = VCpu;
	}

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// Gets or Sets ExtendedAttributes
	/// </summary>
	[DataMember(Name = "extendedAttributes", EmitDefaultValue = false)]
	public Object ExtendedAttributes { get; set; }

	/// <summary>
	/// Gets or Sets Memory
	/// </summary>
	[DataMember(Name = "memory", EmitDefaultValue = false)]
	public int? Memory { get; set; }

	/// <summary>
	/// Gets or Sets ProductType
	/// </summary>
	[DataMember(Name = "productType", EmitDefaultValue = false)]
	public string? ProductType { get; set; }

	/// <summary>
	/// Gets or Sets ProfileName
	/// </summary>
	[DataMember(Name = "profileName", EmitDefaultValue = false)]
	public string? ProfileName { get; set; }

	/// <summary>
	/// Gets or Sets Shares
	/// </summary>
	[DataMember(Name = "shares", EmitDefaultValue = false)]
	public int? Shares { get; set; }

	/// <summary>
	/// Gets or Sets VCpu
	/// </summary>
	[DataMember(Name = "vCpu", EmitDefaultValue = false)]
	public int? VCpu { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ImageInfoListResponseProfileInfo {\n");
		sb.Append("  Description: ").Append(Description).Append("\n");
		sb.Append("  ExtendedAttributes: ").Append(ExtendedAttributes).Append("\n");
		sb.Append("  Memory: ").Append(Memory).Append("\n");
		sb.Append("  ProductType: ").Append(ProductType).Append("\n");
		sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
		sb.Append("  Shares: ").Append(Shares).Append("\n");
		sb.Append("  VCpu: ").Append(VCpu).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
