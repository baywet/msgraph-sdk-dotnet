// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type IdentityContainerIdentityProvidersCollectionRequestBuilder.
    /// </summary>
    public partial class IdentityContainerIdentityProvidersCollectionRequestBuilder : BaseRequestBuilder, IIdentityContainerIdentityProvidersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new IdentityContainerIdentityProvidersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IdentityContainerIdentityProvidersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IIdentityContainerIdentityProvidersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IIdentityContainerIdentityProvidersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new IdentityContainerIdentityProvidersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityProviderBaseRequestBuilder"/> for the specified IdentityContainerIdentityProviderBase.
        /// </summary>
        /// <param name="id">The ID for the IdentityContainerIdentityProviderBase.</param>
        /// <returns>The <see cref="IIdentityProviderBaseRequestBuilder"/>.</returns>
        public IIdentityProviderBaseRequestBuilder this[string id]
        {
            get
            {
                return new IdentityProviderBaseRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityProviderBaseAvailableProviderTypes.
        /// </summary>
        /// <returns>The <see cref="IIdentityProviderBaseAvailableProviderTypesRequestBuilder"/>.</returns>
        public IIdentityProviderBaseAvailableProviderTypesRequestBuilder AvailableProviderTypes()
        {
            return new IdentityProviderBaseAvailableProviderTypesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.availableProviderTypes"),
                this.Client);
        }
    }
}
