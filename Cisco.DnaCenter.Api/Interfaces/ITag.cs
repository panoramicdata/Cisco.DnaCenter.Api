using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITags
{
	/// <summary>
	/// Add members to the tag
	/// </summary>
	/// <remarks>
	/// Adds members to the tag specified by id
	/// </remarks>
	/// <param name="request">request</param>
	/// <param name="id">Tag ID</param>
	/// <returns>Task of TaskIdResult</returns>
	[Post("/dna/intent/api/v1/tag/{id}/member")]
	Task<TaskIdResult> AddMembersAsync(
		[Body]Listentrystringliststring request,
		string Content_Type,
		[AliasAs("id")]string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create Tag
	/// </summary>
	/// <remarks>
	/// Creates tag with specified tag attributes
	/// </remarks>
	/// <param name="request">request</param>
	/// <returns>Task of TaskIdResult</returns>
	[Post("/dna/intent/api/v1/tag")]
	Task<TaskIdResult> CreateAsync(
		[Body]TagDto request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete Tag
	/// </summary>
	/// <remarks>
	/// Deletes a tag specified by id
	/// </remarks>
	/// <param name="id">Tag ID</param>
	/// <returns>Task of TaskIdResult</returns>
	[Delete("/dna/intent/api/v1/tag/{id}")]
	Task<TaskIdResult> DeleteAsync(
		[AliasAs("id")]string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag
	/// </summary>
	/// <remarks>
	/// Returns the tags for given filter criteria
	/// </remarks>
	/// <param name="name">Tag name is mandatory when filter operation is used. (optional)</param>
	/// <param name="additionalInfo_nameSpace">nameSpace (optional)</param>
	/// <param name="additionalInfo_attributes">attributeName (optional)</param>
	/// <param name="level">levelArg (optional)</param>
	/// <param name="offset">offset (optional)</param>
	/// <param name="limit">limit (optional)</param>
	/// <param name="size">size in kilobytes(KB) (optional)</param>
	/// <param name="field">Available field names are :&#39;name,id,parentId,type,additionalInfo.nameSpace,additionalInfo.attributes&#39; (optional)</param>
	/// <param name="sortBy">Only supported attribute is name. SortyBy is mandatory when order is used. (optional)</param>
	/// <param name="order">Available values are asc and des (optional)</param>
	/// <param name="systemTag">systemTag (optional)</param>
	/// <returns>Task of TagListResult</returns>
	[Get("/dna/intent/api/v1/tag")]
	Task<TagListResult> GetAllAsync(
		[AliasAs("name")]string name = null,
		[AliasAs("additionalInfo_nameSpace")]string additionalInfo_nameSpace = null,
		[AliasAs("additionalInfo_attributes")]string additionalInfo_attributes = null,
		[AliasAs("level")]string level = null,
		[AliasAs("offset")]string offset = null,
		[AliasAs("limit")]string limit = null,
		[AliasAs("size")]string size = null,
		[AliasAs("field")]string field = null,
		[AliasAs("sortBy")]string sortBy = null,
		[AliasAs("order")]string order = null,
		[AliasAs("systemTag")]string systemTag = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag by Id
	/// </summary>
	/// <remarks>
	/// Returns tag specified by Id
	/// </remarks>
	/// <param name="id">Tag ID</param>
	/// <returns>Task of TagResult</returns>
	[Get("/dna/intent/api/v1/tag/{id}")]
	Task<TagResult> GetByIdAsync(
		[AliasAs("id")]string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag Count
	/// </summary>
	/// <remarks>
	/// Returns tag count
	/// </remarks>
	/// <param name="name">tagName (optional)</param>
	/// <param name="_nameSpace">nameSpace (optional)</param>
	/// <param name="attributeName">attributeName (optional)</param>
	/// <param name="level">levelArg (optional)</param>
	/// <param name="size">size in kilobytes(KB) (optional)</param>
	/// <param name="systemTag">systemTag (optional)</param>
	/// <returns>Task of CountResult</returns>
	[Get("/dna/intent/api/v1/tag/count")]
	Task<CountResult> GetCountAsync(
		[AliasAs("name")]string name = null,
		[AliasAs("_nameSpace")]string _nameSpace = null,
		[AliasAs("attributeName")]string attributeName = null,
		[AliasAs("level")]string level = null,
		[AliasAs("size")]string size = null,
		[AliasAs("systemTag")]string systemTag = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag Member count
	/// </summary>
	/// <remarks>
	/// Returns the number of members in a given tag
	/// </remarks>
	/// <param name="id">Tag ID</param>
	/// <param name="memberType">memberType</param>
	/// <param name="memberAssociationType">memberAssociationType (optional)</param>
	/// <param name="level">level (optional)</param>
	/// <returns>Task of CountResult</returns>
	[Get("/dna/intent/api/v1/tag/{id}/member/count")]
	Task<CountResult> GetMemberCountAsync(
		[AliasAs("id")]string id,
		[AliasAs("memberType")]string memberType,
		[AliasAs("memberAssociationType")]string memberAssociationType = null,
		[AliasAs("level")]string level = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag members by Id
	/// </summary>
	/// <remarks>
	/// Returns tag members specified by id
	/// </remarks>
	/// <param name="id">Tag ID</param>
	/// <param name="memberType">Entity type of the member. Possible values can be retrieved by using /tag/member/type API</param>
	/// <param name="offset">Used for pagination. It indicates the starting row number out of available member records (optional)</param>
	/// <param name="limit">Used to Number of maximum members to return in the result (optional)</param>
	/// <param name="memberAssociationType">Indicates how the member is associated with the tag. Possible values and description. 1) DYNAMIC : The member is associated to the tag through rules. 2) STATIC ??? The member is associated to the tag manually. 3) MIXED ??? The member is associated manually and also satisfies the rule defined for the tag (optional)</param>
	/// <param name="level">level (optional)</param>
	/// <returns>Task of TagMembersResult</returns>
	[Get("/dna/intent/api/v1/tag/{id}/member")]
	Task<TagMembersResult> GetMembersByIdAsync(
		[AliasAs("id")]string id,
		[AliasAs("memberType")]string memberType,
		[AliasAs("offset")]string offset = null,
		[AliasAs("limit")]string limit = null,
		[AliasAs("memberAssociationType")]string memberAssociationType = null,
		[AliasAs("level")]string level = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Tag resource types
	/// </summary>
	/// <remarks>
	/// Returns list of supported resource types
	/// </remarks>
	/// <returns>Task of TagTypesResult</returns>
	[Get("/dna/intent/api/v1/tag/member/type")]
	Task<TagTypesResult> GetResourceTypesAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove Tag member
	/// </summary>
	/// <remarks>
	/// Removes Tag member from the tag specified by id
	/// </remarks>
	/// <param name="id">Tag ID</param>
	/// <param name="memberId">TagMember id to be removed from tag</param>
	/// <returns>Task of TaskIdResult</returns>
	[Delete("/dna/intent/api/v1/tag/{id}/member/{memberId}")]
	Task<TaskIdResult> RemoveMemberAsync(
		[AliasAs("id")]string id,
		[AliasAs("memberId")]string memberId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update Tag
	/// </summary>
	/// <remarks>
	/// Updates a tag specified by id
	/// </remarks>
	/// <param name="request">request</param>
	/// <returns>Task of TaskIdResult</returns>
	[Put("/dna/intent/api/v1/tag")]
	Task<TaskIdResult> UpdateAsync(
		[Body]TagDto request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Updates tag membership
	/// </summary>
	/// <remarks>
	/// Updates tag membership. As part of the request payload through this API, only the specified members are added / retained to the given input tags. Possible values of memberType attribute in the request payload can be queried by using the /tag/member/type API
	/// </remarks>
	/// <param name="request">request</param>
	/// <returns>Task of TaskIdResult</returns>
	[Put("/dna/intent/api/v1/tag/member")]
	Task<TaskIdResult> UpdateMembershipAsync(
		[Body]TagMemberDto request,
		CancellationToken cancellationToken = default);
}
