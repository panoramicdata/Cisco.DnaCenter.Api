using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDtoSelection
	/// </summary>
	[DataContract]
	public class TemplateDtoSelection
	{
		/// <summary>
		/// Gets or Sets SelectionType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SelectionTypeEnum
		{

			/// <summary>
			/// Enum SINGLESELECT for "SINGLE_SELECT"
			/// </summary>
			[EnumMember(Value = "SINGLE_SELECT")]
			SINGLESELECT,

			/// <summary>
			/// Enum MULTISELECT for "MULTI_SELECT"
			/// </summary>
			[EnumMember(Value = "MULTI_SELECT")]
			MULTISELECT
		}

		/// <summary>
		/// Gets or Sets SelectionType
		/// </summary>
		[DataMember(Name = "selectionType", EmitDefaultValue = false)]
		public SelectionTypeEnum? SelectionType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDtoSelection" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="SelectionType">SelectionType.</param>
		/// <param name="SelectionValues">SelectionValues.</param>
		public TemplateDtoSelection(string? Id = default, SelectionTypeEnum? SelectionType = default, Object SelectionValues = default)
		{
			this.Id = Id;
			this.SelectionType = SelectionType;
			this.SelectionValues = SelectionValues;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets SelectionValues
		/// </summary>
		[DataMember(Name = "selectionValues", EmitDefaultValue = false)]
		public Object SelectionValues { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDtoSelection {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SelectionType: ").Append(SelectionType).Append("\n");
			sb.Append("  SelectionValues: ").Append(SelectionValues).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
