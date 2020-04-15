using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// PathResponseResultResponse
	/// </summary>
	[DataContract]
	public partial class PathResponseResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PathResponseResultResponse" /> class.
		/// </summary>
		/// <param name="DetailedStatus">DetailedStatus.</param>
		/// <param name="LastUpdate">LastUpdate.</param>
		/// <param name="NetworkElements">NetworkElements.</param>
		/// <param name="NetworkElementsInfo">NetworkElementsInfo.</param>
		/// <param name="Properties">Properties.</param>
		/// <param name="Request">Request.</param>
		public PathResponseResultResponse(PathResponseResultResponseDetailedStatus DetailedStatus = default, string? LastUpdate = default, List<PathResponseResultResponseNetworkElements> NetworkElements = default, List<PathResponseResultResponseNetworkElementsInfo> NetworkElementsInfo = default, List<string> Properties = default, FlowAnalysisListOutputResponse Request = default)
		{
			this.DetailedStatus = DetailedStatus;
			this.LastUpdate = LastUpdate;
			this.NetworkElements = NetworkElements;
			this.NetworkElementsInfo = NetworkElementsInfo;
			this.Properties = Properties;
			this.Request = Request;
		}

		/// <summary>
		/// Gets or Sets DetailedStatus
		/// </summary>
		[DataMember(Name = "detailedStatus", EmitDefaultValue = false)]
		public PathResponseResultResponseDetailedStatus DetailedStatus { get; set; }
		/// <summary>
		/// Gets or Sets LastUpdate
		/// </summary>
		[DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
		public string? LastUpdate { get; set; }
		/// <summary>
		/// Gets or Sets NetworkElements
		/// </summary>
		[DataMember(Name = "networkElements", EmitDefaultValue = false)]
		public List<PathResponseResultResponseNetworkElements> NetworkElements { get; set; }
		/// <summary>
		/// Gets or Sets NetworkElementsInfo
		/// </summary>
		[DataMember(Name = "networkElementsInfo", EmitDefaultValue = false)]
		public List<PathResponseResultResponseNetworkElementsInfo> NetworkElementsInfo { get; set; }
		/// <summary>
		/// Gets or Sets Properties
		/// </summary>
		[DataMember(Name = "properties", EmitDefaultValue = false)]
		public List<string> Properties { get; set; }
		/// <summary>
		/// Gets or Sets Request
		/// </summary>
		[DataMember(Name = "request", EmitDefaultValue = false)]
		public FlowAnalysisListOutputResponse Request { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PathResponseResultResponse {\n");
			sb.Append("  DetailedStatus: ").Append(DetailedStatus).Append("\n");
			sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
			sb.Append("  NetworkElements: ").Append(NetworkElements).Append("\n");
			sb.Append("  NetworkElementsInfo: ").Append(NetworkElementsInfo).Append("\n");
			sb.Append("  Properties: ").Append(Properties).Append("\n");
			sb.Append("  Request: ").Append(Request).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
