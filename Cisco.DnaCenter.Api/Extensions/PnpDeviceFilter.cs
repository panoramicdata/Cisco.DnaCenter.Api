namespace Cisco.DnaCenter.Api.Extensions;

/// <summary>
/// Filter criteria for retrieving the PnP device list.
/// </summary>
public sealed class PnpDeviceFilter
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PnpDeviceFilter" /> class.
	/// </summary>
	public PnpDeviceFilter()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PnpDeviceFilter" /> class.
	/// </summary>
	/// <param name="sort">The fields to sort by.</param>
	/// <param name="sortOrder">The sort order, ascending or descending.</param>
	/// <param name="serialNumber">Serial numbers to filter by.</param>
	/// <param name="state">Device states to filter by.</param>
	/// <param name="onbState">Onboarding states to filter by.</param>
	/// <param name="cmState">Connection manager states to filter by.</param>
	/// <param name="name">Device names to filter by.</param>
	/// <param name="pid">Product IDs to filter by.</param>
	/// <param name="source">Device sources to filter by.</param>
	/// <param name="projectId">Project IDs to filter by.</param>
	/// <param name="workflowId">Workflow IDs to filter by.</param>
	/// <param name="projectName">Project names to filter by.</param>
	/// <param name="siteName">Site names to filter by.</param>
	/// <param name="workflowName">Workflow names to filter by.</param>
	/// <param name="smartAccountId">Smart account IDs to filter by.</param>
	/// <param name="virtualAccountId">Virtual account IDs to filter by.</param>
	/// <param name="lastContact">Whether to filter to devices with a last contact time.</param>
	public PnpDeviceFilter(
		List<string>? sort = null,
		string? sortOrder = null,
		List<string>? serialNumber = null,
		List<string>? state = null,
		List<string>? onbState = null,
		List<string>? cmState = null,
		List<string>? name = null,
		List<string>? pid = null,
		List<string>? source = null,
		List<string>? projectId = null,
		List<string>? workflowId = null,
		List<string>? projectName = null,
		List<string>? siteName = null,
		List<string>? workflowName = null,
		List<string>? smartAccountId = null,
		List<string>? virtualAccountId = null,
		bool? lastContact = null)
	{
		Sort = sort;
		SortOrder = sortOrder;
		SerialNumber = serialNumber;
		State = state;
		OnbState = onbState;
		CmState = cmState;
		Name = name;
		Pid = pid;
		Source = source;
		ProjectId = projectId;
		WorkflowId = workflowId;
		ProjectName = projectName;
		SiteName = siteName;
		WorkflowName = workflowName;
		SmartAccountId = smartAccountId;
		VirtualAccountId = virtualAccountId;
		LastContact = lastContact;
	}

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
