using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AuthenticationAPIResponse
	/// </summary>
	[DataContract]
	public partial class AuthenticationAPIResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationAPIResponse" /> class.
		/// </summary>
		/// <param name="Token">Token.</param>
		public AuthenticationAPIResponse(string? Token = default)
		{
			this.Token = Token;
		}

		/// <summary>
		/// Gets or Sets Token
		/// </summary>
		[DataMember(Name = "Token", EmitDefaultValue = false)]
		public string? Token { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuthenticationAPIResponse {\n");
			sb.Append("  Token: ").Append(Token).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
