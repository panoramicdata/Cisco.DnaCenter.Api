using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// AddFabricRequestInner
	/// </summary>
	[DataContract]
	public class AddFabricRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddFabricRequestInner" /> class.
		/// </summary>
		/// <param name="FabricName">FabricName.</param>

		public AddFabricRequestInner() : this(default) { }

		public AddFabricRequestInner(string? FabricName)
		{
			this.FabricName = FabricName;
		}

		/// <summary>
		/// Gets or Sets FabricName
		/// </summary>
		[DataMember(Name = "fabricName", EmitDefaultValue = false)]
		public string? FabricName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddFabricRequestInner {\n");
			sb.Append("  FabricName: ").Append(FabricName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
