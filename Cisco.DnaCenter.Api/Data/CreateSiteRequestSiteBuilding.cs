using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateSiteRequestSiteBuilding
	/// </summary>
	[DataContract]
	public class CreateSiteRequestSiteBuilding
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateSiteRequestSiteBuilding" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Address">Address.</param>
		/// <param name="ParentName">ParentName.</param>
		/// <param name="Latitude">Latitude.</param>
		/// <param name="Longitude">Longitude.</param>
		public CreateSiteRequestSiteBuilding(string? Name = default, string? Address = default, string? ParentName = default, decimal? Latitude = default, decimal? Longitude = default)
		{
			this.Name = Name;
			this.Address = Address;
			this.ParentName = ParentName;
			this.Latitude = Latitude;
			this.Longitude = Longitude;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Address
		/// </summary>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string? Address { get; set; }
		/// <summary>
		/// Gets or Sets ParentName
		/// </summary>
		[DataMember(Name = "parentName", EmitDefaultValue = false)]
		public string? ParentName { get; set; }
		/// <summary>
		/// Gets or Sets Latitude
		/// </summary>
		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		public decimal? Latitude { get; set; }
		/// <summary>
		/// Gets or Sets Longitude
		/// </summary>
		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		public decimal? Longitude { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateSiteRequestSiteBuilding {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  ParentName: ").Append(ParentName).Append("\n");
			sb.Append("  Latitude: ").Append(Latitude).Append("\n");
			sb.Append("  Longitude: ").Append(Longitude).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
