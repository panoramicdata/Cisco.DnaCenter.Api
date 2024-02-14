using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// ImportDevicesInBulkResponse
/// </summary>
[DataContract]
public class ImportDevicesInBulkResponse
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ImportDevicesInBulkResponse" /> class.
	/// </summary>
	/// <param name="SuccessList">SuccessList.</param>
	/// <param name="FailureList">FailureList.</param>
	public ImportDevicesInBulkResponse(List<ImportDevicesInBulkResponseSuccessList> SuccessList = default, List<ImportDevicesInBulkResponseFailureList> FailureList = default)
	{
		this.SuccessList = SuccessList;
		this.FailureList = FailureList;
	}

	/// <summary>
	/// Gets or Sets SuccessList
	/// </summary>
	[DataMember(Name = "successList", EmitDefaultValue = false)]
	public List<ImportDevicesInBulkResponseSuccessList> SuccessList { get; set; }

	/// <summary>
	/// Gets or Sets FailureList
	/// </summary>
	[DataMember(Name = "failureList", EmitDefaultValue = false)]
	public List<ImportDevicesInBulkResponseFailureList> FailureList { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ImportDevicesInBulkResponse {\n");
		sb.Append("  SuccessList: ").Append(SuccessList).Append("\n");
		sb.Append("  FailureList: ").Append(FailureList).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
