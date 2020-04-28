using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDtoRollbackTemplateParams
	/// </summary>
	[DataContract]
	public class TemplateDtoRollbackTemplateParams
	{
		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DataTypeEnum
		{

			/// <summary>
			/// Enum STRING for "STRING"
			/// </summary>
			[EnumMember(Value = "STRING")]
			STRING,

			/// <summary>
			/// Enum INTEGER for "INTEGER"
			/// </summary>
			[EnumMember(Value = "INTEGER")]
			INTEGER,

			/// <summary>
			/// Enum IPADDRESS for "IPADDRESS"
			/// </summary>
			[EnumMember(Value = "IPADDRESS")]
			IPADDRESS,

			/// <summary>
			/// Enum MACADDRESS for "MACADDRESS"
			/// </summary>
			[EnumMember(Value = "MACADDRESS")]
			MACADDRESS,

			/// <summary>
			/// Enum SECTIONDIVIDER for "SECTIONDIVIDER"
			/// </summary>
			[EnumMember(Value = "SECTIONDIVIDER")]
			SECTIONDIVIDER
		}

		/// <summary>
		/// Gets or Sets DataType
		/// </summary>
		[DataMember(Name = "dataType", EmitDefaultValue = false)]
		public DataTypeEnum? DataType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDtoRollbackTemplateParams" /> class.
		/// </summary>
		/// <param name="Binding">Binding.</param>
		/// <param name="DataType">DataType.</param>
		/// <param name="DefaultValue">DefaultValue.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="Group">Group.</param>
		/// <param name="Id">Id.</param>
		/// <param name="InstructionText">InstructionText.</param>
		/// <param name="Key">Key.</param>
		/// <param name="NotParam">NotParam.</param>
		/// <param name="Order">Order.</param>
		/// <param name="ParamArray">ParamArray.</param>
		/// <param name="ParameterName">ParameterName.</param>
		/// <param name="Provider">Provider.</param>
		/// <param name="Range">Range.</param>
		/// <param name="Required">Required.</param>
		/// <param name="Selection">Selection.</param>
		public TemplateDtoRollbackTemplateParams(string? Binding = default, DataTypeEnum? DataType = default, string? DefaultValue = default, string? Description = default, string? DisplayName = default, string? Group = default, string? Id = default, string? InstructionText = default, string? Key = default, bool? NotParam = default, int? Order = default, bool? ParamArray = default, string? ParameterName = default, string? Provider = default, List<TemplateDtoRange> Range = default, bool? Required = default, TemplateDtoSelection Selection = default)
		{
			this.Binding = Binding;
			this.DataType = DataType;
			this.DefaultValue = DefaultValue;
			this.Description = Description;
			this.DisplayName = DisplayName;
			this.Group = Group;
			this.Id = Id;
			this.InstructionText = InstructionText;
			this.Key = Key;
			this.NotParam = NotParam;
			this.Order = Order;
			this.ParamArray = ParamArray;
			this.ParameterName = ParameterName;
			this.Provider = Provider;
			this.Range = Range;
			this.Required = Required;
			this.Selection = Selection;
		}

		/// <summary>
		/// Gets or Sets Binding
		/// </summary>
		[DataMember(Name = "binding", EmitDefaultValue = false)]
		public string? Binding { get; set; }

		/// <summary>
		/// Gets or Sets DefaultValue
		/// </summary>
		[DataMember(Name = "defaultValue", EmitDefaultValue = false)]
		public string? DefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string? Description { get; set; }

		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string? DisplayName { get; set; }

		/// <summary>
		/// Gets or Sets Group
		/// </summary>
		[DataMember(Name = "group", EmitDefaultValue = false)]
		public string? Group { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets InstructionText
		/// </summary>
		[DataMember(Name = "instructionText", EmitDefaultValue = false)]
		public string? InstructionText { get; set; }

		/// <summary>
		/// Gets or Sets Key
		/// </summary>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string? Key { get; set; }

		/// <summary>
		/// Gets or Sets NotParam
		/// </summary>
		[DataMember(Name = "notParam", EmitDefaultValue = false)]
		public bool? NotParam { get; set; }

		/// <summary>
		/// Gets or Sets Order
		/// </summary>
		[DataMember(Name = "order", EmitDefaultValue = false)]
		public int? Order { get; set; }

		/// <summary>
		/// Gets or Sets ParamArray
		/// </summary>
		[DataMember(Name = "paramArray", EmitDefaultValue = false)]
		public bool? ParamArray { get; set; }

		/// <summary>
		/// Gets or Sets ParameterName
		/// </summary>
		[DataMember(Name = "parameterName", EmitDefaultValue = false)]
		public string? ParameterName { get; set; }

		/// <summary>
		/// Gets or Sets Provider
		/// </summary>
		[DataMember(Name = "provider", EmitDefaultValue = false)]
		public string? Provider { get; set; }

		/// <summary>
		/// Gets or Sets Range
		/// </summary>
		[DataMember(Name = "range", EmitDefaultValue = false)]
		public List<TemplateDtoRange> Range { get; set; }

		/// <summary>
		/// Gets or Sets Required
		/// </summary>
		[DataMember(Name = "required", EmitDefaultValue = false)]
		public bool? Required { get; set; }

		/// <summary>
		/// Gets or Sets Selection
		/// </summary>
		[DataMember(Name = "selection", EmitDefaultValue = false)]
		public TemplateDtoSelection Selection { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDtoRollbackTemplateParams {\n");
			sb.Append("  Binding: ").Append(Binding).Append("\n");
			sb.Append("  DataType: ").Append(DataType).Append("\n");
			sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  Group: ").Append(Group).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  InstructionText: ").Append(InstructionText).Append("\n");
			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  NotParam: ").Append(NotParam).Append("\n");
			sb.Append("  Order: ").Append(Order).Append("\n");
			sb.Append("  ParamArray: ").Append(ParamArray).Append("\n");
			sb.Append("  ParameterName: ").Append(ParameterName).Append("\n");
			sb.Append("  Provider: ").Append(Provider).Append("\n");
			sb.Append("  Range: ").Append(Range).Append("\n");
			sb.Append("  Required: ").Append(Required).Append("\n");
			sb.Append("  Selection: ").Append(Selection).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
