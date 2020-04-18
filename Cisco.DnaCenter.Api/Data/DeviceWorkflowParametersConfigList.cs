using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceWorkflowParametersConfigList
	/// </summary>
	[DataContract]
	public class DeviceWorkflowParametersConfigList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceWorkflowParametersConfigList" /> class.
		/// </summary>
		/// <param name="ConfigParameters">ConfigParameters.</param>
		/// <param name="ConfigId">ConfigId.</param>
		public DeviceWorkflowParametersConfigList(List<DeviceDeviceInfoHttpHeaders> ConfigParameters = default, string? ConfigId = default)
		{
			this.ConfigParameters = ConfigParameters;
			this.ConfigId = ConfigId;
		}

		/// <summary>
		/// Gets or Sets ConfigParameters
		/// </summary>
		[DataMember(Name = "configParameters", EmitDefaultValue = false)]
		public List<DeviceDeviceInfoHttpHeaders> ConfigParameters { get; set; }
		/// <summary>
		/// Gets or Sets ConfigId
		/// </summary>
		[DataMember(Name = "configId", EmitDefaultValue = false)]
		public string? ConfigId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceWorkflowParametersConfigList {\n");
			sb.Append("  ConfigParameters: ").Append(ConfigParameters).Append("\n");
			sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
