namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// UpdateSPProfileRequestSettings
/// </summary>
[DataContract]
public class UpdateSpProfileRequestSettings
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UpdateSpProfileRequestSettings" /> class.
	/// </summary>
	public UpdateSpProfileRequestSettings() : this(default) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="UpdateSpProfileRequestSettings" /> class.
	/// </summary>
	/// <param name="Qos">Qos.</param>
	public UpdateSpProfileRequestSettings(List<UpdateSpProfileRequestSettingsQos> Qos)
	{
		this.Qos = Qos;
	}

	/// <summary>
	/// Gets or Sets Qos
	/// </summary>
	[DataMember(Name = "qos", EmitDefaultValue = false)]
	public List<UpdateSpProfileRequestSettingsQos> Qos { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UpdateSPProfileRequestSettings {\n");
		sb.Append("  Qos: ").Append(Qos).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
