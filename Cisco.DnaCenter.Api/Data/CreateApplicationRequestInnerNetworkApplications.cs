using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateApplicationRequestInnerNetworkApplications
	/// </summary>
	[DataContract]
	public class CreateApplicationRequestInnerNetworkApplications
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateApplicationRequestInnerNetworkApplications" /> class.
		/// </summary>
		/// <param name="AppProtocol">AppProtocol.</param>
		/// <param name="ApplicationSubType">ApplicationSubType.</param>
		/// <param name="ApplicationType">ApplicationType.</param>
		/// <param name="CategoryId">CategoryId.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="EngineId">EngineId.</param>
		/// <param name="HelpString">HelpString.</param>
		/// <param name="LongDescription">LongDescription.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Popularity">Popularity.</param>
		/// <param name="Rank">Rank.</param>
		/// <param name="TrafficClass">TrafficClass.</param>
		/// <param name="ServerName">ServerName.</param>
		/// <param name="Url">Url.</param>
		/// <param name="Dscp">Dscp.</param>
		/// <param name="IgnoreConflict">IgnoreConflict.</param>
		public CreateApplicationRequestInnerNetworkApplications(string? AppProtocol = default, string? ApplicationSubType = default, string? ApplicationType = default, string? CategoryId = default, string? DisplayName = default, string? EngineId = default, string? HelpString = default, string? LongDescription = default, string? Name = default, string? Popularity = default, string? Rank = default, string? TrafficClass = default, string? ServerName = default, string? Url = default, string? Dscp = default, string? IgnoreConflict = default)
		{
			this.AppProtocol = AppProtocol;
			this.ApplicationSubType = ApplicationSubType;
			this.ApplicationType = ApplicationType;
			this.CategoryId = CategoryId;
			this.DisplayName = DisplayName;
			this.EngineId = EngineId;
			this.HelpString = HelpString;
			this.LongDescription = LongDescription;
			this.Name = Name;
			this.Popularity = Popularity;
			this.Rank = Rank;
			this.TrafficClass = TrafficClass;
			this.ServerName = ServerName;
			this.Url = Url;
			this.Dscp = Dscp;
			this.IgnoreConflict = IgnoreConflict;
		}

		/// <summary>
		/// Gets or Sets AppProtocol
		/// </summary>
		[DataMember(Name = "appProtocol", EmitDefaultValue = false)]
		public string? AppProtocol { get; set; }
		/// <summary>
		/// Gets or Sets ApplicationSubType
		/// </summary>
		[DataMember(Name = "applicationSubType", EmitDefaultValue = false)]
		public string? ApplicationSubType { get; set; }
		/// <summary>
		/// Gets or Sets ApplicationType
		/// </summary>
		[DataMember(Name = "applicationType", EmitDefaultValue = false)]
		public string? ApplicationType { get; set; }
		/// <summary>
		/// Gets or Sets CategoryId
		/// </summary>
		[DataMember(Name = "categoryId", EmitDefaultValue = false)]
		public string? CategoryId { get; set; }
		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string? DisplayName { get; set; }
		/// <summary>
		/// Gets or Sets EngineId
		/// </summary>
		[DataMember(Name = "engineId", EmitDefaultValue = false)]
		public string? EngineId { get; set; }
		/// <summary>
		/// Gets or Sets HelpString
		/// </summary>
		[DataMember(Name = "helpString", EmitDefaultValue = false)]
		public string? HelpString { get; set; }
		/// <summary>
		/// Gets or Sets LongDescription
		/// </summary>
		[DataMember(Name = "longDescription", EmitDefaultValue = false)]
		public string? LongDescription { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Popularity
		/// </summary>
		[DataMember(Name = "popularity", EmitDefaultValue = false)]
		public string? Popularity { get; set; }
		/// <summary>
		/// Gets or Sets Rank
		/// </summary>
		[DataMember(Name = "rank", EmitDefaultValue = false)]
		public string? Rank { get; set; }
		/// <summary>
		/// Gets or Sets TrafficClass
		/// </summary>
		[DataMember(Name = "trafficClass", EmitDefaultValue = false)]
		public string? TrafficClass { get; set; }
		/// <summary>
		/// Gets or Sets ServerName
		/// </summary>
		[DataMember(Name = "serverName", EmitDefaultValue = false)]
		public string? ServerName { get; set; }
		/// <summary>
		/// Gets or Sets Url
		/// </summary>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string? Url { get; set; }
		/// <summary>
		/// Gets or Sets Dscp
		/// </summary>
		[DataMember(Name = "dscp", EmitDefaultValue = false)]
		public string? Dscp { get; set; }
		/// <summary>
		/// Gets or Sets IgnoreConflict
		/// </summary>
		[DataMember(Name = "ignoreConflict", EmitDefaultValue = false)]
		public string? IgnoreConflict { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateApplicationRequestInnerNetworkApplications {\n");
			sb.Append("  AppProtocol: ").Append(AppProtocol).Append("\n");
			sb.Append("  ApplicationSubType: ").Append(ApplicationSubType).Append("\n");
			sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
			sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  EngineId: ").Append(EngineId).Append("\n");
			sb.Append("  HelpString: ").Append(HelpString).Append("\n");
			sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Popularity: ").Append(Popularity).Append("\n");
			sb.Append("  Rank: ").Append(Rank).Append("\n");
			sb.Append("  TrafficClass: ").Append(TrafficClass).Append("\n");
			sb.Append("  ServerName: ").Append(ServerName).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Dscp: ").Append(Dscp).Append("\n");
			sb.Append("  IgnoreConflict: ").Append(IgnoreConflict).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
