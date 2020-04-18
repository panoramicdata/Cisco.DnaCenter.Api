using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// Listentrystringliststring
	/// </summary>
	[DataContract]
	public class Listentrystringliststring
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Listentrystringliststring" /> class.
		/// </summary>
		[JsonConstructor]
		public Listentrystringliststring()
		{
		}

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Listentrystringliststring {\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
