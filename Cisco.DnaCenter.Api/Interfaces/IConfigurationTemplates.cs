using Cisco.DnaCenter.Api.Data;
using Refit;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConfigurationTemplates
	{
		#region Asynchronous Operations

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
		System.Threading.Tasks.Task<TaskIdResult> CreateProject([Header("UserAgent")] string userAgent, [Body]ProjectDto request, string Content_Type);

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
		System.Threading.Tasks.Task<TaskIdResult> CreateTemplate([Header("UserAgent")] string userAgent, [Body]TemplateDto request, string Content_Type, [AliasAs("projectId")]string projectId);

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
		System.Threading.Tasks.Task<TaskIdResult> DeleteProject([Header("UserAgent")] string userAgent, [AliasAs("projectId")]string projectId);

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
		System.Threading.Tasks.Task<TaskIdResult> DeleteTemplate([Header("UserAgent")] string userAgent, [AliasAs("templateId")]string templateId);

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
		System.Threading.Tasks.Task<TemplateDeploymentStatusDto> DeployTemplate([Header("UserAgent")] string userAgent, [Body]TemplateDeploymentInfo request, string Content_Type);

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
		System.Threading.Tasks.Task<CollectionProjectDto> GetProjects([Header("UserAgent")] string userAgent, [AliasAs("name")]string name = null);

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
		System.Threading.Tasks.Task<TemplateDeploymentStatusDto> GetTemplateDeploymentStatus([Header("UserAgent")] string userAgent, [AliasAs("deploymentId")]string deploymentId);

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
		System.Threading.Tasks.Task<TemplateDto> GetTemplateDetails([Header("UserAgent")] string userAgent, [AliasAs("templateId")]string templateId, [AliasAs("latestVersion")]bool? latestVersion = null);

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
		System.Threading.Tasks.Task<CollectionTemplateInfo> GetTemplateVersions([Header("UserAgent")] string userAgent, [AliasAs("templateId")]string templateId);

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
		System.Threading.Tasks.Task<CollectionTemplateInfo> GetsTheTemplatesAvailable([Header("UserAgent")] string userAgent, [AliasAs("projectId")]string projectId = null, [AliasAs("softwareType")]string softwareType = null, [AliasAs("softwareVersion")]string softwareVersion = null, [AliasAs("productFamily")]string productFamily = null, [AliasAs("productSeries")]string productSeries = null, [AliasAs("productType")]string productType = null, [AliasAs("filterConflictingTemplates")]bool? filterConflictingTemplates = null);

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
		System.Threading.Tasks.Task<TemplatePreviewResponseDto> PreviewTemplate([Header("UserAgent")] string userAgent, [Body]TemplatePreviewRequestDto request, string Content_Type);

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
		System.Threading.Tasks.Task<TaskIdResult> UpdateProject([Header("UserAgent")] string userAgent, [Body]ProjectDto request, string Content_Type);

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
		System.Threading.Tasks.Task<TaskIdResult> UpdateTemplate([Header("UserAgent")] string userAgent, [Body]TemplateDto request, string Content_Type);

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
		System.Threading.Tasks.Task<TaskIdResult> VersionTemplate([Header("UserAgent")] string userAgent, [Body]TemplateVersionRequestDto request, string Content_Type);
		#endregion Asynchronous Operations
	}
}
