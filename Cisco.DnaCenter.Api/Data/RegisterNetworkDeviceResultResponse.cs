using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// RegisterNetworkDeviceResultResponse
/// </summary>
[DataContract]
public class RegisterNetworkDeviceResultResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RegisterNetworkDeviceResultResponse" /> class.
	/// </summary>
	/// <param name="MacAddress">MacAddress.</param>
	/// <param name="ModelNumber">ModelNumber.</param>
	/// <param name="Name">Name.</param>
	/// <param name="SerialNumber">SerialNumber.</param>
	/// <param name="TenantId">TenantId.</param>
	public RegisterNetworkDeviceResultResponse(string? MacAddress = default, string? ModelNumber = default, string? Name = default, string? SerialNumber = default, string? TenantId = default)
	{
		this.MacAddress = MacAddress;
		this.ModelNumber = ModelNumber;
		this.Name = Name;
		this.SerialNumber = SerialNumber;
		this.TenantId = TenantId;
	}

	/// <summary>
	/// Gets or Sets MacAddress
	/// </summary>
	[DataMember(Name = "macAddress", EmitDefaultValue = false)]
	public string? MacAddress { get; set; }

	/// <summary>
	/// Gets or Sets ModelNumber
	/// </summary>
	[DataMember(Name = "modelNumber", EmitDefaultValue = false)]
	public string? ModelNumber { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets SerialNumber
	/// </summary>
	[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
	public string? SerialNumber { get; set; }

	/// <summary>
	/// Gets or Sets TenantId
	/// </summary>
	[DataMember(Name = "tenantId", EmitDefaultValue = false)]
	public string? TenantId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class RegisterNetworkDeviceResultResponse {\n");
		sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
		sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
		sb.Append("  Name: ").Append(Name).Append("\n");
		sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
		sb.Append("  TenantId: ").Append(TenantId).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
