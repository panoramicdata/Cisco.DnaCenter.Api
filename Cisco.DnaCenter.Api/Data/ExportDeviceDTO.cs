using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ExportDeviceDto
	/// </summary>
	[DataContract]
	public class ExportDeviceDto
	{
		/// <summary>
		/// Gets or Sets OperationEnum
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum OperationEnumEnum
		{

			/// <summary>
			/// Enum CREDENTIALDETAILS for "CREDENTIALDETAILS"
			/// </summary>
			[EnumMember(Value = "CREDENTIALDETAILS")]
			CREDENTIALDETAILS,

			/// <summary>
			/// Enum DEVICEDETAILS for "DEVICEDETAILS"
			/// </summary>
			[EnumMember(Value = "DEVICEDETAILS")]
			DEVICEDETAILS
		}

		/// <summary>
		/// Gets or Sets OperationEnum
		/// </summary>
		[DataMember(Name = "operationEnum", EmitDefaultValue = false)]
		public OperationEnumEnum? OperationEnum { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ExportDeviceDto" /> class.
		/// </summary>
		/// <param name="DeviceUuids">DeviceUuids.</param>
		/// <param name="Id">Id.</param>
		/// <param name="OperationEnum">OperationEnum.</param>
		/// <param name="Parameters">Parameters.</param>
		/// <param name="Password">Password.</param>
		public ExportDeviceDto(List<string> DeviceUuids = default, string? Id = default, OperationEnumEnum? OperationEnum = default, List<string> Parameters = default, string? Password = default)
		{
			this.DeviceUuids = DeviceUuids;
			this.Id = Id;
			this.OperationEnum = OperationEnum;
			this.Parameters = Parameters;
			this.Password = Password;
		}

		/// <summary>
		/// Gets or Sets DeviceUuids
		/// </summary>
		[DataMember(Name = "deviceUuids", EmitDefaultValue = false)]
		public List<string> DeviceUuids { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets Parameters
		/// </summary>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public List<string> Parameters { get; set; }

		/// <summary>
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "password", EmitDefaultValue = false)]
		public string? Password { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExportDeviceDto {\n");
			sb.Append("  DeviceUuids: ").Append(DeviceUuids).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  OperationEnum: ").Append(OperationEnum).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
