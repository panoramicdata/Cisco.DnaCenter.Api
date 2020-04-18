using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// EditApplicationRequestInnerApplicationSet
	/// </summary>
	[DataContract]
	public class EditApplicationRequestInnerApplicationSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EditApplicationRequestInnerApplicationSet" /> class.
		/// </summary>
		/// <param name="IdRef">IdRef.</param>
		public EditApplicationRequestInnerApplicationSet(string? IdRef = default)
		{
			this.IdRef = IdRef;
		}

		/// <summary>
		/// Gets or Sets IdRef
		/// </summary>
		[DataMember(Name = "idRef", EmitDefaultValue = false)]
		public string? IdRef { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EditApplicationRequestInnerApplicationSet {\n");
			sb.Append("  IdRef: ").Append(IdRef).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
