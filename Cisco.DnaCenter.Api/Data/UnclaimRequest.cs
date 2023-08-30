namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UnclaimRequest
	/// </summary>
	[DataContract]
	public class UnclaimRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnclaimRequest" /> class.
		/// </summary>
		/// <param name="DeviceIdList">DeviceIdList.</param>
		public UnclaimRequest() : this(default) { }

		public UnclaimRequest(List<string> DeviceIdList)
		{
			this.DeviceIdList = DeviceIdList;
		}

		/// <summary>
		/// Gets or Sets DeviceIdList
		/// </summary>
		[DataMember(Name = "deviceIdList", EmitDefaultValue = false)]
		public List<string> DeviceIdList { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UnclaimRequest {\n");
			sb.Append("  DeviceIdList: ").Append(DeviceIdList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
