// <auto-generated/>
using Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\tokenLifetimePolicies\{tokenLifetimePolicy-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class TokenLifetimePolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.TokenLifetimePolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenLifetimePolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenLifetimePolicies/{tokenLifetimePolicy%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.TokenLifetimePolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenLifetimePolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenLifetimePolicies/{tokenLifetimePolicy%2Did}", rawUrl)
        {
        }
    }
}
