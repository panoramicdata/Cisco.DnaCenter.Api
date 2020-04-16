using Cisco.DnaCenter.Api.Data;
using Refit;
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
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/project")]
		Task<TaskIdResult> CreateProject([Body]ProjectDto request, string Content_Type);

		/// <summary>
		/// Create Template
		/// </summary>
		/// <remarks>
		/// Creates a new template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <param name="projectId">projectId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/project/{projectId}/template")]
		Task<TaskIdResult> CreateTemplate([Body]TemplateDto request, string Content_Type, [AliasAs("projectId")]string projectId);

		/// <summary>
		/// Delete Project
		/// </summary>
		/// <remarks>
		/// Deletes an existing Project
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="projectId">projectId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/template-programmer/project/{projectId}")]
		Task<TaskIdResult> DeleteProject([AliasAs("projectId")]string projectId);

		/// <summary>
		/// Delete Template
		/// </summary>
		/// <remarks>
		/// Deletes an existing template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="templateId">templateId</param>
		/// <returns>Task of TaskIdResult</returns>
		[Delete("/dna/intent/api/v1/template-programmer/template/{templateId}")]
		Task<TaskIdResult> DeleteTemplate([AliasAs("templateId")]string templateId);

		/// <summary>
		/// Deploy Template
		/// </summary>
		/// <remarks>
		/// Deploys a template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TemplateDeploymentStatusDto</returns>
		[Post("/dna/intent/api/v1/template-programmer/template/deploy")]
		Task<TemplateDeploymentStatusDto> DeployTemplate([Body]TemplateDeploymentInfo request, string Content_Type);

		/// <summary>
		/// Get Projects
		/// </summary>
		/// <remarks>
		/// Returns the projects in the system
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">Name of project to be searched (optional)</param>
		/// <returns>Task of CollectionProjectDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/project")]
		Task<CollectionProjectDto> GetProjects([AliasAs("name")]string name = null);

		/// <summary>
		/// Get Template deployment status
		/// </summary>
		/// <remarks>
		/// Returns the status of a deployed template.
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="deploymentId">deploymentId</param>
		/// <returns>Task of TemplateDeploymentStatusDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/deploy/status/{deploymentId}")]
		Task<TemplateDeploymentStatusDto> GetTemplateDeploymentStatus([AliasAs("deploymentId")]string deploymentId);

		/// <summary>
		/// Get Template Details
		/// </summary>
		/// <remarks>
		/// Returns details of the specified template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="templateId">templateId</param>
		/// <param name="latestVersion">latestVersion (optional)</param>
		/// <returns>Task of TemplateDto</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/{templateId}")]
		Task<TemplateDto> GetTemplateDetails([AliasAs("templateId")]string templateId, [AliasAs("latestVersion")]bool? latestVersion = null);

		/// <summary>
		/// Get Template Versions
		/// </summary>
		/// <remarks>
		/// Returns the versions of a specified template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="templateId">templateId</param>
		/// <returns>Task of CollectionTemplateInfo</returns>
		[Get("/dna/intent/api/v1/template-programmer/template/version/{templateId}")]
		Task<CollectionTemplateInfo> GetTemplateVersions([AliasAs("templateId")]string templateId);

		/// <summary>
		/// Gets the templates available
		/// </summary>
		/// <remarks>
		/// List the templates available
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="projectId">projectId (optional)</param>
		/// <param name="softwareType">softwareType (optional)</param>
		/// <param name="softwareVersion">softwareVersion (optional)</param>
		/// <param name="productFamily">productFamily (optional)</param>
		/// <param name="productSeries">productSeries (optional)</param>
		/// <param name="productType">productType (optional)</param>
		/// <param name="filterConflictingTemplates">filterConflictingTemplates (optional)</param>
		/// <returns>Task of CollectionTemplateInfo</returns>
		[Get("/dna/intent/api/v1/template-programmer/template")]
		Task<CollectionTemplateInfo> GetsTheTemplatesAvailable([AliasAs("projectId")]string projectId = null, [AliasAs("softwareType")]string softwareType = null, [AliasAs("softwareVersion")]string softwareVersion = null, [AliasAs("productFamily")]string productFamily = null, [AliasAs("productSeries")]string productSeries = null, [AliasAs("productType")]string productType = null, [AliasAs("filterConflictingTemplates")]bool? filterConflictingTemplates = null);

		/// <summary>
		/// Preview Template
		/// </summary>
		/// <remarks>
		/// Previews an existing template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TemplatePreviewResponseDto</returns>
		[Put("/dna/intent/api/v1/template-programmer/template/preview")]
		Task<TemplatePreviewResponseDto> PreviewTemplate([Body]TemplatePreviewRequestDto request, string Content_Type);

		/// <summary>
		/// Update Project
		/// </summary>
		/// <remarks>
		/// Updates an existing project
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/template-programmer/project")]
		Task<TaskIdResult> UpdateProject([Body]ProjectDto request, string Content_Type);

		/// <summary>
		/// Update Template
		/// </summary>
		/// <remarks>
		/// Updates an existing template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Put("/dna/intent/api/v1/template-programmer/template")]
		Task<TaskIdResult> UpdateTemplate([Body]TemplateDto request, string Content_Type);

		/// <summary>
		/// Version Template
		/// </summary>
		/// <remarks>
		/// Creates Versioning for the current contents of the template
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Request body content type</param>
		/// <returns>Task of TaskIdResult</returns>
		[Post("/dna/intent/api/v1/template-programmer/template/version")]
		Task<TaskIdResult> VersionTemplate([Body]TemplateVersionRequestDto request, string Content_Type);
	}
}
