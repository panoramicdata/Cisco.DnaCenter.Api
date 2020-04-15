using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetServiceProviderDetailsResponseValue
	/// </summary>
	[DataContract]
	public partial class GetServiceProviderDetailsResponseValue
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetServiceProviderDetailsResponseValue" /> class.
		/// </summary>
		/// <param name="WanProvider">WanProvider.</param>
		/// <param name="SpProfileName">SpProfileName.</param>
		/// <param name="SlaProfileName">SlaProfileName.</param>
		public GetServiceProviderDetailsResponseValue(string? WanProvider = default, string? SpProfileName = default, string? SlaProfileName = default)
		{
			this.WanProvider = WanProvider;
			this.SpProfileName = SpProfileName;
			this.SlaProfileName = SlaProfileName;
		}

		/// <summary>
		/// Gets or Sets WanProvider
		/// </summary>
		[DataMember(Name = "wanProvider", EmitDefaultValue = false)]
		public string? WanProvider { get; set; }
		/// <summary>
		/// Gets or Sets SpProfileName
		/// </summary>
		[DataMember(Name = "spProfileName", EmitDefaultValue = false)]
		public string? SpProfileName { get; set; }
		/// <summary>
		/// Gets or Sets SlaProfileName
		/// </summary>
		[DataMember(Name = "slaProfileName", EmitDefaultValue = false)]
		public string? SlaProfileName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetServiceProviderDetailsResponseValue {\n");
			sb.Append("  WanProvider: ").Append(WanProvider).Append("\n");
			sb.Append("  SpProfileName: ").Append(SpProfileName).Append("\n");
			sb.Append("  SlaProfileName: ").Append(SlaProfileName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
