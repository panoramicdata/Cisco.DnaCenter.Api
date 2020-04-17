using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// RetrieveRfProfilesResponseResponse
	/// </summary>
	[DataContract]
	public partial class RetrieveRfProfilesResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RetrieveRfProfilesResponseResponse" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ParentProfileA">ParentProfileA.</param>
		/// <param name="ParentProfileB">ParentProfileB.</param>
		/// <param name="EnableARadioType">EnableARadioType.</param>
		/// <param name="EnableBRadioType">EnableBRadioType.</param>
		/// <param name="ChannelWidth">ChannelWidth.</param>
		/// <param name="ARadioChannels">ARadioChannels.</param>
		/// <param name="BRadioChannels">BRadioChannels.</param>
		/// <param name="DataRatesA">DataRatesA.</param>
		/// <param name="DataRatesB">DataRatesB.</param>
		/// <param name="MandatoryDataRatesA">MandatoryDataRatesA.</param>
		/// <param name="MandatoryDataRatesB">MandatoryDataRatesB.</param>
		/// <param name="EnableCustom">EnableCustom.</param>
		/// <param name="MinPowerLevelA">MinPowerLevelA.</param>
		/// <param name="MinPowerLevelB">MinPowerLevelB.</param>
		/// <param name="MaxPowerLevelA">MaxPowerLevelA.</param>
		/// <param name="MaxPowerLevelB">MaxPowerLevelB.</param>
		/// <param name="PowerThresholdV1A">PowerThresholdV1A.</param>
		/// <param name="PowerThresholdV1B">PowerThresholdV1B.</param>
		/// <param name="RxSopThresholdA">RxSopThresholdA.</param>
		/// <param name="RxSopThresholdB">RxSopThresholdB.</param>
		/// <param name="DefaultRfProfile">DefaultRfProfile.</param>
		/// <param name="EnableBrownField">EnableBrownField.</param>
		public RetrieveRfProfilesResponseResponse(string? Name = default, string? ParentProfileA = default, string? ParentProfileB = default, bool? EnableARadioType = default, bool? EnableBRadioType = default, string? ChannelWidth = default, string? ARadioChannels = default, string? BRadioChannels = default, string? DataRatesA = default, string? DataRatesB = default, string? MandatoryDataRatesA = default, string? MandatoryDataRatesB = default, bool? EnableCustom = default, string? MinPowerLevelA = default, string? MinPowerLevelB = default, string? MaxPowerLevelA = default, string? MaxPowerLevelB = default, int? PowerThresholdV1A = default, int? PowerThresholdV1B = default, string? RxSopThresholdA = default, string? RxSopThresholdB = default, bool? DefaultRfProfile = default, bool? EnableBrownField = default)
		{
			this.Name = Name;
			this.ParentProfileA = ParentProfileA;
			this.ParentProfileB = ParentProfileB;
			this.EnableARadioType = EnableARadioType;
			this.EnableBRadioType = EnableBRadioType;
			this.ChannelWidth = ChannelWidth;
			this.ARadioChannels = ARadioChannels;
			this.BRadioChannels = BRadioChannels;
			this.DataRatesA = DataRatesA;
			this.DataRatesB = DataRatesB;
			this.MandatoryDataRatesA = MandatoryDataRatesA;
			this.MandatoryDataRatesB = MandatoryDataRatesB;
			this.EnableCustom = EnableCustom;
			this.MinPowerLevelA = MinPowerLevelA;
			this.MinPowerLevelB = MinPowerLevelB;
			this.MaxPowerLevelA = MaxPowerLevelA;
			this.MaxPowerLevelB = MaxPowerLevelB;
			this.PowerThresholdV1A = PowerThresholdV1A;
			this.PowerThresholdV1B = PowerThresholdV1B;
			this.RxSopThresholdA = RxSopThresholdA;
			this.RxSopThresholdB = RxSopThresholdB;
			this.DefaultRfProfile = DefaultRfProfile;
			this.EnableBrownField = EnableBrownField;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets ParentProfileA
		/// </summary>
		[DataMember(Name = "parentProfileA", EmitDefaultValue = false)]
		public string? ParentProfileA { get; set; }
		/// <summary>
		/// Gets or Sets ParentProfileB
		/// </summary>
		[DataMember(Name = "parentProfileB", EmitDefaultValue = false)]
		public string? ParentProfileB { get; set; }
		/// <summary>
		/// Gets or Sets EnableARadioType
		/// </summary>
		[DataMember(Name = "enableARadioType", EmitDefaultValue = false)]
		public bool? EnableARadioType { get; set; }
		/// <summary>
		/// Gets or Sets EnableBRadioType
		/// </summary>
		[DataMember(Name = "enableBRadioType", EmitDefaultValue = false)]
		public bool? EnableBRadioType { get; set; }
		/// <summary>
		/// Gets or Sets ChannelWidth
		/// </summary>
		[DataMember(Name = "channelWidth", EmitDefaultValue = false)]
		public string? ChannelWidth { get; set; }
		/// <summary>
		/// Gets or Sets ARadioChannels
		/// </summary>
		[DataMember(Name = "aRadioChannels", EmitDefaultValue = false)]
		public string? ARadioChannels { get; set; }
		/// <summary>
		/// Gets or Sets BRadioChannels
		/// </summary>
		[DataMember(Name = "bRadioChannels", EmitDefaultValue = false)]
		public string? BRadioChannels { get; set; }
		/// <summary>
		/// Gets or Sets DataRatesA
		/// </summary>
		[DataMember(Name = "dataRatesA", EmitDefaultValue = false)]
		public string? DataRatesA { get; set; }
		/// <summary>
		/// Gets or Sets DataRatesB
		/// </summary>
		[DataMember(Name = "dataRatesB", EmitDefaultValue = false)]
		public string? DataRatesB { get; set; }
		/// <summary>
		/// Gets or Sets MandatoryDataRatesA
		/// </summary>
		[DataMember(Name = "mandatoryDataRatesA", EmitDefaultValue = false)]
		public string? MandatoryDataRatesA { get; set; }
		/// <summary>
		/// Gets or Sets MandatoryDataRatesB
		/// </summary>
		[DataMember(Name = "mandatoryDataRatesB", EmitDefaultValue = false)]
		public string? MandatoryDataRatesB { get; set; }
		/// <summary>
		/// Gets or Sets EnableCustom
		/// </summary>
		[DataMember(Name = "enableCustom", EmitDefaultValue = false)]
		public bool? EnableCustom { get; set; }
		/// <summary>
		/// Gets or Sets MinPowerLevelA
		/// </summary>
		[DataMember(Name = "minPowerLevelA", EmitDefaultValue = false)]
		public string? MinPowerLevelA { get; set; }
		/// <summary>
		/// Gets or Sets MinPowerLevelB
		/// </summary>
		[DataMember(Name = "minPowerLevelB", EmitDefaultValue = false)]
		public string? MinPowerLevelB { get; set; }
		/// <summary>
		/// Gets or Sets MaxPowerLevelA
		/// </summary>
		[DataMember(Name = "maxPowerLevelA", EmitDefaultValue = false)]
		public string? MaxPowerLevelA { get; set; }
		/// <summary>
		/// Gets or Sets MaxPowerLevelB
		/// </summary>
		[DataMember(Name = "maxPowerLevelB", EmitDefaultValue = false)]
		public string? MaxPowerLevelB { get; set; }
		/// <summary>
		/// Gets or Sets PowerThresholdV1A
		/// </summary>
		[DataMember(Name = "powerThresholdV1A", EmitDefaultValue = false)]
		public int? PowerThresholdV1A { get; set; }
		/// <summary>
		/// Gets or Sets PowerThresholdV1B
		/// </summary>
		[DataMember(Name = "powerThresholdV1B", EmitDefaultValue = false)]
		public int? PowerThresholdV1B { get; set; }
		/// <summary>
		/// Gets or Sets RxSopThresholdA
		/// </summary>
		[DataMember(Name = "rxSopThresholdA", EmitDefaultValue = false)]
		public string? RxSopThresholdA { get; set; }
		/// <summary>
		/// Gets or Sets RxSopThresholdB
		/// </summary>
		[DataMember(Name = "rxSopThresholdB", EmitDefaultValue = false)]
		public string? RxSopThresholdB { get; set; }
		/// <summary>
		/// Gets or Sets DefaultRfProfile
		/// </summary>
		[DataMember(Name = "defaultRfProfile", EmitDefaultValue = false)]
		public bool? DefaultRfProfile { get; set; }
		/// <summary>
		/// Gets or Sets EnableBrownField
		/// </summary>
		[DataMember(Name = "enableBrownField", EmitDefaultValue = false)]
		public bool? EnableBrownField { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RetrieveRfProfilesResponseResponse {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ParentProfileA: ").Append(ParentProfileA).Append("\n");
			sb.Append("  ParentProfileB: ").Append(ParentProfileB).Append("\n");
			sb.Append("  EnableARadioType: ").Append(EnableARadioType).Append("\n");
			sb.Append("  EnableBRadioType: ").Append(EnableBRadioType).Append("\n");
			sb.Append("  ChannelWidth: ").Append(ChannelWidth).Append("\n");
			sb.Append("  ARadioChannels: ").Append(ARadioChannels).Append("\n");
			sb.Append("  BRadioChannels: ").Append(BRadioChannels).Append("\n");
			sb.Append("  DataRatesA: ").Append(DataRatesA).Append("\n");
			sb.Append("  DataRatesB: ").Append(DataRatesB).Append("\n");
			sb.Append("  MandatoryDataRatesA: ").Append(MandatoryDataRatesA).Append("\n");
			sb.Append("  MandatoryDataRatesB: ").Append(MandatoryDataRatesB).Append("\n");
			sb.Append("  EnableCustom: ").Append(EnableCustom).Append("\n");
			sb.Append("  MinPowerLevelA: ").Append(MinPowerLevelA).Append("\n");
			sb.Append("  MinPowerLevelB: ").Append(MinPowerLevelB).Append("\n");
			sb.Append("  MaxPowerLevelA: ").Append(MaxPowerLevelA).Append("\n");
			sb.Append("  MaxPowerLevelB: ").Append(MaxPowerLevelB).Append("\n");
			sb.Append("  PowerThresholdV1A: ").Append(PowerThresholdV1A).Append("\n");
			sb.Append("  PowerThresholdV1B: ").Append(PowerThresholdV1B).Append("\n");
			sb.Append("  RxSopThresholdA: ").Append(RxSopThresholdA).Append("\n");
			sb.Append("  RxSopThresholdB: ").Append(RxSopThresholdB).Append("\n");
			sb.Append("  DefaultRfProfile: ").Append(DefaultRfProfile).Append("\n");
			sb.Append("  EnableBrownField: ").Append(EnableBrownField).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
