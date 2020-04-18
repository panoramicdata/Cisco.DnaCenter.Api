using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetSyncResultForVirtualAccountResponse
	/// </summary>
	[DataContract]
	public class GetSyncResultForVirtualAccountResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetSyncResultForVirtualAccountResponse" /> class.
		/// </summary>
		/// <param name="VirtualAccountId">VirtualAccountId.</param>
		/// <param name="AutoSyncPeriod">AutoSyncPeriod.</param>
		/// <param name="SyncResultStr">SyncResultStr.</param>
		/// <param name="Profile">Profile.</param>
		/// <param name="CcoUser">CcoUser.</param>
		/// <param name="SyncResult">SyncResult.</param>
		/// <param name="Token">Token.</param>
		/// <param name="SyncStartTime">SyncStartTime.</param>
		/// <param name="LastSync">LastSync.</param>
		/// <param name="TenantId">TenantId.</param>
		/// <param name="SmartAccountId">SmartAccountId.</param>
		/// <param name="Expiry">Expiry.</param>
		/// <param name="SyncStatus">SyncStatus.</param>
		public GetSyncResultForVirtualAccountResponse(string? VirtualAccountId = default, decimal? AutoSyncPeriod = default, string? SyncResultStr = default, GetSyncResultForVirtualAccountResponseProfile Profile = default, string? CcoUser = default, GetSyncResultForVirtualAccountResponseSyncResult SyncResult = default, string? Token = default, decimal? SyncStartTime = default, decimal? LastSync = default, string? TenantId = default, string? SmartAccountId = default, decimal? Expiry = default, string? SyncStatus = default)
		{
			this.VirtualAccountId = VirtualAccountId;
			this.AutoSyncPeriod = AutoSyncPeriod;
			this.SyncResultStr = SyncResultStr;
			this.Profile = Profile;
			this.CcoUser = CcoUser;
			this.SyncResult = SyncResult;
			this.Token = Token;
			this.SyncStartTime = SyncStartTime;
			this.LastSync = LastSync;
			this.TenantId = TenantId;
			this.SmartAccountId = SmartAccountId;
			this.Expiry = Expiry;
			this.SyncStatus = SyncStatus;
		}

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
		/// Gets or Sets Profile
		/// </summary>
		[DataMember(Name = "profile", EmitDefaultValue = false)]
		public GetSyncResultForVirtualAccountResponseProfile Profile { get; set; }
		/// <summary>
		/// Gets or Sets CcoUser
		/// </summary>
		[DataMember(Name = "ccoUser", EmitDefaultValue = false)]
		public string? CcoUser { get; set; }
		/// <summary>
		/// Gets or Sets SyncResult
		/// </summary>
		[DataMember(Name = "syncResult", EmitDefaultValue = false)]
		public GetSyncResultForVirtualAccountResponseSyncResult SyncResult { get; set; }
		/// <summary>
		/// Gets or Sets Token
		/// </summary>
		[DataMember(Name = "token", EmitDefaultValue = false)]
		public string? Token { get; set; }
		/// <summary>
		/// Gets or Sets SyncStartTime
		/// </summary>
		[DataMember(Name = "syncStartTime", EmitDefaultValue = false)]
		public decimal? SyncStartTime { get; set; }
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
		/// Gets or Sets SmartAccountId
		/// </summary>
		[DataMember(Name = "smartAccountId", EmitDefaultValue = false)]
		public string? SmartAccountId { get; set; }
		/// <summary>
		/// Gets or Sets Expiry
		/// </summary>
		[DataMember(Name = "expiry", EmitDefaultValue = false)]
		public decimal? Expiry { get; set; }
		/// <summary>
		/// Gets or Sets SyncStatus
		/// </summary>
		[DataMember(Name = "syncStatus", EmitDefaultValue = false)]
		public string? SyncStatus { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetSyncResultForVirtualAccountResponse {\n");
			sb.Append("  VirtualAccountId: ").Append(VirtualAccountId).Append("\n");
			sb.Append("  AutoSyncPeriod: ").Append(AutoSyncPeriod).Append("\n");
			sb.Append("  SyncResultStr: ").Append(SyncResultStr).Append("\n");
			sb.Append("  Profile: ").Append(Profile).Append("\n");
			sb.Append("  CcoUser: ").Append(CcoUser).Append("\n");
			sb.Append("  SyncResult: ").Append(SyncResult).Append("\n");
			sb.Append("  Token: ").Append(Token).Append("\n");
			sb.Append("  SyncStartTime: ").Append(SyncStartTime).Append("\n");
			sb.Append("  LastSync: ").Append(LastSync).Append("\n");
			sb.Append("  TenantId: ").Append(TenantId).Append("\n");
			sb.Append("  SmartAccountId: ").Append(SmartAccountId).Append("\n");
			sb.Append("  Expiry: ").Append(Expiry).Append("\n");
			sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
