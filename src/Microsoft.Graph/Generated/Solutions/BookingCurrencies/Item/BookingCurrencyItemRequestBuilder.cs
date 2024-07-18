// <auto-generated/>
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
namespace Microsoft.Graph.Solutions.BookingCurrencies.Item
{
    /// <summary>
    /// Provides operations to manage the bookingCurrencies property of the microsoft.graph.solutionsRoot entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class BookingCurrencyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingCurrencyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/bookingCurrencies/{bookingCurrency%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingCurrencyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/bookingCurrencies/{bookingCurrency%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property bookingCurrencies for solutions
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
        /// Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business. Use the id property, which is the currency code, to specify the currency.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingcurrency-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BookingCurrency"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.BookingCurrency?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder.BookingCurrencyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.BookingCurrency> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder.BookingCurrencyItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.BookingCurrency>(requestInfo, global::Microsoft.Graph.Models.BookingCurrency.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property bookingCurrencies in solutions
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BookingCurrency"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.BookingCurrency?> PatchAsync(global::Microsoft.Graph.Models.BookingCurrency body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.BookingCurrency> PatchAsync(global::Microsoft.Graph.Models.BookingCurrency body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.BookingCurrency>(requestInfo, global::Microsoft.Graph.Models.BookingCurrency.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property bookingCurrencies for solutions
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
        /// Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business. Use the id property, which is the currency code, to specify the currency.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder.BookingCurrencyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder.BookingCurrencyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property bookingCurrencies in solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.BookingCurrency body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.BookingCurrency body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class BookingCurrencyItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business. Use the id property, which is the currency code, to specify the currency.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class BookingCurrencyItemRequestBuilderGetQueryParameters 
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
        public partial class BookingCurrencyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Solutions.BookingCurrencies.Item.BookingCurrencyItemRequestBuilder.BookingCurrencyItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class BookingCurrencyItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
