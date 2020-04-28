using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoHttpHeaders
	/// </summary>
	[DataContract]
	public class DeviceDeviceInfoHttpHeaders
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoHttpHeaders" /> class.
		/// </summary>
		/// <param name="Key">Key.</param>
		/// <param name="Value">Value.</param>
		public DeviceDeviceInfoHttpHeaders(string? Key = default, string? Value = default)
		{
			this.Key = Key;
			this.Value = Value;
		}

		/// <summary>
		/// Gets or Sets Key
		/// </summary>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string? Key { get; set; }

		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string? Value { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoHttpHeaders {\n");
			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
