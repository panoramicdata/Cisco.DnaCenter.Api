using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateGlobalPoolRequestSettings
	/// </summary>
	[DataContract]
	public class CreateGlobalPoolRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateGlobalPoolRequestSettings" /> class.
		/// </summary>
		/// <param name="Ippool">Ippool.</param>
		public CreateGlobalPoolRequestSettings(List<CreateGlobalPoolRequestSettingsIppool> Ippool = default)
		{
			this.Ippool = Ippool;
		}

		/// <summary>
		/// Gets or Sets Ippool
		/// </summary>
		[DataMember(Name = "ippool", EmitDefaultValue = false)]
		public List<CreateGlobalPoolRequestSettingsIppool> Ippool { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateGlobalPoolRequestSettings {\n");
			sb.Append("  Ippool: ").Append(Ippool).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
