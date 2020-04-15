using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceHistoryResponseHistoryTaskInfo
	/// </summary>
	[DataContract]
	public partial class GetDeviceHistoryResponseHistoryTaskInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceHistoryResponseHistoryTaskInfo" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Type">Type.</param>
		/// <param name="TimeTaken">TimeTaken.</param>
		/// <param name="WorkItemList">WorkItemList.</param>
		/// <param name="AddnDetails">AddnDetails.</param>
		public GetDeviceHistoryResponseHistoryTaskInfo(string? Name = default, string? Type = default, decimal? TimeTaken = default, List<GetDeviceHistoryResponseHistoryTaskInfoWorkItemList> WorkItemList = default, List<DeviceDeviceInfoHttpHeaders> AddnDetails = default)
		{
			this.Name = Name;
			this.Type = Type;
			this.TimeTaken = TimeTaken;
			this.WorkItemList = WorkItemList;
			this.AddnDetails = AddnDetails;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets TimeTaken
		/// </summary>
		[DataMember(Name = "timeTaken", EmitDefaultValue = false)]
		public decimal? TimeTaken { get; set; }
		/// <summary>
		/// Gets or Sets WorkItemList
		/// </summary>
		[DataMember(Name = "workItemList", EmitDefaultValue = false)]
		public List<GetDeviceHistoryResponseHistoryTaskInfoWorkItemList> WorkItemList { get; set; }
		/// <summary>
		/// Gets or Sets AddnDetails
		/// </summary>
		[DataMember(Name = "addnDetails", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoHttpHeaders> AddnDetails { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceHistoryResponseHistoryTaskInfo {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  TimeTaken: ").Append(TimeTaken).Append("\n");
			sb.Append("  WorkItemList: ").Append(WorkItemList).Append("\n");
			sb.Append("  AddnDetails: ").Append(AddnDetails).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
