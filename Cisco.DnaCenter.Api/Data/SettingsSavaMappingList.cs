using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SettingsSavaMappingList
	/// </summary>
	[DataContract]
	public class SettingsSavaMappingList
	{
		/// <summary>
		/// Gets or Sets SyncStatus
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SyncStatusEnum
		{

			/// <summary>
			/// Enum NOTSYNCED for "NOT_SYNCED"
			/// </summary>
			[EnumMember(Value = "NOT_SYNCED")]
			NOTSYNCED,

			/// <summary>
			/// Enum SYNCING for "SYNCING"
			/// </summary>
			[EnumMember(Value = "SYNCING")]
			SYNCING,

			/// <summary>
			/// Enum SUCCESS for "SUCCESS"
			/// </summary>
			[EnumMember(Value = "SUCCESS")]
			SUCCESS,

			/// <summary>
			/// Enum FAILURE for "FAILURE"
			/// </summary>
			[EnumMember(Value = "FAILURE")]
			FAILURE
		}

		/// <summary>
		/// Gets or Sets SyncStatus
		/// </summary>
		[DataMember(Name = "syncStatus", EmitDefaultValue = false)]
		public SyncStatusEnum? SyncStatus { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsSavaMappingList" /> class.
		/// </summary>
		/// <param name="AutoSyncPeriod">AutoSyncPeriod.</param>
		/// <param name="CcoUser">CcoUser.</param>
		/// <param name="Expiry">Expiry.</param>
		/// <param name="LastSync">LastSync.</param>
		/// <param name="Profile">Profile.</param>
		/// <param name="SmartAccountId">SmartAccountId.</param>
		/// <param name="SyncResult">SyncResult.</param>
		/// <param name="SyncResultStr">SyncResultStr.</param>
		/// <param name="SyncStartTime">SyncStartTime.</param>
		/// <param name="SyncStatus">SyncStatus.</param>
		/// <param name="TenantId">TenantId.</param>
		/// <param name="Token">Token.</param>
		/// <param name="VirtualAccountId">VirtualAccountId.</param>
		public SettingsSavaMappingList(int? AutoSyncPeriod = default, string? CcoUser = default, int? Expiry = default, int? LastSync = default, SavaMappingProfile Profile = default, string? SmartAccountId = default, SavaMappingSyncResult SyncResult = default, string? SyncResultStr = default, int? SyncStartTime = default, SyncStatusEnum? SyncStatus = default, string? TenantId = default, string? Token = default, string? VirtualAccountId = default)
		{
			this.AutoSyncPeriod = AutoSyncPeriod;
			this.CcoUser = CcoUser;
			this.Expiry = Expiry;
			this.LastSync = LastSync;
			this.Profile = Profile;
			this.SmartAccountId = SmartAccountId;
			this.SyncResult = SyncResult;
			this.SyncResultStr = SyncResultStr;
			this.SyncStartTime = SyncStartTime;
			this.SyncStatus = SyncStatus;
			this.TenantId = TenantId;
			this.Token = Token;
			this.VirtualAccountId = VirtualAccountId;
		}

		/// <summary>
		/// Gets or Sets AutoSyncPeriod
		/// </summary>
		[DataMember(Name = "autoSyncPeriod", EmitDefaultValue = false)]
		public int? AutoSyncPeriod { get; set; }
		/// <summary>
		/// Gets or Sets CcoUser
		/// </summary>
		[DataMember(Name = "ccoUser", EmitDefaultValue = false)]
		public string? CcoUser { get; set; }
		/// <summary>
		/// Gets or Sets Expiry
		/// </summary>
		[DataMember(Name = "expiry", EmitDefaultValue = false)]
		public int? Expiry { get; set; }
		/// <summary>
		/// Gets or Sets LastSync
		/// </summary>
		[DataMember(Name = "lastSync", EmitDefaultValue = false)]
		public int? LastSync { get; set; }
		/// <summary>
		/// Gets or Sets Profile
		/// </summary>
		[DataMember(Name = "profile", EmitDefaultValue = false)]
		public SavaMappingProfile Profile { get; set; }
		/// <summary>
		/// Gets or Sets SmartAccountId
		/// </summary>
		[DataMember(Name = "smartAccountId", EmitDefaultValue = false)]
		public string? SmartAccountId { get; set; }
		/// <summary>
		/// Gets or Sets SyncResult
		/// </summary>
		[DataMember(Name = "syncResult", EmitDefaultValue = false)]
		public SavaMappingSyncResult SyncResult { get; set; }
		/// <summary>
		/// Gets or Sets SyncResultStr
		/// </summary>
		[DataMember(Name = "syncResultStr", EmitDefaultValue = false)]
		public string? SyncResultStr { get; set; }
		/// <summary>
		/// Gets or Sets SyncStartTime
		/// </summary>
		[DataMember(Name = "syncStartTime", EmitDefaultValue = false)]
		public int? SyncStartTime { get; set; }
		/// <summary>
		/// Gets or Sets TenantId
		/// </summary>
		[DataMember(Name = "tenantId", EmitDefaultValue = false)]
		public string? TenantId { get; set; }
		/// <summary>
		/// Gets or Sets Token
		/// </summary>
		[DataMember(Name = "token", EmitDefaultValue = false)]
		public string? Token { get; set; }
		/// <summary>
		/// Gets or Sets VirtualAccountId
		/// </summary>
		[DataMember(Name = "virtualAccountId", EmitDefaultValue = false)]
		public string? VirtualAccountId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SettingsSavaMappingList {\n");
			sb.Append("  AutoSyncPeriod: ").Append(AutoSyncPeriod).Append("\n");
			sb.Append("  CcoUser: ").Append(CcoUser).Append("\n");
			sb.Append("  Expiry: ").Append(Expiry).Append("\n");
			sb.Append("  LastSync: ").Append(LastSync).Append("\n");
			sb.Append("  Profile: ").Append(Profile).Append("\n");
			sb.Append("  SmartAccountId: ").Append(SmartAccountId).Append("\n");
			sb.Append("  SyncResult: ").Append(SyncResult).Append("\n");
			sb.Append("  SyncResultStr: ").Append(SyncResultStr).Append("\n");
			sb.Append("  SyncStartTime: ").Append(SyncStartTime).Append("\n");
			sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("  Token: ").Append(Token).Append("\n");
			sb.Append("  VirtualAccountId: ").Append(VirtualAccountId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
