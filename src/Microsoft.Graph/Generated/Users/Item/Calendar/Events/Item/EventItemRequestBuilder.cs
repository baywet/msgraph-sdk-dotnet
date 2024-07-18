// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Accept;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Attachments;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Calendar;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Cancel;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Decline;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.DismissReminder;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Extensions;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Forward;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.Instances;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.SnoozeReminder;
using Microsoft.Graph.Users.Item.Calendar.Events.Item.TentativelyAccept;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Users.Item.Calendar.Events.Item
{
    /// <summary>
    /// Provides operations to manage the events property of the microsoft.graph.calendar entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class EventItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the accept method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Accept.AcceptRequestBuilder Accept
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Accept.AcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.event entity.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Attachments.AttachmentsRequestBuilder Attachments
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.event entity.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Calendar.CalendarRequestBuilder Calendar
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancel method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Cancel.CancelRequestBuilder Cancel
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the decline method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Decline.DeclineRequestBuilder Decline
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Decline.DeclineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dismissReminder method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.DismissReminder.DismissReminderRequestBuilder DismissReminder
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.DismissReminder.DismissReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.event entity.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Extensions.ExtensionsRequestBuilder Extensions
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the forward method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Forward.ForwardRequestBuilder Forward
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.event entity.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Instances.InstancesRequestBuilder Instances
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.Instances.InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the snoozeReminder method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.SnoozeReminder.SnoozeReminderRequestBuilder SnoozeReminder
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.SnoozeReminder.SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the tentativelyAccept method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptRequestBuilder TentativelyAccept
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar/events/{event%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar/events/{event%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property events for users
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Event"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Event?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Event> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Event>(requestInfo, global::Microsoft.Graph.Models.Event.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property events in users
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Event"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Event?> PatchAsync(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Event> PatchAsync(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Event>(requestInfo, global::Microsoft.Graph.Models.Event.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property events for users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property events in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Event body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventItemRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.Events.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class EventItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
