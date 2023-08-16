using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateGlobalPoolRequestSettings
	/// </summary>
	[DataContract]
	public class UpdateGlobalPoolRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateGlobalPoolRequestSettings" /> class.
		/// </summary>
		/// <param name="Ippool">Ippool.</param>

		public UpdateGlobalPoolRequestSettings() : this(default) { }

		public UpdateGlobalPoolRequestSettings(List<UpdateGlobalPoolRequestSettingsIppool> Ippool)
		{
			this.Ippool = Ippool;
		}

		/// <summary>
		/// Gets or Sets Ippool
		/// </summary>
		[DataMember(Name = "ippool", EmitDefaultValue = false)]
		public List<UpdateGlobalPoolRequestSettingsIppool> Ippool { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateGlobalPoolRequestSettings {\n");
			sb.Append("  Ippool: ").Append(Ippool).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
