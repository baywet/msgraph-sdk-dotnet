// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IServiceAnnouncementHealthOverviewsCollectionRequestBuilder.
    /// </summary>
    public partial interface IServiceAnnouncementHealthOverviewsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IServiceAnnouncementHealthOverviewsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IServiceAnnouncementHealthOverviewsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IServiceHealthRequestBuilder"/> for the specified ServiceHealth.
        /// </summary>
        /// <param name="id">The ID for the ServiceHealth.</param>
        /// <returns>The <see cref="IServiceHealthRequestBuilder"/>.</returns>
        IServiceHealthRequestBuilder this[string id] { get; }

        
    }
}