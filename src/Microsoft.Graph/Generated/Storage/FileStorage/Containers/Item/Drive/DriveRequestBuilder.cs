// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Bundles;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.CreatedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Following;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.LastModifiedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Recent;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Root;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SearchWithQ;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SharedWithMe;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Special;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive
{
    /// <summary>
    /// Provides operations to manage the drive property of the microsoft.graph.fileStorageContainer entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class DriveRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the bundles property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Bundles.BundlesRequestBuilder Bundles
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Bundles.BundlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the following property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Following.FollowingRequestBuilder Following
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Following.FollowingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.ItemsRequestBuilder Items
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the list property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder List
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.ListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recent method.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Recent.RecentRequestBuilder Recent
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Recent.RecentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the root property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Root.RootRequestBuilder Root
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Root.RootRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sharedWithMe method.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SharedWithMe.SharedWithMeRequestBuilder SharedWithMe
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SharedWithMe.SharedWithMeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the special property of the microsoft.graph.drive entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Special.SpecialRequestBuilder Special
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Special.SpecialRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property drive for storage
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
        /// The drive of the resource fileStorageContainer. Read-only.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Drive"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Drive?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder.DriveRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Drive> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder.DriveRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Drive>(requestInfo, global::Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property drive in storage
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Drive"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Drive?> PatchAsync(global::Microsoft.Graph.Models.Drive body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Drive> PatchAsync(global::Microsoft.Graph.Models.Drive body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Drive>(requestInfo, global::Microsoft.Graph.Models.Drive.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the search method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SearchWithQ.SearchWithQRequestBuilder"/></returns>
        /// <param name="q">Usage: q=&apos;{q}&apos;</param>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SearchWithQ.SearchWithQRequestBuilder SearchWithQ(string q)
        {
            if(string.IsNullOrEmpty(q)) throw new ArgumentNullException(nameof(q));
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.SearchWithQ.SearchWithQRequestBuilder(PathParameters, RequestAdapter, q);
        }
        /// <summary>
        /// Delete navigation property drive for storage
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
        /// The drive of the resource fileStorageContainer. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder.DriveRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder.DriveRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property drive in storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Drive body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Drive body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class DriveRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The drive of the resource fileStorageContainer. Read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class DriveRequestBuilderGetQueryParameters 
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
        public partial class DriveRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.DriveRequestBuilder.DriveRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class DriveRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
