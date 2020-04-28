using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateOrUpdateRfProfileRequest
	/// </summary>
	[DataContract]
	public class CreateOrUpdateRfProfileRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateOrUpdateRfProfileRequest" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="DefaultRfProfile">DefaultRfProfile.</param>
		/// <param name="EnableRadioTypeA">EnableRadioTypeA.</param>
		/// <param name="EnableRadioTypeB">EnableRadioTypeB.</param>
		/// <param name="ChannelWidth">ChannelWidth.</param>
		/// <param name="EnableCustom">EnableCustom.</param>
		/// <param name="EnableBrownField">EnableBrownField.</param>
		/// <param name="RadioTypeAProperties">RadioTypeAProperties.</param>
		/// <param name="RadioTypeBProperties">RadioTypeBProperties.</param>
		public CreateOrUpdateRfProfileRequest(string? Name = default, bool? DefaultRfProfile = default, bool? EnableRadioTypeA = default, bool? EnableRadioTypeB = default, string? ChannelWidth = default, bool? EnableCustom = default, bool? EnableBrownField = default, CreateOrUpdateRfProfileRequestRadioTypeAProperties RadioTypeAProperties = default, CreateOrUpdateRfProfileRequestRadioTypeAProperties RadioTypeBProperties = default)
		{
			this.Name = Name;
			this.DefaultRfProfile = DefaultRfProfile;
			this.EnableRadioTypeA = EnableRadioTypeA;
			this.EnableRadioTypeB = EnableRadioTypeB;
			this.ChannelWidth = ChannelWidth;
			this.EnableCustom = EnableCustom;
			this.EnableBrownField = EnableBrownField;
			this.RadioTypeAProperties = RadioTypeAProperties;
			this.RadioTypeBProperties = RadioTypeBProperties;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets DefaultRfProfile
		/// </summary>
		[DataMember(Name = "defaultRfProfile", EmitDefaultValue = false)]
		public bool? DefaultRfProfile { get; set; }

		/// <summary>
		/// Gets or Sets EnableRadioTypeA
		/// </summary>
		[DataMember(Name = "enableRadioTypeA", EmitDefaultValue = false)]
		public bool? EnableRadioTypeA { get; set; }

		/// <summary>
		/// Gets or Sets EnableRadioTypeB
		/// </summary>
		[DataMember(Name = "enableRadioTypeB", EmitDefaultValue = false)]
		public bool? EnableRadioTypeB { get; set; }

		/// <summary>
		/// Gets or Sets ChannelWidth
		/// </summary>
		[DataMember(Name = "channelWidth", EmitDefaultValue = false)]
		public string? ChannelWidth { get; set; }

		/// <summary>
		/// Gets or Sets EnableCustom
		/// </summary>
		[DataMember(Name = "enableCustom", EmitDefaultValue = false)]
		public bool? EnableCustom { get; set; }

		/// <summary>
		/// Gets or Sets EnableBrownField
		/// </summary>
		[DataMember(Name = "enableBrownField", EmitDefaultValue = false)]
		public bool? EnableBrownField { get; set; }

		/// <summary>
		/// Gets or Sets RadioTypeAProperties
		/// </summary>
		[DataMember(Name = "radioTypeAProperties", EmitDefaultValue = false)]
		public CreateOrUpdateRfProfileRequestRadioTypeAProperties RadioTypeAProperties { get; set; }

		/// <summary>
		/// Gets or Sets RadioTypeBProperties
		/// </summary>
		[DataMember(Name = "radioTypeBProperties", EmitDefaultValue = false)]
		public CreateOrUpdateRfProfileRequestRadioTypeAProperties RadioTypeBProperties { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateOrUpdateRfProfileRequest {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DefaultRfProfile: ").Append(DefaultRfProfile).Append("\n");
			sb.Append("  EnableRadioTypeA: ").Append(EnableRadioTypeA).Append("\n");
			sb.Append("  EnableRadioTypeB: ").Append(EnableRadioTypeB).Append("\n");
			sb.Append("  ChannelWidth: ").Append(ChannelWidth).Append("\n");
			sb.Append("  EnableCustom: ").Append(EnableCustom).Append("\n");
			sb.Append("  EnableBrownField: ").Append(EnableBrownField).Append("\n");
			sb.Append("  RadioTypeAProperties: ").Append(RadioTypeAProperties).Append("\n");
			sb.Append("  RadioTypeBProperties: ").Append(RadioTypeBProperties).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
