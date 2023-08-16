using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// NFVProvisioningDetailRequest
	/// </summary>
	[DataContract]
	public class NfvProvisioningDetailRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NfvProvisioningDetailRequest" /> class.
		/// </summary>
		/// <param name="DeviceIp">DeviceIp.</param>

		public NfvProvisioningDetailRequest() : this(default) { }

		public NfvProvisioningDetailRequest(string? DeviceIp)
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
