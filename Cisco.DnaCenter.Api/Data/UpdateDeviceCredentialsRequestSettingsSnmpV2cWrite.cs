using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite
	/// </summary>
	[DataContract]
	public class UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite" /> class.
		/// </summary>
		/// <param name="Description">Description.</param>
		/// <param name="WriteCommunity">WriteCommunity.</param>
		/// <param name="Id">Id.</param>
		public UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite(string? Description = default, string? WriteCommunity = default, string? Id = default)
		{
			this.Description = Description;
			this.WriteCommunity = WriteCommunity;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets WriteCommunity
		/// </summary>
		[DataMember(Name = "writeCommunity", EmitDefaultValue = false)]
		public string? WriteCommunity { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateDeviceCredentialsRequestSettingsSnmpV2cWrite {\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  WriteCommunity: ").Append(WriteCommunity).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
