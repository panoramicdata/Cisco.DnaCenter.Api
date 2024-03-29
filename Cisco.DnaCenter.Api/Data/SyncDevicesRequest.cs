using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// SyncDevicesRequest
/// </summary>
[DataContract]
public class SyncDevicesRequest : List<Object>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SyncDevicesRequest" /> class.
	/// </summary>
	[JsonConstructor]
	public SyncDevicesRequest()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SyncDevicesRequest {\n");
		sb.Append("}\n");
		return sb.ToString();
	}
}
