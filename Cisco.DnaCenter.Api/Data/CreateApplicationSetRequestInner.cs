using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateApplicationSetRequestInner
	/// </summary>
	[DataContract]
	public class CreateApplicationSetRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateApplicationSetRequestInner" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		public CreateApplicationSetRequestInner(string? Name = default)
		{
			this.Name = Name;
		}

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
			sb.Append("class CreateApplicationSetRequestInner {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
