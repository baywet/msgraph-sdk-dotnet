// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Analytics;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreateLink;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreatedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DocumentSetVersions;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DriveItem;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Fields;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByInterval;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.LastModifiedByUser;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Versions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item
{
    /// <summary>
    /// Provides operations to manage the items property of the microsoft.graph.list entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ListItemItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.listItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Analytics.AnalyticsRequestBuilder Analytics
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createLink method.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreateLink.CreateLinkRequestBuilder CreateLink
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.CreateLink.CreateLinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the documentSetVersions property of the microsoft.graph.listItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DocumentSetVersions.DocumentSetVersionsRequestBuilder DocumentSetVersions
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DocumentSetVersions.DocumentSetVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the driveItem property of the microsoft.graph.listItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DriveItem.DriveItemRequestBuilder DriveItem
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.DriveItem.DriveItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the fields property of the microsoft.graph.listItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Fields.FieldsRequestBuilder Fields
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Fields.FieldsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the versions property of the microsoft.graph.listItem entity.</summary>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Versions.VersionsRequestBuilder Versions
        {
            get => new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.Versions.VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/list/items/{listItem%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/list/items/{listItem%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property items for storage
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
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// All items contained in the list.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ListItem"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ListItem?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder.ListItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ListItem> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder.ListItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ListItem>(requestInfo, global::Microsoft.Graph.Models.ListItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property items in storage
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ListItem"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ListItem?> PatchAsync(global::Microsoft.Graph.Models.ListItem body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ListItem> PatchAsync(global::Microsoft.Graph.Models.ListItem body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ListItem>(requestInfo, global::Microsoft.Graph.Models.ListItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property items for storage
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
        /// All items contained in the list.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder.ListItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder.ListItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property items in storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ListItem body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ListItem body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ListItemItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// All items contained in the list.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ListItemItemRequestBuilderGetQueryParameters 
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
        public partial class ListItemItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.List.Items.Item.ListItemItemRequestBuilder.ListItemItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ListItemItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
