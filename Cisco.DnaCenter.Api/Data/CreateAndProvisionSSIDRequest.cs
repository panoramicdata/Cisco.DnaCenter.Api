using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateAndProvisionSSIDRequest
	/// </summary>
	[DataContract]
	public partial class CreateAndProvisionSsidRequest
	{
		/// <summary>
		/// Gets or Sets SsidType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SsidTypeEnum
		{

			/// <summary>
			/// Enum Guest for "Guest"
			/// </summary>
			[EnumMember(Value = "Guest")]
			Guest,

			/// <summary>
			/// Enum Enterprise for "Enterprise"
			/// </summary>
			[EnumMember(Value = "Enterprise")]
			Enterprise
		}

		/// <summary>
		/// Gets or Sets SsidType
		/// </summary>
		[DataMember(Name = "ssidType", EmitDefaultValue = false)]
		public SsidTypeEnum? SsidType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateAndProvisionSsidRequest" /> class.
		/// </summary>
		/// <param name="ManagedAPLocations">ManagedAPLocations.</param>
		/// <param name="SsidDetails">SsidDetails.</param>
		/// <param name="SsidType">SsidType.</param>
		/// <param name="EnableFabric">EnableFabric.</param>
		/// <param name="FlexConnect">FlexConnect.</param>
		public CreateAndProvisionSsidRequest(List<string> ManagedAPLocations = default, CreateAndProvisionSsidRequestSsidDetails SsidDetails = default, SsidTypeEnum? SsidType = default, bool? EnableFabric = default, GetWirelessProfileResponseInnerProfileDetailsFlexConnect FlexConnect = default)
		{
			this.ManagedAPLocations = ManagedAPLocations;
			this.SsidDetails = SsidDetails;
			this.SsidType = SsidType;
			this.EnableFabric = EnableFabric;
			this.FlexConnect = FlexConnect;
		}

		/// <summary>
		/// Gets or Sets ManagedAPLocations
		/// </summary>
		[DataMember(Name = "managedAPLocations", EmitDefaultValue = false)]
		public List<string> ManagedAPLocations { get; set; }
		/// <summary>
		/// Gets or Sets SsidDetails
		/// </summary>
		[DataMember(Name = "ssidDetails", EmitDefaultValue = false)]
		public CreateAndProvisionSsidRequestSsidDetails SsidDetails { get; set; }
		/// <summary>
		/// Gets or Sets EnableFabric
		/// </summary>
		[DataMember(Name = "enableFabric", EmitDefaultValue = false)]
		public bool? EnableFabric { get; set; }
		/// <summary>
		/// Gets or Sets FlexConnect
		/// </summary>
		[DataMember(Name = "flexConnect", EmitDefaultValue = false)]
		public GetWirelessProfileResponseInnerProfileDetailsFlexConnect FlexConnect { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateAndProvisionSSIDRequest {\n");
			sb.Append("  ManagedAPLocations: ").Append(ManagedAPLocations).Append("\n");
			sb.Append("  SsidDetails: ").Append(SsidDetails).Append("\n");
			sb.Append("  SsidType: ").Append(SsidType).Append("\n");
			sb.Append("  EnableFabric: ").Append(EnableFabric).Append("\n");
			sb.Append("  FlexConnect: ").Append(FlexConnect).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
