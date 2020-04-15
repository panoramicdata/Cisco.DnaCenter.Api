using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateOrUpdateRFProfileRequestRadioTypeAProperties
	/// </summary>
	[DataContract]
	public partial class CreateOrUpdateRFProfileRequestRadioTypeAProperties
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateOrUpdateRFProfileRequestRadioTypeAProperties" /> class.
		/// </summary>
		/// <param name="ParentProfile">ParentProfile.</param>
		/// <param name="RadioChannels">RadioChannels.</param>
		/// <param name="DataRates">DataRates.</param>
		/// <param name="MandatoryDataRates">MandatoryDataRates.</param>
		/// <param name="PowerThresholdV1">PowerThresholdV1.</param>
		/// <param name="RxSopThreshold">RxSopThreshold.</param>
		/// <param name="MinPowerLevel">MinPowerLevel.</param>
		/// <param name="MaxPowerLevel">MaxPowerLevel.</param>
		public CreateOrUpdateRFProfileRequestRadioTypeAProperties(string? ParentProfile = default, string? RadioChannels = default, string? DataRates = default, string? MandatoryDataRates = default, decimal? PowerThresholdV1 = default, string? RxSopThreshold = default, decimal? MinPowerLevel = default, decimal? MaxPowerLevel = default)
		{
			this.ParentProfile = ParentProfile;
			this.RadioChannels = RadioChannels;
			this.DataRates = DataRates;
			this.MandatoryDataRates = MandatoryDataRates;
			this.PowerThresholdV1 = PowerThresholdV1;
			this.RxSopThreshold = RxSopThreshold;
			this.MinPowerLevel = MinPowerLevel;
			this.MaxPowerLevel = MaxPowerLevel;
		}

		/// <summary>
		/// Gets or Sets ParentProfile
		/// </summary>
		[DataMember(Name = "parentProfile", EmitDefaultValue = false)]
		public string? ParentProfile { get; set; }
		/// <summary>
		/// Gets or Sets RadioChannels
		/// </summary>
		[DataMember(Name = "radioChannels", EmitDefaultValue = false)]
		public string? RadioChannels { get; set; }
		/// <summary>
		/// Gets or Sets DataRates
		/// </summary>
		[DataMember(Name = "dataRates", EmitDefaultValue = false)]
		public string? DataRates { get; set; }
		/// <summary>
		/// Gets or Sets MandatoryDataRates
		/// </summary>
		[DataMember(Name = "mandatoryDataRates", EmitDefaultValue = false)]
		public string? MandatoryDataRates { get; set; }
		/// <summary>
		/// Gets or Sets PowerThresholdV1
		/// </summary>
		[DataMember(Name = "powerThresholdV1", EmitDefaultValue = false)]
		public decimal? PowerThresholdV1 { get; set; }
		/// <summary>
		/// Gets or Sets RxSopThreshold
		/// </summary>
		[DataMember(Name = "rxSopThreshold", EmitDefaultValue = false)]
		public string? RxSopThreshold { get; set; }
		/// <summary>
		/// Gets or Sets MinPowerLevel
		/// </summary>
		[DataMember(Name = "minPowerLevel", EmitDefaultValue = false)]
		public decimal? MinPowerLevel { get; set; }
		/// <summary>
		/// Gets or Sets MaxPowerLevel
		/// </summary>
		[DataMember(Name = "maxPowerLevel", EmitDefaultValue = false)]
		public decimal? MaxPowerLevel { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateOrUpdateRFProfileRequestRadioTypeAProperties {\n");
			sb.Append("  ParentProfile: ").Append(ParentProfile).Append("\n");
			sb.Append("  RadioChannels: ").Append(RadioChannels).Append("\n");
			sb.Append("  DataRates: ").Append(DataRates).Append("\n");
			sb.Append("  MandatoryDataRates: ").Append(MandatoryDataRates).Append("\n");
			sb.Append("  PowerThresholdV1: ").Append(PowerThresholdV1).Append("\n");
			sb.Append("  RxSopThreshold: ").Append(RxSopThreshold).Append("\n");
			sb.Append("  MinPowerLevel: ").Append(MinPowerLevel).Append("\n");
			sb.Append("  MaxPowerLevel: ").Append(MaxPowerLevel).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
