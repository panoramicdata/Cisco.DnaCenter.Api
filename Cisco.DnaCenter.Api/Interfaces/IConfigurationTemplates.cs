using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConfigurationTemplates
	{
		/// <summary>
		/// Create Project
		/// </summary>
		/// <remarks>
		/// Creates a new project
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/project")]
		Task<TaskIdResult> CreateProjectAsync(
			[Body]ProjectDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Template
		/// </summary>
		/// <remarks>
		/// Creates a new template
		/// </remarks>
		/// <param name="request">request</param>
		/// <param name="projectId">projectId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/project/{projectId}/template")]
		Task<TaskIdResult> CreateTemplateAsync(
			[Body]TemplateDto request,
			string Content_Type,
			[AliasAs("projectId")]string projectId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Project
		/// </summary>
		/// <remarks>
		/// Deletes an existing Project
		/// </remarks>
		/// <param name="projectId">projectId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/template-programmer/project/{projectId}")]
		Task<TaskIdResult> DeleteProjectAsync(
			[AliasAs("projectId")]string projectId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Template
		/// </summary>
		/// <remarks>
		/// Deletes an existing template
		/// </remarks>
		/// <param name="templateId">templateId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/template-programmer/template/{templateId}")]
		Task<TaskIdResult> DeleteTemplateAsync(
			[AliasAs("templateId")]string templateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Deploy Template
		/// </summary>
		/// <remarks>
		/// Deploys a template
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TemplateDeploymentStatusDto</returns>
		[Post("/dna/intent/api/v1/template-programmer/template/deploy")]
		Task<TemplateDeploymentStatusDto> DeployTemplateAsync(
			[Body]TemplateDeploymentInfo request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Projects
		/// </summary>
		/// <remarks>
		/// Returns the projects in the system
		/// </remarks>
		/// <param name="name">Name of project to be searched (optional)</param>
		/// <returns>Task of CollectionProjectDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/project")]
		Task<CollectionProjectDto> GetProjectsAsync(
			[AliasAs("name")]string name = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Template deployment status
		/// </summary>
		/// <remarks>
		/// Returns the status of a deployed template.
		/// </remarks>
		/// <param name="deploymentId">deploymentId</param>
		/// <returns>Task of TemplateDeploymentStatusDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/deploy/status/{deploymentId}")]
		Task<TemplateDeploymentStatusDto> GetTemplateDeploymentStatusAsync(
			[AliasAs("deploymentId")]string deploymentId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Template Details
		/// </summary>
		/// <remarks>
		/// Returns details of the specified template
		/// </remarks>
		/// <param name="templateId">templateId</param>
		/// <param name="latestVersion">latestVersion (optional)</param>
		/// <returns>Task of TemplateDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/{templateId}")]
		Task<TemplateDto> GetTemplateDetailsAsync(
			[AliasAs("templateId")]string templateId,
			[AliasAs("latestVersion")]bool? latestVersion = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Template Versions
		/// </summary>
		/// <remarks>
		/// Returns the versions of a specified template
		/// </remarks>
		/// <param name="templateId">templateId</param>
		/// <returns>Task of CollectionTemplateInfo</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/version/{templateId}")]
		Task<CollectionTemplateInfo> GetTemplateVersionsAsync(
			[AliasAs("templateId")]string templateId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Gets the templates available
		/// </summary>
		/// <remarks>
		/// List the templates available
		/// </remarks>
		/// <param name="projectId">projectId (optional)</param>
		/// <param name="softwareType">softwareType (optional)</param>
		/// <param name="softwareVersion">softwareVersion (optional)</param>
		/// <param name="productFamily">productFamily (optional)</param>
		/// <param name="productSeries">productSeries (optional)</param>
		/// <param name="productType">productType (optional)</param>
		/// <param name="filterConflictingTemplates">filterConflictingTemplates (optional)</param>
		/// <returns>Task of CollectionTemplateInfo</returns>
		[Get("/dna/intent/api/v1/template-programmer/template")]
		Task<CollectionTemplateInfo> GetsAvailableTemplatesAsync(
			[AliasAs("projectId")]string projectId = null,
			[AliasAs("softwareType")]string softwareType = null,
			[AliasAs("softwareVersion")]string softwareVersion = null,
			[AliasAs("productFamily")]string productFamily = null,
			[AliasAs("productSeries")]string productSeries = null,
			[AliasAs("productType")]string productType = null,
			[AliasAs("filterConflictingTemplates")]bool? filterConflictingTemplates = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Preview Template
		/// </summary>
		/// <remarks>
		/// Previews an existing template
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TemplatePreviewResponseDto</returns>
		[Put("/dna/intent/api/v1/template-programmer/template/preview")]
		Task<TemplatePreviewResponseDto> PreviewTemplate(
			[Body]TemplatePreviewRequestDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Project
		/// </summary>
		/// <remarks>
		/// Updates an existing project
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/template-programmer/project")]
		Task<TaskIdResult> UpdateProjectAsync([Body]ProjectDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Template
		/// </summary>
		/// <remarks>
		/// Updates an existing template
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/template-programmer/template")]
		Task<TaskIdResult> UpdateTemplateAsync([Body]TemplateDto request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Version Template
		/// </summary>
		/// <remarks>
		/// Creates Versioning for the current contents of the template
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/template/version")]
		Task<TaskIdResult> VersionTemplateAsync([Body]TemplateVersionRequestDto request,
			CancellationToken cancellationToken = default);
	}
}
