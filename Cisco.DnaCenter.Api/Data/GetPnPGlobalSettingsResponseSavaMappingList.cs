using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetPnPGlobalSettingsResponseSavaMappingList
	/// </summary>
	[DataContract]
	public partial class GetPnPGlobalSettingsResponseSavaMappingList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetPnPGlobalSettingsResponseSavaMappingList" /> class.
		/// </summary>
		/// <param name="SyncStatus">SyncStatus.</param>
		/// <param name="SyncStartTime">SyncStartTime.</param>
		/// <param name="SyncResult">SyncResult.</param>
		/// <param name="LastSync">LastSync.</param>
		/// <param name="TenantId">TenantId.</param>
		/// <param name="Profile">Profile.</param>
		/// <param name="Token">Token.</param>
		/// <param name="Expiry">Expiry.</param>
		/// <param name="CcoUser">CcoUser.</param>
		/// <param name="SmartAccountId">SmartAccountId.</param>
		/// <param name="VirtualAccountId">VirtualAccountId.</param>
		/// <param name="AutoSyncPeriod">AutoSyncPeriod.</param>
		/// <param name="SyncResultStr">SyncResultStr.</param>
		public GetPnPGlobalSettingsResponseSavaMappingList(string? SyncStatus = default, decimal? SyncStartTime = default, GetSyncResultForVirtualAccountResponseSyncResult SyncResult = default, decimal? LastSync = default, string? TenantId = default, GetPnpGlobalSettingsResponseProfile Profile = default, string? Token = default, decimal? Expiry = default, string? CcoUser = default, string? SmartAccountId = default, string? VirtualAccountId = default, decimal? AutoSyncPeriod = default, string? SyncResultStr = default)
		{
			this.SyncStatus = SyncStatus;
			this.SyncStartTime = SyncStartTime;
			this.SyncResult = SyncResult;
			this.LastSync = LastSync;
			this.TenantId = TenantId;
			this.Profile = Profile;
			this.Token = Token;
			this.Expiry = Expiry;
			this.CcoUser = CcoUser;
			this.SmartAccountId = SmartAccountId;
			this.VirtualAccountId = VirtualAccountId;
			this.AutoSyncPeriod = AutoSyncPeriod;
			this.SyncResultStr = SyncResultStr;
		}

		/// <summary>
		/// Gets or Sets SyncStatus
		/// </summary>
		[DataMember(Name = "syncStatus", EmitDefaultValue = false)]
		public string? SyncStatus { get; set; }
		/// <summary>
		/// Gets or Sets SyncStartTime
		/// </summary>
		[DataMember(Name = "syncStartTime", EmitDefaultValue = false)]
		public decimal? SyncStartTime { get; set; }
		/// <summary>
		/// Gets or Sets SyncResult
		/// </summary>
		[DataMember(Name = "syncResult", EmitDefaultValue = false)]
		public GetSyncResultForVirtualAccountResponseSyncResult SyncResult { get; set; }
		/// <summary>
		/// Gets or Sets LastSync
		/// </summary>
		[DataMember(Name = "lastSync", EmitDefaultValue = false)]
		public decimal? LastSync { get; set; }
		/// <summary>
		/// Gets or Sets TenantId
		/// </summary>
		[DataMember(Name = "tenantId", EmitDefaultValue = false)]
		public string? TenantId { get; set; }
		/// <summary>
		/// Gets or Sets Profile
		/// </summary>
		[DataMember(Name = "profile", EmitDefaultValue = false)]
		public GetPnpGlobalSettingsResponseProfile Profile { get; set; }
		/// <summary>
		/// Gets or Sets Token
		/// </summary>
		[DataMember(Name = "token", EmitDefaultValue = false)]
		public string? Token { get; set; }
		/// <summary>
		/// Gets or Sets Expiry
		/// </summary>
		[DataMember(Name = "expiry", EmitDefaultValue = false)]
		public decimal? Expiry { get; set; }
		/// <summary>
		/// Gets or Sets CcoUser
		/// </summary>
		[DataMember(Name = "ccoUser", EmitDefaultValue = false)]
		public string? CcoUser { get; set; }
		/// <summary>
		/// Gets or Sets SmartAccountId
		/// </summary>
		[DataMember(Name = "smartAccountId", EmitDefaultValue = false)]
		public string? SmartAccountId { get; set; }
		/// <summary>
		/// Gets or Sets VirtualAccountId
		/// </summary>
		[DataMember(Name = "virtualAccountId", EmitDefaultValue = false)]
		public string? VirtualAccountId { get; set; }
		/// <summary>
		/// Gets or Sets AutoSyncPeriod
		/// </summary>
		[DataMember(Name = "autoSyncPeriod", EmitDefaultValue = false)]
		public decimal? AutoSyncPeriod { get; set; }
		/// <summary>
		/// Gets or Sets SyncResultStr
		/// </summary>
		[DataMember(Name = "syncResultStr", EmitDefaultValue = false)]
		public string? SyncResultStr { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetPnPGlobalSettingsResponseSavaMappingList {\n");
			sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
			sb.Append("  SyncStartTime: ").Append(SyncStartTime).Append("\n");
			sb.Append("  SyncResult: ").Append(SyncResult).Append("\n");
			sb.Append("  LastSync: ").Append(LastSync).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("  Profile: ").Append(Profile).Append("\n");
			sb.Append("  Token: ").Append(Token).Append("\n");
			sb.Append("  Expiry: ").Append(Expiry).Append("\n");
			sb.Append("  CcoUser: ").Append(CcoUser).Append("\n");
			sb.Append("  SmartAccountId: ").Append(SmartAccountId).Append("\n");
			sb.Append("  VirtualAccountId: ").Append(VirtualAccountId).Append("\n");
			sb.Append("  AutoSyncPeriod: ").Append(AutoSyncPeriod).Append("\n");
			sb.Append("  SyncResultStr: ").Append(SyncResultStr).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
