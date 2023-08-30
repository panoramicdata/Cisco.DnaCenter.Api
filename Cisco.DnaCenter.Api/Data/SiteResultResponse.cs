namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// SiteResultResponse
	/// </summary>
	[DataContract]
	public class SiteResultResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SiteResultResponse" /> class.
		/// </summary>
		/// <param name="Sites">Sites.</param>
		public SiteResultResponse() : this(default) { }

		public SiteResultResponse(List<SiteResultResponseSites> Sites)
		{
			this.Sites = Sites;
		}

		/// <summary>
		/// Gets or Sets Sites
		/// </summary>
		[DataMember(Name = "sites", EmitDefaultValue = false)]
		public List<SiteResultResponseSites> Sites { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SiteResultResponse {\n");
			sb.Append("  Sites: ").Append(Sites).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
