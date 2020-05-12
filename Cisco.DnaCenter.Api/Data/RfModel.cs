using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cisco.DnaCenter.Api.Data
{
	/// <summary>
	/// Gets or Sets RfModel
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RfModel
	{

		/// <summary>
		/// Enum CubesAndWalledOffices for "Cubes And Walled Offices"
		/// </summary>
		[EnumMember(Value = "Cubes And Walled Offices")]
		CubesAndWalledOffices,

		/// <summary>
		/// Enum DrywallOfficeOnly for "Drywall Office Only"
		/// </summary>
		[EnumMember(Value = "Drywall Office Only")]
		DrywallOfficeOnly,

		/// <summary>
		/// Enum IndoorHighCeiling for "Indoor High Ceiling"
		/// </summary>
		[EnumMember(Value = "Indoor High Ceiling")]
		IndoorHighCeiling,

		/// <summary>
		/// Enum OutdoorOpenSpace for "Outdoor Open Space"
		/// </summary>
		[EnumMember(Value = "Outdoor Open Space")]
		OutdoorOpenSpace
	}
}
