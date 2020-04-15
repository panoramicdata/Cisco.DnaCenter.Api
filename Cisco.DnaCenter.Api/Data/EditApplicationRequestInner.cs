using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// EditApplicationRequestInner
	/// </summary>
	[DataContract]
	public partial class EditApplicationRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EditApplicationRequestInner" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="NetworkApplications">NetworkApplications.</param>
		/// <param name="NetworkIdentity">NetworkIdentity.</param>
		/// <param name="ApplicationSet">ApplicationSet.</param>
		public EditApplicationRequestInner(string? Id = default, string? Name = default, List<EditApplicationRequestInnerNetworkApplications> NetworkApplications = default, List<EditApplicationRequestInnerNetworkIdentity> NetworkIdentity = default, EditApplicationRequestInnerApplicationSet ApplicationSet = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.NetworkApplications = NetworkApplications;
			this.NetworkIdentity = NetworkIdentity;
			this.ApplicationSet = ApplicationSet;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string? Id { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets NetworkApplications
		/// </summary>
		[DataMember(Name = "networkApplications", EmitDefaultValue = false)]
		public List<EditApplicationRequestInnerNetworkApplications> NetworkApplications { get; set; }
		/// <summary>
		/// Gets or Sets NetworkIdentity
		/// </summary>
		[DataMember(Name = "networkIdentity", EmitDefaultValue = false)]
		public List<EditApplicationRequestInnerNetworkIdentity> NetworkIdentity { get; set; }
		/// <summary>
		/// Gets or Sets ApplicationSet
		/// </summary>
		[DataMember(Name = "applicationSet", EmitDefaultValue = false)]
		public EditApplicationRequestInnerApplicationSet ApplicationSet { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EditApplicationRequestInner {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  NetworkApplications: ").Append(NetworkApplications).Append("\n");
			sb.Append("  NetworkIdentity: ").Append(NetworkIdentity).Append("\n");
			sb.Append("  ApplicationSet: ").Append(ApplicationSet).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
