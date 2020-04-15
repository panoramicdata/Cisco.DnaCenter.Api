using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SAVAMappingSyncResult
	/// </summary>
	[DataContract]
	public partial class SAVAMappingSyncResult
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SAVAMappingSyncResult" /> class.
		/// </summary>
		/// <param name="SyncList">SyncList.</param>
		/// <param name="SyncMsg">SyncMsg.</param>
		public SAVAMappingSyncResult(List<SAVAMappingSyncResultSyncList> SyncList = default, string? SyncMsg = default)
		{
			this.SyncList = SyncList;
			this.SyncMsg = SyncMsg;
		}

		/// <summary>
		/// Gets or Sets SyncList
		/// </summary>
		[DataMember(Name = "syncList", EmitDefaultValue = false)]
		public List<SAVAMappingSyncResultSyncList> SyncList { get; set; }
		/// <summary>
		/// Gets or Sets SyncMsg
		/// </summary>
		[DataMember(Name = "syncMsg", EmitDefaultValue = false)]
		public string? SyncMsg { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SAVAMappingSyncResult {\n");
			sb.Append("  SyncList: ").Append(SyncList).Append("\n");
			sb.Append("  SyncMsg: ").Append(SyncMsg).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
