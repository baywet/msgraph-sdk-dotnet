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
    /// The type GroupAcceptedSendersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class GroupAcceptedSendersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IGroupAcceptedSendersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupAcceptedSendersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupAcceptedSendersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupAcceptedSendersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupAcceptedSendersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new GroupAcceptedSendersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified GroupDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the GroupDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IGroupAcceptedSendersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IGroupAcceptedSendersCollectionReferencesRequestBuilder"/>.</returns>
        public IGroupAcceptedSendersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new GroupAcceptedSendersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}