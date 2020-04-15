using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetOverallNetworkHealthResponse
	/// </summary>
	[DataContract]
	public partial class GetOverallNetworkHealthResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetOverallNetworkHealthResponse" /> class.
		/// </summary>
		/// <param name="_Version">_Version.</param>
		/// <param name="Response">Response.</param>
		/// <param name="MeasuredBy">MeasuredBy.</param>
		/// <param name="LatestMeasuredByEntity">LatestMeasuredByEntity.</param>
		/// <param name="LatestHealthScore">LatestHealthScore.</param>
		/// <param name="MonitoredDevices">MonitoredDevices.</param>
		/// <param name="MonitoredHealthyDevices">MonitoredHealthyDevices.</param>
		/// <param name="MonitoredUnHealthyDevices">MonitoredUnHealthyDevices.</param>
		/// <param name="UnMonitoredDevices">UnMonitoredDevices.</param>
		/// <param name="HealthDistirubution">HealthDistirubution.</param>
		public GetOverallNetworkHealthResponse(string? _Version = default, List<GetOverallNetworkHealthResponseResponse> Response = default, string? MeasuredBy = default, Object LatestMeasuredByEntity = default, int? LatestHealthScore = default, int? MonitoredDevices = default, int? MonitoredHealthyDevices = default, int? MonitoredUnHealthyDevices = default, decimal? UnMonitoredDevices = default, List<GetOverallNetworkHealthResponseHealthDistirubution> HealthDistirubution = default)
		{
			this._Version = _Version;
			this.Response = Response;
			this.MeasuredBy = MeasuredBy;
			this.LatestMeasuredByEntity = LatestMeasuredByEntity;
			this.LatestHealthScore = LatestHealthScore;
			this.MonitoredDevices = MonitoredDevices;
			this.MonitoredHealthyDevices = MonitoredHealthyDevices;
			this.MonitoredUnHealthyDevices = MonitoredUnHealthyDevices;
			this.UnMonitoredDevices = UnMonitoredDevices;
			this.HealthDistirubution = HealthDistirubution;
		}

		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Gets or Sets Response
		/// </summary>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public List<GetOverallNetworkHealthResponseResponse> Response { get; set; }
		/// <summary>
		/// Gets or Sets MeasuredBy
		/// </summary>
		[DataMember(Name = "measuredBy", EmitDefaultValue = false)]
		public string? MeasuredBy { get; set; }
		/// <summary>
		/// Gets or Sets LatestMeasuredByEntity
		/// </summary>
		[DataMember(Name = "latestMeasuredByEntity", EmitDefaultValue = false)]
		public Object LatestMeasuredByEntity { get; set; }
		/// <summary>
		/// Gets or Sets LatestHealthScore
		/// </summary>
		[DataMember(Name = "latestHealthScore", EmitDefaultValue = false)]
		public int? LatestHealthScore { get; set; }
		/// <summary>
		/// Gets or Sets MonitoredDevices
		/// </summary>
		[DataMember(Name = "monitoredDevices", EmitDefaultValue = false)]
		public int? MonitoredDevices { get; set; }
		/// <summary>
		/// Gets or Sets MonitoredHealthyDevices
		/// </summary>
		[DataMember(Name = "monitoredHealthyDevices", EmitDefaultValue = false)]
		public int? MonitoredHealthyDevices { get; set; }
		/// <summary>
		/// Gets or Sets MonitoredUnHealthyDevices
		/// </summary>
		[DataMember(Name = "monitoredUnHealthyDevices", EmitDefaultValue = false)]
		public int? MonitoredUnHealthyDevices { get; set; }
		/// <summary>
		/// Gets or Sets UnMonitoredDevices
		/// </summary>
		[DataMember(Name = "unMonitoredDevices", EmitDefaultValue = false)]
		public decimal? UnMonitoredDevices { get; set; }
		/// <summary>
		/// Gets or Sets HealthDistirubution
		/// </summary>
		[DataMember(Name = "healthDistirubution", EmitDefaultValue = false)]
		public List<GetOverallNetworkHealthResponseHealthDistirubution> HealthDistirubution { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetOverallNetworkHealthResponse {\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
			sb.Append("  MeasuredBy: ").Append(MeasuredBy).Append("\n");
			sb.Append("  LatestMeasuredByEntity: ").Append(LatestMeasuredByEntity).Append("\n");
			sb.Append("  LatestHealthScore: ").Append(LatestHealthScore).Append("\n");
			sb.Append("  MonitoredDevices: ").Append(MonitoredDevices).Append("\n");
			sb.Append("  MonitoredHealthyDevices: ").Append(MonitoredHealthyDevices).Append("\n");
			sb.Append("  MonitoredUnHealthyDevices: ").Append(MonitoredUnHealthyDevices).Append("\n");
			sb.Append("  UnMonitoredDevices: ").Append(UnMonitoredDevices).Append("\n");
			sb.Append("  HealthDistirubution: ").Append(HealthDistirubution).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
