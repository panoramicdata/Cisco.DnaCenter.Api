using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetClientDetailResponse
	/// </summary>
	[DataContract]
	public class GetClientDetailResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetClientDetailResponse" /> class.
		/// </summary>
		/// <param name="Detail">Detail.</param>
		/// <param name="ConnectionInfo">ConnectionInfo.</param>
		/// <param name="Topology">Topology.</param>
		public GetClientDetailResponse(GetClientDetailResponseDetail Detail = default, GetClientDetailResponseConnectionInfo ConnectionInfo = default, GetClientDetailResponseTopology Topology = default)
		{
			this.Detail = Detail;
			this.ConnectionInfo = ConnectionInfo;
			this.Topology = Topology;
		}

		/// <summary>
		/// Gets or Sets Detail
		/// </summary>
		[DataMember(Name = "detail", EmitDefaultValue = false)]
		public GetClientDetailResponseDetail Detail { get; set; }
		/// <summary>
		/// Gets or Sets ConnectionInfo
		/// </summary>
		[DataMember(Name = "connectionInfo", EmitDefaultValue = false)]
		public GetClientDetailResponseConnectionInfo ConnectionInfo { get; set; }
		/// <summary>
		/// Gets or Sets Topology
		/// </summary>
		[DataMember(Name = "topology", EmitDefaultValue = false)]
		public GetClientDetailResponseTopology Topology { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetClientDetailResponse {\n");
			sb.Append("  Detail: ").Append(Detail).Append("\n");
			sb.Append("  ConnectionInfo: ").Append(ConnectionInfo).Append("\n");
			sb.Append("  Topology: ").Append(Topology).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
