using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DistributeDtoInner
	/// </summary>
	[DataContract]
	public class DistributeDtoInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DistributeDtoInner" /> class.
		/// </summary>
		/// <param name="DeviceUuid">DeviceUuid.</param>
		/// <param name="ImageUuid">ImageUuid.</param>
		public DistributeDtoInner(string? DeviceUuid = default, string? ImageUuid = default)
		{
			this.DeviceUuid = DeviceUuid;
			this.ImageUuid = ImageUuid;
		}

		/// <summary>
		/// Gets or Sets DeviceUuid
		/// </summary>
		[DataMember(Name = "deviceUuid", EmitDefaultValue = false)]
		public string? DeviceUuid { get; set; }

		/// <summary>
		/// Gets or Sets ImageUuid
		/// </summary>
		[DataMember(Name = "imageUuid", EmitDefaultValue = false)]
		public string? ImageUuid { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DistributeDtoInner {\n");
			sb.Append("  DeviceUuid: ").Append(DeviceUuid).Append("\n");
			sb.Append("  ImageUuid: ").Append(ImageUuid).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
