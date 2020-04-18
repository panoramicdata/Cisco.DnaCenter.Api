using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetApplicationSetsResponseResponse
	/// </summary>
	[DataContract]
	public class GetApplicationSetsResponseResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetApplicationSetsResponseResponse" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IdentitySource">IdentitySource.</param>
		/// <param name="Name">Name.</param>
		public GetApplicationSetsResponseResponse(string? Id = default, GetApplicationSetsResponseIdentitySource IdentitySource = default, string? Name = default)
		{
			this.Id = Id;
			this.IdentitySource = IdentitySource;
			this.Name = Name;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets IdentitySource
		/// </summary>
		[DataMember(Name = "identitySource", EmitDefaultValue = false)]
		public GetApplicationSetsResponseIdentitySource IdentitySource { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetApplicationSetsResponseResponse {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  IdentitySource: ").Append(IdentitySource).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
