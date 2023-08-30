namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateNetworkRequest
	/// </summary>
	[DataContract]
	public class CreateNetworkRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateNetworkRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public CreateNetworkRequest() : this(default) { }

		public CreateNetworkRequest(UpdateNetworkRequestSettings Settings)
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
			sb.Append("class CreateNetworkRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
