// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId
{
    /// <summary>
    /// Provides operations to call the getApplicableContentTypesForList method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class GetApplicableContentTypesForListWithListIdRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string listId = "") : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')/getApplicableContentTypesForList(listId='{listId}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(listId)) PathParameters.Add("listId", listId);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')/getApplicableContentTypesForList(listId='{listId}'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get site contentTypes that can be added to a list.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-getapplicablecontenttypesforlist?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdGetResponse?> GetAsGetApplicableContentTypesForListWithListIdGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdGetResponse> GetAsGetApplicableContentTypesForListWithListIdGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdGetResponse>(requestInfo, global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get site contentTypes that can be added to a list.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-getapplicablecontenttypesforlist?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetApplicableContentTypesForListWithListIdGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdResponse>(requestInfo, global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get site contentTypes that can be added to a list.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get site contentTypes that can be added to a list.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters 
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
        public partial class GetApplicableContentTypesForListWithListIdRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder.GetApplicableContentTypesForListWithListIdRequestBuilderGetQueryParameters>
        {
        }
    }
}
