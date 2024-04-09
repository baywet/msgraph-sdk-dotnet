// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.Appointments;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.CalendarView;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.CustomQuestions;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.Customers;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.GetStaffAvailability;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.Publish;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.Services;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.StaffMembers;
using Microsoft.Graph.Solutions.BookingBusinesses.Item.Unpublish;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Solutions.BookingBusinesses.Item {
    /// <summary>
    /// Provides operations to manage the bookingBusinesses property of the microsoft.graph.solutionsRoot entity.
    /// </summary>
    public class BookingBusinessItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the appointments property of the microsoft.graph.bookingBusiness entity.</summary>
        public AppointmentsRequestBuilder Appointments
        {
            get => new AppointmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.bookingBusiness entity.</summary>
        public CalendarViewRequestBuilder CalendarView
        {
            get => new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customers property of the microsoft.graph.bookingBusiness entity.</summary>
        public CustomersRequestBuilder Customers
        {
            get => new CustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customQuestions property of the microsoft.graph.bookingBusiness entity.</summary>
        public CustomQuestionsRequestBuilder CustomQuestions
        {
            get => new CustomQuestionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getStaffAvailability method.</summary>
        public GetStaffAvailabilityRequestBuilder GetStaffAvailability
        {
            get => new GetStaffAvailabilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the publish method.</summary>
        public PublishRequestBuilder Publish
        {
            get => new PublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the services property of the microsoft.graph.bookingBusiness entity.</summary>
        public ServicesRequestBuilder Services
        {
            get => new ServicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the staffMembers property of the microsoft.graph.bookingBusiness entity.</summary>
        public StaffMembersRequestBuilder StaffMembers
        {
            get => new StaffMembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unpublish method.</summary>
        public UnpublishRequestBuilder Unpublish
        {
            get => new UnpublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="BookingBusinessItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingBusinessItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BookingBusinessItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingBusinessItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a bookingBusiness object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingbusiness-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
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
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the properties and relationships of a bookingBusiness object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingbusiness-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="BookingBusiness"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BookingBusiness?> GetAsync(Action<RequestConfiguration<BookingBusinessItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<BookingBusiness> GetAsync(Action<RequestConfiguration<BookingBusinessItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BookingBusiness>(requestInfo, BookingBusiness.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a bookingBusiness object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingbusiness-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="BookingBusiness"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BookingBusiness?> PatchAsync(BookingBusiness body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<BookingBusiness> PatchAsync(BookingBusiness body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BookingBusiness>(requestInfo, BookingBusiness.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a bookingBusiness object.
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
        /// Get the properties and relationships of a bookingBusiness object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BookingBusinessItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BookingBusinessItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a bookingBusiness object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(BookingBusiness body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(BookingBusiness body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="BookingBusinessItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BookingBusinessItemRequestBuilder WithUrl(string rawUrl)
        {
            return new BookingBusinessItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BookingBusinessItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Get the properties and relationships of a bookingBusiness object.
        /// </summary>
        public class BookingBusinessItemRequestBuilderGetQueryParameters 
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
        public class BookingBusinessItemRequestBuilderGetRequestConfiguration : RequestConfiguration<BookingBusinessItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BookingBusinessItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
