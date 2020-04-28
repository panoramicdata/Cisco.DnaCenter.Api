using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetApplicationSetsResponseIdentitySource
	/// </summary>
	[DataContract]
	public class GetApplicationSetsResponseIdentitySource
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetApplicationSetsResponseIdentitySource" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Type">Type.</param>
		public GetApplicationSetsResponseIdentitySource(string? Id = default, string? Type = default)
		{
			this.Id = Id;
			this.Type = Type;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetApplicationSetsResponseIdentitySource {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
