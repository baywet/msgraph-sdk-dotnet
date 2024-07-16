// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.Ref;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.ServiceProvisioningErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\accessPackages\{accessPackage-id}\incompatibleGroups\{group-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class GroupItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of identityGovernance entities.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceProvisioningErrors property</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder ServiceProvisioningErrors
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/incompatibleGroups/{group%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleGroups.Item.GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/incompatibleGroups/{group%2Did}", rawUrl)
        {
        }
    }
}
