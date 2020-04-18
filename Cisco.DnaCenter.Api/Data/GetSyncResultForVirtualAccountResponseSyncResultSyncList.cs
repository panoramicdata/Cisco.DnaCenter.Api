using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSyncResultForVirtualAccountResponseSyncResultSyncList
	/// </summary>
	[DataContract]
	public class GetSyncResultForVirtualAccountResponseSyncResultSyncList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSyncResultForVirtualAccountResponseSyncResultSyncList" /> class.
		/// </summary>
		/// <param name="SyncType">SyncType.</param>
		/// <param name="DeviceSnList">DeviceSnList.</param>
		public GetSyncResultForVirtualAccountResponseSyncResultSyncList(string? SyncType = default, List<string> DeviceSnList = default)
		{
			this.SyncType = SyncType;
			this.DeviceSnList = DeviceSnList;
		}

		/// <summary>
		/// Gets or Sets SyncType
		/// </summary>
		[DataMember(Name = "syncType", EmitDefaultValue = false)]
		public string? SyncType { get; set; }
		/// <summary>
		/// Gets or Sets DeviceSnList
		/// </summary>
		[DataMember(Name = "deviceSnList", EmitDefaultValue = false)]
		public List<string> DeviceSnList { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSyncResultForVirtualAccountResponseSyncResultSyncList {\n");
			sb.Append("  SyncType: ").Append(SyncType).Append("\n");
			sb.Append("  DeviceSnList: ").Append(DeviceSnList).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
