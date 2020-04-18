using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// RawCliInfoNioListResultResponse
	/// </summary>
	[DataContract]
	public class RawCliInfoNioListResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RawCliInfoNioListResultResponse" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="CdpNeighbors">CdpNeighbors.</param>
		/// <param name="HealthMonitor">HealthMonitor.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IntfDescription">IntfDescription.</param>
		/// <param name="Inventory">Inventory.</param>
		/// <param name="IpIntfBrief">IpIntfBrief.</param>
		/// <param name="MacAddressTable">MacAddressTable.</param>
		/// <param name="RunningConfig">RunningConfig.</param>
		/// <param name="Snmp">Snmp.</param>
		/// <param name="_Version">_Version.</param>
		public RawCliInfoNioListResultResponse(Object AttributeInfo = default, string? CdpNeighbors = default, string? HealthMonitor = default, string? Id = default, string? IntfDescription = default, string? Inventory = default, string? IpIntfBrief = default, string? MacAddressTable = default, string? RunningConfig = default, string? Snmp = default, string? _Version = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.CdpNeighbors = CdpNeighbors;
			this.HealthMonitor = HealthMonitor;
			this.Id = Id;
			this.IntfDescription = IntfDescription;
			this.Inventory = Inventory;
			this.IpIntfBrief = IpIntfBrief;
			this.MacAddressTable = MacAddressTable;
			this.RunningConfig = RunningConfig;
			this.Snmp = Snmp;
			this._Version = _Version;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets CdpNeighbors
		/// </summary>
		[DataMember(Name = "cdpNeighbors", EmitDefaultValue = false)]
		public string? CdpNeighbors { get; set; }
		/// <summary>
		/// Gets or Sets HealthMonitor
		/// </summary>
		[DataMember(Name = "healthMonitor", EmitDefaultValue = false)]
		public string? HealthMonitor { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets IntfDescription
		/// </summary>
		[DataMember(Name = "intfDescription", EmitDefaultValue = false)]
		public string? IntfDescription { get; set; }
		/// <summary>
		/// Gets or Sets Inventory
		/// </summary>
		[DataMember(Name = "inventory", EmitDefaultValue = false)]
		public string? Inventory { get; set; }
		/// <summary>
		/// Gets or Sets IpIntfBrief
		/// </summary>
		[DataMember(Name = "ipIntfBrief", EmitDefaultValue = false)]
		public string? IpIntfBrief { get; set; }
		/// <summary>
		/// Gets or Sets MacAddressTable
		/// </summary>
		[DataMember(Name = "macAddressTable", EmitDefaultValue = false)]
		public string? MacAddressTable { get; set; }
		/// <summary>
		/// Gets or Sets RunningConfig
		/// </summary>
		[DataMember(Name = "runningConfig", EmitDefaultValue = false)]
		public string? RunningConfig { get; set; }
		/// <summary>
		/// Gets or Sets Snmp
		/// </summary>
		[DataMember(Name = "snmp", EmitDefaultValue = false)]
		public string? Snmp { get; set; }
		/// <summary>
		/// Gets or Sets _Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string? _Version { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RawCliInfoNioListResultResponse {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  CdpNeighbors: ").Append(CdpNeighbors).Append("\n");
			sb.Append("  HealthMonitor: ").Append(HealthMonitor).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IntfDescription: ").Append(IntfDescription).Append("\n");
			sb.Append("  Inventory: ").Append(Inventory).Append("\n");
			sb.Append("  IpIntfBrief: ").Append(IpIntfBrief).Append("\n");
			sb.Append("  MacAddressTable: ").Append(MacAddressTable).Append("\n");
			sb.Append("  RunningConfig: ").Append(RunningConfig).Append("\n");
			sb.Append("  Snmp: ").Append(Snmp).Append("\n");
			sb.Append("  _Version: ").Append(_Version).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
