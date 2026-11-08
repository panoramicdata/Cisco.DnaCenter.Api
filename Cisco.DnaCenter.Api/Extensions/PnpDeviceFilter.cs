namespace Cisco.DnaCenter.Api.Extensions;

/// <summary>
/// Filter criteria for retrieving the PnP device list.
/// </summary>
public sealed class PnpDeviceFilter
{
	/// <summary>
	/// The fields to sort by.
	/// </summary>
	public List<string>? Sort { get; set; }

	/// <summary>
	/// The sort order, ascending or descending.
	/// </summary>
	public string? SortOrder { get; set; }

	/// <summary>
	/// Serial numbers to filter by.
	/// </summary>
	public List<string>? SerialNumber { get; set; }

	/// <summary>
	/// Device states to filter by.
	/// </summary>
	public List<string>? State { get; set; }

	/// <summary>
	/// Onboarding states to filter by.
	/// </summary>
	public List<string>? OnbState { get; set; }

	/// <summary>
	/// Connection manager states to filter by.
	/// </summary>
	public List<string>? CmState { get; set; }

	/// <summary>
	/// Device names to filter by.
	/// </summary>
	public List<string>? Name { get; set; }

	/// <summary>
	/// Product IDs to filter by.
	/// </summary>
	public List<string>? Pid { get; set; }

	/// <summary>
	/// Device sources to filter by.
	/// </summary>
	public List<string>? Source { get; set; }

	/// <summary>
	/// Project IDs to filter by.
	/// </summary>
	public List<string>? ProjectId { get; set; }

	/// <summary>
	/// Workflow IDs to filter by.
	/// </summary>
	public List<string>? WorkflowId { get; set; }

	/// <summary>
	/// Project names to filter by.
	/// </summary>
	public List<string>? ProjectName { get; set; }

	/// <summary>
	/// Site names to filter by.
	/// </summary>
	public List<string>? SiteName { get; set; }

	/// <summary>
	/// Workflow names to filter by.
	/// </summary>
	public List<string>? WorkflowName { get; set; }

	/// <summary>
	/// Smart account IDs to filter by.
	/// </summary>
	public List<string>? SmartAccountId { get; set; }

	/// <summary>
	/// Virtual account IDs to filter by.
	/// </summary>
	public List<string>? VirtualAccountId { get; set; }

	/// <summary>
	/// Whether to filter to devices with a last contact time.
	/// </summary>
	public bool? LastContact { get; set; }
}