using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ImportDevicesInBulkResponseFailureList
	/// </summary>
	[DataContract]
	public class ImportDevicesInBulkResponseFailureList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImportDevicesInBulkResponseFailureList" /> class.
		/// </summary>
		/// <param name="Index">Index.</param>
		/// <param name="SerialNum">SerialNum.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Msg">Msg.</param>
		public ImportDevicesInBulkResponseFailureList(decimal? Index = default, string? SerialNum = default, string? Id = default, string? Msg = default)
		{
			this.Index = Index;
			this.SerialNum = SerialNum;
			this.Id = Id;
			this.Msg = Msg;
		}

		/// <summary>
		/// Gets or Sets Index
		/// </summary>
		[DataMember(Name = "index", EmitDefaultValue = false)]
		public decimal? Index { get; set; }
		/// <summary>
		/// Gets or Sets SerialNum
		/// </summary>
		[DataMember(Name = "serialNum", EmitDefaultValue = false)]
		public string? SerialNum { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Msg
		/// </summary>
		[DataMember(Name = "msg", EmitDefaultValue = false)]
		public string? Msg { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ImportDevicesInBulkResponseFailureList {\n");
			sb.Append("  Index: ").Append(Index).Append("\n");
			sb.Append("  SerialNum: ").Append(SerialNum).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Msg: ").Append(Msg).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
