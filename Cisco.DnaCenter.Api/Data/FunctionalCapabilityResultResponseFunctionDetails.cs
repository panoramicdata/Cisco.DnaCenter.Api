using System;
using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// FunctionalCapabilityResultResponseFunctionDetails
	/// </summary>
	[DataContract]
	public class FunctionalCapabilityResultResponseFunctionDetails
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FunctionalCapabilityResultResponseFunctionDetails" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="Id">Id.</param>
		/// <param name="PropertyName">PropertyName.</param>
		/// <param name="StringValue">StringValue.</param>
		public FunctionalCapabilityResultResponseFunctionDetails(Object AttributeInfo = default, string? Id = default, string? PropertyName = default, string? StringValue = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.Id = Id;
			this.PropertyName = PropertyName;
			this.StringValue = StringValue;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets PropertyName
		/// </summary>
		[DataMember(Name = "propertyName", EmitDefaultValue = false)]
		public string? PropertyName { get; set; }

		/// <summary>
		/// Gets or Sets StringValue
		/// </summary>
		[DataMember(Name = "stringValue", EmitDefaultValue = false)]
		public string? StringValue { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FunctionalCapabilityResultResponseFunctionDetails {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
			sb.Append("  StringValue: ").Append(StringValue).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
