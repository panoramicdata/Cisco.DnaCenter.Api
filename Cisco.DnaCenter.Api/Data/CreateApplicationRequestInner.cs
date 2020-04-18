using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CreateApplicationRequestInner
	/// </summary>
	[DataContract]
	public class CreateApplicationRequestInner
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateApplicationRequestInner" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="NetworkApplications">NetworkApplications.</param>
		/// <param name="NetworkIdentity">NetworkIdentity.</param>
		/// <param name="ApplicationSet">ApplicationSet.</param>
		public CreateApplicationRequestInner(string? Name = default, List<CreateApplicationRequestInnerNetworkApplications> NetworkApplications = default, List<CreateApplicationRequestInnerNetworkIdentity> NetworkIdentity = default, EditApplicationRequestInnerApplicationSet ApplicationSet = default)
		{
			this.Name = Name;
			this.NetworkApplications = NetworkApplications;
			this.NetworkIdentity = NetworkIdentity;
			this.ApplicationSet = ApplicationSet;
		}

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets NetworkApplications
		/// </summary>
		[DataMember(Name = "networkApplications", EmitDefaultValue = false)]
		public List<CreateApplicationRequestInnerNetworkApplications> NetworkApplications { get; set; }
		/// <summary>
		/// Gets or Sets NetworkIdentity
		/// </summary>
		[DataMember(Name = "networkIdentity", EmitDefaultValue = false)]
		public List<CreateApplicationRequestInnerNetworkIdentity> NetworkIdentity { get; set; }
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
			sb.Append("class CreateApplicationRequestInner {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  NetworkApplications: ").Append(NetworkApplications).Append("\n");
			sb.Append("  NetworkIdentity: ").Append(NetworkIdentity).Append("\n");
			sb.Append("  ApplicationSet: ").Append(ApplicationSet).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
