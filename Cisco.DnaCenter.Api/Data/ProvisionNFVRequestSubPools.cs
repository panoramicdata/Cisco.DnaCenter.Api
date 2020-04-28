using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// ProvisionNFVRequestSubPools
	/// </summary>
	[DataContract]
	public class ProvisionNFVRequestSubPools
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Lan for "Lan"
			/// </summary>
			[EnumMember(Value = "Lan")]
			Lan,

			/// <summary>
			/// Enum Management for "Management"
			/// </summary>
			[EnumMember(Value = "Management")]
			Management,

			/// <summary>
			/// Enum Service for "Service"
			/// </summary>
			[EnumMember(Value = "Service")]
			Service,

			/// <summary>
			/// Enum Wan for "Wan"
			/// </summary>
			[EnumMember(Value = "Wan")]
			Wan,

			/// <summary>
			/// Enum Generic for "Generic"
			/// </summary>
			[EnumMember(Value = "Generic")]
			Generic
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ProvisionNFVRequestSubPools" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Name">Name.</param>
		/// <param name="IpSubnet">IpSubnet.</param>
		/// <param name="Gateway">Gateway.</param>
		/// <param name="ParentPoolName">ParentPoolName.</param>
		public ProvisionNFVRequestSubPools(TypeEnum? Type = default, string? Name = default, string? IpSubnet = default, string? Gateway = default, string? ParentPoolName = default)
		{
			this.Type = Type;
			this.Name = Name;
			this.IpSubnet = IpSubnet;
			this.Gateway = Gateway;
			this.ParentPoolName = ParentPoolName;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets IpSubnet
		/// </summary>
		[DataMember(Name = "ipSubnet", EmitDefaultValue = false)]
		public string? IpSubnet { get; set; }

		/// <summary>
		/// Gets or Sets Gateway
		/// </summary>
		[DataMember(Name = "gateway", EmitDefaultValue = false)]
		public string? Gateway { get; set; }

		/// <summary>
		/// Gets or Sets ParentPoolName
		/// </summary>
		[DataMember(Name = "parentPoolName", EmitDefaultValue = false)]
		public string? ParentPoolName { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProvisionNFVRequestSubPools {\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  IpSubnet: ").Append(IpSubnet).Append("\n");
			sb.Append("  Gateway: ").Append(Gateway).Append("\n");
			sb.Append("  ParentPoolName: ").Append(ParentPoolName).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
