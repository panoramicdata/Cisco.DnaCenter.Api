using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteRequest
	/// </summary>
	[DataContract]
	public class UpdateSiteRequest
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Area for "area"
			/// </summary>
			[EnumMember(Value = "area")]
			Area,

			/// <summary>
			/// Enum Building for "building"
			/// </summary>
			[EnumMember(Value = "building")]
			Building,

			/// <summary>
			/// Enum Floor for "floor"
			/// </summary>
			[EnumMember(Value = "floor")]
			Floor
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSiteRequest" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Site">Site.</param>
		public UpdateSiteRequest(TypeEnum? Type = default, UpdateSiteRequestSite Site = default)
		{
			this.Type = Type;
			this.Site = Site;
		}

		/// <summary>
		/// Gets or Sets Site
		/// </summary>
		[DataMember(Name = "site", EmitDefaultValue = false)]
		public UpdateSiteRequestSite Site { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSiteRequest {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Site: ").Append(Site).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
