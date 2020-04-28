using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// InventoryDeviceInfoUpdateMgmtIPaddressList
	/// </summary>
	[DataContract]
	public class InventoryDeviceInfoUpdateManagementIpAddressList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryDeviceInfoUpdateManagementIpAddressList" /> class.
		/// </summary>
		/// <param name="ExistMgmtIpAddress">ExistMgmtIpAddress.</param>
		/// <param name="NewMgmtIpAddress">NewMgmtIpAddress.</param>
		public InventoryDeviceInfoUpdateManagementIpAddressList(string? ExistMgmtIpAddress = default, string? NewMgmtIpAddress = default)
		{
			this.ExistMgmtIpAddress = ExistMgmtIpAddress;
			this.NewMgmtIpAddress = NewMgmtIpAddress;
		}

		/// <summary>
		/// Gets or Sets ExistMgmtIpAddress
		/// </summary>
		[DataMember(Name = "existMgmtIpAddress", EmitDefaultValue = false)]
		public string? ExistMgmtIpAddress { get; set; }

		/// <summary>
		/// Gets or Sets NewMgmtIpAddress
		/// </summary>
		[DataMember(Name = "newMgmtIpAddress", EmitDefaultValue = false)]
		public string? NewMgmtIpAddress { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InventoryDeviceInfoUpdateMgmtIPaddressList {\n");
			sb.Append("  ExistMgmtIpAddress: ").Append(ExistMgmtIpAddress).Append("\n");
			sb.Append("  NewMgmtIpAddress: ").Append(NewMgmtIpAddress).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
