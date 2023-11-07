// <auto-generated/>
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp.Assignments;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp.Categories;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp.ContentVersions;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DeviceAppManagement.MobileApps.Item.GraphManagedIOSLobApp {
    /// <summary>
    /// Casts the previous resource to managedIOSLobApp.
    /// </summary>
    public class GraphManagedIOSLobAppRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.</summary>
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.</summary>
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentVersions property of the microsoft.graph.managedMobileLobApp entity.</summary>
        public ContentVersionsRequestBuilder ContentVersions { get =>
            new ContentVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GraphManagedIOSLobAppRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphManagedIOSLobAppRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.managedIOSLobApp{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GraphManagedIOSLobAppRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphManagedIOSLobAppRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.managedIOSLobApp{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.managedIOSLobApp
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedIOSLobApp?> GetAsync(Action<RequestConfiguration<GraphManagedIOSLobAppRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ManagedIOSLobApp> GetAsync(Action<RequestConfiguration<GraphManagedIOSLobAppRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedIOSLobApp>(requestInfo, ManagedIOSLobApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.managedIOSLobApp
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphManagedIOSLobAppRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GraphManagedIOSLobAppRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GraphManagedIOSLobAppRequestBuilder WithUrl(string rawUrl) {
            return new GraphManagedIOSLobAppRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.managedIOSLobApp
        /// </summary>
        public class GraphManagedIOSLobAppRequestBuilderGetQueryParameters {
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
        public class GraphManagedIOSLobAppRequestBuilderGetRequestConfiguration : RequestConfiguration<GraphManagedIOSLobAppRequestBuilderGetQueryParameters> {
        }
    }
}
