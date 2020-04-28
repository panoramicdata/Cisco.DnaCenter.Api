using System.Text;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// TagMembersResultResponse
	/// </summary>
	[DataContract]
	public class TagMembersResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TagMembersResultResponse" /> class.
		/// </summary>
		/// <param name="InstanceUuid">InstanceUuid.</param>
		public TagMembersResultResponse(string? InstanceUuid = default)
		{
			this.InstanceUuid = InstanceUuid;
		}

		/// <summary>
		/// Gets or Sets InstanceUuid
		/// </summary>
		[DataMember(Name = "instanceUuid", EmitDefaultValue = false)]
		public string? InstanceUuid { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TagMembersResultResponse {\n");
			sb.Append("  InstanceUuid: ").Append(InstanceUuid).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
