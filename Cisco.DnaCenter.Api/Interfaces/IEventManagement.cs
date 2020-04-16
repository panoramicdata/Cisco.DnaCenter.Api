using Cisco.DnaCenter.Api.Data;
using Refit;
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
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="eventIds">List of subscriptions related to the respective eventIds</param>
		/// <returns>Task of CountOfEventSubscriptionsResponse</returns>
		[Get("/dna/intent/api/v1/event/subscription/count")]
		Task<CountOfEventSubscriptionsResponse> CountOfEventSubscriptions([AliasAs("eventIds")]string eventIds);

		/// <summary>
		/// Count of Events
		/// </summary>
		/// <remarks>
		/// Get the count of registered events with provided eventIds or tags as mandatory
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tags">The registered Tags should be provided</param>
		/// <param name="eventId">The registered EventId should be provided (optional)</param>
		/// <returns>Task of CountOfEventsResponse</returns>
		[Get("/dna/intent/api/v1/events/count")]
		Task<CountOfEventsResponse> CountOfEvents([AliasAs("tags")]string tags, [AliasAs("eventId")]string eventId = null);

		/// <summary>
		/// Count of Notifications
		/// </summary>
		/// <remarks>
		/// Get the Count of Published Notifications
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
		Task<CountOfNotificationsResponse> CountOfNotifications([AliasAs("eventIds")]string eventIds = null, [AliasAs("startTime")]string startTime = null, [AliasAs("endTime")]string endTime = null, [AliasAs("category")]string category = null, [AliasAs("type")]string type = null, [AliasAs("severity")]string severity = null, [AliasAs("domain")]string domain = null, [AliasAs("subDomain")]string subDomain = null, [AliasAs("source")]string source = null);

		/// <summary>
		/// Create Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Subscribe SubscriptionEndpoint to list of registered events
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Content Type</param>
		/// <returns>Task of CreateEventSubscriptionsResponse</returns>
		[Post("/dna/intent/api/v1/event/subscription")]
		Task<CreateEventSubscriptionsResponse> CreateEventSubscriptions([Body]CreateEventSubscriptionsRequest request, string Content_Type);

		/// <summary>
		/// Delete Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Delete EventSubscriptions
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="Content_Type">Content Type</param>
		/// <param name="subscriptions">List of EventSubscriptionId&#39;s for removal</param>
		/// <returns>Task of DeleteEventSubscriptionsResponse</returns>
		[Delete("/dna/intent/api/v1/event/subscription")]
		Task<DeleteEventSubscriptionsResponse> DeleteEventSubscriptions(string Content_Type, [AliasAs("subscriptions")]string subscriptions);

		/// <summary>
		/// Get Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Gets the list of Subscriptions&#39;s based on provided offset and limit
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="eventIds">List of subscriptions related to the respective eventIds (optional)</param>
		/// <param name="offset">The number of Subscriptions&#39;s to offset in the resultset whose default value 0 (optional)</param>
		/// <param name="limit">The number of Subscriptions&#39;s to limit in the resultset whose default value 10 (optional)</param>
		/// <param name="sortBy">SortBy field name (optional)</param>
		/// <param name="order">order(asc/desc) (optional)</param>
		/// <returns>Task of GetEventSubscriptionsResponse</returns>
		[Get("/dna/intent/api/v1/event/subscription")]
		Task<GetEventSubscriptionsResponse> GetEventSubscriptions([AliasAs("eventIds")]string eventIds = null, [AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("order")]string order = null);

		/// <summary>
		/// Get Events
		/// </summary>
		/// <remarks>
		/// Gets the list of registered Events with provided eventIds or tags as mandatory
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="tags">The registered Tags should be provided</param>
		/// <param name="eventId">The registered EventId should be provided (optional)</param>
		/// <param name="offset">The number of Registries to offset in the resultset whose default value 0 (optional)</param>
		/// <param name="limit">The number of Registries to limit in the resultset whose default value 10 (optional)</param>
		/// <param name="sortBy">SortBy field name (optional)</param>
		/// <param name="order">order(asc/desc) (optional)</param>
		/// <returns>Task of GetEventsResponse</returns>
		[Get("/dna/intent/api/v1/events")]
		Task<GetEventsResponse> GetEvents([AliasAs("tags")]string tags, [AliasAs("eventId")]string eventId = null, [AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("order")]string order = null);

		/// <summary>
		/// Get Notifications
		/// </summary>
		/// <remarks>
		/// Get the list of Published Notifications
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
		Task<GetNotificationsResponse> GetNotifications([AliasAs("eventIds")]string eventIds = null, [AliasAs("startTime")]string startTime = null, [AliasAs("endTime")]string endTime = null, [AliasAs("category")]string category = null, [AliasAs("type")]string type = null, [AliasAs("severity")]string severity = null, [AliasAs("domain")]string domain = null, [AliasAs("subDomain")]string subDomain = null, [AliasAs("source")]string source = null, [AliasAs("offset")]decimal? offset = null, [AliasAs("limit")]decimal? limit = null, [AliasAs("sortBy")]string sortBy = null, [AliasAs("order")]string order = null);

		/// <summary>
		/// Get Status API for Events
		/// </summary>
		/// <remarks>
		/// Get the Status of events API calls with provided executionId as mandatory path parameter
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="executionId">Execution ID</param>
		/// <returns>Task of GetStatusAPIForEventsResponse</returns>
		[Get("/dna/intent/api/v1/event/api-status/{executionId}")]
		Task<GetStatusAPIForEventsResponse> GetStatusAPIForEvents([AliasAs("executionId")]string executionId);

		/// <summary>
		/// Update Event Subscriptions
		/// </summary>
		/// <remarks>
		/// Update SubscriptionEndpoint to list of registered events
		/// </remarks>
		/// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="request">request</param>
		/// <param name="Content_Type">Content Type</param>
		/// <returns>Task of UpdateEventSubscriptionsResponse</returns>
		[Put("/dna/intent/api/v1/event/subscription")]
		Task<UpdateEventSubscriptionsResponse> UpdateEventSubscriptions([Body]UpdateEventSubscriptionsRequest request, string Content_Type);
	}
}
