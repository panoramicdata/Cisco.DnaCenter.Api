namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AssignDeviceToSiteRequest
	/// </summary>
	[DataContract]
	public class AssignDeviceToSiteRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssignDeviceToSiteRequest" /> class.
		/// </summary>
		/// <param name="Device">Device.</param>
		public AssignDeviceToSiteRequest() : this(default) { }

		public AssignDeviceToSiteRequest(List<AssignDeviceToSiteRequestDevice> Device)
		{
			this.Device = Device;
		}

		/// <summary>
		/// Gets or Sets Device
		/// </summary>
		[DataMember(Name = "device", EmitDefaultValue = false)]
		public List<AssignDeviceToSiteRequestDevice> Device { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssignDeviceToSiteRequest {\n");
			sb.Append("  Device: ").Append(Device).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
