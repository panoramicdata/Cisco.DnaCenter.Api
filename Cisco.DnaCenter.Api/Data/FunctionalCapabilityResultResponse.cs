using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// FunctionalCapabilityResultResponse
	/// </summary>
	[DataContract]
	public class FunctionalCapabilityResultResponse
	{
		/// <summary>
		/// Gets or Sets FunctionOpState
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FunctionOpStateEnum
		{

			/// <summary>
			/// Enum UNKNOWN for "UNKNOWN"
			/// </summary>
			[EnumMember(Value = "UNKNOWN")]
			UNKNOWN,

			/// <summary>
			/// Enum NOTAPPLICABLE for "NOT_APPLICABLE"
			/// </summary>
			[EnumMember(Value = "NOT_APPLICABLE")]
			NOTAPPLICABLE,

			/// <summary>
			/// Enum DISABLED for "DISABLED"
			/// </summary>
			[EnumMember(Value = "DISABLED")]
			DISABLED,

			/// <summary>
			/// Enum ENABLED for "ENABLED"
			/// </summary>
			[EnumMember(Value = "ENABLED")]
			ENABLED
		}

		/// <summary>
		/// Gets or Sets FunctionOpState
		/// </summary>
		[DataMember(Name = "functionOpState", EmitDefaultValue = false)]
		public FunctionOpStateEnum? FunctionOpState { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FunctionalCapabilityResultResponse" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="FunctionDetails">FunctionDetails.</param>
		/// <param name="FunctionName">FunctionName.</param>
		/// <param name="FunctionOpState">FunctionOpState.</param>
		/// <param name="Id">Id.</param>
		public FunctionalCapabilityResultResponse(Object AttributeInfo = default, List<FunctionalCapabilityResultResponseFunctionDetails> FunctionDetails = default, string? FunctionName = default, FunctionOpStateEnum? FunctionOpState = default, string? Id = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.FunctionDetails = FunctionDetails;
			this.FunctionName = FunctionName;
			this.FunctionOpState = FunctionOpState;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets FunctionDetails
		/// </summary>
		[DataMember(Name = "functionDetails", EmitDefaultValue = false)]
		public List<FunctionalCapabilityResultResponseFunctionDetails> FunctionDetails { get; set; }
		/// <summary>
		/// Gets or Sets FunctionName
		/// </summary>
		[DataMember(Name = "functionName", EmitDefaultValue = false)]
		public string? FunctionName { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FunctionalCapabilityResultResponse {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  FunctionDetails: ").Append(FunctionDetails).Append("\n");
			sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
			sb.Append("  FunctionOpState: ").Append(FunctionOpState).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
