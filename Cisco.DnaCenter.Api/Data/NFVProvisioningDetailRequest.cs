using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// NFVProvisioningDetailRequest
	/// </summary>
	[DataContract]
	public partial class NFVProvisioningDetailRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NFVProvisioningDetailRequest" /> class.
		/// </summary>
		/// <param name="DeviceIp">DeviceIp.</param>
		public NFVProvisioningDetailRequest(string? DeviceIp = default)
		{
			this.DeviceIp = DeviceIp;
		}

		/// <summary>
		/// Gets or Sets DeviceIp
		/// </summary>
		[DataMember(Name = "device_ip", EmitDefaultValue = false)]
		public string? DeviceIp { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NFVProvisioningDetailRequest {\n");
			sb.Append("  DeviceIp: ").Append(DeviceIp).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
