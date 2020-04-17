using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SAVAMappingSyncResultSyncList
	/// </summary>
	[DataContract]
	public partial class SavaMappingSyncResultSyncList
	{
		/// <summary>
		/// Gets or Sets SyncType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SyncTypeEnum
		{

			/// <summary>
			/// Enum Add for "Add"
			/// </summary>
			[EnumMember(Value = "Add")]
			Add,

			/// <summary>
			/// Enum Update for "Update"
			/// </summary>
			[EnumMember(Value = "Update")]
			Update,

			/// <summary>
			/// Enum Delete for "Delete"
			/// </summary>
			[EnumMember(Value = "Delete")]
			Delete,

			/// <summary>
			/// Enum MismatchError for "MismatchError"
			/// </summary>
			[EnumMember(Value = "MismatchError")]
			MismatchError
		}

		/// <summary>
		/// Gets or Sets SyncType
		/// </summary>
		[DataMember(Name = "syncType", EmitDefaultValue = false)]
		public SyncTypeEnum? SyncType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SavaMappingSyncResultSyncList" /> class.
		/// </summary>
		/// <param name="DeviceSnList">DeviceSnList.</param>
		/// <param name="SyncType">SyncType.</param>
		public SavaMappingSyncResultSyncList(List<string> DeviceSnList = default, SyncTypeEnum? SyncType = default)
		{
			this.DeviceSnList = DeviceSnList;
			this.SyncType = SyncType;
		}

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
			sb.Append("class SAVAMappingSyncResultSyncList {\n");
			sb.Append("  DeviceSnList: ").Append(DeviceSnList).Append("\n");
			sb.Append("  SyncType: ").Append(SyncType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
