namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateNetworkRequest
	/// </summary>
	[DataContract]
	public class UpdateNetworkRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequest" /> class.
		/// </summary>
		public UpdateNetworkRequest() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateNetworkRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public UpdateNetworkRequest(UpdateNetworkRequestSettings? Settings)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public UpdateNetworkRequestSettings Settings { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateNetworkRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
