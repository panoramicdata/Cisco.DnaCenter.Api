using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateDeviceCredentialsRequestSettingsSnmpV2cRead
	/// </summary>
	[DataContract]
	public partial class UpdateDeviceCredentialsRequestSettingsSnmpV2cRead
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateDeviceCredentialsRequestSettingsSnmpV2cRead" /> class.
		/// </summary>
		/// <param name="Description">Description.</param>
		/// <param name="ReadCommunity">ReadCommunity.</param>
		/// <param name="Id">Id.</param>
		public UpdateDeviceCredentialsRequestSettingsSnmpV2cRead(string? Description = default, string? ReadCommunity = default, string? Id = default)
		{
			this.Description = Description;
			this.ReadCommunity = ReadCommunity;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets ReadCommunity
		/// </summary>
		[DataMember(Name = "readCommunity", EmitDefaultValue = false)]
		public string? ReadCommunity { get; set; }
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
			sb.Append("class UpdateDeviceCredentialsRequestSettingsSnmpV2cRead {\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  ReadCommunity: ").Append(ReadCommunity).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
