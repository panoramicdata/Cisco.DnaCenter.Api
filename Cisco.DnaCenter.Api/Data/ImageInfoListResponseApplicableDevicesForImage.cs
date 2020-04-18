using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ImageInfoListResponseApplicableDevicesForImage
	/// </summary>
	[DataContract]
	public class ImageInfoListResponseApplicableDevicesForImage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageInfoListResponseApplicableDevicesForImage" /> class.
		/// </summary>
		/// <param name="MdfId">MdfId.</param>
		/// <param name="ProductId">ProductId.</param>
		/// <param name="ProductName">ProductName.</param>
		public ImageInfoListResponseApplicableDevicesForImage(string? MdfId = default, List<string> ProductId = default, string? ProductName = default)
		{
			this.MdfId = MdfId;
			this.ProductId = ProductId;
			this.ProductName = ProductName;
		}

		/// <summary>
		/// Gets or Sets MdfId
		/// </summary>
		[DataMember(Name = "mdfId", EmitDefaultValue = false)]
		public string? MdfId { get; set; }
		/// <summary>
		/// Gets or Sets ProductId
		/// </summary>
		[DataMember(Name = "productId", EmitDefaultValue = false)]
		public List<string> ProductId { get; set; }
		/// <summary>
		/// Gets or Sets ProductName
		/// </summary>
		[DataMember(Name = "productName", EmitDefaultValue = false)]
		public string? ProductName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImageInfoListResponseApplicableDevicesForImage {\n");
			sb.Append("  MdfId: ").Append(MdfId).Append("\n");
			sb.Append("  ProductId: ").Append(ProductId).Append("\n");
			sb.Append("  ProductName: ").Append(ProductName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
