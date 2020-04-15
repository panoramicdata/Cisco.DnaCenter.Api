using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// DeviceDeviceInfoFileSystemList
	/// </summary>
	[DataContract]
	public partial class DeviceDeviceInfoFileSystemList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceDeviceInfoFileSystemList" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Writeable">Writeable.</param>
		/// <param name="Freespace">Freespace.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Readable">Readable.</param>
		/// <param name="Size">Size.</param>
		public DeviceDeviceInfoFileSystemList(string? Type = default, bool? Writeable = default, decimal? Freespace = default, string? Name = default, bool? Readable = default, decimal? Size = default)
		{
			this.Type = Type;
			this.Writeable = Writeable;
			this.Freespace = Freespace;
			this.Name = Name;
			this.Readable = Readable;
			this.Size = Size;
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string? Type { get; set; }
		/// <summary>
		/// Gets or Sets Writeable
		/// </summary>
		[DataMember(Name = "writeable", EmitDefaultValue = false)]
		public bool? Writeable { get; set; }
		/// <summary>
		/// Gets or Sets Freespace
		/// </summary>
		[DataMember(Name = "freespace", EmitDefaultValue = false)]
		public decimal? Freespace { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets Readable
		/// </summary>
		[DataMember(Name = "readable", EmitDefaultValue = false)]
		public bool? Readable { get; set; }
		/// <summary>
		/// Gets or Sets Size
		/// </summary>
		[DataMember(Name = "size", EmitDefaultValue = false)]
		public decimal? Size { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDeviceInfoFileSystemList {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Writeable: ").Append(Writeable).Append("\n");
			sb.Append("  Freespace: ").Append(Freespace).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Readable: ").Append(Readable).Append("\n");
			sb.Append("  Size: ").Append(Size).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
