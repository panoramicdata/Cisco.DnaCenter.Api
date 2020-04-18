using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation
	/// </summary>
	[DataContract]
	public class GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation" /> class.
		/// </summary>
		/// <param name="SiteId">SiteId.</param>
		/// <param name="SiteType">SiteType.</param>
		/// <param name="Area">Area.</param>
		/// <param name="Building">Building.</param>
		/// <param name="Floor">Floor.</param>
		/// <param name="ApsImpacted">ApsImpacted.</param>
		public GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation(string? SiteId = default, string? SiteType = default, string? Area = default, string? Building = default, Object Floor = default, List<Object> ApsImpacted = default)
		{
			this.SiteId = SiteId;
			this.SiteType = SiteType;
			this.Area = Area;
			this.Building = Building;
			this.Floor = Floor;
			this.ApsImpacted = ApsImpacted;
		}

		/// <summary>
		/// Gets or Sets SiteId
		/// </summary>
		[DataMember(Name = "siteId", EmitDefaultValue = false)]
		public string? SiteId { get; set; }
		/// <summary>
		/// Gets or Sets SiteType
		/// </summary>
		[DataMember(Name = "siteType", EmitDefaultValue = false)]
		public string? SiteType { get; set; }
		/// <summary>
		/// Gets or Sets Area
		/// </summary>
		[DataMember(Name = "area", EmitDefaultValue = false)]
		public string? Area { get; set; }
		/// <summary>
		/// Gets or Sets Building
		/// </summary>
		[DataMember(Name = "building", EmitDefaultValue = false)]
		public string? Building { get; set; }
		/// <summary>
		/// Gets or Sets Floor
		/// </summary>
		[DataMember(Name = "floor", EmitDefaultValue = false)]
		public Object Floor { get; set; }
		/// <summary>
		/// Gets or Sets ApsImpacted
		/// </summary>
		[DataMember(Name = "apsImpacted", EmitDefaultValue = false)]
		public List<Object> ApsImpacted { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientEnrichmentDetailsResponseInnerIssueDetailsLocation {\n");
			sb.Append("  SiteId: ").Append(SiteId).Append("\n");
			sb.Append("  SiteType: ").Append(SiteType).Append("\n");
			sb.Append("  Area: ").Append(Area).Append("\n");
			sb.Append("  Building: ").Append(Building).Append("\n");
			sb.Append("  Floor: ").Append(Floor).Append("\n");
			sb.Append("  ApsImpacted: ").Append(ApsImpacted).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
