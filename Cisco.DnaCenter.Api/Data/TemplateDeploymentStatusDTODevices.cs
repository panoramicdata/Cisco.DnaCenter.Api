using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDeploymentStatusDtoDevices
	/// </summary>
	[DataContract]
	public class TemplateDeploymentStatusDtoDevices
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDeploymentStatusDtoDevices" /> class.
		/// </summary>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="Duration">Duration.</param>
		/// <param name="EndTime">EndTime.</param>
		/// <param name="IpAddress">IpAddress.</param>
		/// <param name="Name">Name.</param>
		/// <param name="StartTime">StartTime.</param>
		/// <param name="Status">Status.</param>
		public TemplateDeploymentStatusDtoDevices(string? DeviceId = default, string? Duration = default, string? EndTime = default, string? IpAddress = default, string? Name = default, string? StartTime = default, string? Status = default)
		{
			this.DeviceId = DeviceId;
			this.Duration = Duration;
			this.EndTime = EndTime;
			this.IpAddress = IpAddress;
			this.Name = Name;
			this.StartTime = StartTime;
			this.Status = Status;
		}

		/// <summary>
		/// Gets or Sets DeviceId
		/// </summary>
		[DataMember(Name = "deviceId", EmitDefaultValue = false)]
		public string? DeviceId { get; set; }
		/// <summary>
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public string? Duration { get; set; }
		/// <summary>
		/// Gets or Sets EndTime
		/// </summary>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public string? EndTime { get; set; }
		/// <summary>
		/// Gets or Sets IpAddress
		/// </summary>
		[DataMember(Name = "ipAddress", EmitDefaultValue = false)]
		public string? IpAddress { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets StartTime
		/// </summary>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public string? StartTime { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDeploymentStatusDtoDevices {\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
