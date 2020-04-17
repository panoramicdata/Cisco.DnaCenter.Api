using Cisco.DnaCenter.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IEventManagement
	{
		/// <summary>
		/// Count of Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Returns the Count of EventSubscriptions
		/// </remarks>
		/// <param name="eventIds">List of subscriptions related to the respective eventIds</param>
		/// <returns>Task of CountOfEventSubscriptionsResponse</returns>
		[Get("/dna/intent/api/v1/event/subscription/count")]
		Task<EventSubscriptionCountResponse> GetEventSubscriptionCountAsync(
			[AliasAs("eventIds")]string eventIds,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Count of Events
		/// </summary>
		/// <remarks>
		/// Get the count of registered events with provided eventIds or tags as mandatory
		/// </remarks>
		/// <param name="tags">The registered Tags should be provided</param>
		/// <param name="eventId">The registered EventId should be provided (optional)</param>
		/// <returns>Task of CountOfEventsResponse</returns>
		[Get("/dna/intent/api/v1/events/count")]
		Task<EventCountResponse> GetEventCountAsync(
			[AliasAs("tags")]string tags,
			[AliasAs("eventId")]string eventId = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Count of Notifications
		/// </summary>
		/// <remarks>
		/// Get the Count of Published Notifications
		/// </remarks>
		/// <param name="eventIds">The registered EventIds should be provided (optional)</param>
		/// <param name="startTime">StartTime  (optional)</param>
		/// <param name="endTime">endTime  (optional)</param>
		/// <param name="category">category  (optional)</param>
		/// <param name="type">type  (optional)</param>
		/// <param name="severity">severity  (optional)</param>
		/// <param name="domain">domain  (optional)</param>
		/// <param name="subDomain">subDomain  (optional)</param>
		/// <param name="source">source  (optional)</param>
		/// <returns>Task of CountOfNotificationsResponse</returns>
		[Get("/dna/intent/api/v1/event/event-series/count")]
		Task<NotificationCountResponse> GetNotificationCountAsync(
			[AliasAs("eventIds")]string eventIds = null,
			[AliasAs("startTime")]string startTime = null,
			[AliasAs("endTime")]string endTime = null,
			[AliasAs("category")]string category = null,
			[AliasAs("type")]string type = null,
			[AliasAs("severity")]string severity = null,
			[AliasAs("domain")]string domain = null,
			[AliasAs("subDomain")]string subDomain = null,
			[AliasAs("source")]string source = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Create Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Subscribe SubscriptionEndpoint to list of registered events
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of CreateEventSubscriptionsResponse</returns>
		[Post("/dna/intent/api/v1/event/subscription")]
		Task<CreateEventSubscriptionsResponse> CreateEventSubscriptionsAsync(
			[Body]CreateEventSubscriptionsRequest request,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Delete EventSubscriptions
		/// </remarks>
		/// <param name="subscriptions">List of EventSubscriptionId&#39;s for removal</param>
		/// <returns>Task of DeleteEventSubscriptionsResponse</returns>
		[Delete("/dna/intent/api/v1/event/subscription")]
		Task<DeleteEventSubscriptionsResponse> DeleteEventSubscriptionsAsync(
			[AliasAs("subscriptions")]string subscriptions,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Gets the list of Subscriptions&#39;s based on provided offset and limit
		/// </remarks>
		/// <param name="eventIds">List of subscriptions related to the respective eventIds (optional)</param>
		/// <param name="offset">The number of Subscriptions&#39;s to offset in the resultset whose default value 0 (optional)</param>
		/// <param name="limit">The number of Subscriptions&#39;s to limit in the resultset whose default value 10 (optional)</param>
		/// <param name="sortBy">SortBy field name (optional)</param>
		/// <param name="order">order(asc/desc) (optional)</param>
		/// <returns>Task of GetEventSubscriptionsResponse</returns>
		[Get("/dna/intent/api/v1/event/subscription")]
		Task<GetEventSubscriptionsResponse> GetEventSubscriptionsAsync(
			[AliasAs("eventIds")]string eventIds = null,
			[AliasAs("offset")]int? offset = null,
			[AliasAs("limit")]int? limit = null,
			[AliasAs("sortBy")]string sortBy = null,
			[AliasAs("order")]string order = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Events
		/// </summary>
		/// <remarks>
		/// Gets the list of registered Events with provided eventIds or tags as mandatory
		/// </remarks>
		/// <param name="tags">The registered Tags should be provided</param>
		/// <param name="eventId">The registered EventId should be provided (optional)</param>
		/// <param name="offset">The number of Registries to offset in the resultset whose default value 0 (optional)</param>
		/// <param name="limit">The number of Registries to limit in the resultset whose default value 10 (optional)</param>
		/// <param name="sortBy">SortBy field name (optional)</param>
		/// <param name="order">order(asc/desc) (optional)</param>
		/// <returns>Task of GetEventsResponse</returns>
		[Get("/dna/intent/api/v1/events")]
		Task<GetEventsResponse> GetEventsAsync(
			[AliasAs("tags")]string tags,
			[AliasAs("eventId")]string eventId = null,
			[AliasAs("offset")]int? offset = null,
			[AliasAs("limit")]int? limit = null,
			[AliasAs("sortBy")]string sortBy = null,
			[AliasAs("order")]string order = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Notifications
		/// </summary>
		/// <remarks>
		/// Get the list of Published Notifications
		/// </remarks>
		/// <param name="eventIds">The registered EventIds should be provided (optional)</param>
		/// <param name="startTime">StartTime  (optional)</param>
		/// <param name="endTime">endTime  (optional)</param>
		/// <param name="category">category  (optional)</param>
		/// <param name="type">type  (optional)</param>
		/// <param name="severity">severity  (optional)</param>
		/// <param name="domain">domain  (optional)</param>
		/// <param name="subDomain">subDomain  (optional)</param>
		/// <param name="source">source  (optional)</param>
		/// <param name="offset">Offset whose default value 0 (optional)</param>
		/// <param name="limit">Limit whose default value 10 (optional)</param>
		/// <param name="sortBy">SortBy field name (optional)</param>
		/// <param name="order">order(asc/desc) (optional)</param>
		/// <returns>Task of GetNotificationsResponse</returns>
		[Get("/dna/intent/api/v1/event/event-series")]
		Task<GetNotificationsResponse> GetNotificationsAsync(
			[AliasAs("eventIds")]string eventIds = null,
			[AliasAs("startTime")]string startTime = null,
			[AliasAs("endTime")]string endTime = null,
			[AliasAs("category")]string category = null,
			[AliasAs("type")]string type = null,
			[AliasAs("severity")]string severity = null,
			[AliasAs("domain")]string domain = null,
			[AliasAs("subDomain")]string subDomain = null,
			[AliasAs("source")]string source = null,
			[AliasAs("offset")]int? offset = null,
			[AliasAs("limit")]int? limit = null,
			[AliasAs("sortBy")]string sortBy = null,
			[AliasAs("order")]string order = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Get Status API for Events
		/// </summary>
		/// <remarks>
		/// Get the Status of events API calls with provided executionId as mandatory path parameter
		/// </remarks>
		/// <param name="executionId">Execution ID</param>
		/// <returns>Task of GetStatusAPIForEventsResponse</returns>
		[Get("/dna/intent/api/v1/event/api-status/{executionId}")]
		Task<GetEventStatusApisResponse> GetEventStatusApis(
			[AliasAs("executionId")]string executionId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Update SubscriptionEndpoint to list of registered events
		/// </remarks>
		/// <param name="request">request</param>
		/// <returns>Task of UpdateEventSubscriptionsResponse</returns>
		[Put("/dna/intent/api/v1/event/subscription")]
		Task<UpdateEventSubscriptionsResponse> UpdateEventSubscriptionsAsync(
			[Body]UpdateEventSubscriptionsRequest request,
			CancellationToken cancellationToken = default);
	}
}
