using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceHistoryTaskInfo
	/// </summary>
	[DataContract]
	public partial class DeviceHistoryTaskInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceHistoryTaskInfo" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="WorkItemList">WorkItemList.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		/// <param name="AddnDetails">AddnDetails.</param>
		/// <param name="Name">Name.</param>
		public DeviceHistoryTaskInfo(string? Type = default, List<DeviceSystemResetWorkflowWorkItemList> WorkItemList = default, decimal? TimeTaken = default, List<DeviceDeviceInfoHttpHeaders> AddnDetails = default, string? Name = default)
		{
			this.Type = Type;
			this.WorkItemList = WorkItemList;
			this.TimeTaken = TimeTaken;
			this.AddnDetails = AddnDetails;
			this.Name = Name;
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets WorkItemList
		/// </summary>
		[DataMember(Name = "workItemList", EmitDefaultValue = false)]
		public List<DeviceSystemResetWorkflowWorkItemList> WorkItemList { get; set; }
		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public decimal? TimeTaken { get; set; }
		/// <summary>
		/// Gets or Sets AddnDetails
		/// </summary>
		[DataMember(Name = "addnDetails", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoHttpHeaders> AddnDetails { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceHistoryTaskInfo {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  WorkItemList: ").Append(WorkItemList).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("  AddnDetails: ").Append(AddnDetails).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
