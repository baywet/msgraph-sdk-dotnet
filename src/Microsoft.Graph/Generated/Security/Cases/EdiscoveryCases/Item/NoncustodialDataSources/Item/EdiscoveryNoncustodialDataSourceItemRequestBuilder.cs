using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.ApplyHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.DataSource;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.LastIndexOperation;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.Release;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.RemoveHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.UpdateIndex;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item {
    /// <summary>Provides operations to manage the noncustodialDataSources property of the microsoft.graph.security.ediscoveryCase entity.</summary>
    public class EdiscoveryNoncustodialDataSourceItemRequestBuilder {
        /// <summary>Provides operations to call the applyHold method.</summary>
        public ApplyHoldRequestBuilder ApplyHold { get =>
            new ApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataSource property of the microsoft.graph.security.ediscoveryNoncustodialDataSource entity.</summary>
        public DataSourceRequestBuilder DataSource { get =>
            new DataSourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastIndexOperation property of the microsoft.graph.security.ediscoveryNoncustodialDataSource entity.</summary>
        public LastIndexOperationRequestBuilder LastIndexOperation { get =>
            new LastIndexOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to call the release method.</summary>
        public ReleaseRequestBuilder Release { get =>
            new ReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        public RemoveHoldRequestBuilder RemoveHold { get =>
            new RemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        public UpdateIndexRequestBuilder UpdateIndex { get =>
            new UpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new EdiscoveryNoncustodialDataSourceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryNoncustodialDataSourceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new EdiscoveryNoncustodialDataSourceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryNoncustodialDataSourceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for security
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateDeleteRequestInformation(Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a list of case ediscoveryNoncustodialDataSource objects for this case.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in security
        /// </summary>
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreatePatchRequestInformation(EdiscoveryNoncustodialDataSource body, Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task DeleteAsync(Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Returns a list of case ediscoveryNoncustodialDataSource objects for this case.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<EdiscoveryNoncustodialDataSource> GetAsync(Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EdiscoveryNoncustodialDataSource>(requestInfo, EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in security
        /// </summary>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<EdiscoveryNoncustodialDataSource> PatchAsync(EdiscoveryNoncustodialDataSource body, Action<EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EdiscoveryNoncustodialDataSource>(requestInfo, EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Returns a list of case ediscoveryNoncustodialDataSource objects for this case.</summary>
        public class EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
