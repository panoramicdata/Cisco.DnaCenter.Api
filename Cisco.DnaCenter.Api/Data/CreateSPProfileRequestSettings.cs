namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSPProfileRequestSettings
	/// </summary>
	[DataContract]
	public class CreateSpProfileRequestSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSpProfileRequestSettings" /> class.
		/// </summary>
		public CreateSpProfileRequestSettings() : this(default) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSpProfileRequestSettings" /> class.
		/// </summary>
		/// <param name="Qos">Qos.</param>
		public CreateSpProfileRequestSettings(List<CreateSpProfileRequestSettingsQos> Qos)
		{
			this.Qos = Qos;
		}

		/// <summary>
		/// Gets or Sets Qos
		/// </summary>
		[DataMember(Name = "qos", EmitDefaultValue = false)]
		public List<CreateSpProfileRequestSettingsQos> Qos { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSPProfileRequestSettings {\n");
			sb.Append("  Qos: ").Append(Qos).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
