using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDeploymentInfoTargetInfo
	/// </summary>
	[DataContract]
	public class TemplateDeploymentInfoTargetInfo
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum MANAGEDDEVICEIP for "MANAGED_DEVICE_IP"
			/// </summary>
			[EnumMember(Value = "MANAGED_DEVICE_IP")]
			MANAGEDDEVICEIP,

			/// <summary>
			/// Enum MANAGEDDEVICEUUID for "MANAGED_DEVICE_UUID"
			/// </summary>
			[EnumMember(Value = "MANAGED_DEVICE_UUID")]
			MANAGEDDEVICEUUID,

			/// <summary>
			/// Enum PREPROVISIONEDSERIAL for "PRE_PROVISIONED_SERIAL"
			/// </summary>
			[EnumMember(Value = "PRE_PROVISIONED_SERIAL")]
			PREPROVISIONEDSERIAL,

			/// <summary>
			/// Enum PREPROVISIONEDMAC for "PRE_PROVISIONED_MAC"
			/// </summary>
			[EnumMember(Value = "PRE_PROVISIONED_MAC")]
			PREPROVISIONEDMAC,

			/// <summary>
			/// Enum DEFAULT for "DEFAULT"
			/// </summary>
			[EnumMember(Value = "DEFAULT")]
			DEFAULT,

			/// <summary>
			/// Enum MANAGEDDEVICEHOSTNAME for "MANAGED_DEVICE_HOSTNAME"
			/// </summary>
			[EnumMember(Value = "MANAGED_DEVICE_HOSTNAME")]
			MANAGEDDEVICEHOSTNAME
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDeploymentInfoTargetInfo" /> class.
		/// </summary>
		/// <param name="HostName">HostName.</param>
		/// <param name="Id">Id.</param>
		/// <param name="_Params">_Params.</param>
		/// <param name="Type">Type.</param>
		public TemplateDeploymentInfoTargetInfo(string? HostName = default, string? Id = default, Object _Params = default, TypeEnum? Type = default)
		{
			this.HostName = HostName;
			this.Id = Id;
			this._Params = _Params;
			this.Type = Type;
		}

		/// <summary>
		/// Gets or Sets HostName
		/// </summary>
		[DataMember(Name = "hostName", EmitDefaultValue = false)]
		public string? HostName { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets _Params
		/// </summary>
		[DataMember(Name = "params", EmitDefaultValue = false)]
		public Object _Params { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDeploymentInfoTargetInfo {\n");
			sb.Append("  HostName: ").Append(HostName).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  _Params: ").Append(_Params).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
