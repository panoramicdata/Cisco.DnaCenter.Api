using System.Runtime.Serialization;
using System.Text;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// UpdateSiteRequestSiteFloor
	/// </summary>
	[DataContract]
	public class UpdateSiteRequestSiteFloor
	{

		/// <summary>
		/// Gets or Sets RfModel
		/// </summary>
		[DataMember(Name = "rfModel", EmitDefaultValue = false)]
		public RfModel? RfModel { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSiteRequestSiteFloor" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="RfModel">RfModel.</param>
		/// <param name="Width">Width.</param>
		/// <param name="Length">Length.</param>
		/// <param name="Height">Height.</param>
		public UpdateSiteRequestSiteFloor(string? Name = default, RfModel? RfModel = default, decimal? Width = default, decimal? Length = default, decimal? Height = default)
		{
			this.Name = Name;
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
			sb.Append("class UpdateSiteRequestSiteFloor {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  RfModel: ").Append(RfModel).Append("\n");
			sb.Append("  Width: ").Append(Width).Append("\n");
			sb.Append("  Length: ").Append(Length).Append("\n");
			sb.Append("  Height: ").Append(Height).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
