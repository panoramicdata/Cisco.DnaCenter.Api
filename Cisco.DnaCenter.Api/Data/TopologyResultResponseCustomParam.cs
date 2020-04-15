using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TopologyResultResponseCustomParam
	/// </summary>
	[DataContract]
	public partial class TopologyResultResponseCustomParam
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TopologyResultResponseCustomParam" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Label">Label.</param>
		/// <param name="ParentNodeId">ParentNodeId.</param>
		/// <param name="X">X.</param>
		/// <param name="Y">Y.</param>
		public TopologyResultResponseCustomParam(string? Id = default, string? Label = default, string? ParentNodeId = default, int? X = default, int? Y = default)
		{
			this.Id = Id;
			this.Label = Label;
			this.ParentNodeId = ParentNodeId;
			this.X = X;
			this.Y = Y;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public string? Label { get; set; }
		/// <summary>
		/// Gets or Sets ParentNodeId
		/// </summary>
		[DataMember(Name = "parentNodeId", EmitDefaultValue = false)]
		public string? ParentNodeId { get; set; }
		/// <summary>
		/// Gets or Sets X
		/// </summary>
		[DataMember(Name = "x", EmitDefaultValue = false)]
		public int? X { get; set; }
		/// <summary>
		/// Gets or Sets Y
		/// </summary>
		[DataMember(Name = "y", EmitDefaultValue = false)]
		public int? Y { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TopologyResultResponseCustomParam {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  ParentNodeId: ").Append(ParentNodeId).Append("\n");
			sb.Append("  X: ").Append(X).Append("\n");
			sb.Append("  Y: ").Append(Y).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
