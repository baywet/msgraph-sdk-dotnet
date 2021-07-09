// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesPage.
    /// </summary>
    public partial class B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesPage : CollectionPage<IdentityProviderBase>, IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}