using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TemplateDtoRange
	/// </summary>
	[DataContract]
	public class TemplateDtoRange
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TemplateDtoRange" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="MaxValue">MaxValue.</param>
		/// <param name="MinValue">MinValue.</param>
		public TemplateDtoRange(string? Id = default, int? MaxValue = default, int? MinValue = default)
		{
			this.Id = Id;
			this.MaxValue = MaxValue;
			this.MinValue = MinValue;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets MaxValue
		/// </summary>
		[DataMember(Name = "maxValue", EmitDefaultValue = false)]
		public int? MaxValue { get; set; }
		/// <summary>
		/// Gets or Sets MinValue
		/// </summary>
		[DataMember(Name = "minValue", EmitDefaultValue = false)]
		public int? MinValue { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TemplateDtoRange {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
			sb.Append("  MinValue: ").Append(MinValue).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
