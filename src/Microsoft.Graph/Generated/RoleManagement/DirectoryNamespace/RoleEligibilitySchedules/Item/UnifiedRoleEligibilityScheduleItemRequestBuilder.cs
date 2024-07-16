// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.AppScope;
using Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.DirectoryScope;
using Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.Principal;
using Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.RoleDefinition;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item
{
    /// <summary>
    /// Provides operations to manage the roleEligibilitySchedules property of the microsoft.graph.rbacApplication entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class UnifiedRoleEligibilityScheduleItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the appScope property of the microsoft.graph.unifiedRoleScheduleBase entity.</summary>
        public global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.AppScope.AppScopeRequestBuilder AppScope
        {
            get => new global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.AppScope.AppScopeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directoryScope property of the microsoft.graph.unifiedRoleScheduleBase entity.</summary>
        public global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.DirectoryScope.DirectoryScopeRequestBuilder DirectoryScope
        {
            get => new global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.DirectoryScope.DirectoryScopeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the principal property of the microsoft.graph.unifiedRoleScheduleBase entity.</summary>
        public global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.Principal.PrincipalRequestBuilder Principal
        {
            get => new global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.Principal.PrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinition property of the microsoft.graph.unifiedRoleScheduleBase entity.</summary>
        public global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.RoleDefinition.RoleDefinitionRequestBuilder RoleDefinition
        {
            get => new global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.RoleDefinition.RoleDefinitionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnifiedRoleEligibilityScheduleItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory/roleEligibilitySchedules/{unifiedRoleEligibilitySchedule%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnifiedRoleEligibilityScheduleItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory/roleEligibilitySchedules/{unifiedRoleEligibilitySchedule%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property roleEligibilitySchedules for roleManagement
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
        /// Retrieve the schedule for a role eligibility operation.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/unifiedroleeligibilityschedule-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder.UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder.UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>(requestInfo, global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property roleEligibilitySchedules in roleManagement
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule?> PatchAsync(global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule> PatchAsync(global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>(requestInfo, global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property roleEligibilitySchedules for roleManagement
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
        /// Retrieve the schedule for a role eligibility operation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder.UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder.UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property roleEligibilitySchedules in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class UnifiedRoleEligibilityScheduleItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the schedule for a role eligibility operation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters 
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
        public partial class UnifiedRoleEligibilityScheduleItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.Item.UnifiedRoleEligibilityScheduleItemRequestBuilder.UnifiedRoleEligibilityScheduleItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class UnifiedRoleEligibilityScheduleItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
