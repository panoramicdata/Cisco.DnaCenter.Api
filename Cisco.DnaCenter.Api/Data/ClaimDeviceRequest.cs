using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ClaimDeviceRequest
	/// </summary>
	[DataContract]
	public partial class ClaimDeviceRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimDeviceRequest" /> class.
		/// </summary>
		/// <param name="ConfigFileUrl">ConfigFileUrl.</param>
		/// <param name="ConfigId">ConfigId.</param>
		/// <param name="DeviceClaimList">DeviceClaimList.</param>
		/// <param name="FileServiceId">FileServiceId.</param>
		/// <param name="ImageId">ImageId.</param>
		/// <param name="ImageUrl">ImageUrl.</param>
		/// <param name="PopulateInventory">PopulateInventory.</param>
		/// <param name="ProjectId">ProjectId.</param>
		/// <param name="WorkflowId">WorkflowId.</param>
		public ClaimDeviceRequest(string? ConfigFileUrl = default, string? ConfigId = default, List<ResetRequestDeviceResetList> DeviceClaimList = default, string? FileServiceId = default, string? ImageId = default, string? ImageUrl = default, bool? PopulateInventory = default, string? ProjectId = default, string? WorkflowId = default)
		{
			this.ConfigFileUrl = ConfigFileUrl;
			this.ConfigId = ConfigId;
			this.DeviceClaimList = DeviceClaimList;
			this.FileServiceId = FileServiceId;
			this.ImageId = ImageId;
			this.ImageUrl = ImageUrl;
			this.PopulateInventory = PopulateInventory;
			this.ProjectId = ProjectId;
			this.WorkflowId = WorkflowId;
		}

		/// <summary>
		/// Gets or Sets ConfigFileUrl
		/// </summary>
		[DataMember(Name = "configFileUrl", EmitDefaultValue = false)]
		public string? ConfigFileUrl { get; set; }
		/// <summary>
		/// Gets or Sets ConfigId
		/// </summary>
		[DataMember(Name = "configId", EmitDefaultValue = false)]
		public string? ConfigId { get; set; }
		/// <summary>
		/// Gets or Sets DeviceClaimList
		/// </summary>
		[DataMember(Name = "deviceClaimList", EmitDefaultValue = false)]
		public List<ResetRequestDeviceResetList> DeviceClaimList { get; set; }
		/// <summary>
		/// Gets or Sets FileServiceId
		/// </summary>
		[DataMember(Name = "fileServiceId", EmitDefaultValue = false)]
		public string? FileServiceId { get; set; }
		/// <summary>
		/// Gets or Sets ImageId
		/// </summary>
		[DataMember(Name = "imageId", EmitDefaultValue = false)]
		public string? ImageId { get; set; }
		/// <summary>
		/// Gets or Sets ImageUrl
		/// </summary>
		[DataMember(Name = "imageUrl", EmitDefaultValue = false)]
		public string? ImageUrl { get; set; }
		/// <summary>
		/// Gets or Sets PopulateInventory
		/// </summary>
		[DataMember(Name = "populateInventory", EmitDefaultValue = false)]
		public bool? PopulateInventory { get; set; }
		/// <summary>
		/// Gets or Sets ProjectId
		/// </summary>
		[DataMember(Name = "projectId", EmitDefaultValue = false)]
		public string? ProjectId { get; set; }
		/// <summary>
		/// Gets or Sets WorkflowId
		/// </summary>
		[DataMember(Name = "workflowId", EmitDefaultValue = false)]
		public string? WorkflowId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ClaimDeviceRequest {\n");
			sb.Append("  ConfigFileUrl: ").Append(ConfigFileUrl).Append("\n");
			sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
			sb.Append("  DeviceClaimList: ").Append(DeviceClaimList).Append("\n");
			sb.Append("  FileServiceId: ").Append(FileServiceId).Append("\n");
			sb.Append("  ImageId: ").Append(ImageId).Append("\n");
			sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
			sb.Append("  PopulateInventory: ").Append(PopulateInventory).Append("\n");
			sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
			sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
