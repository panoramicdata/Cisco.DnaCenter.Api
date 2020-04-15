using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// FunctionalCapabilityListResultResponse
	/// </summary>
	[DataContract]
	public partial class FunctionalCapabilityListResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FunctionalCapabilityListResultResponse" /> class.
		/// </summary>
		/// <param name="AttributeInfo">AttributeInfo.</param>
		/// <param name="DeviceId">DeviceId.</param>
		/// <param name="FunctionalCapability">FunctionalCapability.</param>
		/// <param name="Id">Id.</param>
		public FunctionalCapabilityListResultResponse(Object AttributeInfo = default, string? DeviceId = default, List<FunctionalCapabilityResultResponse> FunctionalCapability = default, string? Id = default)
		{
			this.AttributeInfo = AttributeInfo;
			this.DeviceId = DeviceId;
			this.FunctionalCapability = FunctionalCapability;
			this.Id = Id;
		}

		/// <summary>
		/// Gets or Sets AttributeInfo
		/// </summary>
		[DataMember(Name = "attributeInfo", EmitDefaultValue = false)]
		public Object AttributeInfo { get; set; }
		/// <summary>
		/// Gets or Sets DeviceId
		/// </summary>
		[DataMember(Name = "deviceId", EmitDefaultValue = false)]
		public string? DeviceId { get; set; }
		/// <summary>
		/// Gets or Sets FunctionalCapability
		/// </summary>
		[DataMember(Name = "functionalCapability", EmitDefaultValue = false)]
		public List<FunctionalCapabilityResultResponse> FunctionalCapability { get; set; }
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
			sb.Append("class FunctionalCapabilityListResultResponse {\n");
			sb.Append("  AttributeInfo: ").Append(AttributeInfo).Append("\n");
			sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
			sb.Append("  FunctionalCapability: ").Append(FunctionalCapability).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
