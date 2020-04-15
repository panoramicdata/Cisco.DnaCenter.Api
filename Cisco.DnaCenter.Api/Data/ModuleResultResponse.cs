using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ModuleResultResponse
	/// </summary>
	[DataContract]
	public partial class ModuleResultResponse
	{
		/// <summary>
		/// Gets or Sets IsFieldReplaceable
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum IsFieldReplaceableEnum
		{

			/// <summary>
			/// Enum UNKNOWN for "UNKNOWN"
			/// </summary>
			[EnumMember(Value = "UNKNOWN")]
			UNKNOWN,

			/// <summary>
			/// Enum TRUE for "TRUE"
			/// </summary>
			[EnumMember(Value = "TRUE")]
			TRUE,

			/// <summary>
			/// Enum FALSE for "FALSE"
			/// </summary>
			[EnumMember(Value = "FALSE")]
			FALSE,

			/// <summary>
			/// Enum NOTAPPLICABLE for "NOT_APPLICABLE"
			/// </summary>
			[EnumMember(Value = "NOT_APPLICABLE")]
			NOTAPPLICABLE
		}

		/// <summary>
		/// Gets or Sets IsReportingAlarmsAllowed
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum IsReportingAlarmsAllowedEnum
		{

			/// <summary>
			/// Enum UNKNOWN for "UNKNOWN"
			/// </summary>
			[EnumMember(Value = "UNKNOWN")]
			UNKNOWN,

			/// <summary>
			/// Enum TRUE for "TRUE"
			/// </summary>
			[EnumMember(Value = "TRUE")]
			TRUE,

			/// <summary>
			/// Enum FALSE for "FALSE"
			/// </summary>
			[EnumMember(Value = "FALSE")]
			FALSE,

			/// <summary>
			/// Enum NOTAPPLICABLE for "NOT_APPLICABLE"
			/// </summary>
			[EnumMember(Value = "NOT_APPLICABLE")]
			NOTAPPLICABLE
		}

		/// <summary>
		/// Gets or Sets IsFieldReplaceable
		/// </summary>
		[DataMember(Name = "isFieldReplaceable", EmitDefaultValue = false)]
		public IsFieldReplaceableEnum? IsFieldReplaceable { get; set; }
		/// <summary>
		/// Gets or Sets IsReportingAlarmsAllowed
		/// </summary>
		[DataMember(Name = "isReportingAlarmsAllowed", EmitDefaultValue = false)]
		public IsReportingAlarmsAllowedEnum? IsReportingAlarmsAllowed { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ModuleResultResponse" /> class.
		/// </summary>
		/// <param name="AssemblyNumber">AssemblyNumber.</param>
		/// <param name="AssemblyRevision">AssemblyRevision.</param>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="ContainmentEntity">ContainmentEntity.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EntityPhysicalIndex">EntityPhysicalIndex.</param>
		/// <param name="Id">Id.</param>
		/// <param name="IsFieldReplaceable">IsFieldReplaceable.</param>
		/// <param name="IsReportingAlarmsAllowed">IsReportingAlarmsAllowed.</param>
		/// <param name="Manufacturer">Manufacturer.</param>
		/// <param name="ModuleIndex">ModuleIndex.</param>
		/// <param name="Name">Name.</param>
		/// <param name="OperationalStateCode">OperationalStateCode.</param>
		/// <param name="PartNumber">PartNumber.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="VendorEquipmentType">VendorEquipmentType.</param>
		public ModuleResultResponse(string? AssemblyNumber = default, string? AssemblyRevision = default, Object AttributeInfo = default, string? ContainmentEntity = default, string? Description = default, string? EntityPhysicalIndex = default, string? Id = default, IsFieldReplaceableEnum? IsFieldReplaceable = default, IsReportingAlarmsAllowedEnum? IsReportingAlarmsAllowed = default, string? Manufacturer = default, int? ModuleIndex = default, string? Name = default, string? OperationalStateCode = default, string? PartNumber = default, string? SerialNumber = default, string? VendorEquipmentType = default)
		{
			this.AssemblyNumber = AssemblyNumber;
			this.AssemblyRevision = AssemblyRevision;
			this.AttributeInfo = AttributeInfo;
			this.ContainmentEntity = ContainmentEntity;
			this.Description = Description;
			this.EntityPhysicalIndex = EntityPhysicalIndex;
			this.Id = Id;
			this.IsFieldReplaceable = IsFieldReplaceable;
			this.IsReportingAlarmsAllowed = IsReportingAlarmsAllowed;
			this.Manufacturer = Manufacturer;
			this.ModuleIndex = ModuleIndex;
			this.Name = Name;
			this.OperationalStateCode = OperationalStateCode;
			this.PartNumber = PartNumber;
			this.SerialNumber = SerialNumber;
			this.VendorEquipmentType = VendorEquipmentType;
		}

		/// <summary>
		/// Gets or Sets AssemblyNumber
		/// </summary>
		[DataMember(Name = "assemblyNumber", EmitDefaultValue = false)]
		public string? AssemblyNumber { get; set; }
		/// <summary>
		/// Gets or Sets AssemblyRevision
		/// </summary>
		[DataMember(Name = "assemblyRevision", EmitDefaultValue = false)]
		public string? AssemblyRevision { get; set; }
		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets ContainmentEntity
		/// </summary>
		[DataMember(Name = "containmentEntity", EmitDefaultValue = false)]
		public string? ContainmentEntity { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or Sets EntityPhysicalIndex
		/// </summary>
		[DataMember(Name = "entityPhysicalIndex", EmitDefaultValue = false)]
		public string? EntityPhysicalIndex { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Manufacturer
		/// </summary>
		[DataMember(Name = "manufacturer", EmitDefaultValue = false)]
		public string? Manufacturer { get; set; }
		/// <summary>
		/// Gets or Sets ModuleIndex
		/// </summary>
		[DataMember(Name = "moduleIndex", EmitDefaultValue = false)]
		public int? ModuleIndex { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets OperationalStateCode
		/// </summary>
		[DataMember(Name = "operationalStateCode", EmitDefaultValue = false)]
		public string? OperationalStateCode { get; set; }
		/// <summary>
		/// Gets or Sets PartNumber
		/// </summary>
		[DataMember(Name = "partNumber", EmitDefaultValue = false)]
		public string? PartNumber { get; set; }
		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
		public string? SerialNumber { get; set; }
		/// <summary>
		/// Gets or Sets VendorEquipmentType
		/// </summary>
		[DataMember(Name = "vendorEquipmentType", EmitDefaultValue = false)]
		public string? VendorEquipmentType { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ModuleResultResponse {\n");
			sb.Append("  AssemblyNumber: ").Append(AssemblyNumber).Append("\n");
			sb.Append("  AssemblyRevision: ").Append(AssemblyRevision).Append("\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  ContainmentEntity: ").Append(ContainmentEntity).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  EntityPhysicalIndex: ").Append(EntityPhysicalIndex).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IsFieldReplaceable: ").Append(IsFieldReplaceable).Append("\n");
			sb.Append("  IsReportingAlarmsAllowed: ").Append(IsReportingAlarmsAllowed).Append("\n");
			sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
			sb.Append("  ModuleIndex: ").Append(ModuleIndex).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  OperationalStateCode: ").Append(OperationalStateCode).Append("\n");
			sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
			sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
			sb.Append("  VendorEquipmentType: ").Append(VendorEquipmentType).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
