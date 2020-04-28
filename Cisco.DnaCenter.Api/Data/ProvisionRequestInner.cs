using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionRequestInner
	/// </summary>
	[DataContract]
	public class ProvisionRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionRequestInner" /> class.
		/// </summary>
		/// <param name="DeviceName">DeviceName.</param>
		/// <param name="Site">Site.</param>
		/// <param name="ManagedAPLocations">ManagedAPLocations.</param>
		/// <param name="DynamicInterfaces">DynamicInterfaces.</param>
		public ProvisionRequestInner(string? DeviceName = default, string? Site = default, List<string> ManagedAPLocations = default, List<ProvisionRequestInnerDynamicInterfaces> DynamicInterfaces = default)
		{
			this.DeviceName = DeviceName;
			this.Site = Site;
			this.ManagedAPLocations = ManagedAPLocations;
			this.DynamicInterfaces = DynamicInterfaces;
		}

		/// <summary>
		/// Gets or Sets DeviceName
		/// </summary>
		[DataMember(Name = "deviceName", EmitDefaultValue = false)]
		public string? DeviceName { get; set; }

		/// <summary>
		/// Gets or Sets Site
		/// </summary>
		[DataMember(Name = "site", EmitDefaultValue = false)]
		public string? Site { get; set; }

		/// <summary>
		/// Gets or Sets ManagedAPLocations
		/// </summary>
		[DataMember(Name = "managedAPLocations", EmitDefaultValue = false)]
		public List<string> ManagedAPLocations { get; set; }

		/// <summary>
		/// Gets or Sets DynamicInterfaces
		/// </summary>
		[DataMember(Name = "dynamicInterfaces", EmitDefaultValue = false)]
		public List<ProvisionRequestInnerDynamicInterfaces> DynamicInterfaces { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionRequestInner {\n");
			sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
			sb.Append("  Site: ").Append(Site).Append("\n");
			sb.Append("  ManagedAPLocations: ").Append(ManagedAPLocations).Append("\n");
			sb.Append("  DynamicInterfaces: ").Append(DynamicInterfaces).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
