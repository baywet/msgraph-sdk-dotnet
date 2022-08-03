// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserFollowedSitesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserFollowedSitesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserFollowedSitesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserFollowedSitesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserFollowedSitesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserFollowedSitesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserFollowedSitesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserFollowedSitesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISiteWithReferenceRequestBuilder"/> for the specified UserSite.
        /// </summary>
        /// <param name="id">The ID for the UserSite.</param>
        /// <returns>The <see cref="ISiteWithReferenceRequestBuilder"/>.</returns>
        public ISiteWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new SiteWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserFollowedSitesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserFollowedSitesCollectionReferencesRequestBuilder"/>.</returns>
        public IUserFollowedSitesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserFollowedSitesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}