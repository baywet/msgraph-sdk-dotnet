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
    /// The type GraphServiceLocalizationsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceLocalizationsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceLocalizationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceLocalizationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceLocalizationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceLocalizationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceLocalizationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceLocalizationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOrganizationalBrandingLocalizationRequestBuilder"/> for the specified GraphServiceOrganizationalBrandingLocalization.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceOrganizationalBrandingLocalization.</param>
        /// <returns>The <see cref="IOrganizationalBrandingLocalizationRequestBuilder"/>.</returns>
        public IOrganizationalBrandingLocalizationRequestBuilder this[string id]
        {
            get
            {
                return new OrganizationalBrandingLocalizationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}