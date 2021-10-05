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

		// Note: Insert these in the same order as in the DNA Center

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
		/// Enum FreeSpace for "Free Space"
		/// </summary>
		[EnumMember(Value = "Free Space")]
		FreeSpace,

		/// <summary>
		/// Enum IndoorHighCeiling for "Indoor High Ceiling"
		/// </summary>
		[EnumMember(Value = "Indoor High Ceiling")]
		IndoorHighCeiling,

		/// <summary>
		/// Enum OutdoorOpenSpace for "Outdoor Open Space"
		/// </summary>
		[EnumMember(Value = "Outdoor Open Space")]
		OutdoorOpenSpace,
	}
}
