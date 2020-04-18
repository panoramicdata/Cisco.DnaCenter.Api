using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetWirelessProfileResponseInnerProfileDetailsFlexConnect
	/// </summary>
	[DataContract]
	public class GetWirelessProfileResponseInnerProfileDetailsFlexConnect
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetWirelessProfileResponseInnerProfileDetailsFlexConnect" /> class.
		/// </summary>
		/// <param name="EnableFlexConnect">EnableFlexConnect.</param>
		/// <param name="LocalToVlan">LocalToVlan.</param>
		public GetWirelessProfileResponseInnerProfileDetailsFlexConnect(bool? EnableFlexConnect = default, int? LocalToVlan = default)
		{
			this.EnableFlexConnect = EnableFlexConnect;
			this.LocalToVlan = LocalToVlan;
		}

		/// <summary>
		/// Gets or Sets EnableFlexConnect
		/// </summary>
		[DataMember(Name = "enableFlexConnect", EmitDefaultValue = false)]
		public bool? EnableFlexConnect { get; set; }
		/// <summary>
		/// Gets or Sets LocalToVlan
		/// </summary>
		[DataMember(Name = "localToVlan", EmitDefaultValue = false)]
		public int? LocalToVlan { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetWirelessProfileResponseInnerProfileDetailsFlexConnect {\n");
			sb.Append("  EnableFlexConnect: ").Append(EnableFlexConnect).Append("\n");
			sb.Append("  LocalToVlan: ").Append(LocalToVlan).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
