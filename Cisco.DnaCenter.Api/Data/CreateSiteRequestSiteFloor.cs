using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSiteRequestSiteFloor
	/// </summary>
	[DataContract]
	public class CreateSiteRequestSiteFloor
	{
		/// <summary>
		/// Gets or Sets RfModel
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum RfModelEnum
		{

			/// <summary>
			/// Enum CubesAndWalledOffices for "Cubes And Walled Offices"
			/// </summary>
			[EnumMember(Value = "Cubes And Walled Offices")]
			CubesAndWalledOffices,

			/// <summary>
			/// Enum DrywallOfficeOnly for "Drywall Office Only"
			/// </summary>
			[EnumMember(Value = "Drywall Office Only")]
			DrywallOfficeOnly,

			/// <summary>
			/// Enum IndoorHighCeiling for "Indoor High Ceiling"
			/// </summary>
			[EnumMember(Value = "Indoor High Ceiling")]
			IndoorHighCeiling,

			/// <summary>
			/// Enum OutdoorOpenSpace for "Outdoor Open Space"
			/// </summary>
			[EnumMember(Value = "Outdoor Open Space")]
			OutdoorOpenSpace
		}

		/// <summary>
		/// Gets or Sets RfModel
		/// </summary>
		[DataMember(Name = "rfModel", EmitDefaultValue = false)]
		public RfModelEnum? RfModel { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSiteRequestSiteFloor" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="ParentName">ParentName.</param>
		/// <param name="RfModel">RfModel.</param>
		/// <param name="Width">Width.</param>
		/// <param name="Length">Length.</param>
		/// <param name="Height">Height.</param>
		public CreateSiteRequestSiteFloor(string? Name = default, string? ParentName = default, RfModelEnum? RfModel = default, decimal? Width = default, decimal? Length = default, decimal? Height = default)
		{
			this.Name = Name;
			this.ParentName = ParentName;
			this.RfModel = RfModel;
			this.Width = Width;
			this.Length = Length;
			this.Height = Height;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets ParentName
		/// </summary>
		[DataMember(Name = "parentName", EmitDefaultValue = false)]
		public string? ParentName { get; set; }

		/// <summary>
		/// Gets or Sets Width
		/// </summary>
		[DataMember(Name = "width", EmitDefaultValue = false)]
		public decimal? Width { get; set; }

		/// <summary>
		/// Gets or Sets Length
		/// </summary>
		[DataMember(Name = "length", EmitDefaultValue = false)]
		public decimal? Length { get; set; }

		/// <summary>
		/// Gets or Sets Height
		/// </summary>
		[DataMember(Name = "height", EmitDefaultValue = false)]
		public decimal? Height { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSiteRequestSiteFloor {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ParentName: ").Append(ParentName).Append("\n");
			sb.Append("  RfModel: ").Append(RfModel).Append("\n");
			sb.Append("  Width: ").Append(Width).Append("\n");
			sb.Append("  Length: ").Append(Length).Append("\n");
			sb.Append("  Height: ").Append(Height).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
