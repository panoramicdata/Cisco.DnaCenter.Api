using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetGlobalPoolResponseContext
	/// </summary>
	[DataContract]
	public class GetGlobalPoolResponseContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetGlobalPoolResponseContext" /> class.
		/// </summary>
		/// <param name="Owner">Owner.</param>
		/// <param name="ContextKey">ContextKey.</param>
		/// <param name="ContextValue">ContextValue.</param>
		public GetGlobalPoolResponseContext(string? Owner = default, string? ContextKey = default, string? ContextValue = default)
		{
			this.Owner = Owner;
			this.ContextKey = ContextKey;
			this.ContextValue = ContextValue;
		}

		/// <summary>
		/// Gets or Sets Owner
		/// </summary>
		[DataMember(Name = "owner", EmitDefaultValue = false)]
		public string? Owner { get; set; }
		/// <summary>
		/// Gets or Sets ContextKey
		/// </summary>
		[DataMember(Name = "contextKey", EmitDefaultValue = false)]
		public string? ContextKey { get; set; }
		/// <summary>
		/// Gets or Sets ContextValue
		/// </summary>
		[DataMember(Name = "contextValue", EmitDefaultValue = false)]
		public string? ContextValue { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetGlobalPoolResponseContext {\n");
			sb.Append("  Owner: ").Append(Owner).Append("\n");
			sb.Append("  ContextKey: ").Append(ContextKey).Append("\n");
			sb.Append("  ContextValue: ").Append(ContextValue).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
