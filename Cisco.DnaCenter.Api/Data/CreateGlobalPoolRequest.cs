namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateGlobalPoolRequest
	/// </summary>
	[DataContract]
	public class CreateGlobalPoolRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateGlobalPoolRequest" /> class.
		/// </summary>
		/// <param name="Settings">Settings.</param>
		public CreateGlobalPoolRequest() : this(default) { }

		public CreateGlobalPoolRequest(CreateGlobalPoolRequestSettings Settings)
		{
			this.Settings = Settings;
		}

		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public CreateGlobalPoolRequestSettings Settings { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateGlobalPoolRequest {\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
