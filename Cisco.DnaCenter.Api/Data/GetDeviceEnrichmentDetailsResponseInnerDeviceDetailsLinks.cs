using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks
	/// </summary>
	[DataContract]
	public class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks" /> class.
		/// </summary>
		/// <param name="Source">Source.</param>
		/// <param name="LinkStatus">LinkStatus.</param>
		/// <param name="Label">Label.</param>
		/// <param name="Target">Target.</param>
		/// <param name="Id">Id.</param>
		/// <param name="PortUtilization">PortUtilization.</param>
		public GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks(string? Source = default, string? LinkStatus = default, List<Object> Label = default, string? Target = default, Object Id = default, Object PortUtilization = default)
		{
			this.Source = Source;
			this.LinkStatus = LinkStatus;
			this.Label = Label;
			this.Target = Target;
			this.Id = Id;
			this.PortUtilization = PortUtilization;
		}

		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string? Source { get; set; }

		/// <summary>
		/// Gets or Sets LinkStatus
		/// </summary>
		[DataMember(Name = "linkStatus", EmitDefaultValue = false)]
		public string? LinkStatus { get; set; }

		/// <summary>
		/// Gets or Sets Label
		/// </summary>
		[DataMember(Name = "label", EmitDefaultValue = false)]
		public List<Object> Label { get; set; }

		/// <summary>
		/// Gets or Sets Target
		/// </summary>
		[DataMember(Name = "target", EmitDefaultValue = false)]
		public string? Target { get; set; }

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Object Id { get; set; }

		/// <summary>
		/// Gets or Sets PortUtilization
		/// </summary>
		[DataMember(Name = "portUtilization", EmitDefaultValue = false)]
		public Object PortUtilization { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GetDeviceEnrichmentDetailsResponseInnerDeviceDetailsLinks {\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  LinkStatus: ").Append(LinkStatus).Append("\n");
			sb.Append("  Label: ").Append(Label).Append("\n");
			sb.Append("  Target: ").Append(Target).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  PortUtilization: ").Append(PortUtilization).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
