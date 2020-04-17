using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetPortAssignmentForAccessPointInSdaFabricResponse
	/// </summary>
	[DataContract]
	public partial class GetPortAssignmentForAccessPointInSdaFabricResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetPortAssignmentForAccessPointInSdaFabricResponse" /> class.
		/// </summary>
		/// <param name="Status">Status.</param>
		/// <param name="Description">Description.</param>
		/// <param name="SiteNameHierarchy">SiteNameHierarchy.</param>
		/// <param name="DeviceManagementIpAddress">DeviceManagementIpAddress.</param>
		/// <param name="InterfaceName">InterfaceName.</param>
		/// <param name="DataIpAddressPoolName">DataIpAddressPoolName.</param>
		/// <param name="VoiceIpAddressPoolName">VoiceIpAddressPoolName.</param>
		/// <param name="ScalableGroupName">ScalableGroupName.</param>
		/// <param name="AuthenticateTemplateName">AuthenticateTemplateName.</param>
		public GetPortAssignmentForAccessPointInSdaFabricResponse(string? Status = default, string? Description = default, string? SiteNameHierarchy = default, string? DeviceManagementIpAddress = default, string? InterfaceName = default, string? DataIpAddressPoolName = default, string? VoiceIpAddressPoolName = default, string? ScalableGroupName = default, string? AuthenticateTemplateName = default)
		{
			this.Status = Status;
			this.Description = Description;
			this.SiteNameHierarchy = SiteNameHierarchy;
			this.DeviceManagementIpAddress = DeviceManagementIpAddress;
			this.InterfaceName = InterfaceName;
			this.DataIpAddressPoolName = DataIpAddressPoolName;
			this.VoiceIpAddressPoolName = VoiceIpAddressPoolName;
			this.ScalableGroupName = ScalableGroupName;
			this.AuthenticateTemplateName = AuthenticateTemplateName;
		}

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public string? Status { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets SiteNameHierarchy
		/// </summary>
		[DataMember(Name = "siteNameHierarchy", EmitDefaultValue = false)]
		public string? SiteNameHierarchy { get; set; }
		/// <summary>
		/// Gets or Sets DeviceManagementIpAddress
		/// </summary>
		[DataMember(Name = "deviceManagementIpAddress", EmitDefaultValue = false)]
		public string? DeviceManagementIpAddress { get; set; }
		/// <summary>
		/// Gets or Sets InterfaceName
		/// </summary>
		[DataMember(Name = "interfaceName", EmitDefaultValue = false)]
		public string? InterfaceName { get; set; }
		/// <summary>
		/// Gets or Sets DataIpAddressPoolName
		/// </summary>
		[DataMember(Name = "dataIpAddressPoolName", EmitDefaultValue = false)]
		public string? DataIpAddressPoolName { get; set; }
		/// <summary>
		/// Gets or Sets VoiceIpAddressPoolName
		/// </summary>
		[DataMember(Name = "voiceIpAddressPoolName", EmitDefaultValue = false)]
		public string? VoiceIpAddressPoolName { get; set; }
		/// <summary>
		/// Gets or Sets ScalableGroupName
		/// </summary>
		[DataMember(Name = "scalableGroupName", EmitDefaultValue = false)]
		public string? ScalableGroupName { get; set; }
		/// <summary>
		/// Gets or Sets AuthenticateTemplateName
		/// </summary>
		[DataMember(Name = "authenticateTemplateName", EmitDefaultValue = false)]
		public string? AuthenticateTemplateName { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetPortAssignmentForAccessPointInSdaFabricResponse {\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  SiteNameHierarchy: ").Append(SiteNameHierarchy).Append("\n");
			sb.Append("  DeviceManagementIpAddress: ").Append(DeviceManagementIpAddress).Append("\n");
			sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
			sb.Append("  DataIpAddressPoolName: ").Append(DataIpAddressPoolName).Append("\n");
			sb.Append("  VoiceIpAddressPoolName: ").Append(VoiceIpAddressPoolName).Append("\n");
			sb.Append("  ScalableGroupName: ").Append(ScalableGroupName).Append("\n");
			sb.Append("  AuthenticateTemplateName: ").Append(AuthenticateTemplateName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
