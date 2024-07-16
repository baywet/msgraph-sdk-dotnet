// <auto-generated/>
using Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.Content;
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
namespace Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder
{
    /// <summary>
    /// Provides operations to manage the filesFolder property of the microsoft.graph.channel entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class FilesFolderRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.Content.ContentRequestBuilder Content
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.Content.ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesFolderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/channels/{channel%2Did}/filesFolder{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesFolderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/channels/{channel%2Did}/filesFolder{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Metadata for the location where the channel&apos;s files are stored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DriveItem"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DriveItem?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder.FilesFolderRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DriveItem> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder.FilesFolderRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DriveItem>(requestInfo, global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Metadata for the location where the channel&apos;s files are stored.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder.FilesFolderRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder.FilesFolderRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Metadata for the location where the channel&apos;s files are stored.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class FilesFolderRequestBuilderGetQueryParameters 
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
        public partial class FilesFolderRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Channels.Item.FilesFolder.FilesFolderRequestBuilder.FilesFolderRequestBuilderGetQueryParameters>
        {
        }
    }
}
