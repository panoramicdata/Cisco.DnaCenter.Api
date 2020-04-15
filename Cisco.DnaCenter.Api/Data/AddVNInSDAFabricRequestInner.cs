using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddVNInSDAFabricRequestInner
	/// </summary>
	[DataContract]
	public partial class AddVNInSDAFabricRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddVNInSDAFabricRequestInner" /> class.
		/// </summary>
		/// <param name="VirtualNetworkName">VirtualNetworkName.</param>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		public AddVNInSDAFabricRequestInner(string? VirtualNetworkName = default, string? SiteNameHierarchy = default)
		{
			this.VirtualNetworkName = VirtualNetworkName;
			this.SiteNameHierarchy = SiteNameHierarchy;
		}

		/// <summary>
		/// Gets or Sets VirtualNetworkName
		/// </summary>
		[DataMember(Name = "virtualNetworkName", EmitDefaultValue = false)]
		public string? VirtualNetworkName { get; set; }
		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddVNInSDAFabricRequestInner {\n");
			sb.Append("  VirtualNetworkName: ").Append(VirtualNetworkName).Append("\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
