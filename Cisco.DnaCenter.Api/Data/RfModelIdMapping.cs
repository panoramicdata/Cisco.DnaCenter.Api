namespace Cisco.DnaCenter.Api.Data;

/// <summary>
/// Maps an RF model to the identifier DNA Center uses for it.
/// </summary>
public class RfModelIdMapping
{
	/// <summary>
	/// The identifier DNA Center uses for this RF model.
	/// </summary>
	public long Id { get; set; }

	/// <summary>
	/// The RF model.
	/// </summary>
	public RfModel Name { get; set; }

	/// <summary>
	/// The status of the mapping.
	/// </summary>
	public int Status { get; set; }
}
