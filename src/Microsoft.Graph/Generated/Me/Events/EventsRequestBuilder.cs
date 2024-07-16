// <auto-generated/>
using Microsoft.Graph.Me.Events.Count;
using Microsoft.Graph.Me.Events.Delta;
using Microsoft.Graph.Me.Events.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Me.Events
{
    /// <summary>
    /// Provides operations to manage the events property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class EventsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Me.Events.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Me.Events.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delta method.</summary>
        public global::Microsoft.Graph.Me.Events.Delta.DeltaRequestBuilder Delta
        {
            get => new global::Microsoft.Graph.Me.Events.Delta.DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.user entity.</summary>
        /// <param name="position">The unique identifier of event</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Events.Item.EventItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Me.Events.Item.EventItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("event%2Did", position);
                return new global::Microsoft.Graph.Me.Events.Item.EventItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/events{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/events{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get a list of event objects in the user&apos;s mailbox. The list contains singleinstance meetings and series masters. To get expanded event instances, you can get the calendar view, orget the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-list-events?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EventCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EventCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EventCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EventCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.EventCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create an event in the user&apos;s default calendar or specified calendar. By default, the allowNewTimeProposals property is set to true when an event is created, which means invitees can propose a different date/time for the event. See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal. You can specify the time zone for each of the start and end times of the event as part of their values, because thestart and end properties are of dateTimeTimeZone type. First find the supported time zones to make sure you set only time zones that have been configured for the user&apos;s mailbox server. When an event is sent, the server sends invitations to all the attendees. Setting the location in an event An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipmentlike a projector. Users can then invite the resource as an attendee to a meeting. On behalf of the resource, the server accepts or rejectsthe meeting request based on the free/busy schedule of the resource.If the server accepts a meeting for the resource, it creates an event for the meeting in the resource&apos;s calendar. If the meeting is rescheduled,the server automatically updates the event in the resource&apos;s calendar. Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executivesor their delegates can book a private meeting room. If you&apos;re organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-post-events?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Event"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Event?> PostAsync(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Event> PostAsync(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Event>(requestInfo, global::Microsoft.Graph.Models.Event.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of event objects in the user&apos;s mailbox. The list contains singleinstance meetings and series masters. To get expanded event instances, you can get the calendar view, orget the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create an event in the user&apos;s default calendar or specified calendar. By default, the allowNewTimeProposals property is set to true when an event is created, which means invitees can propose a different date/time for the event. See Propose new meeting times for more information on how to propose a time, and how to receive and accept a new time proposal. You can specify the time zone for each of the start and end times of the event as part of their values, because thestart and end properties are of dateTimeTimeZone type. First find the supported time zones to make sure you set only time zones that have been configured for the user&apos;s mailbox server. When an event is sent, the server sends invitations to all the attendees. Setting the location in an event An Exchange administrator can set up a mailbox and an email address for a resource such as a meeting room, or equipmentlike a projector. Users can then invite the resource as an attendee to a meeting. On behalf of the resource, the server accepts or rejectsthe meeting request based on the free/busy schedule of the resource.If the server accepts a meeting for the resource, it creates an event for the meeting in the resource&apos;s calendar. If the meeting is rescheduled,the server automatically updates the event in the resource&apos;s calendar. Another advantage of setting up a mailbox for a resource is to control scheduling of the resource, for example, only executivesor their delegates can book a private meeting room. If you&apos;re organizing an event that involves a meeting location: Additionally, if the meeting location has been set up as a resource, or if the event involves some equipment that has been set up as a resource:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.Events.EventsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.Events.EventsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.Events.EventsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a list of event objects in the user&apos;s mailbox. The list contains singleinstance meetings and series masters. To get expanded event instances, you can get the calendar view, orget the instances of an event. Currently, this operation returns event bodies in only HTML format. There are two scenarios where an app can get events in another user&apos;s calendar:
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
