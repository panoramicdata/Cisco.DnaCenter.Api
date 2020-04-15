using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// CollectionProjectDto
	/// </summary>
	[DataContract]
	public partial class CollectionProjectDto : List<CollectionProjectDtoInner>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionProjectDto" /> class.
		/// </summary>
		[JsonConstructor]
		public CollectionProjectDto()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CollectionProjectDto {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
