using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AssignDeviceToSiteRequestDevice
	/// </summary>
	[DataContract]
	public class AssignDeviceToSiteRequestDevice
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssignDeviceToSiteRequestDevice" /> class.
		/// </summary>
		/// <param name="Ip">Ip.</param>
		public AssignDeviceToSiteRequestDevice(string? Ip = default)
		{
			this.Ip = Ip;
		}

		/// <summary>
		/// Gets or Sets Ip
		/// </summary>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string? Ip { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssignDeviceToSiteRequestDevice {\n");
			sb.Append("  Ip: ").Append(Ip).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
