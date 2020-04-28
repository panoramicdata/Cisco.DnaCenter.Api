using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDtoDeviceTypes
	/// </summary>
	[DataContract]
	public class TemplateDtoDeviceTypes
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDtoDeviceTypes" /> class.
		/// </summary>
		/// <param name="ProductFamily">ProductFamily.</param>
		/// <param name="ProductSeries">ProductSeries.</param>
		/// <param name="ProductType">ProductType.</param>
		public TemplateDtoDeviceTypes(string? ProductFamily = default, string? ProductSeries = default, string? ProductType = default)
		{
			this.ProductFamily = ProductFamily;
			this.ProductSeries = ProductSeries;
			this.ProductType = ProductType;
		}

		/// <summary>
		/// Gets or Sets ProductFamily
		/// </summary>
		[DataMember(Name = "productFamily", EmitDefaultValue = false)]
		public string? ProductFamily { get; set; }

		/// <summary>
		/// Gets or Sets ProductSeries
		/// </summary>
		[DataMember(Name = "productSeries", EmitDefaultValue = false)]
		public string? ProductSeries { get; set; }

		/// <summary>
		/// Gets or Sets ProductType
		/// </summary>
		[DataMember(Name = "productType", EmitDefaultValue = false)]
		public string? ProductType { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDtoDeviceTypes {\n");
			sb.Append("  ProductFamily: ").Append(ProductFamily).Append("\n");
			sb.Append("  ProductSeries: ").Append(ProductSeries).Append("\n");
			sb.Append("  ProductType: ").Append(ProductType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
